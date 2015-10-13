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
    /// Логика взаимодействия для addCategoryUC.xaml
    /// </summary>
    public partial class addCategoryUC : UserControl
    {
        public addCategoryUC()
        {
            InitializeComponent();
        }
        public ChildWindow ParentWin { get; set; }
        public string CategoryName { get; set; }
        public string subCategoryName { get; set; }
        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {


            CategoryName = tbxCategoryName.Text;
            subCategoryName = tbxSubCategoryName.Text;
            ParentWin.DialogResult = true;

        }
    }
}
