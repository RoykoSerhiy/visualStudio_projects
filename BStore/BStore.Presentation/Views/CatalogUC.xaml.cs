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
    /// Логика взаимодействия для CatalogUC.xaml
    /// </summary>
    public partial class CatalogUC : UserControl
    {
        public CatalogUC()
        {
            InitializeComponent();
            tbxFilter_TextChanged_1(null, null);
           
        }

        private void cmbCategory_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (cmbCategory.SelectedIndex == 0)
            {
                dgCatalogUC.DataContext = MainWindow.catalogViewModel.Catalog;
            }
            else
            {
                dgCatalogUC.DataContext = MainWindow.catalogViewModel.Catalog.Where(c => c.SubCategory == CmbCategory);
            }
                
            
        }

        public string CmbCategory
        {
            get
            {
                return cmbCategory.SelectedItem.ToString();
            }
        }

       // public string CmbSubCategory
       // {
       //     get
       //     {
       //         return CmbSubCategory.SelectedItem.ToString();
       //     }
       // }

        private void tbxFilter_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (tbxFilter.Text == "")
            {

                cmbCategory.IsEnabled = true;
                btnFilter.IsEnabled = false;
                btnClear.IsEnabled = false;
            }
            else
            {
                cmbCategory.IsEnabled = false;
                btnFilter.IsEnabled = true;
                btnClear.IsEnabled = true;
            }
        }

        private void btnFilter_Click_1(object sender, RoutedEventArgs e)
        {
            dgCatalogUC.DataContext = MainWindow.catalogViewModel.Catalog
                .Where(c => c.Name.ToLower().IndexOf(tbxFilter.Text.ToLower()) != -1
                || c.Producer.ToLower().IndexOf(tbxFilter.Text.ToLower()) != -1
                );
        }

        private void btnClear_Click_1(object sender, RoutedEventArgs e)
        {
            tbxFilter.Text = "";
            tbxFilter_TextChanged_1(null, null);
            

            cmbCategory.SelectedIndex = 0;
            dgCatalogUC.DataContext = MainWindow.catalogViewModel.Catalog;
        }

        private void addPack_Click_1(object sender, RoutedEventArgs e)
        {
            ChildWindow win = new ChildWindow();
            AddPackageUC addPackUC = new AddPackageUC();

            addPackUC.ParentWin = win;
            win.forUC.Children.Add(addPackUC);
            win.SizeToContent = SizeToContent.WidthAndHeight;
            
            win.Title = "Новий товар";
            bool? dialogRes = win.ShowDialog();
            if (dialogRes.HasValue && dialogRes.Value)
            {
               MainWindow.catalogViewModel.ResetCatalog();
               this.dgCatalogUC.DataContext = MainWindow.catalogViewModel.Catalog;
            }
        }
    }
}
