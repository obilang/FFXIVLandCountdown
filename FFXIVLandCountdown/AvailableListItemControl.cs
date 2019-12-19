using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FFXIVLandCountdown
{

    public partial class AvailableListItemControl : UserControl, IComparable<AvailableListItemControl>
    {
        public delegate void OnDataUpdated();
        public event OnDataUpdated onDataUpdated;

        private LandItemData landItemData;

        public AvailableListItemControl()
        {
            InitializeComponent();
        }

        public void Init(LandItemData data)
        {
            this.LocationLabel.Text = string.Format("{0} {1}-{2}", GetRegionName(data.Region), data.SectionIndex, data.Index + 1);
            this.TimeLabel.Text = data.EmptyTime.ToString();
            landItemData = data;
            CustomUpdate();
        }

        public int CompareTo(AvailableListItemControl other)
        {
            if (this.landItemData.Bookmark)
            {
                if (other.landItemData.Bookmark)
                {
                    return this.landItemData.EmptyTime.CompareTo(other.landItemData.EmptyTime);
                }
                return -1;
            }

            if (other.landItemData.Bookmark)
            {
                return 1;
            }

            return this.landItemData.EmptyTime.CompareTo(other.landItemData.EmptyTime);
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
                if (passedTime.TotalHours < LandItemData.CD_HOUR)
                {
                    this.TimeLabel.Text = string.Format("倒计时 {0:c}", LandItemData.sCdHour.Subtract(passedTime));
                }
                else
                {
                    this.TimeLabel.Text = string.Format("已经过 {0:c}", passedTime.Subtract(LandItemData.sCdHour));
                }

                if (landItemData.Bookmark)
                {
                    this.PinButton.BackgroundImage = Properties.Resources.tack_save_button_pined;
                }
                else
                {
                    this.PinButton.BackgroundImage = Properties.Resources.tack_save_button;
                }
            }
        }

        private void PinButton_Click(object sender, EventArgs e)
        {
            landItemData.Bookmark = !landItemData.Bookmark;
            CustomUpdate();
            onDataUpdated();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            landItemData.LandState = ELandState.OCCUPIED;
            onDataUpdated();
        }
    }
}
