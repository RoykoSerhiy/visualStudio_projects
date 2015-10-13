using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if (!listBox1.Items.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Дані не повинні повторюватись");
                }

            }
            else
            {
                MessageBox.Show("Empty String");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedItems != null)
                {
                    for (int i = 0; i < listBox1.SelectedItems.Count; ++i)
                    {
                        listBox1.Items.Remove(listBox1.SelectedItems[i]);
                    }
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count != 0)
            {
                listBox2.Items.Clear();
                for (int i = 0; i < listBox1.Items.Count; ++i)
                {

                    listBox2.Items.Add(listBox1.Items[i]);
                }
            }
            else
            {
                MessageBox.Show("First list box empty");
            }
        }
    }
}
