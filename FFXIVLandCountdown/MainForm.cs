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

namespace FFXIVLandCountdown
{
    public partial class MainForm : Form
    {
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
            List<LandItemData> dataList = DataManager.Instance.LandItemDataList;
            foreach (LandItemData data in dataList)
            {
                LandItemControl landItem = new LandItemControl();
                landItem.InitItem(data);
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
    }
}
