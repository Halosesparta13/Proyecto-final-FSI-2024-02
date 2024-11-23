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
        public FormReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView
            dgvReporte.DataSource = null;

            // Obtener la lista de usuarios
            var usuarios = nUsuario.ListarTodo();

            // Generar la lista de usuarios y sus propiedades no eliminadas
            var reporte = new List<dynamic>();

            foreach (var usuario in usuarios)
            {
                var propiedades = nInmobiliaria.ListarTodoActivo()
                                               .FindAll(p => p.IdUsuario == usuario.IdUsuario);

                if (propiedades.Count > 0)
                {
                    foreach (var propiedad in propiedades)
                    {
                        reporte.Add(new
                        {
                            Usuario = usuario.NombreCompleto,
                            DNI = usuario.DNI,
                            Correo = usuario.CorreoElectronico,
                            Propiedad = propiedad.Direccion,
                            Tipo = propiedad.TipoPropiedad,
                            Estado = propiedad.Estado
                        });
                    }
                }
            }

            // Mostrar en el DataGridView
          
            dgvReporte.DataSource = reporte;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {

        }
    }
}
