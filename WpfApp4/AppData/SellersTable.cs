//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp4.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class SellersTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SellersTable()
        {
            this.SalesTable = new HashSet<SalesTable>();
        }
    
        public int id { get; set; }
        public string FIO { get; set; }
        public string JobTitle { get; set; }
        public int UserID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesTable> SalesTable { get; set; }
        public virtual UsersTable UsersTable { get; set; }
    }
}
