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

namespace _29._09._14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Person _person;

        public MainWindow()
        {
            InitializeComponent();
            ManualMoveData();
        }

        private void ManualMoveData()
        {
            _person = new Person
            {
                FirstName = "Roberto",
                LastName = "Bugatti",
                
            };

            this.fNameTBox.Text = _person.FirstName;
            this.lNameTBox.Text = _person.LastName;
            this.fullNameTBlock.Text = _person.FullName;

            this.fNameTBox.TextChanged += fNameTBox_TextChanged;
            this.lNameTBox.TextChanged += lNameTBox_TextChanged;
        }

        private void lNameTBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void fNameTBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void fNameTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _person.FirstName = this.fNameTBox.Text;
            this.fullNameTBlock.Text = _person.FullName;
        }

        private void lNameTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _person.LastName = this.lNameTBox.Text;
            this.fullNameTBlock.Text = _person.FullName;
        }

    }
}
