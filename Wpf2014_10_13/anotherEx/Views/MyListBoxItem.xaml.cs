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

namespace anotherEx.Views
{
    /// <summary>
    /// Логика взаимодействия для MyListBoxItem.xaml
    /// </summary>
    public partial class MyListBoxItem : UserControl
    {
        public MyListBoxItem()
        {
            InitializeComponent();
        }
        public string ButtonText
        {
            get {
                return this.btnMyListItem.Content.ToString();
            }
            set
            {
                 this.btnMyListItem.Content = value;
            }
        }
    }
}
