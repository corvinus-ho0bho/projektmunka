//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Szofttech_Beadando
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rendeles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rendeles()
        {
            this.RendelesOssz = new HashSet<RendelesOssz>();
        }
    
        public int idRendelesOsszesites { get; set; }
        public System.DateTime RendelesiDatum { get; set; }
        public Nullable<byte> Kedvezmenyes { get; set; }
        public int Ugyfel_idUgyfel { get; set; }
    
        public virtual Ugyfel Ugyfel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RendelesOssz> RendelesOssz { get; set; }
    }
}