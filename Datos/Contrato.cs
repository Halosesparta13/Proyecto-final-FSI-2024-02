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
    
    public partial class Contrato
    {
        public int IdContrato { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFinalización { get; set; }
        public int IdPropiedad { get; set; }
        public int IdPago { get; set; }
        public byte[] Estado { get; set; }
    
        public virtual Pago Pago { get; set; }
        public virtual Propiedad Propiedad { get; set; }
    }
}
