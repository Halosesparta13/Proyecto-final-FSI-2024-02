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
    public partial class FormAdminMenu : Form
    {
        private NUsuario nUsuario = new NUsuario();
        public FormAdminMenu()
        {
            InitializeComponent();
        }

        private void MostrarUsuarios(List<Usuario> usuarios)
        {
            dgUsuario.DataSource = null;
            if(usuarios.Count == 0)
            {
                return;
            }
            else
            {
                dgUsuario.DataSource= usuarios;
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

            if (cbEstado.Text==""||cbRol.Text==""||  tbRUC.Text == "" || tbNombreCompleto.Text == "" || tbNombreUsuario.Text == "" || tbDNI.Text == "" || tbCorreo.Text == "" || tbContraseña.Text == "" || tbCelular.Text == "")
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
                Rol = cbRol.Text,
                Estado = cbEstado.Text,
                NombreCompleto = tbNombreCompleto.Text,
                CorreoElectronico = tbCorreo.Text,
                DNI = tbDNI.Text,
                FechaRegistro = DateTime.Now,
                Celular = celular,
                RUC = ruc,
            };

            string mensaje = nUsuario.Registrar(usuario);
            MessageBox.Show(mensaje);

            MostrarUsuarios(nUsuario.ListarTodo());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombreCompleto.Clear();
            tbNombreUsuario.Clear();  
            tbDNI.Clear();
            tbCorreo.Clear();
            tbContraseña.Clear();
            tbCelular.Clear();
            tbRUC.Clear(); 
            cbRol.Items.Clear();
            cbEstado.Items.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un registro");
                return;
            }
            int usuario_id = int.Parse(dgUsuario.SelectedRows[0].Cells[0].Value.ToString());
            string dni = tbDNI.Text;
            string celular = tbCelular.Text;
            string correo = tbCorreo.Text;
            string ruc = tbRUC.Text;
            string username = tbNombreUsuario.Text;
            string passwoard = tbContraseña.Text;

            if (cbEstado.Text == "" || cbRol.Text == "" || tbRUC.Text == "" || tbNombreCompleto.Text == "" || tbNombreUsuario.Text == "" || tbDNI.Text == "" || tbCorreo.Text == "" || tbContraseña.Text == "" || tbCelular.Text == "")
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
                IdUsuario = usuario_id,
                UserName = username,
                Password = passwoard,
                Rol = cbRol.Text,
                Estado = cbEstado.Text,
                NombreCompleto = tbNombreCompleto.Text,
                CorreoElectronico = tbCorreo.Text,
                DNI = tbDNI.Text,
                FechaRegistro = DateTime.Now,
                Celular = celular,
                RUC = ruc,
            };

            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
