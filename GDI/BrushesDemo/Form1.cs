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

namespace BrushesDemo
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

            Rectangle rect1 = new Rectangle(20 , 20 , 200 , 40);
            LinearGradientBrush lgBrush = new LinearGradientBrush(rect1, Color.Red, Color.Green, 0.0f , true);
            Rectangle rect2 = new Rectangle(20, 80, 200, 40);
            HatchBrush hBrush = new HatchBrush(HatchStyle.Cross, Color.Blue);
           

            TextureBrush txBrush = new TextureBrush(new Bitmap("bmp/bricks.bmp"));
            Rectangle rect3 = new Rectangle(20, 140, 200, 40);
            


            g.FillRectangle(lgBrush, rect1);
            g.FillRectangle(hBrush, rect2);
            g.FillRectangle(txBrush, rect3);

            g.Dispose();
        }
    }
}
