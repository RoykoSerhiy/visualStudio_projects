using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Path
{
    public enum RegionOperation
    {
        Complement,
        Union,
        Intersect,
        Exclude,
        Xor,
        No
    }
    public partial class Form1 : Form
    {
        Graphics g;
        RegionOperation rgnOperation = RegionOperation.No;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawRegionOperation();
        }

        void DrawRegionOperation()
        {
            g = this.CreateGraphics();
            Rectangle rect1 = new Rectangle(100, 100, 120, 120);
            Rectangle rect2 = new Rectangle(70, 70, 120, 120);

            Region rgn1 = new Region(rect1);
            Region rgn2 = new Region(rect2);

            g.DrawRectangle(Pens.Blue, rect1);
            g.DrawRectangle(Pens.Red, rect2);

            switch(rgnOperation)
            {
                case RegionOperation.Union:
                    rgn1.Union(rgn2);
                    break;
                case RegionOperation.Complement:
                    rgn1.Complement(rgn2);
                    break;
                case RegionOperation.Intersect:
                    rgn1.Intersect(rgn2);
                    break;
                case RegionOperation.Exclude:
                    rgn1.Exclude(rgn2);
                    break;
                case RegionOperation.Xor:
                    rgn1.Xor(rgn2);
                    break;
                default:
                    break;

            }

            g.FillRegion(Brushes.Tomato, rgn1);
            
            g.Dispose();
            
        }
        #region ClickEvents
        private void mnComplement_Click(object sender, EventArgs e)
        {
            rgnOperation = RegionOperation.Complement;
            this.Refresh();
        }

        private void mnUnion_Click(object sender, EventArgs e)
        {
            rgnOperation = RegionOperation.Union;
            this.Refresh();
        }

        private void mnIntersect_Click(object sender, EventArgs e)
        {
            rgnOperation = RegionOperation.Intersect;
            this.Refresh();
        }

        private void mnExclude_Click(object sender, EventArgs e)
        {
            rgnOperation = RegionOperation.Exclude;
            this.Refresh();
        }

        private void mnXor_Click(object sender, EventArgs e)
        {
            rgnOperation = RegionOperation.Xor;
            this.Refresh();
        }
        #endregion
    }
}
