//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fuel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class AZS
    {
        public AZS()
        {
            this.FuelinAZS = new HashSet<FuelinAZS>();
        }
    
        public int id { get; set; }
        public int RegionId { get; set; }
        public string AZS_Name { get; set; }
    
        public virtual Region Region { get; set; }
        public virtual ICollection<FuelinAZS> FuelinAZS { get; set; }
    }
}
