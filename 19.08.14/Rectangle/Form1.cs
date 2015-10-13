using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle_Losers
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

            int x = 20;
            int y = 30;
            int width = 120;
            int height = 60;

            Point pt = new Point(10, 10);
            Size size = new Size(210, 180);

            Rectangle rect1 = new Rectangle(x, y, width, height);
            Rectangle rect2 = new Rectangle(pt, size);

            g.FillRectangle(Brushes.Tomato, rect2);
            g.DrawRectangle(new Pen(Brushes.Black , 3), rect1);
            

            g.Dispose();
        }
    }
}
