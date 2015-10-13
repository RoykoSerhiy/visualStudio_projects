using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._08._14.Codes
{
    class Brick
    {
        int x, y;
        int width, height;
        Image image;
        Rectangle rect;

        public Brick(int X , int Y)
        {
            x = X;
            y = Y;
            image = Image.FromFile(@"images/brick.jpg");
            width = image.Width;
            height = image.Height;
            rect = new Rectangle(x, y, width, height);
            Visible = true;
        }
        public bool Visible { set; get; }
        public Rectangle Rectangle
        {
            get { return rect; }
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(image, rect);
        }
    }
}
