﻿using Datos;
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
    public partial class FormInmobilario : Form
    {

        private Usuario usuario; // Almacena el objeto propietario
        public FormInmobilario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
    }
}
