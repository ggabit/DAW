//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProiectDAW.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Localitate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Localitate()
        {
            this.Persoana_Detaliu = new HashSet<PersoanaDetaliu>();
        }
    
        public int LocalitateID { get; set; }
        public string Denumire { get; set; }
        public string JudetID { get; set; }
    
        public virtual Judet Judet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersoanaDetaliu> Persoana_Detaliu { get; set; }
    }
}
