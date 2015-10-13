using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsAnket
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        
        string name;
        string country;
        string city;
        string sex;
        string dateofbirth;
        string about;
        private void button1_Click(object sender, EventArgs e)
        {
            childForm form = new childForm();
            

            name = Name.Text;
            country = Country.Text;
            city = City.Text;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton r = c as RadioButton;
                    if (r.Checked)
                    {
                        sex = r.Text;
                    }
                }
            }
            DateTime dt = dateTimePicker1.Value;
            dateofbirth = dt.ToString();
            about = textBox1.Text;
            if(form.ShowDialog() == DialogResult.OK)
            {
                form.tb1Text = name+"\n"+country+"\n"+city+"\n"+sex+"\n"+dateofbirth+"\n"+about+";";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
