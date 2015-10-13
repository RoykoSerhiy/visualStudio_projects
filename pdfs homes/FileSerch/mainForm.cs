using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSerch
{
    public partial class mainForm : Form
    {
        childForm child;
        public mainForm()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void dlgEvent(object sender, EventArgs e)
        {
            childForm objModeless = sender as childForm;
            if (objModeless != null)
            {
                textBox1.Text += objModeless.filesGet;
            }

            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            child = new childForm();
            child.dlgEvent += dlgEvent;

            child.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
