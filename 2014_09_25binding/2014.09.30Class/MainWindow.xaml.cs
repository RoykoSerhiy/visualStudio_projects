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

namespace _2014._09._30Class
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPushMe_Click_1(object sender, RoutedEventArgs e)
        {
            ChildWindow child = new ChildWindow();

            bool? resDiag = child.ShowDialog();

            if (resDiag.HasValue && resDiag.Value)
            {
                lbl1.Content = child.txtBox1Text;
            }
        }
    }
}
