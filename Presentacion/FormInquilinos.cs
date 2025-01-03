﻿using Datos;
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
    public partial class FormInquilinos : Form
    {
        private NInquilino nInquilino = new NInquilino();
        private NContrato nContrato = new NContrato();
        private NInmobiliaria nInmobiliaria = new NInmobiliaria();
        private Usuario usuario; // Almacena el objeto PROPIETARIO
        private int idInmueble;
        public FormInquilinos(Usuario usuarios, int idInmueble)
        {
            InitializeComponent();
            MostrarInquilinos(nInquilino.ListarActivos());
            this.usuario = usuarios;
            this.idInmueble = idInmueble;
            // Obtener todos los inquilinos activos
            List<Inquilino> inquilinosActivos = nInquilino.ListarActivos();

            // Mostrar los inquilinos filtrados por IdInmueble
            MostrarInquilinos(inquilinosActivos);

            MostrarMontoPorInmueble(idInmueble);
            lblNombre_Usuario.Text = $"¡Bienvenido {usuario.NombreCompleto}! | Fecha de último acceso {DateTime.Now}";
        }
        private void MostrarInquilinos(List<Inquilino> inquilinos)
        {
            // Filtrar los inquilinos por el idInmueble
            var inquilinosFiltrados = inquilinos.Where(i => i.IdPropiedad == idInmueble).ToList();

            dgInquilinos.DataSource = null;

            if (inquilinosFiltrados.Count == 0)
            {
                //MessageBox.Show("No hay inquilinos asociados a este inmueble.");
                return;
            }
            else
            {

                // Establecer los inquilinos filtrados como fuente de datos del DataGridView
                dgInquilinos.DataSource = inquilinosFiltrados;
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
                lblmonto_Total.Text = $"{montoPago:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el monto total: {ex.Message}");
            }
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreCompletoInquilino = tbNombreCompleto.Text;
            string telefono = tbCelular.Text;
            string correoElectronicoInquilino = tbCorreo.Text;
            string dni = tbDNI.Text;
            //int idPropiedad = 1; // esta por defecto para probar se tiene que modificar NO VA
            string estado = "Activo";
            string eliminado = "0";

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(nombreCompletoInquilino) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(correoElectronicoInquilino) ||
                string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Rellene todas las casillas.");
                return;
            }

            // Validación de longitud del DNI
            if (dni.Length != 8 || !dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe contener 8 dígitos numéricos.");
                return;
            }

            // Validación del número de celular
            if (telefono.Length < 9 || !telefono.All(char.IsDigit))
            {
                MessageBox.Show("El número de celular debe tener al menos 9 dígitos y solo contener números.");
                return;
            }

            // Validación del formato de correo electrónico
            if (!correoElectronicoInquilino.Contains("@") || !correoElectronicoInquilino.Contains("."))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                return;
            }

            // Crear objeto Inquilino
            Inquilino inquilino = new Inquilino()
            {
                NombreCompletoInquilino = nombreCompletoInquilino,
                Telefono = telefono,
                CorreoElectronicoInquilino = correoElectronicoInquilino,
                DNI = dni,
                IdPropiedad = idInmueble,
            };

            // Llamar al método para registrar el inquilino
            string mensaje = nInquilino.Registrar(inquilino);
            MessageBox.Show(mensaje);

            // Actualizar la lista de inquilinos
            MostrarInquilinos(nInquilino.ListarActivos());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya un inquilino seleccionado
                if (dgInquilinos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona un inquilino para eliminar.");
                    return;
                }

                // Obtener el ID del inquilino seleccionado
                int idInquilino = Convert.ToInt32(dgInquilinos.SelectedRows[0].Cells["IdInquilino"].Value);

                // Confirmación antes de eliminar
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este inquilino?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Llamar al método para eliminar en la capa de negocio
                    string mensaje = nInquilino.EliminarLogico(idInquilino); // Método que realiza la eliminación lógica
                    MessageBox.Show(mensaje);

                    // Actualizar la lista de inquilinos activos
                    MostrarInquilinos(nInquilino.ListarActivos());
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

        private void btnPagos_Click(object sender, EventArgs e)
        {
            if(dgInquilinos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            int idInquilinos = int.Parse(dgInquilinos.SelectedRows[0].Cells[0].Value.ToString());
            FormPagos form = new FormPagos(idInquilinos, usuario, idInmueble);
            form.Show();
        }
    }
}
