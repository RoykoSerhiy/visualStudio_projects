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
using CRUDWpf.Model;

namespace CRUDWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static readonly IRepository _repo = new DBRepository();
        static IEnumerable<Worker> _workers = new List<Worker>();

        public MainWindow()
        {
            InitializeComponent();
            _workers = _repo.GetAll();
            dgWorkers.ItemsSource = _workers;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddWindow addWin = new AddWindow();

            bool? resDiag = addWin.ShowDialog();
            if (resDiag.HasValue && resDiag.Value)
            {
                try
                {
                    _repo.Add(addWin.Worker);
                    _workers = _repo.GetAll();
                    dgWorkers.ItemsSource = _workers;
                    dgWorkers.Items.Refresh();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);  
                }
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            int index = dgWorkers.Items.IndexOf(dgWorkers.CurrentItem);

            if (index < _workers.Count())
            {
                try
                {
                    _repo.Remove(_workers.ElementAt(index).Id);
                    _workers = _repo.GetAll();
                    dgWorkers.ItemsSource = _workers;
                    dgWorkers.Items.Refresh();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                }
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            int index = dgWorkers.Items.IndexOf(dgWorkers.CurrentItem);

            try
            {
                Worker res = _repo.Get(_workers.ElementAt(index).Id);
                MessageBox.Show("id = " + res.ToString(), "Get by id");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

         
        }

        private void dgWorkers_PreviewKeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                _workers = _repo.GetAll();
                dgWorkers.ItemsSource = _workers;
                dgWorkers.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgWorkers_CellEditEnding_1(object sender, DataGridCellEditEndingEventArgs e)
        {
            Action action = delegate
            {
                int index = dgWorkers.Items.IndexOf(dgWorkers.CurrentItem);
                Worker wkr = e.Row.Item as Worker;


                bool updateRes = _repo.Update(wkr);
                if (updateRes)
                {
                    MessageBox.Show(wkr.ToString() + "\r\r was update" , "Update");
                }

                
            };

            Dispatcher.BeginInvoke(action, System.Windows.Threading.DispatcherPriority.Background);
        }

       

    }
}
