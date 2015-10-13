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

namespace Path
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

            Point[] points = { 
                                new Point(5,10) ,
                                new Point(23 , 130),
                                new Point(130 , 57)
                             };

            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddEllipse(170 , 170 , 100 , 50);
            g.FillPath(Brushes.Black, path);
            path.CloseFigure();

            path.StartFigure();
            path.AddCurve(points , 0.5F);
            g.FillPath(Brushes.Blue, path);

            //coords
            g.TranslateTransform(40, 40);
            Point A = new Point(0, 0);
            Point B = new Point(150 , 150);
            g.DrawLine(new Pen(Brushes.Black, 3), A, B);

            g.Dispose();
        }
    }
}
