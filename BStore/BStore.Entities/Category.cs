//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BStore.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Category1 = new HashSet<Category>();
            this.Product = new HashSet<Product>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Category> Category1 { get; set; }
        public virtual Category Category2 { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
