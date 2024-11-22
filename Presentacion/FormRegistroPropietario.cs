using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRegistroPropietario : Form
    {
        private NUsuario nUsuario = new NUsuario();
        public FormRegistroPropietario()
        {
            InitializeComponent();
            MostrarPropietarios(nUsuario.ListarTodo());
        }

        private void MostrarPropietarios(List<Usuario> usuarios)
        {
            dgPropietarios.DataSource = null;
            if (usuarios.Count == 0)
            {
                return;
            }
            else
            {
                dgPropietarios.DataSource = usuarios;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string dni = tbDNI.Text;
            string celular = tbCelular.Text;
            string correo = tbCorreo.Text;
            string ruc = tbRUC.Text;
            string username = tbNombreUsuario.Text;
            string passwoard = tbContraseña.Text;

            if (tbRUC.Text == "" || tbNombreCompleto.Text == "" || tbNombreUsuario.Text == "" || tbDNI.Text == "" || tbCorreo.Text == "" || tbContraseña.Text == "" || tbCelular.Text == "")
            {
                MessageBox.Show("Rellene todas las casilas");
                return;
            }
            // Validación de longitud del DNI
            if (dni.Length != 8 || !dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe contener 8 dígitos numéricos.");
                return;
            }

            // Validación del número de celular
            if (celular.Length < 9 || !celular.All(char.IsDigit))
            {
                MessageBox.Show("El número de celular debe tener al menos 9 dígitos y solo contener números.");
                return;
            }

            // Validación del formato de correo electrónico
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                return;
            }

            // Validación del RUC (asumiendo 11 dígitos)
            if (ruc.Length != 11 || !ruc.All(char.IsDigit))
            {
                MessageBox.Show("El RUC debe contener 11 dígitos numéricos.");
                return;
            }

            Usuario usuario = new Usuario()
            {
                UserName = username,
                Password = passwoard,
                Rol = "Propietario",
                NombreCompleto = tbNombreCompleto.Text,
                CorreoElectronico = tbCorreo.Text,
                DNI = tbDNI.Text,
                FechaRegistro = DateTime.Now,
                Celular = celular,
                RUC = ruc,
            };

            string mensaje = nUsuario.Registrar(usuario);
            MessageBox.Show(mensaje);

            MostrarPropietarios(nUsuario.ListarTodo());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombreCompleto.Clear();
            tbNombreUsuario.Clear();  // Faltaba este
            tbDNI.Clear();
            tbCorreo.Clear();
            tbContraseña.Clear();
            tbCelular.Clear();
            tbRUC.Clear();  // Faltaba este
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
