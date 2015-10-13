using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._08._14.Codes
{
    public class Ball : IShape
    {
        private Image _image;
        Rectangle _rect;
        int speedX, speedY;
        Random randSpeed = new Random();
        Size _formSize;
        public Ball(Size formSize)
        {
            Image= Image.FromFile(@"images/ball.jpg");
            Rectangle = new Rectangle(0, 0, _image.Width, _image.Height);
            _formSize = formSize;
            speedX = randSpeed.Next(2, 3);
            speedY = randSpeed.Next(3, 4);
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

        public void Draw(System.Drawing.Graphics g)
        {
            g.DrawImage(_image, _rect);
        }

        public void Move(int x = 0, int y = 0)
        {
            _rect.X += speedX;
            _rect.Y += speedY;
        }
        public void wallHit()
        {
            if (_rect.X < 0 || _rect.X > _formSize.Width - _rect.Width)
            {
                speedX *= -1;

            }
            if (_rect.Y < 0 || _rect.Y > _formSize.Height - _rect.Height)
            {
                speedY *= -1;
            }
        }
        public void caretHit(Rectangle caretRect)
        {
            if (caretRect.IntersectsWith(_rect))
            {
                speedY *= -1;

            }
        }
        public void brickHit(List<Brick> bricks)
        {
            foreach (Brick b in bricks)
            {
                if (b.Rectangle.IntersectsWith(_rect) && b.Visible)
                {
                    b.Visible = false;
                    speedY *= -1;
        
                }
            }
        }
    }
}
