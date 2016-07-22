//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TopalMarti.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Firma_Urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firma_Urunler()
        {
            this.SiparisDetaylari = new HashSet<SiparisDetaylari>();
            this.Yorumlar = new HashSet<Yorumlar>();
        }
    
        public int ID { get; set; }
        public int FirmaNo { get; set; }
        public int UrunID { get; set; }
        public int Stok { get; set; }
        public decimal BirimFiyat { get; set; }
        public string UrunBilgisi { get; set; }
        public string UrunResimYolu1 { get; set; }
        public string UrunResimYolu2 { get; set; }
        public bool Silindi { get; set; }
    
        public virtual Firmalar Firmalar { get; set; }
        public virtual Urunler Urunler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiparisDetaylari> SiparisDetaylari { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorumlar> Yorumlar { get; set; }
    }
}