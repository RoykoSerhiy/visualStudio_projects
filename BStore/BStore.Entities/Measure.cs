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
    
    public partial class Measure
    {
        public Measure()
        {
            this.Package = new HashSet<Package>();
            this.Package1 = new HashSet<Package>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    
        public virtual ICollection<Package> Package { get; set; }
        public virtual ICollection<Package> Package1 { get; set; }
    }
}
