using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
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

            Pen p = new Pen(Brushes.Tomato , 4);
            p.DashStyle = DashStyle.Dot;

            g.DrawEllipse(p, 50, 100, 170, 90);

            g.Dispose();
        }
    }
}
