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
    
    public partial class TBL_MUSTERI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_MUSTERI()
        {
            this.TBL_BAKIM = new HashSet<TBL_BAKIM>();
            this.TBL_M_URUNLER = new HashSet<TBL_M_URUNLER>();
            this.TBL_SATIS = new HashSet<TBL_SATIS>();
        }
    
        public int MUSTERI_ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string TELEFON { get; set; }
        public string ADRES { get; set; }
        public Nullable<int> BAYI_ID { get; set; }
        public string MAIL { get; set; }
        public string KULLANICI_ADI { get; set; }
        public string SIFRE { get; set; }
        public string DOGUM_TARIHI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_BAKIM> TBL_BAKIM { get; set; }
        public virtual TBL_BAYI TBL_BAYI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_M_URUNLER> TBL_M_URUNLER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SATIS> TBL_SATIS { get; set; }
    }
}