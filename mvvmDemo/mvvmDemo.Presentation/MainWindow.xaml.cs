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
using System.Configuration;
using mvvmDemo.Business.Managers.Abstract;
using mvvmDemo.Business.Managers.Concrete;
using mvvmDemo.Presentation.ViewModels;
namespace mvvmDemo.Presentation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = 
                    ConfigurationManager.ConnectionStrings["TestDatabaseEntities"].ConnectionString;

                IWorkersManager workersManager = new WorkersManager(connectionString);
                WorkesViewModels workersViewModel =
                    new WorkesViewModels(workersManager);

                vwWorkers.dgWorkersUC.DataContext =
                    workersViewModel.Workers;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
