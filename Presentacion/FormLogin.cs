using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        private NUsuario nUsuario = new NUsuario();
        //private List<Usuario> usuariosRegistrados = new List<Usuario>();

        public FormLogin()
        {
            InitializeComponent();
        }


        //PORTEO DEL CODIGO TP EN PROGRESO
        private void btnIniciarSeccion_Click(object sender, EventArgs e)
        {
            // Obtener los datos introducidos por el usuario
            string username = tbUsuario.Text;
            string passwoard = tbContraseña.Text;

            if (username == "" || passwoard == "")
            {
                MessageBox.Show("Rellena todos los campos");
                return;
            }
            // Buscar el propietario en la lista
            var usuario = nUsuario.ListarTodo().FirstOrDefault(p => p.UserName == username);
            if (usuario != null)
            {
                // Verificar si la contraseña es correcta
                if (usuario.Password == passwoard)
                {
                    if(usuario.Rol == "Admin")
                    {

                        MessageBox.Show("Inicio de sesión como Admin exitoso.");
                        FormAdminMenu form = new FormAdminMenu();
                        form.Show();
                    }
                    else
                    {

                        MessageBox.Show("Inicio de sesión exitosa.");
                        FormInmobilario form = new FormInmobilario(usuario);
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta. Inténtalo de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistroPropietario form = new FormRegistroPropietario();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
