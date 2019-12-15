using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXIVLandCountdown
{
    public partial class ItemPopupForm : Form
    {
        public delegate void OnFormClose(DateTime targetTime);
        public event OnFormClose onFormClose;

        public ItemPopupForm()
        {
            InitializeComponent();
        }

        public ItemPopupForm(DateTime currentTime)
        {
            InitializeComponent();
            this.targetTime = currentTime;
            if (targetTime.Year == DateTime.MaxValue.Year)
            {
                targetTime = DateTime.Now;
            }

            this.DayTextBox.Text = targetTime.Month.ToString() + "/" + targetTime.Day.ToString();
            this.HourTextBox.Text = targetTime.Hour.ToString();
            this.MinTextBox.Text = targetTime.Minute.ToString();
        }

        private void LandItemPopupForm_Load(object sender, EventArgs e)
        {

        }

        private DateTime GetDateTimeFromTextBox()
        {
            string monthStr = this.DayTextBox.Text.Substring(0, this.DayTextBox.Text.IndexOf('/'));
            string dayStr = this.DayTextBox.Text.Substring(this.DayTextBox.Text.IndexOf('/') + 1);
            string hourStr = this.HourTextBox.Text;
            string minStr = this.MinTextBox.Text;

            DateTime time = new DateTime(targetTime.Year,
                int.Parse(monthStr),
                int.Parse(dayStr),
                int.Parse(hourStr),
                int.Parse(minStr),
                0);
            return time;
        }

        private DateTime targetTime;

        private void ItemPopupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

            }

            if (e.CloseReason == CloseReason.WindowsShutDown)
            {

            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            this.targetTime = GetDateTimeFromTextBox();
            onFormClose(targetTime);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemPopupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
