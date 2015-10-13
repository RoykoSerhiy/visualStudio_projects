using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Product no chose");
                return;
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        Product prod = null;
        private void button1_Click(object sender, EventArgs e)
        {
            prod = new Product();
            AddEditForm addForm = new AddEditForm(prod, true);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(prod);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Product no chose");
                return;
            }
            int n = listBox1.SelectedIndex;
            prod = (Product)listBox1.Items[n];

            AddEditForm editFrom = new AddEditForm(prod, false);
            editFrom.ShowDialog();


            listBox1.Items.RemoveAt(n);
            listBox1.Items.Insert(n , prod);
            listBox1.SelectedIndex = n;
        }
    }
}
