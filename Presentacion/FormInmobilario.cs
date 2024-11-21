using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private BDEFEntities _dbContext;
        public FormInmobilario()
        {
            InitializeComponent();
            _dbContext = new BDEFEntities();
            CargarInmobiliaria();
        }

        private void CargarInmobiliaria()
        {
            throw new NotImplementedException();
        }

        private void CargarInmboliaria()
        {
            try
            {

                var propiedad = _dbContext.Propiedad
                    .Where(i => i.Eliminado != "1")
                    .Select(i => new
                    {
                        i.IdPropiedad,
                        i.Direccion,
                        i.TipoPropiedad,
                        i.Area,
                        i.Num_Habitaciones,
                        i.Descripcion,
                        i.IdUsuario,
                        i.Estado
                    })
                    .ToList();


                dgInmobiliario.DataSource = propiedad;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
                try
                {

                    if (string.IsNullOrWhiteSpace(tbInmueble_Id.Text) ||
                        string.IsNullOrWhiteSpace(tbDireccion.Text) ||
                        string.IsNullOrWhiteSpace(tbPagoMensual.Text)||
                        string.IsNullOrWhiteSpace(tbArea.Text)||
                        string.IsNullOrWhiteSpace(tbNumeroHabitaciones.Text)||
                        string.IsNullOrWhiteSpace(cbTipoInmueble.Text)||
                        string.IsNullOrWhiteSpace(tbDescripcion.Text)||
                        string.IsNullOrWhiteSpace(tbAgregado.Text)||
                        string.IsNullOrWhiteSpace(tbIdUsuario.Text)||
                        string.IsNullOrWhiteSpace(tbEstado.Text))

                {
                        MessageBox.Show("Todos los campos son obligatorios.");
                        return;
                    }


                    var nuevoInmobiliario = new Inmobiliario
                    {
                       
                        Direccion = tbDireccion.Text,
                        TipoPropiedad = cbTipoInmueble.Text,
                        Area = tbArea.Text,
                        Num_Habitaciones = tbNumeroHabitaciones.Text,
                        Descripcion = tbDescripcion.Text,
                        IdUsuario = tbIdUsuario.Text,
                        Estado= tbEstado.Text,
                        Eliminado = "0"
                    };


                    _dbContext.Propiedad.Add(nuevoInmobiliario);
                    _dbContext.SaveChanges();

                    MessageBox.Show("Inmobiliaria registrada correctamente.");
                    LimpiarCampos();
                    CargarInmobiliaria();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar: {ex.Message}");
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
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            tbInmueble_Id.Clear();
            tbDireccion.Clear();
            tbPagoMensual.Clear();
            tbArea.Clear();
            tbNumeroHabitaciones.Clear();
            tbDescripcion.Clear();
            tbAgregado.Clear();
            tbIdUsuario.Clear();
            tbEstado.Clear();
        }


        private void btnRegistrarInquilinos_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormInmobilario_Load(object sender, EventArgs e)
        {

        }

        private void tbInmueble_Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
