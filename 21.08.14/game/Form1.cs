using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game.classes;

namespace game
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

            _game.Person.Draw(g);
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _game.Person.wallHit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        _game.Person.MoveUp();
                    }
                    break;
                case Keys.Down:
                    {
                        _game.Person.MoveDown();
                    }
                    break;
                case Keys.Left:
                    {
                        _game.Person.MoveLeft();
                    }
                    break;
                case Keys.Right:
                    {
                        _game.Person.MoveRight();
                    }
                    break;
            }
        }
    }
}
