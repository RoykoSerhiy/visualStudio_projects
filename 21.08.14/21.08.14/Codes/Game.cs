using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._08._14.Codes
{
    public sealed class Game
    {
        Carret _carret;
        Ball _ball;
        List<Brick> _bricks = new List<Brick>();
        public Game(Size clientSize, Graphics g)
        {
            _carret = new Carret(clientSize);
            _ball = new Ball(clientSize);
            _bricks.Add(new Brick(100, 10));
            _bricks.Add(new Brick(200, 10));
            _bricks.Add(new Brick(300, 10));
        }
        public Carret Carret
        {
            get { return _carret; }
        }
        public Ball Ball
        {
            get { return _ball; }
        }
        public void CarretMove(int x , int y = 0)
        {
            Carret.Move(x , y);
        }
        public void BallCaretHit()
        {
            Ball.caretHit(Carret.Rectangle);
        }
        public List<Brick> Bricks
        {
            get { return _bricks; }
        }
        public void brickHit()
        {
            Ball.brickHit(Bricks);
        }
    }
}
