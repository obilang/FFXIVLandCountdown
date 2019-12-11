using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LandItem;
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
                regionSelectButton.Text = regionPair.Key.ToString();
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
        }

        private void RefreshSelectedSection()
        {
            this.landItemLayoutPanel.Controls.Clear();
            for (int i = 0; i < DataManager.Instance.GetLandItemList()[currentSelectedRegion][currentSelectedSection].Count; ++i)
            {
                LandItemControl landItem = new LandItemControl();
                landItem.InitItem(DataManager.Instance.GetLandItemList()[currentSelectedRegion][currentSelectedSection][i]);
                this.landItemLayoutPanel.Controls.Add(landItem);
                landItemControlList.Add(landItem);
            }
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
        }

        private List<LandItemControl> landItemControlList = new List<LandItemControl>();

        private void button1_Click(object sender, EventArgs e)
        {
            DataManager.Instance.SaveToFile();
        }

        private void RegionSelectButton_Click(object sender, EventArgs e, int index)
        {
            Console.WriteLine("11112" + index.ToString());
            currentSelectedRegion = (ERegion)index;
            currentSelectedSection = 1;
            RefreshSelectedSection();
        }

        private void SectionSelectButton_Click(object sender, EventArgs e, int index)
        {
            Console.WriteLine("21112" + index.ToString());
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
}
