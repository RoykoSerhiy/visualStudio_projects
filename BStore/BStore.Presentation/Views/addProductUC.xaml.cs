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

namespace BStore.Presentation.Views
{
    /// <summary>
    /// Логика взаимодействия для addProductUC.xaml
    /// </summary>
    public partial class addProductUC : UserControl
    {
        public addProductUC()
        {
            InitializeComponent();
        }
        public ChildWindow ParentWin { get; set; }
        public string ProductName { get; set; }
        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            ProductName = tbxProductName.Text;
            ParentWin.DialogResult = true;
        }
    }
}
