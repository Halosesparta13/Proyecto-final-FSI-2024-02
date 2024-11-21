using Datos;
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
    public partial class FormInquilinos : Form
    {
        private BDEFEntities _dbContext;
        public FormInquilinos()
        {
            InitializeComponent();
            _dbContext = new BDEFEntities(); 
            CargarInquilinos(); 
        }

        private void CargarInquilinos()
        {
            try
            {
                
                var inquilinos = _dbContext.Inquilino
                    .Where(i => i.Eliminado != "1")
                    .Select(i => new
                    {
                        i.IdInquilino,
                        i.NombreCompletoInquilino,
                        i.Telefono,
                        i.CorreoElectronicoInquilino,
                        i.DNI,
                        i.Estado
                    })
                    .ToList();

                
                dgInquilinos.DataSource = inquilinos;
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
                
                if (string.IsNullOrWhiteSpace(tbNombreCompleto.Text) ||
                    string.IsNullOrWhiteSpace(tbDNI.Text) ||
                    string.IsNullOrWhiteSpace(tbCelular.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                
                var nuevoInquilino = new Inquilino
                {
                    NombreCompletoInquilino = tbNombreCompleto.Text,
                    Telefono = tbCelular.Text,
                    CorreoElectronicoInquilino = tbCorreo.Text,
                    DNI = tbDNI.Text,
                    IdPropiedad = 1, 
                    Estado = "Activo",
                    Eliminado = "0"
                };

                
                _dbContext.Inquilino.Add(nuevoInquilino);
                _dbContext.SaveChanges();

                MessageBox.Show("Inquilino registrado correctamente.");
                LimpiarCampos();
                CargarInquilinos(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgInquilinos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona un inquilino para eliminar.");
                    return;
                }

                
                int idInquilino = Convert.ToInt32(dgInquilinos.SelectedRows[0].Cells["IdInquilino"].Value);

                
                var inquilino = _dbContext.Inquilino.FirstOrDefault(i => i.IdInquilino == idInquilino);
                if (inquilino != null)
                {
                    inquilino.Eliminado = "1"; 
                    _dbContext.SaveChanges();
                    MessageBox.Show("Inquilino eliminado correctamente.");
                    CargarInquilinos(); 
                }
                else
                {
                    MessageBox.Show("No se encontró el inquilino.");
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
            tbNombreCompleto.Clear();
            tbDNI.Clear();
            tbCelular.Clear();
            tbCorreo.Clear();
            dpFechaPago.Value = DateTime.Now;
            dpFechaFin.Value = DateTime.Now;
        }

        private void FormInquilinos_Load(object sender, EventArgs e)
        {

        }
    }
}
