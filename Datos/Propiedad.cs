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
    
    public partial class Propiedad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Propiedad()
        {
            this.Contrato = new HashSet<Contrato>();
            this.Inquilino = new HashSet<Inquilino>();
        }
    
        public int IdPropiedad { get; set; }
        public string Direccion { get; set; }
        public string TipoPropiedad { get; set; }
        public double Area { get; set; }
        public int Num_Habitaciones { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuario { get; set; }
        public string Eliminado { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inquilino> Inquilino { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
