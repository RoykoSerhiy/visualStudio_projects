using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twoforms
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            childForm form = new childForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(form.tb1Text);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            ArrayList si = new ArrayList(listBox1.SelectedItems);

            foreach (string item in si)
            {
                listBox1.Items.Remove(item);
            }
            listBox1.EndUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
