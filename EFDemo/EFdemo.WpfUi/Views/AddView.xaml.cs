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
using EFDemo.Entities;

namespace EFdemo.WpfUi.Views
{
    /// <summary>
    /// Логика взаимодействия для AddView.xaml
    /// </summary>
    public partial class AddView : UserControl
    {
        public AddView()
        {
            InitializeComponent();
        }

        public AddWindow ParentWin { get; set; }

        public Worker newWorker
        {
            get
            {
                return new Worker
                    {
                        FirstName = this.txtBoxFirstName.Text,
                        LastName = this.txtBoxLastName.Text,
                        Position = this.txtBoxPosition.Text,
                        Phone = this.txtBoxPhone.Text
                    };
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            ParentWin.DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            ParentWin.Close();
        }
    }
}
