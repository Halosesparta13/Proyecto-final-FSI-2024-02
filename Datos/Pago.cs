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
    
    public partial class Pago
    {
        public int IdPago { get; set; }
        public int FechaPago { get; set; }
        public int Monto { get; set; }
        public int MetodoPago { get; set; }
        public int Id_Contrato { get; set; }
        public int Contrato_IdContrato { get; set; }
    
        public virtual Contrato Contrato { get; set; }
    }
}
