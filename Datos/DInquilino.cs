using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DInquilino
    {
        // Registrar Inquilino
        public string Registrar(Inquilino inquilino)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var existeDNI = context.Inquilino.Any(i => i.DNI == inquilino.DNI && i.Eliminado == "0");
                    if (existeDNI)
                    {
                        return "Error: El DNI ya está registrado.";
                    }
                    inquilino.Eliminado = "0";
                    inquilino.Estado = "Activo";
                    context.Inquilino.Add(inquilino);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Listar Inquilinos Activos
        public List<Inquilino> ListarActivos()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Inquilino.Where(i => i.Eliminado == "0").ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Inquilino>();
            }
        }

        // Eliminar Lógico
        public string EliminarLogico(int idInquilino)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var inquilino = context.Inquilino.Find(idInquilino);
                    if (inquilino == null) return "Error: Inquilino no encontrado.";
                    inquilino.Eliminado = "1";
                    context.SaveChanges();
                }
                return "Inquilino eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Modificar Inquilino
        public string Modificar(Inquilino inquilino)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var inquilinoExistente = context.Inquilino.Find(inquilino.IdInquilino);
                    if (inquilinoExistente == null) return "Error: Inquilino no encontrado.";

                    inquilinoExistente.NombreCompletoInquilino = inquilino.NombreCompletoInquilino;
                    inquilinoExistente.Telefono = inquilino.Telefono;
                    inquilinoExistente.CorreoElectronicoInquilino = inquilino.CorreoElectronicoInquilino;
                    inquilinoExistente.DNI = inquilino.DNI;
                    inquilinoExistente.Estado = inquilino.Estado;

                    context.SaveChanges();
                }
                return "Inquilino modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
