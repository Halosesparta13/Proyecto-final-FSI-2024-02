using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NInquilino
    {
        private DInquilino dInquilino = new DInquilino();

        public string Registrar(Inquilino inquilino)
        {
            return dInquilino.Registrar(inquilino);
        }

        public List<Inquilino> ListarActivos()
        {
            return dInquilino.ListarActivos();
        }

        public string EliminarLogico(int idInquilino)
        {
            return dInquilino.EliminarLogico(idInquilino);
        }

        public string Modificar(Inquilino inquilino)
        {
            return dInquilino.Modificar(inquilino);
        }
    }
}
