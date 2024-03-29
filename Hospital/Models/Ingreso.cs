//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingreso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingreso()
        {
            this.Atencions = new HashSet<Atencion>();
            this.Facturacions = new HashSet<Facturacion>();
            this.Tratamiento_asignado = new HashSet<Tratamiento_asignado>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ID_Paciente { get; set; }
        public Nullable<int> ID_Habitacion { get; set; }
        public Nullable<System.DateTime> Fecha_ingreso { get; set; }
        public Nullable<System.DateTime> Fecha_salida { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Atencion> Atencions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturacion> Facturacions { get; set; }
        public virtual Habitacion Habitacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tratamiento_asignado> Tratamiento_asignado { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
