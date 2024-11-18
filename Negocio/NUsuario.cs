using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NUsuario
    {
        private DUsuario dUsuario = new DUsuario();
        //Registrar
        private string Registrar(Usuario usuario)
        {
            return dUsuario.Registrar(usuario);
        }

        //Listar Todo (activos)
        public List<Usuario> ListarTodo()
        {
            return dUsuario.ListarTodo();
        }

        //Eliminar fisico
        public string EliminadoFisico(int idUsuario)
        {
            return dUsuario.EliminadoFisico(idUsuario);
        }
    }
}
