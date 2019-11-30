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
            LandItemControl landItem = new LandItemControl();
            landItem.InitItem(66, LandItemControl.ELandState.EMPTY);

            this.Controls.Add(landItem);
            this.Controls.Clear();
        }
    }
}
