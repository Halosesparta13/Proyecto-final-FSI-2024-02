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
        public FormPagos()
        {
            InitializeComponent();
            CargarPagos();
        }
        private void CargarPagos()
        {
            var pagos = nPago.ListarTodo(); 
            MostrarPagos(pagos);         
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
                if (string.IsNullOrWhiteSpace(tbNombrePropiedad.Text) ||
                    string.IsNullOrWhiteSpace(tbNombre.Text) ||
                    string.IsNullOrWhiteSpace(tbMonto.Text) ||
                    cmbMetodosPago.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(tbEstado.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                Pago nuevoPago = new Pago
                {
                    NombrePropiedad = tbNombrePropiedad.Text,
                    NombreInquilino = tbNombre.Text,
                    Monto = double.Parse(tbMonto.Text),
                    MetodoPago = cmbMetodosPago.SelectedItem.ToString(),
                    Estado = tbEstado.Text,
                    FechaPago = dpFecha.Value
                };

                string mensaje = nPago.Registrar(nuevoPago);
                MessageBox.Show(mensaje);


                CargarPagos();
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
            tbNombrePropiedad.Clear();
            tbNombre.Clear();
            tbMonto.Clear();
            cmbMetodosPago.SelectedIndex = -1;
            tbEstado.Clear();
            dpFecha.Value = DateTime.Now;
        }
    }
}
