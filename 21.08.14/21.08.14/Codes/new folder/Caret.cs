using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._08._14.Codes
{
    class Caret
    {
        int x, y;
        int width, height;
        Image image;
        Rectangle rect;

        public Caret(Size formSize)
        {
            image = Image.FromFile(@"images/carret.jpg");
            width = image.Width;
            height = image.Height;
            x = formSize.Width / 2;
            y = formSize.Height - height - 20;
            rect = new Rectangle(x, y, width, height);
        }
        public Rectangle Rectangle
        {
            get { return rect; }
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(image, rect);
        }
        public void Move(int dx)
        {
            rect.X = dx;
        }
    }
}
