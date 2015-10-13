using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisnes.Managers.Abstract;
using Buisnes.Managers.Concrete;

namespace BStore.ConsoleUI
{
    class Program
    {
        //static public  IPackageManager _packageManager;
        //static public  IProductManager _productManager;
        //static public  IProducerManager _producerManager;
        //static public  ICategoryManager _categoryManager;
        //static public  IMeasureManager _measureManager;

        static void Main(string[] args)
        {
            //string connStr = ConfigurationManager.ConnectionStrings["MagazinBDEntities"].ConnectionString;
            // _packageManager = new PackageManager(connStr);
            // _productManager = new ProductManager(connStr);
            // _producerManager = new ProducerManager(connStr);
            //_categoryManager = new CategoryManager(connStr);
            //_measureManager = new MeasureManager(connStr);
            //
            //var packages = _packageManager.GetAll();
            //var products =  _productManager.GetAll();
            //var producer = _producerManager.GetAll();
            //var categories =  _categoryManager.GetAll();
            //var measures =  _measureManager.GetAll();
            //
            //var res =
            //    from pg in packages
            //    join p in products
            //        on pg.ProductId equals p.Id
            //    join c in categories
            //        on p.CategoryId equals c.Id
            //    // join cc in categories
            //    //     on c.ParentId equals cc.Id
            //    select new { 
            //        Id = pg.Id,
            //        Name = p.Name,
            //        Category = c.ParentId
            //        //SubDirectories = cc.Name
            //    };
            //
            //
            //foreach (var r in res)
            //{
            //    Console.WriteLine(
            //            r.Id + " |" +
            //            r.Name + "|" + r.Category
            //            //+ "|" + r.SubDirectories
            //        );
            //}
        }
    }
}
