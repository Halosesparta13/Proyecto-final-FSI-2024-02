using System;
using System.Collections.Generic;
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
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Listar Pagos
        public List<Pago> ListarPagos()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.Pago.Where(p => p.Estado == "Activo").ToList();
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
