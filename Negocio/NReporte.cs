using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReporte
    {
        private DUsuario dUsuario = new DUsuario();
        private DInmobiliaria dInmobiliaria = new DInmobiliaria();
        private DInquilino dInquilino = new DInquilino();
        private DPagos dPago = new DPagos();
        private DReporte dReporte = new DReporte();

        //Listar Todo (activos) ordenado por precio de alquiler
        public List<Propiedad> ListarTodoActivoOrdenadoPorPrecio()
        {
            List<Propiedad> propiedades = new List<Propiedad>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    // Ordena por el precio de alquiler (PrecioAlquiler) en orden ascendente
                    return context.Propiedad
                        .Where(i => i.Eliminado == "0")
                        .OrderBy(p => p.Monto) // Asegúrate de que 'PrecioAlquiler' exista en tu modelo
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return propiedades;
            }
        }

        //Listar Todo (activos) ordenado por tipo de propiedad
        public List<Propiedad> ListarTodoActivoOrdenadoPorTipo()
        {
            dReporte.ListarTodoActivoOrdenadoPorTipo();
        }
    }
}
