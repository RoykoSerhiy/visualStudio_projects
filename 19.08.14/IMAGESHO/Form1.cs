using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMAGESHO
{
    public partial class Form1 : Form
    {
        Image _picture;
        Point[] _pictureBounds;

        public Form1()
        {
            InitializeComponent();
            _picture = Image.FromFile(@"images\pictures.jpg");
            _pictureBounds = new Point[3];
            _pictureBounds[0] = new Point(0, 0);
            _pictureBounds[1] = new Point(_picture.Width, 0);
            _pictureBounds[2] = new Point(_picture.Width / 3, _picture.Height);
            this.AutoScrollMinSize = new Size(4 * _picture.Width / 3, _picture.Height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.ScaleTransform(1f, 1f);
            g.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
            g.DrawImage(_picture, _pictureBounds);
            g.Dispose();

        }
     }
}
