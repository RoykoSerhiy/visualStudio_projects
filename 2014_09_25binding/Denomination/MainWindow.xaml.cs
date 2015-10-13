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

namespace Denomination
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Denom();
        }
        private void Denom()
        {
            
            base.DataContext = new Denominations
            {
                
                Denom5 = "0",
                Denom10 ="0",
                Denom20 ="0",
                Denom50= "0",
                Denom100="0"
            };

        }
    }
}
