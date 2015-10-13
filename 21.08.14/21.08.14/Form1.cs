using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _21._08._14.Codes;

namespace _21._08._14
{
    public partial class Form1 : Form
    {
        
        Graphics g;
        Game _game;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            _game = new Game(this.ClientSize, g);
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g = e.Graphics;
            _game.Carret.Draw(g);
            _game.Ball.Draw(g);
            foreach (Brick b in _game.Bricks)
            {
                if (b.Visible)
                {
                    b.Draw(g);
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int caretX = e.X - _game.Carret.Rectangle.Width / 2;
            //int caretY = e.Y - _game.Carret.Rectangle.Height / 2;
            _game.CarretMove(caretX);
            
            this.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _game.Ball.Move();
            _game.Ball.wallHit();
            _game.BallCaretHit();
            _game.brickHit();
            this.Refresh();
        }
    }
}
