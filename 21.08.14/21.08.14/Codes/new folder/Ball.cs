using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._08._14.Codes
{
    class Ball
    {
        int x, y;
        int width, height;
        Image image;
        Rectangle rect;
        int speedX, speedY;
        Random randSpeed = new Random();
        Size formSize;

        public Ball(Size FormSize)
        {
            image = Image.FromFile(@"images/ball.jpg");
            width = image.Width;
            height = image.Height;
            speedX = randSpeed.Next(1, 4);
            speedY = randSpeed.Next(3, 4);
            rect = new Rectangle(x, y, width, height);
            formSize = FormSize;

           

        }
        public Rectangle Rectangle
        {
            get { return rect; }
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(image, rect);
        }
        public void Move()
        {
            rect.X += speedX;
            rect.Y += speedY;
        }
        public void wallHit()
        {
            if (rect.X < 0 || rect.X > formSize.Width - rect.Width)
            {
                speedX *= -1;

            }
            if (rect.Y < 0 || rect.Y > formSize.Height - rect.Height)
            {
                speedY *= -1;
            }
        }
        public void caretHit(Rectangle caretRect)
        {
            if (caretRect.IntersectsWith(rect))
            {
                speedY *= -1;

            }
        }
        public void brickHit(List<Brick> bricks)
        {
            foreach (Brick b in bricks)
            {
                if (b.Rectangle.IntersectsWith(rect) && b.Visible) 
                {
                    b.Visible = false;
                    speedY *= -1;

                }
            }
        }
    }
}
