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
    public partial class AddEditForm : Form
    {
        Product prod;
        bool addNew;

        public AddEditForm(Product _prod , bool _addNew)
        {
            InitializeComponent();

            addNew = _addNew;
            prod = _prod;

            if (!addNew)
            {
                textBox1.Text = prod.Title;
                textBox2.Text = prod.Producer;
                textBox3.Text = prod.Price.ToString();
                this.Text = "Editing";
            }
            else
            {
                this.Text = "Adding";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Enter all fields");
            }
            else
            {
                if (prod == null)
                {
                    prod = new Product();
                }

                prod.Title = textBox1.Text;
                prod.Producer = textBox2.Text;
                try
                {
                    prod.Price = Convert.ToDouble(textBox3.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Price entered incorrect" + ex.Message);
                    return;
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
