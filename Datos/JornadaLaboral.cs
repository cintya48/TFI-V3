//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class JornadaLaboral
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JornadaLaboral()
        {
            this.Hallazgo = new HashSet<Hallazgo>();
        }
    
        public int ID_JL { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<int> Total_PP { get; set; }
        public Nullable<int> Id_Turno { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public Nullable<int> num_op { get; set; }
        public Nullable<int> TotalDR { get; set; }
        public Nullable<int> TotalDO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hallazgo> Hallazgo { get; set; }
        public virtual Turno Turno { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Orden_Produccion Orden_Produccion { get; set; }
    }
}
