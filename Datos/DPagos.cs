using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPagos
    {
        // Registrar Pago
        public string Registrar(Pago pago)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    pago.Estado = "Activo";
                    context.Pago.Add(pago);
                    context.SaveChanges();
                }
                return "Pago registrado correctamente";
            }
            catch (DbUpdateException dbEx)
            {
                // Obtener detalles del error interno
                string detallesError = dbEx.InnerException != null ? dbEx.InnerException.Message : "No se pudo obtener detalles adicionales.";
                return $"Error al registrar pago: {dbEx.Message}. Detalles: {detallesError}";
            }
            catch (Exception ex)
            {
                return $"Error inesperado: {ex.Message}";
            }
        }


        // Listar Pagos
        public List<Pago> ListarPagos()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;

                    return context.Pago.Where(p => p.Estado == "Activo").ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Pago>();
            }
        }

        // Método para listar pagos no realizados (estado vacío)
        public List<Pago> ListarPagosNoRealizados()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Pago.Where(p => string.IsNullOrEmpty(p.Estado)).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Pago>();
            }
        }
    }
}
