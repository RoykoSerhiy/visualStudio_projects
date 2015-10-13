using BStore.Entities;
using BStore.Presentation.Models;
using Buisnes.Managers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BStore.Presentation.ViewModel
{
    public class OICatalogViewModel
    {
        private readonly IOrderItemManager _orderItemManager;
        private readonly IOrderManager _orderManager;
        private readonly IPackageManager _packageManager;
        private readonly IProductManager _productManager;
        private readonly IPriceManager _priceManager;
        private readonly ICustomerManager _customerManager;

        List<OICatalog> _items = null;
        List<OrderItem> _orderItems = null;
        List<Order> _orders = null;
        List<Package> _packages = null;
        List<Product> _products = null;
        List<Price> _prices = null;
        List<Customer> _customers = null;

        public List<OICatalog> CreateOICatalogModel(IEnumerable<OrderItem> orderItems,
            IEnumerable<Order> orders, 
            IEnumerable<Package> packages,
            IEnumerable<Product> products,
            IEnumerable<Price> prices,
            IEnumerable<Customer> customers
            )
        {
            List<OICatalog> listOICatalogModel = new List<OICatalog>();

            var _res =
                from ordItem in orderItems
                join ord in orders
                on ordItem.OrderId equals ord.Id
                join pack in packages
                on ordItem.PackageId equals pack.Id
                join prod in products
                on pack.ProductId equals prod.Id
                join prc in prices
                on pack.Id equals prc.PackageId
                select new
                {
                    Id = ordItem.Id,
                    ProductName = prod.Name,
                    Quantity = ordItem.Quantity,
                    UnitCost = prc.UnitCost
                };

            foreach (var c in _res)
            {
                listOICatalogModel.Add(new OICatalog(c.Id , c.ProductName , c.Quantity , c.UnitCost));
            }


            return listOICatalogModel;
        }
        public IEnumerable<OICatalog> Catalog
        {
            get
            {
                if (_items == null)
                {
                    _items = CreateOICatalogModel(_orderItemManager.GetAll() , _orderManager.GetAll() , _packageManager.GetAll(),
                        _productManager.GetAll() , _priceManager.GetAll() , _customerManager.GetAll());
                }
                return _items;
            }
        }
        public IEnumerable<OrderItem> OrderItems
        {
            get
            {
                if (_orderItems == null)
                {
                    return _orderItemManager.GetAll();
                }
                return _orderItems;
            }
        }
        public IEnumerable<Order> Orders
        {
            get
            {
                if (_orders == null)
                {
                    return _orderManager.GetAll();
                }
                return _orders;
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
        public IEnumerable<Price> Prices
        {
            get
            {
                if (_prices == null)
                {
                    return _priceManager.GetAll();
                }
                return _prices;
            }
        }
        public IEnumerable<Customer> Customers
        {
            get
            {
                if (_customers == null)
                {
                    return _customerManager.GetAll();
                }
                return _customers;
            }
        }
        public OICatalogViewModel(
                IOrderItemManager orderItemManager,
                IOrderManager orderManager,
                IPackageManager packageManager,
                IProductManager productManager,
                IPriceManager priceManager,
                ICustomerManager customerManager
            )
        {
            _orderItemManager = orderItemManager;
            _orderManager = orderManager;
            _packageManager = packageManager;
            _productManager = productManager;
            _priceManager = priceManager;
            _customerManager = customerManager;
        }

    }
}
