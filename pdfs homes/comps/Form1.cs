using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comps
{
   
    public partial class Form1 : Form
    {
        double dtotal = 0;
        
        List<Comp> Goods = new List<Comp>();
        Form2 child = null;
        Form3 child2 = null;
        public Form1()
        {
            InitializeComponent();
            Goods.Add(new Comp("Asus", "MCI", "intel core i7", "RAM 16gb", "hdd 2tb", "nvidia Geforce Titan ", "high performance machine", 18700));
            Goods.Add(new Comp("Acer", "MCI", "intel core i5", "RAM 8gb", "hdd 1tb", "Amd Radeon hd4570", "PC", 5700));
            Goods.Add(new Comp("HP", "MCI", "intel core i3", "RAM 4gb", "hdd 500gb", "nvidia Geforce 700 ", "PC Multimedia", 4700));
            
            foreach (Comp c in Goods)
            {
                comboBox1.Items.Add(c.GetName);
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (dtotal != 0)
            {
                DialogResult dr;
                dr = MessageBox.Show("Pay:" + dtotal, "Want Pay", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Thank You for a buy");
                }
                else
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }

                this.Close();
            }
            else
            {
                MessageBox.Show("Basket is Empty");
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Comp c in Goods)
            {
                if (comboBox1.SelectedItem.ToString() == c.GetName)
                {
                    textBox1.Text = c.GetPrice.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string total = "";
            
            foreach (Comp c in Goods)
            {
                if (comboBox1.SelectedItem.ToString() == c.GetName)
                {
                    child = new Form2(c);
                    if (child.ShowDialog() == DialogResult.OK)
                    {

                        // c.name = child.GetName;
                        c.GetName = child.Name;
                        MessageBox.Show(c.GetName);
                        c.motherboard = child.Motherboard;
                        c.processor = child.Processor;
                        c.ram = child.Ram;
                        c.hdd = child.Hdd;
                        c.video = child.Video;
                        c.about = child.About;
                        //c.price = child.Price;

                    }
                    listBox1.Items.Add(c.GetName+" "+c.GetMotherboard+" "+c.GetProcessor+" "+c.GetRam+" "+c.GetHdd);
                    dtotal += c.GetPrice;
                   
                }
               
            }
            
            textBox2.Text = dtotal.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Comp c in Goods)
                {
                    if (listBox1.SelectedItem.ToString() == c.GetName + " " + c.GetMotherboard + " " + c.GetProcessor + " " + c.GetRam + " " + c.GetHdd)
                    {
                        listBox1.Items.Remove(c.GetName + " " + c.GetMotherboard + " " + c.GetProcessor + " " + c.GetRam + " " + c.GetHdd);
                        dtotal -= c.GetPrice;
                        break;
                    }

                }
                textBox2.Text = dtotal.ToString();
            }
            catch
            {
                MessageBox.Show("Not Chose Element!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                
                foreach (Comp c in Goods)
                {
                    if (comboBox1.SelectedItem.ToString() == c.GetName)
                    {
                        child2 = new Form3(c);
                        child2.ShowDialog();
                        //MessageBox.Show(c.GetName);

                    
                        
                    }
                   
                }
                
            }
            catch
            {
                MessageBox.Show("Element not chose!!!");
            }
        }
    }
    public class Comp
    {
        public string name;
        public string motherboard;
        public string processor;
        public string ram;
        public string hdd;
        public string video;
        public string about;
        public double price;

        public Comp(string n, string m ,string p,string r,string h, string v , string a , double pr)
        {
            name = n;
            motherboard = m;
            processor = p;
            ram = r;
            hdd = h;
            video = v;

            about = a;
            price = pr;
        }
        public string GetName
        {
            get { return name; }
            set { name = value; }
        }
        public string GetProcessor
        {
            get { return processor; }
            set { processor = value; }
        }
        public string GetMotherboard
        {
            get { return motherboard; }
            set { motherboard = value; }
        }
        public string GetRam
        {
            get { return ram; }
            set { ram = value; }
        }
        public string GetHdd
        {
            get { return hdd; }
            set { hdd = value; }
        }
        public string GetVideo
        {
            get { return video; }
            set { video = value; }
        }
        public string GetAbout
        {
            get { return about; }
            set { about = value; }
        }
        public double GetPrice
        {
            get { return price; }
            set { price = value; }
        }
    }
}
