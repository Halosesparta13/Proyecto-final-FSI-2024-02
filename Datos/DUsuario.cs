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
                    context.Configuration.LazyLoadingEnabled = false;
                    var existeDNI = context.Usuario.Any(u => u.DNI == usuario.DNI);
                    if (existeDNI)
                    {
                        return "Error: El DNI ya está registrado.";
                    }
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

        //Modificar
        public string Modificar(Usuario usuario)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Usuario usuarioTemp = context.Usuario.Find(usuario.IdUsuario);
                    usuarioTemp.UserName = usuario.UserName;
                    usuarioTemp.Password = usuario.Password;
                    usuarioTemp.Rol = usuario.Rol;
                    usuarioTemp.Estado = usuario.Estado;
                    usuarioTemp.NombreCompleto = usuario.NombreCompleto;
                    usuarioTemp.CorreoElectronico = usuario.CorreoElectronico;
                    usuarioTemp.DNI = usuario.DNI;
                    usuarioTemp.Celular = usuario.Celular;
                    usuarioTemp.RUC = usuario.RUC;
                    context.SaveChanges();
                }
                return "Modificar correctamente";
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

        //Eliminar Lógico
        public string EliminarLogico(int idUsuario)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Usuario usuarioTemp = context.Usuario.Find(idUsuario);
                    usuarioTemp.Eliminado = "1";
                    context.SaveChanges();
                }
                return "Eliminación correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
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
    }
}
