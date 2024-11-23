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
            propiedad.Eliminado = "0";
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
            return dInmobiliaria.Eliminar(idPropiedad);
        }

        //Modificar
        public string Modificar(Propiedad propiedad)
        {
            return dInmobiliaria.Modificar(propiedad);
        }
        public string EliminadoFisico(int idPropiedad)
        {
            return dInmobiliaria.EliminadoFisico(idPropiedad);
        }
        public List<Propiedad> ListarTodoActivoOrdenadoPorTipo(string tipoPropiedad)
        {
            return dInmobiliaria.ListarTodoActivoOrdenadoPorTipo(tipoPropiedad);
        }
        public List<Propiedad> ListarTodoActivoOrdenadoPorPrecio()
        {
            return dInmobiliaria.ListarTodoActivoOrdenadoPorPrecio();
        }

        public List<Propiedad> ListarPorNumeroDeHabitaciones(int numeroDeHabitaciones)
        {
            return dInmobiliaria.ListarPorNumeroDeHabitaciones(numeroDeHabitaciones);
        }
    }
}

