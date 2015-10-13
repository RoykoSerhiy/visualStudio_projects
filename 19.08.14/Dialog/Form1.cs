using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        SolidBrush _brush = new SolidBrush(Color.Indigo);

        public Form1()
        {
            InitializeComponent();
        }

        private void stmiClear_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
        }

        private void stmiFont_Click(object sender, EventArgs e)
        {
            FontDialog fDialog = new FontDialog();
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                Font font = fDialog.Font;
                DrawStr(font, "NIGERRS font: = "+font.Name);
            }
        }

        void DrawStr(Font font, string str)
        {
            Graphics g = this.CreateGraphics();

            int x = rnd.Next(10, 200);
            int y = rnd.Next(10, 400);

            g.DrawString(str, font, _brush, x, y); 

            g.Dispose();
        }
    }
}
