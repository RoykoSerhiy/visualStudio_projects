using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._08._14.Codes
{
    public class Brick : IShape
    {
        private Image _image;
        Rectangle _rect;
        public Brick(int x , int y)
        {
            Image = Image.FromFile(@"images/brick.jpg");
            Rectangle = new Rectangle(x, y, _image.Width, _image.Height);
            Visible = true;
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
        public bool Visible { set; get; }
        public void Draw(System.Drawing.Graphics g)
        {
            g.DrawImage(_image, _rect);
        }
        public void Move(int x = 0, int y = 0)
        {
            throw new NotImplementedException();
        }
    }
}
