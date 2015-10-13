using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asssa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //lblX.Text = MousePosition.X.ToString();
            //lblY.Text = MousePosition.Y.ToString();
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
        }
    }
}
