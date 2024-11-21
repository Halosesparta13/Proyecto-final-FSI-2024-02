using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInmobilario : Form
    {

        private Usuario usuario; // Almacena el objeto propietario
        public FormInmobilario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private void CargarInmobiliaria()
        {
            throw new NotImplementedException();
        }

        private void MostrarImmobiliarios(List<Inmobiliario> inmobiliarios)
        {
            dgInmobiliario.DataSource = null;
            if(inmobiliarios.Count == 0)
            {
                return;
            }
            else
            {
                dgInmobiliario.DataSource = inmobiliarios;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(tbArea.Text==""|| cbTipo.Text == "" || tbDireccion.Text == "" || tbNumeroHabitaciones.Text == "" || tbDireccion.Text == "")
            {
                MessageBox.Show("Rellene todas las casillas");
                return;
            }
        }

        private void LimpiarCampos()
        {
            throw new NotImplementedException();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgInmobiliario.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona una propiedad para eliminar.");
                    return;
                }


                int idPropiedad = Convert.ToInt32(dgInmobiliario.SelectedRows[0].Cells["IdPropiedad"].Value);


                var propiedad = _dbContext.Propiedad.FirstOrDefault(i => i.IdPropiedad == idPropiedad);
                if (propiedad != null)
                {
                    propiedad.Eliminado = "1";
                    _dbContext.SaveChanges();
                    MessageBox.Show("Propiedad eliminada correctamente.");
                    CargarInmobiliaria();
                }
                else
                {
                    MessageBox.Show("No se encontró la propiedadd.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbDireccion.Clear();
            tbPagoMensual.Clear();
            tbArea.Clear();
            tbNumeroHabitaciones.Clear();
            tbDescripcion.Clear();
        }

        private void LimpiarCampos()
        {
            tbDireccion.Clear();
            tbPagoMensual.Clear();
            tbArea.Clear();
            tbNumeroHabitaciones.Clear();
            tbDescripcion.Clear();
        }


        private void btnRegistrarInquilinos_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

    }
}
