using System;

namespace Presentacion
{
    internal class Inmobiliario
    {
        public object NombreCompletoInquilino { get; set; }
        public object Telefono { get; set; }
        public object CorreoElectronicoInquilino { get; set; }
        public object DNI { get; set; }
        public int IdPropiedad { get; set; }
        public string Estado { get; set; }
        public string Eliminado { get; set; }
        public string Direccion { get; internal set; }
        public string TipoPropiedad { get; internal set; }
        public string Area { get; internal set; }
        public string Num_Habitaciones { get; internal set; }
        public string IdUsuario { get; internal set; }
        public string Descripcion { get; internal set; }

        public static implicit operator Inmobiliario(Inmobiliario v)
        {
            throw new NotImplementedException();
        }
    }
}