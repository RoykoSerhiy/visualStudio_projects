using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Calc
        {
            public double all;
            public double val1;
            public double val2;
            public bool is_plus;
            public bool is_minus;
            public bool is_multy;
            public bool is_dil;

            public Calc()
            {

            }

        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "9";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "7";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "0";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "*";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "/";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "-";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "+";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
        }

        private void TextBox1_TextInput(object sender, TextCompositionEventArgs e)
        {
            //char[] c = TextBox1.Text.ToCharArray();
            //foreach (char l in c)
            //{
            //    if (Char.IsDigit(l))
            //    {
            //        TextBox1.Text += l;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error");
            //    }
            //}
        }
    }
}
