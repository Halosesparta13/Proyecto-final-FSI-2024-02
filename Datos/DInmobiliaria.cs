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
                    var existeID = context.Propiedad.Any(i => i.IdPropiedad == propiedad.IdPropiedad && i.Eliminado == "0");
                    if (existeID)
                    {
                        return "Error: El ID ya está registrado.";
                    }
                    propiedad.Eliminado = "0";
                    propiedad.Estado = "Activo";
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
        public List<Propiedad> ListarActivos()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Propiedad.Where(i => i.Eliminado == "0").ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Propiedad>();
            }
        }

        //Eliminar
        public string Eliminar(int IdPropiedad)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var propiedad = context.Propiedad.Find(IdPropiedad);
                    if (propiedad == null) return "Error: Propiedad no encontrada.";
                    propiedad.Eliminado = "1";
                    context.SaveChanges();
                }
                return "Propiedad eliminada correctamente";
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
                    var propiedadExistente = context.Propiedad.Find(propiedad.IdPropiedad);
                    if (propiedadExistente == null) return "Error: Propiedad no encontrada.";

                    propiedadExistente.Direccion = propiedad.Direccion;
                    propiedadExistente.TipoPropiedad = propiedad.TipoPropiedad;
                    propiedadExistente.Area = propiedad.Area;
                    propiedadExistente.Num_Habitaciones = propiedad.Num_Habitaciones;
                    propiedadExistente.Descripcion = propiedad.Descripcion;
                    propiedadExistente.IdUsuario = propiedad.IdUsuario;
                    propiedadExistente.Estado = propiedad.Estado;


                    context.SaveChanges();
                }
                return "Propiedad modificada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
