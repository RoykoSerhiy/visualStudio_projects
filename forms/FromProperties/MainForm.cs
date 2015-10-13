using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromProperties
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(this.Text);

           // MessageBox.Show("height:" + this.Size.Height + " Width "+this.Size.Width);
           // Point point = this.Location;
           // MessageBox.Show("X = " +point.X +  "Y = " + point.Y);

           // MessageBox.Show("ForeColor: "+ this.ForeColor.Name + "\nBackColor "+ this.BackColor.Name);

        }
    }
}
