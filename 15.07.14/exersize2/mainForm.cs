using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exersize2
{
    public partial class mainForm : Form
    {
        Size _size;
        public mainForm()
        {
            InitializeComponent();
            this.ClientSize = new Size(500, 500);
           
            _size = this.ClientSize;
          
           
        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control)
            {
                this.Close();
            }
        }

        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(_size.Height + " " + _size.Width);
            if (e.Button == MouseButtons.Right)
            {
              
                string s = "Client X: " + _size.Height + " Client Y: " + _size.Width;
                MessageBox.Show(s);
               // label1.Text = s;
                //this.Update();
                //label2.Text = s;
            }
            else
            if (e.Button == MouseButtons.Left)
            {
              if ((e.Y > 10 && e.Y < _size.Height - 10)&& (e.X > 10 && e.X < _size.Width - 10))
              {
                  MessageBox.Show("В межах клієнтської зони");
              }
              else
                  if ((e.Y < 10 || e.Y > _size.Height - 10) || (e.X < 10 || e.X > _size.Width - 10))
                  {
                      MessageBox.Show("Поза клієнтською зоню");
                  }
                  else
                  {
                      MessageBox.Show("На межі клієнтської зони");
                  }

            }
            
                
        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            string s = "X: " + e.X.ToString() + " Y: " + e.Y.ToString() ;
            this.Text = s;
        }
    }
}
