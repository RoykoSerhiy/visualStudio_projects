using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfs_homes
{
    
    public partial class childForm : Form
    {
        //Form1 f = new Form1();
        public delegate void myEvent(object sender, EventArgs e);
        public event myEvent dlgEvent;
        string _str;
        public string tb1Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public childForm(string str)
        {
            InitializeComponent();
            tb1Text = str;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dlgEvent(this, e);
            this.Close();
        }
    }
}
