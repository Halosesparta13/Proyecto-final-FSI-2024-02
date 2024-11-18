using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUsuario
    {
        //Registrar
        public string Registrar(Usuario usuario)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Usuario.Add(usuario);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return ex.Message;

            }
        }

        //Listar Todo (activos)
        public List<Usuario> ListarTodo()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    usuarios = context.Usuario.Where(u => u.Eliminado == "0").ToList();
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return usuarios;
            }
        }

        //Eliminar fisico
        public string EliminadoFisico(int idUsuario)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Usuario usuarioTemp = context.Usuario.Find(idUsuario);
                    context.Usuario.Remove(usuarioTemp);
                    context.SaveChanges();
                }
                return "Eliminación fisico correctamente";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        //Modificar
    }
}
