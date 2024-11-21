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
                    var existingProperty = context.Propiedad.FirstOrDefault(p => p.IdPropiedad == propiedad.IdPropiedad);
                    if (existingProperty != null)
                    {
                        return "Error: Ya existe una propiedad con el mismo ID.";
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
                    return context.Propiedad.Where(i => i.Estado == "A").ToList();
                }
            }
            catch (Exception ex)
            {
                return propiedad;
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
                    if (propiedad != null)
                    {
                        propiedad.Estado = "I"; // Cambia el estado a "I" para inactivo
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
                    propiedadTemp.IdUsuario = propiedad.IdUsuario;
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
    }
}
