//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LSYS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_URUN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_URUN()
        {
            this.TBL_BAKIM = new HashSet<TBL_BAKIM>();
            this.TBL_K_HAMMADELER = new HashSet<TBL_K_HAMMADELER>();
            this.TBL_M_URUNLER = new HashSet<TBL_M_URUNLER>();
            this.TBL_SATIS = new HashSet<TBL_SATIS>();
            this.TBL_SIPARIS_DETAY = new HashSet<TBL_SIPARIS_DETAY>();
        }
    
        public int URUN_ID { get; set; }
        public string URUN_ADI { get; set; }
        public string URUN_MODEL { get; set; }
        public string URUN_EBAT { get; set; }
        public string P_BAKIM_SURESI { get; set; }
        public Nullable<int> ALIS_FIYAT { get; set; }
        public Nullable<int> SATIS_FIYAT { get; set; }
        public Nullable<int> STOK_ADEDI { get; set; }
        public Nullable<int> TEMIN_SURESI { get; set; }
        public Nullable<int> STOK_ESIK_DEGERI { get; set; }
        public Nullable<int> KAR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_BAKIM> TBL_BAKIM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_K_HAMMADELER> TBL_K_HAMMADELER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_M_URUNLER> TBL_M_URUNLER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SATIS> TBL_SATIS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SIPARIS_DETAY> TBL_SIPARIS_DETAY { get; set; }
    }
}
