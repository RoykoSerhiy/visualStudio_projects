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

namespace datagridbinding
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker { 
            Id = 1,
            fName = "Kozel",
            lName = "Luser",
            Position = "Debil",
            Phone = "22-33-33"
            });
            workers.Add(new Worker
            {
                Id = 2,
                fName = "Alah",
                lName = "Babah",
                Position = "God of musulmans",
                Phone = "22-33-32"
            });
            workers.Add(new Worker
            {
                Id = 3,
                fName = "Vasya",
                lName = "Bolt",
                Position = "manager",
                Phone = "22-33-33"
            });
            dgWorkers.ItemsSource = workers;
        }
    }
    public class Worker
    {
        public int Id { set; get; }
        public string fName { set; get; }
        public string lName { set; get; }
        public string Position { set; get; }
        public string Phone { set; get; }
    }
}
