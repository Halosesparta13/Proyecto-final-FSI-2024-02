using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NContrato
    {
        DContrato dContrato = new DContrato();

        public List<Contrato> ListarTodo()
        {
            return dContrato.ListarTodo();
        }
    }
}
