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
    
    public partial class TBL_ODEME
    {
        public int ODEME_ID { get; set; }
        public Nullable<int> SIPARIS_ID { get; set; }
        public string ODEME_YONTEMI { get; set; }
        public Nullable<int> BAYI_ID { get; set; }
        public Nullable<int> FIRMA_ID { get; set; }
    
        public virtual TBL_BAYI TBL_BAYI { get; set; }
        public virtual TBL_FIRMA TBL_FIRMA { get; set; }
        public virtual TBL_SIPARIS TBL_SIPARIS { get; set; }
    }
}
