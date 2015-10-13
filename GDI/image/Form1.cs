using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image
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

            Rectangle rect = this.ClientRectangle;
            Image img = new Bitmap("bmp/img-wallpapers-apple-world-(-7-colours--version--bmp-)-aquagraph-16074.jpg");
            g.DrawImage(img, rect);
            g.Dispose();
        }
    }
}
