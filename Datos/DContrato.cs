using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DContrato
    {
        //ListarTodo Activos
        public List<Contrato> ListarTodo()
        {
            List<Contrato> contratos = new List<Contrato>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Contrato.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return contratos;
            }
        }
    }
}
