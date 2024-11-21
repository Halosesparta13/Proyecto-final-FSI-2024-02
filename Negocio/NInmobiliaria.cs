using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NInmobiliaria
    {
        private DInmobiliaria idInmobiliaria = new DInmobiliaria();

        public string Registrar(Propiedad propiedad)
        {
            return idInmobiliaria.Registrar(propiedad);
        }

        public List<Propiedad> ListarActivos()
        {
            return idInmobiliaria.ListarActivos();
        }

        public string Eliminar(int idPropiedad)
        {
            return idInmobiliaria.Eliminar(idPropiedad);
        }

        public string Modificar(Propiedad propiedad)
        {
            return idInmobiliaria.Modificar(propiedad);
        }
    }
}

