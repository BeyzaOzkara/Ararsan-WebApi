//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiArarsan2
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUrunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUrunler()
        {
            this.tblFavoriler = new HashSet<tblFavoriler>();
        }
    
        public int UrunID { get; set; }
        public int KategoriID { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFavoriler> tblFavoriler { get; set; }
        public virtual tblKategoriler tblKategoriler { get; set; }
    }
}