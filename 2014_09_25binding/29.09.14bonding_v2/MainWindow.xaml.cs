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

namespace _29._09._14bonding_v2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BindInCode();
        }

        private void BindInCode()
        {
            var person = new Person
            {
                FirstName = "Roberto",
                LastName = "Bugatti"
            };

            Binding b = new Binding();
            b.Source = person;
            b.UpdateSourceTrigger =
                UpdateSourceTrigger.PropertyChanged;
            b.Path = new PropertyPath("FirstName");
            this.fNameTBox.SetBinding(TextBox.TextProperty, b);

            b = new Binding();
            b.Source = person;
            b.UpdateSourceTrigger =
                UpdateSourceTrigger.PropertyChanged;
            b.Path = new PropertyPath("LastName");
            this.lNameTBox.SetBinding(TextBox.TextProperty, b);

            b = new Binding();
            b.Source = person;
            b.Path = new PropertyPath("FullName");
            this.fullNameTBlock.SetBinding(TextBlock.TextProperty, b);


        }



    }
}
