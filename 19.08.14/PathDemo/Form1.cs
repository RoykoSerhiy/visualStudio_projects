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

namespace PathDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                GraphicsPath path = new GraphicsPath();
                Rectangle rect = new Rectangle(20, 20, 150, 150);
                path.AddRectangle(rect);
                PathGradientBrush pgBrush =
                    new PathGradientBrush(path.PathPoints);
                pgBrush.CenterColor = Color.Tomato;
                pgBrush.SurroundColors = new Color[] { Color.Indigo  , Color.Khaki};
                Matrix X = new Matrix();
                X.Translate(30f, 10f, MatrixOrder.Append);
                X.Rotate(10f, MatrixOrder.Append);
                X.Scale(1.2f, 1f, MatrixOrder.Append);

                path.Transform(X);
                pgBrush.Transform = X;

                g.FillPath(pgBrush, path);
            }


        }
    }
}
