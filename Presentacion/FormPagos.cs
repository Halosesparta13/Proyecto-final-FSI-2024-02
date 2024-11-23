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
    public partial class FormPagos : Form
    {
        private NPago nPago = new NPago();
        private Usuario usuario; // Almacena el objeto PROPIETARIO
        private int id;
        public FormPagos(int id, Usuario usuario)
        {
            InitializeComponent();
            this.id = id;
            this.usuario = usuario;
            MostrarPagos(nPago.ListarPagos());
            lblNombre_Usuario.Text = $"¡Bienvenido {usuario.NombreCompleto}! | Fecha de último acceso {DateTime.Now}";
        }
        private void MostrarPagos(List<Pago> pagos)
        {
            dgPagos.DataSource = null; 
            if (pagos.Count == 0)
            {
                return; 
            }
            else
            {
                dgPagos.DataSource = pagos; 
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
                    string.IsNullOrWhiteSpace(tbNombre.Text) ||
                    string.IsNullOrWhiteSpace(tbMonto.Text) ||
                    cmbMetodosPago.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(cbEstado.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                Pago nuevoPago = new Pago
                {
                    Monto = double.Parse(tbMonto.Text),
                    MetodoPago = cmbMetodosPago.SelectedItem.ToString(),
                    Estado = cbEstado.Text,
                };

                string mensaje = nPago.Registrar(nuevoPago);
                MessageBox.Show(mensaje);


                MostrarPagos(nPago.ListarTodo());
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Asegúrese de que el monto sea un número válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el pago: {ex.Message}");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbMonto.Clear();
            cmbMetodosPago.SelectedIndex = -1;
        }
    }
}
