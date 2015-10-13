using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font("AmazS.T.A.L.K.E.R.v.3.0", 60, FontStyle.Bold);
            
            
            g.DrawString("S.T.A.L.K.E.R", f, Brushes.Black, 10, 10);
            g.DrawString("Lost Alpha", f, Brushes.Black, 12, 75);
           

            g.Dispose();
        }
    }
}
