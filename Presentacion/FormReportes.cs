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
    public partial class FormReportes : Form
    {
        private NUsuario nUsuario = new NUsuario();
        private NInmobiliaria nInmobiliaria = new NInmobiliaria();
        private NInquilino nInquilino = new NInquilino();
        private NPago nPago = new NPago();

        private Usuario usuario; // Almacena el objeto PROPIETARIO
        public FormReportes(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lbNombreUsuario.Text = $"¡Bienvenido {usuario.NombreCompleto}! | Fecha de último acceso {DateTime.Now}";

        }

        private void MostrarInmuebles(List<Propiedad> inmuebles)
        {
            dgvReporte.DataSource = null;
            if (inmuebles.Count == 0)
            {
                return;
            }
            else
            {
                dgvReporte.DataSource = inmuebles;
            }
        }

        //Ordenar Inmuebles registrados por precio de alquiler
        private void button1_Click(object sender, EventArgs e)
        {
            MostrarInmuebles(nInmobiliaria.ListarTodoActivoOrdenadoPorPrecio());

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            if(cbTipo.Text == "")
            {
                MessageBox.Show("Rellene todas las casillas");
                return;
            }
            MostrarInmuebles(nInmobiliaria.ListarTodoActivoOrdenadoPorTipo(cbTipo.Text));
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            if(tbNumeroHabitaciones.Text == "")
            {
                MessageBox.Show("Rellene todas las casillas");
                return;
            }
            int n_Habitaciones;
            try
            {
                n_Habitaciones = int.Parse(tbNumeroHabitaciones.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ingrese un valor correcto para número de habitaciones");
                return;
            }
            MostrarInmuebles(nInmobiliaria.ListarPorNumeroDeHabitaciones(n_Habitaciones));
        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {

        }
    }
}
