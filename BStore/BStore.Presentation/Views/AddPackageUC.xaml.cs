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
    /// Логика взаимодействия для AddPackageUC.xaml
    /// </summary>
    public partial class AddPackageUC : UserControl
    {
        public AddPackageUC()
        {
            InitializeComponent();
        }



        static private int _mainCategoryID = MainWindow.catalogViewModel.Categories.Where(c => c.ParentId == null)
                .Select(c => c.Id).First();

        public ChildWindow ParentWin { get; set; }

        public string CategoryName { get; set; }

        public int CategoryID { set; get; }
        public int SubCategoryID { set; get; }
        public int ProducerID { set; get; }
        public int PackageID { set; get; }

        public decimal Volume { get; set; }
        public int VolumeMeasureID { get; set; }
        public int MeasureID { get; set; }
        public int ProductID { get; set; }
        public decimal Price { get; set; }

        public IEnumerable<string> CmbCategoryItems
        {
            get
            {
                return MainWindow.catalogViewModel.Categories.Where(c => c.ParentId == null)
                    .OrderBy(c => c.Name)
                    .Select(c => c.Name).ToList();
            }
        }

        public IEnumerable<string> CmbSubCategoryItems
        {
           get
           {
               
                  
                   return MainWindow
                     .catalogViewModel.Categories.Where(c => c.ParentId == CategoryID)
                     .OrderBy(c => c.Name)
                     .Select(c => c.Name).ToList();
               
           }
        }

        public IEnumerable<string> CmbProducerItems
        {
            get
            {
                return MainWindow.catalogViewModel.Producers.Select(p => p.Name);
            }
        }

        public IEnumerable<string> CmbProductItems
        {
            get
            {
                return MainWindow.catalogViewModel.Products.Where(p => p.CategoryId == SubCategoryID).Select(p => p.Name);
                //return MainWindow.catalogViewModel.Products.Select(p => p.Name);
            }
        }


        private void btnAddProduct_Click_1(object sender, RoutedEventArgs e)
        {
            ChildWindow addWin = new ChildWindow();
            addProductUC addProdUC = new addProductUC();
            addProdUC.ParentWin = addWin;
            addWin.forUC.Children.Add(addProdUC);
            addWin.SizeToContent = SizeToContent.WidthAndHeight;
            addWin.Title = "Додати Продукт";

            bool? dialogRes = addWin.ShowDialog();
            if (dialogRes.HasValue && dialogRes.Value)
            {
                if(MainWindow.productManager.AddProduct(addProdUC.ProductName , SubCategoryID, ProducerID))
                {
                    cmbProduct.DataContext = CmbProductItems;
                    cmbProduct.SelectedIndex = cmbProduct.Items.IndexOf(addProdUC.ProductName);

                    MessageBox.Show(addProdUC.ProductName + "\r\n " + " Додано", "Додати продукт", MessageBoxButton.OK
                      , MessageBoxImage.Information);
                }
            }
        }

        private void btnAddProducer_Click_1(object sender, RoutedEventArgs e)
        {
            ChildWindow addWin = new ChildWindow();
            AddProducerUC addProdUC = new AddProducerUC();
            addProdUC.ParentWin = addWin;
            addWin.forUC.Children.Add(addProdUC);
            addWin.SizeToContent = SizeToContent.WidthAndHeight;
            addWin.Title = "Додати Виробника";

            bool? DiagRes = addWin.ShowDialog();
            if (DiagRes.HasValue && DiagRes.Value)
            {
                if (MainWindow.producerManager.AddProducer(addProdUC.ProducerName , addProdUC.ProducerAdress , addProdUC.ProducerPhone))
                {
                    cmbProducer.DataContext = CmbProducerItems;
                    cmbProducer.SelectedIndex = cmbProducer.Items.IndexOf(addProdUC.ProducerName);

                    MessageBox.Show(addProdUC.ProducerName + "\r\n " + addProdUC.ProducerAdress + "\r\n " +addProdUC.ProducerPhone + " Додано", "Додати категорію", MessageBoxButton.OK
                       , MessageBoxImage.Information);
                }
            }
        }

        private void btnOk_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                

               
                    ProductID = MainWindow.catalogViewModel.Products.Where(p => p.Name == cmbProduct.SelectedItem.ToString())
                   .Select(p => p.Id).First();

               

                MeasureID = MainWindow.catalogViewModel.Measures.Where(m => m.Name == cmbMeasure.SelectedItem.ToString())
                    .Select(m => m.Id).First();

                VolumeMeasureID = MainWindow.catalogViewModel
                    .Measures.Where(vm => vm.ShortName == cmbVolumeMeasure.SelectedItem.ToString())
                    .Select(vm => vm.Id).First();

                Volume = Convert.ToDecimal(tbxVolume.Text);

                Price = Convert.ToDecimal(tbxPrice.Text);
                if (MainWindow.packageManager.AddPackage(Volume, VolumeMeasureID, MeasureID, ProductID))
                {
                    PackageID = MainWindow.catalogViewModel.Packages.Select(pack => pack.Id).Last();
                    if (MainWindow.priceManager.AddPrice(DateTime.Now, Price, PackageID))
                    {
                        MessageBox.Show("Price Added");
                        ParentWin.DialogResult = true;
                        //ParentWin.Close();
                    }
                    else
                    {
                        MessageBox.Show("Price Added Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":: Vol_Meas_iD= " 
                    + VolumeMeasureID.ToString() + ":: MeasureID= " 
                    + MeasureID.ToString() + ":: ProductID= " 
                    + ProductID.ToString()
                    + ":: Price= "+ Price
                    + ":: Volume= " + Volume);
            }

        }

        private void btnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            ParentWin.Close();
        }

        private void btnAddCategory_Click_1(object sender, RoutedEventArgs e)
        {
            ChildWindow addWin = new ChildWindow();
            addCategoryUC addCatUC = new addCategoryUC();
            addCatUC.ParentWin = addWin;
            addWin.forUC.Children.Add(addCatUC);
            addWin.SizeToContent = SizeToContent.WidthAndHeight;
            addWin.Title = "Додати Категорію";
            
            bool? dialogRes = addWin.ShowDialog();
            if (dialogRes.HasValue && dialogRes.Value)
            {
                if(MainWindow.categoryManager.AddCategory(addCatUC.CategoryName , addCatUC.subCategoryName))
                {

                    cmbCategory.DataContext = CmbCategoryItems;
                    cmbCategory.SelectedIndex = cmbCategory.Items.IndexOf(addCatUC.CategoryName);

                    MessageBox.Show(addCatUC.CategoryName +"\r\n " + addCatUC.subCategoryName + " Додано" , "Додати категорію" , MessageBoxButton.OK
                        ,MessageBoxImage.Information);

                   
                
                    
                }
            }
        }

        private void btnAddSubCategory_Click_1(object sender, RoutedEventArgs e)
        {
            ChildWindow addWin = new ChildWindow();
            AddSubCategoryUC addSubCatUC = new AddSubCategoryUC();
            addSubCatUC.ParentWin = addWin;
            addWin.forUC.Children.Add(addSubCatUC);
            addWin.SizeToContent = SizeToContent.WidthAndHeight;
            addWin.Title = "Додати Категорію";

            bool? dialogRes = addWin.ShowDialog();
            if (dialogRes.HasValue && dialogRes.Value)
            {
                if (MainWindow.categoryManager.AddSubCategory(CategoryID, addSubCatUC.subCategoryName))
                {
                    MessageBox.Show(addSubCatUC.subCategoryName + " додано до " + CategoryName  , "Додати підкатегорію", MessageBoxButton.OK
                       , MessageBoxImage.Information);
                }
            }
        }

        private void cmbSubCategory_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            SubCategoryID = MainWindow.catalogViewModel.Categories.Where(s => s.Name == cmbSubCategory.SelectedItem.ToString())
                    .Select(s => s.Id).First();

           // List<string> _cmbProductList = MainWindow.catalogViewModel.Products.Where(p => p.CategoryId ==
           //     MainWindow.catalogViewModel.Categories.Where(c => c.Name.IndexOf(cmbSubCategory.SelectedItem.ToString()) != -1)
           //     .Select(c => c.Id).First()).Select(p => p.Name).ToList();
            cmbProduct.DataContext = CmbProductItems;      
            
        }

        private void cmbCategory_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                
                //cmbCategory.DataContext = CmbCategoryItems;
                //List<string> _cmbSubCategoryList = MainWindow.catalogViewModel.Categories.Where(c => c.ParentId == MainWindow.catalogViewModel.Categories
                //          .Where(s => s.Name.IndexOf(cmbCategory.SelectedItem.ToString()) != -1)
                //          .Select(s => s.Id).First()).OrderBy(s => s.Name).Select(s => s.Name).ToList();
                
                 
                
                _mainCategoryID = MainWindow.catalogViewModel.Categories.Where(c => c.Name == cmbCategory.SelectedItem.ToString()
                    && c.ParentId == null)
                    .Select(c => c.Id).First();



                CategoryName = MainWindow.catalogViewModel.Categories.Where(c => c.Name.IndexOf(cmbCategory.SelectedItem.ToString()) != -1)
                    .Select(c => c.Name).First();
          
                CategoryID = _mainCategoryID;
                

               //cmbSubCategory.DataContext = null ;
                //cmbSubCategory.SelectedItem = null;
                
               
                cmbSubCategory.DataContext = CmbSubCategoryItems;
                
                //cmbSubCategory.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            List<string> _products = MainWindow.catalogViewModel.Products.Select(p => p.Name).ToList();
            List<string> _producers = MainWindow.catalogViewModel.Producers.Select(pr => pr.Name).ToList();
            List<string> _measures = MainWindow.catalogViewModel.Measures.Select(m => m.Name).ToList();
            List<string> _VolMeasures = MainWindow.catalogViewModel.Measures.Select(m => m.ShortName).ToList();
            List<string> _categories = MainWindow.catalogViewModel.Categories.Where(c => c.ParentId == null).
                OrderBy(c => c.Name).Select(c => c.Name).ToList();
           // List<string> _Subcategories = MainWindow.catalogViewModel.Categories.Where(c => c.ParentId == CategoryID).
           //     OrderBy(c => c.Name).Select(c => c.Name).ToList();
            //List<string> _subcategories;

            this.cmbProduct.DataContext = _products;
            this.cmbProducer.DataContext = _producers;
            this.cmbMeasure.DataContext = _measures;
            this.cmbVolumeMeasure.DataContext = _VolMeasures;
            this.cmbCategory.DataContext = CmbCategoryItems;
            cmbCategory.SelectedIndex = 0;
            //this.cmbSubCategory.DataContext = _cmbSubCategoryList;
            //vwAddPack.cmbSubCategory.DataContext;
        }

        private void cmbProducer_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ProducerID = MainWindow.catalogViewModel.Producers
                .Where(p => p.Name == cmbProducer.SelectedItem.ToString())
                .Select(c => c.Id).First();
               
        }

        private void cmbVolumeMeasure_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void cmbMeasure_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void cmbProduct_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
