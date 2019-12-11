using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LandItemPopupForm;

namespace LandItem
{
    public partial class LandItemControl : UserControl
    {
        public const float CD_HOUR = 10.0f;
        public static TimeSpan sCdHour = TimeSpan.FromHours(CD_HOUR);
        private LandItemData landItemData;

        public LandItemControl()
        {
            InitializeComponent();
        }

        public void CustomUpdate()
        {
            if (landItemData.LandState == ELandState.EMPTY)
            {
                this.StateText.Text = "空闲";
                TimeSpan passedTime = DateTime.Now - landItemData.EmptyTime;
                passedTime = TimeSpan.FromSeconds((int)passedTime.TotalSeconds);
                if (passedTime.Hours < CD_HOUR)
                {
                    this.TimeText.Text = string.Format("倒计时 {0:c}", sCdHour.Subtract(passedTime));
                }
                else
                {
                    this.TimeText.Text = string.Format("已经过 {0:c}", passedTime.Subtract(sCdHour));
                }
            }
            else
            {
                this.StateText.Text = "占有";
                this.TimeText.Text = string.Empty;
            }
        }

        public void InitItem(LandItemData itemData)
        {
            landItemData = itemData;
            this.IndexText.Text = itemData.Index.ToString();
            CustomUpdate();
        }

        private void LandItemControl_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            landItemData.LandState = ELandState.EMPTY;
            landItemData.EmptyTime = DateTime.Now;
            CustomUpdate();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            landItemData.LandState = ELandState.OCCUPIED;
            landItemData.EmptyTime = DateTime.MaxValue;
            CustomUpdate();
        }

        private void MoreButton_Click(object sender, EventArgs e)
        {
            var formPopup = new ItemPopupForm(landItemData.EmptyTime);
            formPopup.onFormClose += OnPopupFormCallback;
            //var formPopup = new Form();
            //var landItemPopup = new LandItemPopupControl();
            //formPopup.Controls.Add(landItemPopup);
            formPopup.ShowDialog(this);
        }

        private void IndexText_Click(object sender, EventArgs e)
        {

        }

        private void OnPopupFormCallback(DateTime targetTime)
        {
            landItemData.EmptyTime = targetTime;
        }
    }
}
