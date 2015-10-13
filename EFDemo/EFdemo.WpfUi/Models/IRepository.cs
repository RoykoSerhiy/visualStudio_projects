using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo.Entities;

namespace EFdemo.WpfUi.Models
{
    public interface IRepository
    {
        IEnumerable<Worker> GetAll();
        Worker Get(int id);
        IEnumerable<Order> GetOrder(int W_id);
        Order AddOrders(Order o);
        Worker Add(Worker item);
        void Remove(int id);
        void OrderRemove(int id);
        bool OrderUpdate(Order o);
        bool Update(Worker item);
    }
}
