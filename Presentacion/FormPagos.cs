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
        private NInmobiliaria nInmobiliaria = new NInmobiliaria();
        private int idInquilinos;
        private int idInmueble;
        public FormPagos(int idInquilinos, Usuario usuario, int idInmueble)
        {
            InitializeComponent();
            this.idInquilinos = idInquilinos;
            this.usuario = usuario;
            this.idInmueble = idInmueble;
            MostrarPagos(nPago.ListarPagos());
            MostrarMontoPorInmueble(idInmueble);
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
        private void MostrarMontoPorInmueble(int idInmueble)
        {
            try
            {
                // Obtener todos los inmuebles desde la capa de datos
                List<Propiedad> inmuebles = nInmobiliaria.ListarTodoActivo();

                // Filtrar los inmuebles por el IdInmueble proporcionado
                var inmueble = inmuebles.FirstOrDefault(i => i.IdPropiedad == idInmueble);

                // Validar que el inmueble exista
                if (inmueble == null)
                {
                    MessageBox.Show("No se encontró el inmueble especificado.");
                    return;
                }

                // Obtener el monto de pago del inmueble, manejando valores nulos
                decimal montoPago = inmueble.Monto ?? 0;

                // Mostrar el monto en un label
                lbMontoTotal.Text = $"{montoPago}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el monto total: {ex.Message}");
            }
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" ||
                    cmbMetodosPago.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Pago nuevoPago = new Pago
            {
                Monto = double.Parse(lbMontoTotal.Text),
                MetodoPago = cmbMetodosPago.SelectedItem.ToString(),
                Nombe = tbNombre.Text,
                Estado = "Pagado",
                FechaPago = DateTime.Now,
                Contrato = new List<Contrato>()
            };

            string mensaje = nPago.Registrar(nuevoPago);
            MessageBox.Show(mensaje);
            MostrarPagos(nPago.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            tbNombre.Clear();
            cmbMetodosPago.SelectedIndex = -1;
        }
    }
}
