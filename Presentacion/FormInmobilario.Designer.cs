namespace Presentacion
{
    partial class FormInmobilario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnRegistrarInquilinos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pictureBoxInmobiliario = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgPropiedad = new System.Windows.Forms.DataGridView();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNumeroHabitaciones = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbTipoInmueble = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPagoMensual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInmobiliario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPropiedad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(552, 207);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(107, 48);
            this.btnReportes.TabIndex = 78;
            this.btnReportes.Text = "Ver Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnRegistrarInquilinos
            // 
            this.btnRegistrarInquilinos.Location = new System.Drawing.Point(439, 207);
            this.btnRegistrarInquilinos.Name = "btnRegistrarInquilinos";
            this.btnRegistrarInquilinos.Size = new System.Drawing.Size(107, 48);
            this.btnRegistrarInquilinos.TabIndex = 75;
            this.btnRegistrarInquilinos.Text = "Registrar Inquilinos";
            this.btnRegistrarInquilinos.UseVisualStyleBackColor = true;
            this.btnRegistrarInquilinos.Click += new System.EventHandler(this.btnRegistrarInquilinos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(327, 207);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 48);
            this.btnLimpiar.TabIndex = 74;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(214, 207);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 48);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(101, 207);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(107, 48);
            this.btnRegistrar.TabIndex = 72;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(734, 207);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(145, 48);
            this.btnCargarImagen.TabIndex = 69;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            // 
            // pictureBoxInmobiliario
            // 
            this.pictureBoxInmobiliario.Location = new System.Drawing.Point(709, 53);
            this.pictureBoxInmobiliario.Name = "pictureBoxInmobiliario";
            this.pictureBoxInmobiliario.Size = new System.Drawing.Size(180, 139);
            this.pictureBoxInmobiliario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInmobiliario.TabIndex = 60;
            this.pictureBoxInmobiliario.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.barra_propietarios;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 616);
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // dgPropiedad
            // 
            this.dgPropiedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPropiedad.Location = new System.Drawing.Point(101, 265);
            this.dgPropiedad.Name = "dgPropiedad";
            this.dgPropiedad.RowHeadersWidth = 51;
            this.dgPropiedad.RowTemplate.Height = 24;
            this.dgPropiedad.Size = new System.Drawing.Size(797, 236);
            this.dgPropiedad.TabIndex = 88;
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Location = new System.Drawing.Point(98, 504);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(75, 16);
            this.lbNombreUsuario.TabIndex = 89;
            this.lbNombreUsuario.Text = "Bienvenido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNumeroHabitaciones);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbArea);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPagoMensual);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbTipoInmueble);
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(97, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 126);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Inmueble";
            // 
            // tbNumeroHabitaciones
            // 
            this.tbNumeroHabitaciones.Location = new System.Drawing.Point(143, 84);
            this.tbNumeroHabitaciones.Name = "tbNumeroHabitaciones";
            this.tbNumeroHabitaciones.Size = new System.Drawing.Size(172, 22);
            this.tbNumeroHabitaciones.TabIndex = 102;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(427, 87);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(172, 22);
            this.tbArea.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 100;
            this.label8.Text = "N# de habitaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 99;
            this.label1.Text = "Área";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Casa",
            "Departamento",
            "Terreno"});
            this.cbTipo.Location = new System.Drawing.Point(427, 22);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(172, 24);
            this.cbTipo.TabIndex = 98;
            // 
            // cbTipoInmueble
            // 
            this.cbTipoInmueble.AutoSize = true;
            this.cbTipoInmueble.Location = new System.Drawing.Point(342, 27);
            this.cbTipoInmueble.Name = "cbTipoInmueble";
            this.cbTipoInmueble.Size = new System.Drawing.Size(62, 16);
            this.cbTipoInmueble.TabIndex = 97;
            this.cbTipoInmueble.Text = "Tipo Inm.";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(427, 56);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(172, 22);
            this.tbDescripcion.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 95;
            this.label4.Text = "Descripción";
            // 
            // tbPagoMensual
            // 
            this.tbPagoMensual.Location = new System.Drawing.Point(143, 56);
            this.tbPagoMensual.Name = "tbPagoMensual";
            this.tbPagoMensual.Size = new System.Drawing.Size(172, 22);
            this.tbPagoMensual.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 93;
            this.label3.Text = "Pago Mensual";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(143, 23);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(172, 22);
            this.tbDireccion.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 91;
            this.label2.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 37);
            this.label5.TabIndex = 91;
            this.label5.Text = "Registro Inmueble";
            // 
            // FormInmobilario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 529);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.dgPropiedad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnRegistrarInquilinos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pictureBoxInmobiliario);
            this.Name = "FormInmobilario";
            this.Text = "FormInmobilario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInmobiliario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPropiedad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnRegistrarInquilinos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox pictureBoxInmobiliario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgPropiedad;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNumeroHabitaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPagoMensual;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cbTipoInmueble;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label5;
    }
}