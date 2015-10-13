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
    public class OrderCatalogViewModel
    {
        private readonly IOrderManager _orderManager;
        private readonly ICustomerManager _customerManager;

        List<OrderCatalog> _items = null;
        List<Order> _orders = null;
        List<Customer> _customers = null;

        public List<OrderCatalog> CreateOrderCatalogModel(IEnumerable<Order> orders , IEnumerable<Customer> customers)
        {
            List<OrderCatalog> listOrderCatalogModel = new List<OrderCatalog>();

            var _res =
                from ord in orders
                join cus in customers
                on ord.CustomerId equals cus.Id
                select new
                {
                    Id = ord.Id,
                    CustomerName = cus.Name,
                    Time = ord.Time,
                    Cost = ord.Cost,
                    Status = ord.Status
                };
               
           
            foreach(var c in _res)
            {
                listOrderCatalogModel.Add(new OrderCatalog(c.Id , c.CustomerName , c.Time , c.Cost , c.Status));
            }


                return listOrderCatalogModel;

        }
        public void ResetCatalog()
        {
            _items = null;
        }
        public IEnumerable<OrderCatalog> Catalog
        {
            get
            {
                if (_items == null)
                {
                    _items = CreateOrderCatalogModel(_orderManager.GetAll(), _customerManager.GetAll());
                }
                return _items;
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
          public OrderCatalogViewModel(
                IOrderManager orderManager,
                ICustomerManager customerManager
            )
        {
            _orderManager = orderManager;
            _customerManager = customerManager;
        }

         
    }
}
