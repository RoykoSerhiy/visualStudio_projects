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
    /// Логика взаимодействия для OrderUC.xaml
    /// </summary>
    public partial class OrderUC : UserControl
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MagazinBDEntities3"].ConnectionString;

        static public IOrderManager orderManager = new OrderManager(connectionString);
        static public ICustomerManager customerManager = new CustomerManager(connectionString);
        static public OrderCatalogViewModel orderCatalogViewModel = new OrderCatalogViewModel(orderManager, customerManager);

        DateTime? DateFrom { set; get; }
        DateTime? DateTo { set; get; }
        public ChildWindow ParentWin { get; set; }
        public OrderUC()
        {
            InitializeComponent();
        }

        private void addPack_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void addOrder_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                ChildWindow addWin = new ChildWindow();
                AddOrdreUC addOrdUC = new AddOrdreUC();
                addOrdUC.ParentWin = addWin;
                addWin.forUC.Children.Add(addOrdUC);
                addWin.SizeToContent = SizeToContent.WidthAndHeight;
                addWin.Title = "Add Order";

                bool? dialogRes = addWin.ShowDialog();
                if (dialogRes.HasValue && dialogRes.Value)
                {
                    if (orderManager.AddOrder(addOrdUC.CustomerId, addOrdUC.Time, addOrdUC.Cost, addOrdUC.Status, addOrdUC.OrderType))
                    {


                        MessageBox.Show("Sucsses");
                        orderCatalogViewModel.ResetCatalog();
                        this.dgCatalogUC.DataContext = orderCatalogViewModel.Catalog;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            //this.dgCatalogUC.DataContext = orderCatalogViewModel.Catalog;
            this.dpTo.IsEnabled = false;

            orderCatalogViewModel.ResetCatalog();
            this.dgCatalogUC.DataContext = orderCatalogViewModel.Catalog;

        }

        private void dpFrom_SelectedDateChanged_1(object sender, SelectionChangedEventArgs e)
        {
            DateFrom = dpFrom.SelectedDate;
            //this.dgCatalogUC.DataContext = orderCatalogViewModel.Catalog.Where(ord => ord.Time >= DateFrom);
            this.dpTo.IsEnabled = true;
        }

        private void dpTo_SelectedDateChanged_1(object sender, SelectionChangedEventArgs e)
        {
            DateTo = dpTo.SelectedDate;
            this.dgCatalogUC.DataContext = orderCatalogViewModel.Catalog.Where(ord => ord.Time >= DateFrom && ord.Time <= DateTo);
        }

        private void btnResetFilter_Click_1(object sender, RoutedEventArgs e)
        {
            tbxOrdreFilter.Text = "";
            dpFrom.SelectedDate = null;
            dpTo.SelectedDate = null;
            dpTo.IsEnabled = false;
            this.dgCatalogUC.DataContext = orderCatalogViewModel.Catalog;
        }

        private void btnFilterOK_Click_1(object sender, RoutedEventArgs e)
        {
            dgCatalogUC.DataContext = orderCatalogViewModel.Catalog.
                Where(o => o.CustomerName.ToLower().IndexOf(tbxOrdreFilter.Text.ToLower()) != -1);             
        }
    }
}
