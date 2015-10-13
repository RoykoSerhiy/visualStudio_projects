using System;
using System.Collections.Generic;
using System.Configuration;
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
using BStore.Presentation.ViewModel;
using BStore.Presentation.Views;
using Buisnes.Managers.Abstract;
using Buisnes.Managers.Concrete;

namespace BStore.Presentation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MagazinBDEntities3"].ConnectionString;

     static public IPackageManager packageManager = new PackageManager(connectionString);
     static public IProductManager productManager = new ProductManager(connectionString);
     static public ICategoryManager categoryManager = new CategoryManager(connectionString);
     static public IProducerManager producerManager = new ProducerManager(connectionString);
     static public IMeasureManager measureManager = new MeasureManager(connectionString);
     static public IPriceManager priceManager = new PriceManager(connectionString);
     static public CatalogViewModel catalogViewModel = 
         new CatalogViewModel(packageManager,
                              productManager,
                              producerManager,
                              categoryManager,
                              measureManager,
                              priceManager);

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            try
            {

                List<string> _cmbList = catalogViewModel.Categories.
                    Where(c => c.ParentId == null).OrderBy(c => c.Name).Select(c => c.Name).ToList();

                _cmbList.Insert(0, "Всі товари");

                vwCatalog.cmbCategory.DataContext = _cmbList;
                vwCatalog.cmbCategory.SelectedIndex = 0;

        
              
               this.Title = "Каталог товарів";



               catalogViewModel.ResetCatalog();
                vwCatalog.dgCatalogUC.DataContext = catalogViewModel.Catalog;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Main Window Load Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void vwCatalog_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
