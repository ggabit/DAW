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
    
    public partial class Persoana
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persoana()
        {
            this.Adopties = new HashSet<Adoptie>();
        }
    
        public int PersoanaId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public System.DateTime DataNasterii { get; set; }
        public string NrTelefon { get; set; }
        public string UserId { get; set; }
        public System.DateTime UpdateDate { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual PersoanaDetaliu Persoana_Detaliu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adoptie> Adopties { get; set; }
    }
}
