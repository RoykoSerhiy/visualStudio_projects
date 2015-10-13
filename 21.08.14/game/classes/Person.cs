using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.classes
{
    public class Person : IShape
    {
        private Image _image;
        Rectangle _rect;
        Size _formSize;
        int speedX, speedY;
        public Person(Size formSize)
        {
            Image= Image.FromFile(@"images/ball.jpg");
            Rectangle = new Rectangle(0, 0, _image.Width, _image.Height);
            _formSize = formSize;
            speedX = 5;
            speedY = 5;
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
        public void MoveLeft()
        {
            _rect.X -= speedX;
        }
        public void MoveRight()
        {
            _rect.X += speedX;
            
        }
        public void MoveUp()
        {
           _rect.Y += speedY;
        }
        public void MoveDown()
        {
            _rect.Y -= speedY;
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
    }
}
