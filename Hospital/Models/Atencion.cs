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
    
    public partial class Atencion
    {
        public int ID { get; set; }
        public Nullable<int> ID_Medico { get; set; }
        public Nullable<int> ID_Enfermera { get; set; }
        public Nullable<int> ID_Paciente { get; set; }
        public Nullable<int> ID_Ingreso { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Notas { get; set; }
    
        public virtual Enfermera Enfermera { get; set; }
        public virtual Ingreso Ingreso { get; set; }
        public virtual Medico Medico { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
