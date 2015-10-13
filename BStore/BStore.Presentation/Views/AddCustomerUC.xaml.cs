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
    /// Логика взаимодействия для AddCustomerUC.xaml
    /// </summary>
    public partial class AddCustomerUC : UserControl
    {
        public ChildWindow ParentWin { get; set; }
        public string CustomerName { set; get; }
        public string Adress { set; get; }
        public string Phone { set; get; }

        public AddCustomerUC()
        {
            InitializeComponent();
        }
       
        private void btnOk_Click_1(object sender, RoutedEventArgs e)
        {
            CustomerName = tbxCustomerName.Text;
            Adress = tbxAdress.Text;
            Phone = tbxPhone.Text;
            ParentWin.DialogResult = true;
        }

        private void btnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            ParentWin.Close();
        }

    }
}
