//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalShop
{
    using System;
    using System.Collections.Generic;

    public partial class Cumparare
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cumparare()
        {
            this.CumparareItems = new HashSet<CumparareItem>();
        }

        public int CumparareId { get; set; }
        public Nullable<int> UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CumparareItem> CumparareItems { get; set; }
        public virtual User User { get; set; }
    }
}
