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
    
    public partial class Inquilino
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inquilino()
        {
            this.Contrato = new HashSet<Contrato>();
        }
    
        public int IdInquilino { get; set; }
        public int NombresUsuario { get; set; }
        public int ApellidosUsuario { get; set; }
        public int Direccion { get; set; }
        public int Telefono { get; set; }
        public int CorreoElectronico { get; set; }
        public int DNI { get; set; }
        public int ID_Propiedad { get; set; }
        public int Propiedad_IdPropietario { get; set; }
        public int Contrato_IdContrato { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        public virtual Propiedad Propiedad { get; set; }
    }
}