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

namespace Shapes
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
            g.DrawLine(new Pen(Color.Red, 2), 0, 0, 100, 100);
            g.DrawRectangle(new Pen(Color.Indigo , 3) , new Rectangle(100 , 100 , 60 , 60));
            g.DrawPie(new Pen(Color.IndianRed, 4),
                150, 10, 150, 150, 90, 250);
            PointF[] points = { 
                              new PointF(10.0F , 50.0F),
                              new PointF(200.0F , 200.0F),
                              new PointF(90.0F , 20.0F),
                              new PointF(140.0F , 20.0F),
                              new PointF(40.0F , 150.0F),
                              };
            g.DrawPolygon(new Pen(Color.Blue, 2), points);
            g.Dispose();
        }
    }
}
