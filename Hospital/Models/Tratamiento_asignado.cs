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
    
    public partial class Tratamiento_asignado
    {
        public int ID { get; set; }
        public Nullable<int> ID_Tratamiento { get; set; }
        public Nullable<int> ID_Ingreso { get; set; }
        public Nullable<System.DateTime> Fecha_inicio { get; set; }
        public Nullable<System.DateTime> Fecha_fin { get; set; }
    
        public virtual Ingreso Ingreso { get; set; }
        public virtual Tratamiento Tratamiento { get; set; }
    }
}
