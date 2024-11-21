using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPago
    {
        private DPagos dPagos = new DPagos();
        private List<Pago> pagos = new List<Pago>();

        public List<Pago> ListarTodo()
        {
            return pagos; 
        }
        public string Registrar(Pago pago)
        {
            return dPagos.Registrar(pago);
        }

        public List<Pago> ListarPagos()
        {
            return dPagos.ListarPagos();
        }
    }
}
