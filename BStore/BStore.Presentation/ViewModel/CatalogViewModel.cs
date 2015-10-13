using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BStore.Entities;
using BStore.Presentation.Models;
using Buisnes.Managers.Abstract;

namespace BStore.Presentation.ViewModel
{
    public class CatalogViewModel
    {
        private readonly IPackageManager _packageManager;
        private readonly IProductManager _productManager;
        private readonly IProducerManager _producerManager;
        private readonly ICategoryManager _categoryManager;
        private readonly IMeasureManager _measureManager;
        private readonly IPriceManager _priceManager;

        List<CatalogModel> _items = null;
        List<Category> _categories = null;
        List<Product> _products = null;
        List<Producer> _producers = null;
        List<Measure> _measures = null;
        List<Package> _packages = null;

        public List<CatalogModel> CreateCatalogModel(IEnumerable<Package> packages,
            IEnumerable<Product> products,
                IEnumerable<Category> categories,
            IEnumerable<Producer> producers,
            IEnumerable<Measure> measures,
            IEnumerable<Price> prices
                ) 
        {
            List<CatalogModel> listCatalogModel = new List<CatalogModel>();

            var _res = from pg in packages
                       join p in products
                       on pg.ProductId equals p.Id
                       join c in categories
                       on p.CategoryId equals c.Id
                       join cc in categories
                       on c.ParentId equals cc.Id
                       join pr in producers
                       on p.ProducerId equals pr.Id
                       join m in measures
                       on pg.MeasureId equals m.Id
                       join vm in measures
                       on pg.VolumeMeasureId equals vm.Id
                       join prc in prices
                       on pg.Id equals prc.PackageId
                       select new { 
                        Id = pg.Id,
                        Name = p.Name,
                        Producer = pr.Name,
                        Category = c.Name,
                        SubCategory =  cc.Name,
                        Volume = pg.Volume,
                        VolMasure = vm.ShortName,
                        Measure = m.ShortName,
                        Price = prc.UnitCost
                       };

            foreach (var c in _res)
            {
                listCatalogModel.Add(new CatalogModel(c.Id, c.Name, c.Producer, c.Category, c.SubCategory, c.Volume, c.VolMasure, c.Measure , c.Price));
            }

            return listCatalogModel;
        }
        public void ResetCatalog()
        {
            _items = null;
        }
        public IEnumerable<CatalogModel> Catalog
        {
            get {
                if (_items == null)
                {
                    _items = CreateCatalogModel(
                            _packageManager.GetAll(),
                            _productManager.GetAll(),
                            _categoryManager.GetAll(),
                            _producerManager.GetAll(),
                            _measureManager.GetAll(),
                            _priceManager.GetAll()
                        );
                }
                return _items;
            }
        }

        public IEnumerable<Category> Categories
        {
            get
            {
                if (_categories == null)
                {
                    return _categoryManager.GetAll();
                }
                return _categories;
            }
        }

        public IEnumerable<Product> Products
        {
            get 
            {
                if (_products == null)
                {
                    return _productManager.GetAll();
                }
                return _products;
            }
        }

        public IEnumerable<Producer> Producers
        {
            get
            {
                if (_producers == null)
                {
                    return _producerManager.GetAll();
                }
                return _producers;
            }
        }

        public IEnumerable<Measure> Measures
        {
            get
            {
                if (_measures == null)
                {
                    return _measureManager.GetAll();
                }
                return _measures;
            }
        }
        public IEnumerable<Package> Packages
        {
            get 
            {
                if (_packages == null)
                {
                    return _packageManager.GetAll();
                }
                return _packages;
            }
        }

        public CatalogViewModel(
                IPackageManager packageManager,
            IProductManager productManager,
            IProducerManager producerManager,
            ICategoryManager categoryManager,
            IMeasureManager measureManager,
            IPriceManager priceManager
            )
        {
            _packageManager = packageManager;
            _productManager = productManager;
            _producerManager = producerManager;
            _categoryManager = categoryManager;
            _measureManager = measureManager;
            _priceManager = priceManager;
        }


    }
}
