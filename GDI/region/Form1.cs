using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace region
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            Rectangle rect1 = new Rectangle(40, 40, 160, 160);
            Rectangle rect2 = new Rectangle(90, 90, 160, 160);
            Region rg1 = new Region(rect1);
            Region rg2 = new Region(rect2);


            g.DrawRectangle(Pens.Black, rect1);
            g.DrawRectangle(Pens.Red, rect2);


//            rg1.Intersect(rect2);
            rg1.Xor(rect2);
            g.FillRegion(Brushes.Blue , rg1);

            g.Dispose();
        }
    }
}
