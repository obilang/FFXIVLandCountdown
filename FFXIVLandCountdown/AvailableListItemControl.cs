using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FFXIVLandCountdown
{

    public partial class AvailableListItemControl : UserControl
    {
        private LandItemData landItemData;

        public AvailableListItemControl()
        {
            InitializeComponent();
        }

        public void Init(LandItemData data)
        {
            this.LocationLabel.Text = string.Format("{0} {1}-{2}", GetRegionName(data.Region), data.SectionIndex, data.Index);
            this.TimeLabel.Text = data.EmptyTime.ToString();
            landItemData = data;
            CustomUpdate();
        }

        private string GetRegionName(ERegion region)
        {
            switch (region)
            {
                case ERegion.BYX:
                    return "白";
                case ERegion.GJGQ:
                    return "沙";
                case ERegion.HWC:
                    return "海";
                case ERegion.XYCMP:
                    return "森";
                default:
                    return string.Empty;
            }
        }

        private void AvailableListItemControl_Load(object sender, EventArgs e)
        {

        }

        public void CustomUpdate()
        {
            if (landItemData.LandState == ELandState.EMPTY)
            {
                TimeSpan passedTime = DateTime.Now - landItemData.EmptyTime;
                passedTime = TimeSpan.FromSeconds((int)passedTime.TotalSeconds);
                if (passedTime.Hours < LandItemData.CD_HOUR)
                {
                    this.TimeLabel.Text = string.Format("倒计时 {0:c}", LandItemData.sCdHour.Subtract(passedTime));
                }
                else
                {
                    this.TimeLabel.Text = string.Format("已经过 {0:c}", passedTime.Subtract(LandItemData.sCdHour));
                }
            }
        }
    }
}
