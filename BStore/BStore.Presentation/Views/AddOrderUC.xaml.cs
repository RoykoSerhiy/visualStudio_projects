using BStore.Presentation.ViewModel;
using Buisnes.Managers.Abstract;
using Buisnes.Managers.Concrete;
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

namespace BStore.Presentation.Views
{
    /// <summary>
    /// Логика взаимодействия для AddOrdreUC.xaml
    /// </summary>
    public partial class AddOrdreUC : UserControl
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MagazinBDEntities3"].ConnectionString;

        static public IOrderItemManager orderItemManager = new OrderItemManager(connectionString);
        static public IOrderManager orderManager = new OrderManager(connectionString);
        static public IPackageManager packageManager = new PackageManager(connectionString);
        static public IProductManager productManager = new ProductManager(connectionString);
        static public IPriceManager priceManager = new PriceManager(connectionString);
        static public ICustomerManager customerManager = new CustomerManager(connectionString);
        static public OICatalogViewModel OIcatalogViewModel =
            new OICatalogViewModel(
                orderItemManager,
                orderManager,
                packageManager,
                productManager,
                priceManager,
                customerManager
                );
        public ChildWindow ParentWin { get; set; }
        public CatalogUC catalogUC;
        public AddOrdreUC()
        {
            InitializeComponent();
        }

        public int CustomerId { get; set; }
        public DateTime Time { set; get; }
        public decimal Cost { set; get; }
        public int Status { set; get; }
        public int OrderType { set; get; }

          public IEnumerable<string> CmbCustomerItems
          {
              get 
              {
                  return OIcatalogViewModel.Customers.Select(c => c.Name);
              }
          }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            List<string> _cmbList = OIcatalogViewModel.Customers.
                   OrderBy(cu => cu.Name).Select(cu => cu.Name).ToList();
           this.cmbCustomer.DataContext = _cmbList;
           this.cmbCustomer.SelectedIndex = 0;


            this.dgOICatalog.DataContext = OIcatalogViewModel.Catalog;
            
        }

        private void rbDraft_Checked_1(object sender, RoutedEventArgs e)
        {
            Status = 1;
        }

        private void rbReject_Checked_1(object sender, RoutedEventArgs e)
        {
            Status = 2;
        }

        private void rbInput_Checked_1(object sender, RoutedEventArgs e)
        {
            OrderType = 1;
        }

        private void rbOutput_Checked_1(object sender, RoutedEventArgs e)
        {
            OrderType = 0;
        }

        private void cmbCustomer_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            CustomerId = OIcatalogViewModel.Customers.Where(c => c.Name == cmbCustomer.SelectedItem.ToString())
                    .Select(c => c.Id).First();
        }

        private void btnOK_Click_1(object sender, RoutedEventArgs e)
        {
            Cost = Convert.ToDecimal(txbCost.Text);
            Time = Convert.ToDateTime(dpOrder.SelectedDate);
            ParentWin.DialogResult = true;
        }

        private void dpOrder_SelectedDateChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAddCust_Click_1(object sender, RoutedEventArgs e)
        {
            ChildWindow addWin = new ChildWindow();
            AddCustomerUC addCustUC = new AddCustomerUC();
            addCustUC.ParentWin = addWin;
            addWin.forUC.Children.Add(addCustUC);
            addWin.SizeToContent = SizeToContent.WidthAndHeight;
            addWin.Title = "Add Customer";

            bool? DiagRes = addWin.ShowDialog();
            if (DiagRes.HasValue && DiagRes.Value)
            {
                if (customerManager.AddCustomer(addCustUC.CustomerName, addCustUC.Adress, addCustUC.Phone))
                {
                    MessageBox.Show("Customer Added");
                    cmbCustomer.DataContext = CmbCustomerItems;
                    cmbCustomer.SelectedIndex = cmbCustomer.Items.IndexOf(addCustUC.CustomerName);
                }
            }
        }

        private void btnAddPackage_Click_1(object sender, RoutedEventArgs e)
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
                //catalogUC.dgCatalogUC.DataContext = MainWindow.catalogViewModel.Catalog;
            }
        }
    }
}
