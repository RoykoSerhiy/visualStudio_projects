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

namespace GlobalTransformation
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

            Rectangle rect = new Rectangle(30, 30, 60, 60);
            Pen penBlue = new Pen(Brushes.Blue , 2);
            Pen redPen = new Pen(Brushes.Red, 2);


            g.DrawRectangle(penBlue, rect);
            g.DrawLine(redPen, 30, 200, 200, 170);
            g.DrawEllipse(new Pen(Brushes.Plum , 3) , new Rectangle(100 , 30 , 100 , 120));
            Matrix X = new Matrix();
            X.Scale(2.2f, 2.2f, MatrixOrder.Append);
            X.RotateAt(30, new PointF(0f, 0f), MatrixOrder.Append);
            g.Transform = X;



            g.DrawRectangle(penBlue, rect);
            g.DrawLine(redPen, 30, 200, 200, 170);
            g.DrawEllipse(new Pen(Brushes.Plum, 3), new Rectangle(100, 30, 100, 120));

            g.Dispose();
        }
    }
}
