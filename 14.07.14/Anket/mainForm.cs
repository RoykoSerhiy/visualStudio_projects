using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anket
{
    public partial class mainForm : Form
    {
        string firstname;
        string lastname;
        string country;
        string city;
        string phone;
        string dt;
        string radio;

        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstname = textBox2.Text;
            lastname = textBox1.Text;
            country = textBox3.Text;
            city = textBox4.Text;
            phone = textBox5.Text;
            dt = dateTimePicker1.Value.ToLongDateString();
            foreach (Control c in groupBox1.Controls)
            {
                if(c is RadioButton)
                {
                    RadioButton r = c as RadioButton;
                    if (r.Checked)
                    {
                        radio = r.Text;
                    }
                   
                    
                }
            }
            MessageBox.Show(firstname+"\n"+lastname+"\n"+country+"\n"+city+"\n"+phone
                +"\n"+dt+"\n"+radio+"\n" ,"result", MessageBoxButtons.OK ,MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }
    }
}
