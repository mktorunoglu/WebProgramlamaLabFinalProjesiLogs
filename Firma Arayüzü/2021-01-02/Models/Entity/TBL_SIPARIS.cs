//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LSYSweb.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_SIPARIS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_SIPARIS()
        {
            this.TBL_ODEME = new HashSet<TBL_ODEME>();
            this.TBL_SIPARIS_DETAY = new HashSet<TBL_SIPARIS_DETAY>();
        }
    
        public int SIPARIS_ID { get; set; }
        public Nullable<System.DateTime> SIPARIS_TARIHI { get; set; }
        public Nullable<int> BAYI_ID { get; set; }
        public Nullable<int> MALIYET { get; set; }
        public Nullable<int> TEMIN_SURESI { get; set; }
        public Nullable<int> FIRMA_ID { get; set; }
    
        public virtual TBL_BAYI TBL_BAYI { get; set; }
        public virtual TBL_FIRMA TBL_FIRMA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_ODEME> TBL_ODEME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SIPARIS_DETAY> TBL_SIPARIS_DETAY { get; set; }
    }
}
