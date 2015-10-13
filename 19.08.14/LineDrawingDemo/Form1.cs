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

namespace LineDrawingDemo
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

            g.SmoothingMode = SmoothingMode.HighQuality;
            Pen pen = new Pen(Color.Tomato , 10);
            pen.StartCap = LineCap.DiamondAnchor;
            pen.EndCap = LineCap.ArrowAnchor;
            pen.DashStyle = DashStyle.DashDotDot;
            pen.DashCap = DashCap.Triangle;
            g.DrawLine(pen, 20, 100, 270, 100);

            g.Dispose();
        }
    }
}
