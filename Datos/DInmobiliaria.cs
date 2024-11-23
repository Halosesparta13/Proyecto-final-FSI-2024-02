using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DInmobiliaria
    {
        //Registrar
        public string Registrar(Propiedad propiedad)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var existePropiedad = context.Propiedad.Any(p => p.Direccion == propiedad.Direccion);
                    if (existePropiedad)
                    {
                        return "Error: Ya existe una propiedad con la misma dirección.";
                    }
                    context.Propiedad.Add(propiedad);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Listar Todo (activos)
        public List<Propiedad> ListarTodoActivo()
        {
            List<Propiedad> propiedad = new List<Propiedad>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Propiedad.Where(i => i.Eliminado == "0")
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return propiedad;
            }
        }

        //Eliminar Lógico
        public string Eliminar(int IdPropiedad)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var propiedad = context.Propiedad.Find(IdPropiedad);
                    if (propiedad != null)
                    {
                        propiedad.Estado = "Inactivo"; // Cambia el estado a "I" para inactivo
                        propiedad.Eliminado = "1";
                        context.SaveChanges();
                        return "Propiedad eliminada";
                    }
                    else
                    {
                        return "Propiedad no encontrada";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Modificar
        public string Modificar(Propiedad propiedad)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    
                    Propiedad propiedadTemp = context.Propiedad.Find(propiedad.IdPropiedad);
                    propiedadTemp.Direccion = propiedad.Direccion;
                    propiedadTemp.TipoPropiedad = propiedad.TipoPropiedad;
                    propiedadTemp.Area = propiedad.Area;
                    propiedadTemp.Num_Habitaciones = propiedad.Num_Habitaciones;
                    propiedadTemp.Descripcion = propiedad.Descripcion;
                    //propiedadTemp.IdUsuario = propiedad.IdUsuario;
                    propiedadTemp.Estado = propiedad.Estado;
                    context.SaveChanges();
                }
                return "Propiedad modificada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Eliminar fisico
        public string EliminadoFisico(int idPropiedad)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Propiedad propiedadTemp = context.Propiedad.Find(idPropiedad);
                    context.Propiedad.Remove(propiedadTemp);
                    context.SaveChanges();
                }
                return "Eliminación fisico correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Listar Todo (activos) ordenado por TipoPropiedad específico
        public List<Propiedad> ListarTodoActivoOrdenadoPorTipo(string tipoPropiedad)
        {
            List<Propiedad> propiedades = new List<Propiedad>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;

                    // Filtrar por el tipo de propiedad y ordenar por el campo TipoPropiedad
                    return context.Propiedad
                        .Where(i => i.Eliminado == "0" && i.TipoPropiedad == tipoPropiedad) // Filtra por TipoPropiedad
                        .OrderBy(p => p.TipoPropiedad) // Ordena por TipoPropiedad
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return propiedades;
            }
        }

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

        public List<Propiedad> ListarPorNumeroDeHabitaciones(int numeroDeHabitaciones)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Propiedad.Where(p => p.Num_Habitaciones == numeroDeHabitaciones && p.Eliminado == "0")
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Propiedad>();
            }
        }


    }
}
