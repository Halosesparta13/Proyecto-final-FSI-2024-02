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
            dgPropiedad.DataSource = null;
            if(inmobiliarios.Count == 0)
            {
                lbNombreUsuario.Text = $"¡Bienvenido {usuario.NombreCompleto}! | Fecha de último acceso {DateTime.Now}";
                return;
            }
            else
            {
                dgPropiedad.DataSource = inmobiliarios;
                dgPropiedad.Columns["Image_Path"].Visible = false;
                dgPropiedad.Columns["Contrato"].Visible = false;
                dgPropiedad.Columns["Inquilino"].Visible = false;
                dgPropiedad.Columns["Usuario"].Visible = false;
                dgPropiedad.Columns["IdPropiedad"].Visible = false;
                dgPropiedad.Columns["IdUsuario"].Visible = false;
                dgPropiedad.Columns["Eliminado"].Visible = false;
                dgPropiedad.Columns["Estado"].Visible = false;
                lbNombreUsuario.Text = $"¡Bienvenido {usuario.NombreCompleto}! | Fecha de último acceso {DateTime.Now}";
            }
        }

        private void dgPropiedad_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPropiedad.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                var selectedRow = dgPropiedad.SelectedRows[0];

                // Intentar obtener el valor de la celda "Image_Path"
                var imagePath = selectedRow.Cells["Image_Path"].Value as string;

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
                    // Si no hay imagen o la ruta no es válida, limpiar el PictureBox
                    pictureBoxInmobiliario.Image = null;
                }
            }
        }


        private String imageLocation = "";
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBoxInmobiliario.ImageLocation = imageLocation;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la carga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
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
                TipoPropiedad = cbTipo.Text,
                Estado = "Activo",
                Monto = MontoMensual,
                Area = area,
                Num_Habitaciones = numHabitaciones,
                Descripcion = tbDescripcion.Text,
                IdUsuario = usuario.IdUsuario,
                Contrato = new List<Contrato>(),
                Image_Path = imageLocation,
            };

            //Registrar
            string mensaje = nInmobiliaria.Registrar(propiedad);
            MessageBox.Show(mensaje);
            MostrarImmobiliarios(nInmobiliaria.ListarTodoActivo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgPropiedad.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            int id = int.Parse(dgPropiedad.SelectedRows[0].Cells[0].Value.ToString());
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
            if(dgPropiedad.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            int id = int.Parse(dgPropiedad.SelectedRows[0].Cells[0].Value.ToString());
            FormInquilinos form = new FormInquilinos(usuario,id);
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes(usuario);
            form.Show();
        }

    }
}
