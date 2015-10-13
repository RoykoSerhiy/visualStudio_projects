using CourceWord.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace CourceWord
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DocumentManager manager = new DocumentManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (!manager.isDocumentEmpty)
            {
                MessageBoxResult res = MessageBox.Show("Do you want to save the document?", "Exit Programm", MessageBoxButton.YesNoCancel);
                manager.ExitProgramm(res);
            }
        }

        private void btnCreateFile_Click(object sender, RoutedEventArgs e)
        {
            manager.CreateDocument();
            txbText.IsEnabled = true;
            spSaving.IsEnabled = true;
            spTextModified.IsEnabled = true;
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Thread t = new Thread(Load);
                t.Start();//txbText.Dispatcher.Invoke(new Action(Load));
                txbText.IsEnabled = true;
                spSaving.IsEnabled = true;
                spTextModified.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            manager.Save(@"C:\TestWord\test.docx");
        }

        private void btnSaveAs_Click(object sender, RoutedEventArgs e)
        {
            manager.SaveAs();
        }

        private void btnNameClick(object sender, RoutedEventArgs e)
        {
            try
            {
                txbText.Text = txbText.Text.Insert(txbText.SelectionStart, "#UserName");
                //MessageBox.Show(txbText.Text.IndexOf("\n").ToString());
                manager.SynchronizationWithDock(txbText.Text);
                //MessageBox.Show(manager.text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Load()
        {
            try
            {
                txbText.Dispatcher.Invoke(delegate
                {
                    manager.LoadDocument(@"C:\TestWord\test.docx");

                    txbText.Text = manager.text;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Test_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                List<string> list = new List<string>();

                list.Add("Владимир");
                list.Add("Ахмет");
                //list.Add("Руслан");
                //list.Add("Анастасия");
                //list.Add("Роман");
                MessageBox.Show(manager.TestPath());
                manager.Distribution(list);

                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddRecive_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
