using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._07._14
{
    public partial class mainForm : Form
    {
        int min = 0;
        int max = 2000;
        int cur = 0;
        bool game = true;
        int count;
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            DialogResult dr2 = new DialogResult();
            //Random rnd = new Random();
            //cur = min + rnd.Next(max);
            label1.Text = "";
            count = 0;
            while(game != false)
            {

                cur = (min + max) / 2;
                dr = MessageBox.Show("Ваше число:" + cur + "\n", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                count++;
                if (dr == DialogResult.Yes)
                {
                    label1.Text = "Я вгадав";
                    label2.Text = count.ToString();
                    break;
                }
                else
                    if (dr == DialogResult.No)
                    {
                        
                       dr2 = MessageBox.Show("Ваше число більше:" + cur + "\n", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                       count++;
                        if (dr2 == DialogResult.Yes)
                       {
                           min = cur;
                           //max = max;
                       }
                       else
                           if (dr2 == DialogResult.No)
                           {
                               //min = min;
                               max = cur;
                           }
                    }


            }
        }
    }
}
