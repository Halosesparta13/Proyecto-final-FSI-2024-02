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
        public string Registrar(Usuario usuario)
        {
            usuario.Eliminado = "0";
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

        //Modificar
        public string Modificar(Usuario usuario)
        {
            return dUsuario.Modificar(usuario);
        }

        //Eliminar Lógico
        public string EliminarLogico(int idUsuario)
        {
            return dUsuario.EliminarLogico(idUsuario);
        }
    }
}
