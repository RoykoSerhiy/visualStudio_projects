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

namespace ImageDemo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Image img = new Image();
            BitmapImage _Image = new BitmapImage();
            _Image.BeginInit();
            _Image.UriSource = new Uri(@"D:/22.jpg");
            _Image.EndInit();
            img.Source = _Image;
            MyGrid.Children.Add(img);
        }

        private void Image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("Error Sucker");
        }
    }
}
