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
using EFdemo.WpfUi.Models;
using EFDemo.Entities;

namespace EFdemo.WpfUi.Views
{
    /// <summary>
    /// Логика взаимодействия для OrderShow.xaml
    /// </summary>
    public partial class OrderShow : UserControl
    {
        
       
        public OrderShow()
        {
            InitializeComponent();
            dgShowOrders.ItemsSource = MainWindow._orders;
            
        }
        public AddWindow ParentWin { get; set; }

        private void btnOk_Click_1(object sender, RoutedEventArgs e)
        {
            ParentWin.Close();
           
        }

        private void Delete_Click_1(object sender, RoutedEventArgs e)
        {
            int index = dgShowOrders.Items.IndexOf(dgShowOrders.CurrentItem);

            try
            {
              MainWindow._repo.OrderRemove(MainWindow._orders.ElementAt(index).id);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
           // dgShowOrders.ItemsSource = _workers;
            MainWindow._orders = MainWindow._repo.GetOrder(WorkerId);
            dgShowOrders.ItemsSource = MainWindow._orders;
            dgShowOrders.Items.Refresh();
        }

        private void btnAddOrder_Click_1(object sender, RoutedEventArgs e)
        {
            AddWindow win = new AddWindow();
            AddOrder addOrderUc = new AddOrder();

            win.Title = "Orders: " + WorkerId;
            addOrderUc.ParentWin = win;
            win.AddGrid.Children.Add(addOrderUc);
            win.SizeToContent = SizeToContent.WidthAndHeight;

            bool? resDiag = win.ShowDialog();
            if (resDiag.HasValue && resDiag.Value)
            {
                Order toAdd = addOrderUc.newOrder;
                toAdd.WorkerId = WorkerId;
                try
                {
                    MainWindow._repo.AddOrders(toAdd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message , "Show Orders");
                }
                MainWindow._orders = MainWindow._repo.GetOrder(WorkerId);
                dgShowOrders.ItemsSource = MainWindow._orders;
                dgShowOrders.Items.Refresh();
            }
        }


        private void btnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            ParentWin.Close();
        }

        public int WorkerId { get; set; }

        private void dgShowOrders_CellEditEnding_1(object sender, DataGridCellEditEndingEventArgs e)
        {
            Action action = delegate
            {
                int index = dgShowOrders.Items.IndexOf(dgShowOrders.CurrentItem);
                Order ordUpdate = e.Row.Item as Order;

                bool resUpdate = MainWindow._repo.OrderUpdate(ordUpdate);

                if (resUpdate)
                {
                    MessageBox.Show(ordUpdate.id + " " + ordUpdate.Price + " " + ordUpdate.Description + " was updated", "Update");
                }
            };

            Dispatcher.BeginInvoke(action, System.Windows.Threading.DispatcherPriority.Background);
        }
    }
}
