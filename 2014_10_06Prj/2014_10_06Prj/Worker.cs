//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2014_10_06Prj
{
    using System;
    using System.Collections.Generic;
    
    public partial class Worker
    {
        public Worker()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int id { get; set; }
        public string lName { get; set; }
        public string fName { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return id + ". " + fName + " " + lName + " " + Position + " " + Phone;
        }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
