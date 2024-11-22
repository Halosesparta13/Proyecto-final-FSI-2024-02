using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInmobilario : Form
    {
        private NInmobiliaria nInmobiliaria = new NInmobiliaria();
        private Usuario usuario; // Almacena el objeto PROPIETARIO
        public FormInmobilario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            MostrarImmobiliarios(nInmobiliaria.ListarTodoActivo());
        }

        private void MostrarImmobiliarios(List<Propiedad> inmobiliarios)
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
            //Validaciones
            if(tbArea.Text==""||tbDescripcion.Text==""||tbDireccion.Text==""||cbTipo.Text==""||tbNumeroHabitaciones.Text==""||tbPagoMensual.Text=="")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            decimal MontoMensual = 0;
            double area = 0;
            int numHabitaciones = 0;
            try
            {
                MontoMensual = decimal.Parse(tbPagoMensual.Text);
                // Verificar si el monto es positivo
                if (MontoMensual <= 0)
                {
                    MessageBox.Show("El Pago Mensual debe ser un valor positivo.");
                    return;
                }
                area = double.Parse(tbArea.Text);
                if(area <= 0)
                {
                    MessageBox.Show("El area debe de ser mayor");
                    return;
                }
                numHabitaciones = int.Parse(tbNumeroHabitaciones.Text);
                if(numHabitaciones <= 0)
                {
                    MessageBox.Show("El numero de habitaciones debe de ser mayor a 0");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresa un valor valido");
                Console.WriteLine(ex.Message);
                return;
            }

            //Creación de propiedad
            Propiedad propiedad = new Propiedad()
            {
                Direccion = tbDireccion.Text,
                Descripcion = tbDescripcion.Text,
                Area = area,
                Num_Habitaciones = numHabitaciones,
                TipoPropiedad = cbTipo.Text
            };

            //Registrar
            string mensaje = nInmobiliaria.Registrar(propiedad);
            MessageBox.Show(mensaje);
            MostrarImmobiliarios(nInmobiliaria.ListarTodoActivo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgInmobiliario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            int id = int.Parse(dgInmobiliario.SelectedRows[0].Cells[0].Value.ToString());
            string mensaje = nInmobiliaria.Eliminar(id);
            MessageBox.Show(mensaje);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbDireccion.Clear();
            tbPagoMensual.Clear();
            tbArea.Clear();
            tbNumeroHabitaciones.Clear();
            tbDescripcion.Clear();
        }


        private void btnRegistrarInquilinos_Click(object sender, EventArgs e)
        {
            FormInquilinos form = new FormInquilinos();
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes();
            form.Show();
        }

        private void dgInmobiliario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgInmobiliario.SelectedRows.Count > 0)
            {
                var selectedRow = dgInmobiliario.SelectedRows[0];
                var imagePath = selectedRow.Cells["ImagePath"].Value as string;

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    try
                    {
                        // Cargar la imagen en el PictureBox
                        pictureBoxInmobiliario.Image = new Bitmap(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede cargar la imagen: " + ex.Message);
                    }
                }
                else
                {
                    // Si no hay imagen, limpiar el PictureBox
                    pictureBoxInmobiliario.Image = null;
                }
            }
        }
    }
}
