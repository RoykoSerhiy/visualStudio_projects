using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._08._14.Codes
{
    public class Carret : IShape
    {
        private Image _image;
        Rectangle _rect;

        public Carret(Size formSize)
        {
            Image = Image.FromFile(@"images/carret.jpg");
            Rectangle = new Rectangle(0,0,Image.Width , Image.Height);
            _rect.X = formSize.Width / 2 - Image.Width / 2;
            _rect.Y = formSize.Height - Image.Height - 20;
        }
        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
            }
        }

        public Rectangle Rectangle
        {
            get
            {
                return _rect;
            }
            set
            {
                _rect = value;
            }
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Image, Rectangle); 
        }

        public void Move(int x = 0, int y = 0)
        {
            _rect.X = x;
            if (y == 0)
            {
                _rect.Y = _rect.Y;
            }
            else
                _rect.Y = y;
            
        }
    }
}
