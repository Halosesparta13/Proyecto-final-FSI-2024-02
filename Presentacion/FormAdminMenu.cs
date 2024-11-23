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
            MostrarUsuarios(nUsuario.ListarTodo());
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

        //Eliminar lógico
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            int id = int.Parse(dgUsuario.SelectedRows[0].Cells[0].Value.ToString());
            string mensaje = nUsuario.EliminarLogico(id);
            MessageBox.Show(mensaje);
            MostrarUsuarios(nUsuario.ListarTodo());
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

            string mensaje = nUsuario.Modificar(usuario);
            MessageBox.Show(mensaje);

            MostrarUsuarios(nUsuario.ListarTodo());

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            if (dgUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            int id = int.Parse(dgUsuario.SelectedRows[0].Cells[0].Value.ToString());
            string mensaje = nUsuario.EliminadoFisico(id);
            MessageBox.Show(mensaje);
            MostrarUsuarios(nUsuario.ListarTodo());
        }

        private void dgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurarse de que se ha seleccionado una fila (y no una celda vacía)
            if (e.RowIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dgUsuario.Rows[e.RowIndex];

                // Rellenar los TextBox con los valores correspondientes
                tbNombreCompleto.Text = row.Cells["NombreCompleto"].Value.ToString();
                tbNombreUsuario.Text = row.Cells["UserName"].Value.ToString();
                tbDNI.Text = row.Cells["DNI"].Value.ToString();
                tbCorreo.Text = row.Cells["CorreoElectronico"].Value.ToString();
                tbCelular.Text = row.Cells["Celular"].Value.ToString();
                tbRUC.Text = row.Cells["RUC"].Value.ToString();
                tbContraseña.Text = row.Cells["Password"].Value.ToString();

                // Rellenar los ComboBox con los valores correspondientes
                cbEstado.Text = row.Cells["Estado"].Value.ToString();
                cbRol.Text = row.Cells["Rol"].Value.ToString();
            }
        }
    }
}
