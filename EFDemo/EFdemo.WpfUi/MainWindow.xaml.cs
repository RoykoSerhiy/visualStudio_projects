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
using EFdemo.WpfUi.Views;
using EFDemo.Entities;

namespace EFdemo.WpfUi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     public   static readonly IRepository _repo = new Repository();
     public   static IEnumerable<Worker> _workers = new List<Worker>();
     public   static IEnumerable<Order> _orders = new List<Order>();

        public MainWindow()
        {
            InitializeComponent();

            _workers = _repo.GetAll();
            dgWorkers.ItemsSource = _workers;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddWindow addWin = new AddWindow();
            AddView addView = new AddView();

            addWin.SizeToContent = SizeToContent.WidthAndHeight;
            addView.ParentWin = addWin;
            addWin.AddGrid.Children.Add(addView);

            bool? resDiag = addWin.ShowDialog();
            if (resDiag.HasValue && resDiag.Value)
            {
                _repo.Add(addView.newWorker);
                _workers = _repo.GetAll();
                dgWorkers.ItemsSource = _workers;
                dgWorkers.Items.Refresh();
            }
        }

        private void dgWorkers_CellEditEnding_1(object sender, DataGridCellEditEndingEventArgs e)
        {
            Action action = delegate
            {
                int index = dgWorkers.Items.IndexOf(dgWorkers.CurrentItem);
                Worker wrkUpdate = e.Row.Item as Worker;

                bool resUpdate = _repo.Update(wrkUpdate);

                if (resUpdate)
                {
                    MessageBox.Show(wrkUpdate.ToString() + " was updated" ,  "Update");
                }
            };

            Dispatcher.BeginInvoke(action, System.Windows.Threading.DispatcherPriority.Background);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            int index = dgWorkers.Items.IndexOf(dgWorkers.CurrentItem);

            try
            {
                _repo.Remove(_workers.ElementAt(index).id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            _workers = _repo.GetAll();
            dgWorkers.ItemsSource = _workers;
            dgWorkers.Items.Refresh();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            int index = dgWorkers.Items.IndexOf(dgWorkers.CurrentItem);

            Worker res = _repo.Get(_workers.ElementAt(index).id);
            MessageBox.Show(res.ToString(), "Get by id");
        }

        private void dgWorkers_PreviewKeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void dgWorkers_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
             
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            

            
            int index = dgWorkers.Items.IndexOf(dgWorkers.CurrentItem);
            int actId = _workers.ElementAt(index).id;
            
            //int r = res.id;
            //MessageBox.Show(r.ToString());
            _orders = _repo.GetOrder(actId);

            MessageBoxResult res = MessageBoxResult.None;

            if (_orders.Count() == 0)
            {
                res = MessageBox.Show("orders not found in " + " You want add Order ", _workers.ElementAt(index).FirstName + " " + _workers.ElementAt(index).LastName,
                    MessageBoxButton.YesNo , MessageBoxImage.Question);
            }
            
            if (_orders.Count() != 0 || res == MessageBoxResult.Yes)
            {

            
                try
                {
                    AddWindow addWin = new AddWindow();
                    OrderShow orderShow = new OrderShow();

                    addWin.SizeToContent = SizeToContent.WidthAndHeight;
                    addWin.Title = _workers.ElementAt(index).FirstName + " " + _workers.ElementAt(index).LastName;
                    orderShow.ParentWin = addWin;
                    addWin.AddGrid.Children.Add(orderShow);
                    orderShow.WorkerId = _workers.ElementAt(index).id;
                    addWin.ShowDialog();
                }
                    catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void AddOrderMI_Click_1(object sender, RoutedEventArgs e)
        {
            AddWindow addWin = new AddWindow();
            AddOrder addOrder = new AddOrder();

            addWin.SizeToContent = SizeToContent.WidthAndHeight;
          
            addOrder.ParentWin = addWin;
            addWin.AddGrid.Children.Add(addOrder);
            addWin.ShowDialog();
            bool? resDiag = addWin.DialogResult;
            if (resDiag.HasValue && resDiag.Value)
            {
                _repo.AddOrders(addOrder.newOrder);
            }
        }
    }
}
