using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace FFXIVLandCountdown
{
    public partial class MainForm : Form
    {
        private ERegion currentSelectedRegion = ERegion.COUNT;
        private int currentSelectedSection = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000); // 1 secs
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();



            //this.Controls.Clear();

            DataManager.Instance.Init();
            this.landItemLayoutPanel.Controls.Clear();
            this.RegionLayoutPanel.Controls.Clear();
            this.SectionLayoutPanel.Controls.Clear();
            Dictionary<ERegion, Dictionary<int, List<LandItemData>>> dataList = DataManager.Instance.GetLandItemList();

            bool firstLoop = true;
            foreach (var regionPair in dataList)
            {
                Button regionSelectButton = RegionTemplateButton.Clone();
                this.RegionLayoutPanel.Controls.Add(regionSelectButton);
                regionSelectButton.Click += (buttonEventSender, EventArgs) => { RegionSelectButton_Click(buttonEventSender, EventArgs, (int)regionPair.Key); };
                regionSelectButton.Text = GetRegionName(regionPair.Key);
                if (firstLoop)
                {
                    currentSelectedRegion = regionPair.Key;
                    firstLoop = false;
                }
            }

            // This is bad, but since the section count in each region is same, ok for now
            foreach (var sectionPair in dataList[currentSelectedRegion])
            {
                Button sectionSelectButton = SectionSelectTemplateButton.Clone();
                this.SectionLayoutPanel.Controls.Add(sectionSelectButton);
                sectionSelectButton.Click += (buttonEventSender, EventArgs) => { SectionSelectButton_Click(buttonEventSender, EventArgs, (int)sectionPair.Key); };
                sectionSelectButton.Text = sectionPair.Key.ToString();

            }
            RefreshSelectedSection();
            RefreshAvailableList();
        }

        private string GetRegionName(ERegion region)
        {
            switch (region)
            {
                case ERegion.BYX:
                    return "白银乡";
                case ERegion.GJGQ:
                    return "高脚孤丘";
                case ERegion.HWC:
                    return "海雾村";
                case ERegion.XYCMP:
                    return "薰衣草苗圃";
                default:
                    return string.Empty;
            }
        }

        private void RefreshSelectedSection()
        {
            this.landItemLayoutPanel.Controls.Clear();
            foreach(var item in landItemControlList)
            {
                item.onDataUpdated -= OnLandItemDataUpdated;
            }
            landItemControlList.Clear();


            for (int i = 0; i < DataManager.Instance.GetLandItemList()[currentSelectedRegion][currentSelectedSection].Count; ++i)
            {
                LandItemControl landItem = new LandItemControl();
                landItem.InitItem(DataManager.Instance.GetLandItemList()[currentSelectedRegion][currentSelectedSection][i]);
                this.landItemLayoutPanel.Controls.Add(landItem);
                landItemControlList.Add(landItem);
                landItem.onDataUpdated += OnLandItemDataUpdated;
            }
        }

        private void RefreshAvailableList()
        {
            this.AvailabelItemsLayoutPanel.Controls.Clear();
            Dictionary<ERegion, Dictionary<int, List<LandItemData>>> dataList = DataManager.Instance.GetLandItemList();
            foreach (var regionPair in dataList)
            {
                foreach (var sectionPair in regionPair.Value)
                {
                    for (int i = 0; i < sectionPair.Value.Count; ++i)
                    {
                        LandItemData data = sectionPair.Value[i];
                        if (data.LandState == ELandState.EMPTY)
                        {
                            AvailableListItemControl availableItem = new AvailableListItemControl();
                            availableItem.Init(data);
                            //this.AvailabelItemsLayoutPanel.Controls.Add(availableItem);
                            availableLandItemControlList.Add(availableItem);
                        }
                    }
                }
            }


        }

        private void OnLandItemDataUpdated()
        {
            RefreshAvailableList();
        }

        private void landItemControl1_Load(object sender, EventArgs e)
        {

        }

        private void TimerTick(object sender, EventArgs e)
        {
            foreach (LandItemControl itemControl in landItemControlList)
            {
                itemControl.CustomUpdate();
            }

            foreach (AvailableListItemControl itemControl in availableLandItemControlList)
            {
                itemControl.CustomUpdate();
            }
        }

        private List<LandItemControl> landItemControlList = new List<LandItemControl>();
        private List<AvailableListItemControl> availableLandItemControlList = new List<AvailableListItemControl>();

        private void button1_Click(object sender, EventArgs e)
        {
            DataManager.Instance.SaveToFile();
        }

        private void RegionSelectButton_Click(object sender, EventArgs e, int index)
        {
            currentSelectedRegion = (ERegion)index;
            currentSelectedSection = 1;
            RefreshSelectedSection();
        }

        private void SectionSelectButton_Click(object sender, EventArgs e, int index)
        {
            currentSelectedSection = index;
            RefreshSelectedSection();
        }
    }

    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }
    }

    //class AvailableItemSort : IComparer<AvailableListItemControl>
    //{
    //    public int Compare(int x, int y)
    //    {
    //        if (x == 0 || y == 0)
    //        {
    //            return 0;
    //        }

    //        // CompareTo() method 
    //        return x.CompareTo(y);

    //    }
    //}
}
