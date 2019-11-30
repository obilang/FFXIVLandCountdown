using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandItem
{
    public partial class LandItemControl : UserControl
    {
        public enum ELandState
        {
            EMPTY,
            OCCUPIED
        }

        public LandItemControl()
        {
            InitializeComponent();
        }

        public void InitItem(int index, ELandState state)
        {
            this.IndexText.Text = index.ToString();
        }

        private void LandItemControl_Load(object sender, EventArgs e)
        {

        }


    }
}
