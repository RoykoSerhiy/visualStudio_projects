using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void UpdateColor()
        {
            Color r = Color.FromArgb(trackBar1.Value , trackBar2.Value , trackBar3.Value);
            this.BackColor = r;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBar2_RightToLeftLayoutChanged(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
    }
}
