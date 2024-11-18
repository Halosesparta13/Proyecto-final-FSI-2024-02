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
        private List<Usuario> usuariosRegistrados = new List<Usuario>();

        public FormLogin()
        {
            InitializeComponent();
        }

        //Usuario predeterminado para uso de prueba



        //PORTEO DEL CODIGO TP EN PROGRESO
        private void btnIniciarSeccion_Click(object sender, EventArgs e)
        {
            // Obtener los datos introducidos por el usuario
            string usuario = tbUsuario.Text;
            string contraseña = tbContraseña.Text;
            /*
            // Buscar el propietario en la lista
            var propietario = usuariosRegistrados.FirstOrDefault(p => p.Nombre_Usuario == usuario);

            if (propietario != null)
            {
                // Verificar si la contraseña es correcta
                if (propietario.Contraseña == contraseña)
                {
                    MessageBox.Show("Inicio de sesión exitosa.");
                    FormInmobilario form = new FormInmobilario(propietario);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta. Inténtalo de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }*/
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
