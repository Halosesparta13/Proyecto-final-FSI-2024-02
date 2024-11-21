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
        private DInmobiliaria dInmobiliaria = new DInmobiliaria();


        //Registrar
        public string Registrar(Propiedad propiedad)
        {
            propiedad.Estado = "A";
            return dInmobiliaria.Registrar(propiedad);
        }

        //Listar todos los activos
        public List<Propiedad> ListarTodoActivo()
        {
            return dInmobiliaria.ListarTodoActivo();
        }

        //Eliminar
        public string Eliminar(int idPropiedad)
        {
            {

                if (idPropiedad <= 0)
                {
                    return "El ID de la propiedad es inválido.";
                }


                return dInmobiliaria.Eliminar(idPropiedad);
            }
        }

        //Modificar
        public string Modificar(Propiedad propiedad)
        {
            return dInmobiliaria.Modificar(propiedad);
        }
    }
}

