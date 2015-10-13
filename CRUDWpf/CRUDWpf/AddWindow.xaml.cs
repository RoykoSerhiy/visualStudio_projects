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
using System.Windows.Shapes;
using CRUDWpf.Model;

namespace CRUDWpf
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public Worker Worker
        {
            get {
                    return new Worker
                    {
                        FirstName = this.txtBoxFirstName.Text,
                        LastName = this.txtBoxLastName.Text,
                        Position = this.txtBoxPosition.Text,
                        Phone = this.txtBoxPhone.Text
                    };
                }
        }
    }
}
