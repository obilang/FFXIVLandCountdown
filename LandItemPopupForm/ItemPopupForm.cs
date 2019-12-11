using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandItemPopupForm
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
            this.targetTime = this.targetTime.AddHours(1);
        }

        private void LandItemPopupForm_Load(object sender, EventArgs e)
        {

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
            onFormClose(targetTime);
        }
    }
}
