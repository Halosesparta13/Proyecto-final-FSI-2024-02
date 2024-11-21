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
            this.tbInmueble_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrarInquilinos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbTipoInmueble = new System.Windows.Forms.Label();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.tbAgregado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPagoMensual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgInmobiliario = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxInmobiliario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbNumeroHabitaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbIdUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgInmobiliario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInmobiliario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(550, 299);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(120, 60);
            this.btnReportes.TabIndex = 78;
            this.btnReportes.Text = "Ver Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // tbInmueble_Id
            // 
            this.tbInmueble_Id.Location = new System.Drawing.Point(150, 68);
            this.tbInmueble_Id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbInmueble_Id.Name = "tbInmueble_Id";
            this.tbInmueble_Id.Size = new System.Drawing.Size(193, 26);
            this.tbInmueble_Id.TabIndex = 77;
            this.tbInmueble_Id.TextChanged += new System.EventHandler(this.tbInmueble_Id_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "Inmueble Id";
            // 
            // btnRegistrarInquilinos
            // 
            this.btnRegistrarInquilinos.Location = new System.Drawing.Point(423, 299);
            this.btnRegistrarInquilinos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrarInquilinos.Name = "btnRegistrarInquilinos";
            this.btnRegistrarInquilinos.Size = new System.Drawing.Size(120, 60);
            this.btnRegistrarInquilinos.TabIndex = 75;
            this.btnRegistrarInquilinos.Text = "Registrar Inquilinos";
            this.btnRegistrarInquilinos.UseVisualStyleBackColor = true;
            this.btnRegistrarInquilinos.Click += new System.EventHandler(this.btnRegistrarInquilinos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(297, 299);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 60);
            this.btnLimpiar.TabIndex = 74;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(170, 299);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 60);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(43, 299);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 60);
            this.btnRegistrar.TabIndex = 72;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Casa",
            "Departamento",
            "Terreno"});
            this.cbTipo.Location = new System.Drawing.Point(477, 65);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(193, 28);
            this.cbTipo.TabIndex = 71;
            // 
            // cbTipoInmueble
            // 
            this.cbTipoInmueble.AutoSize = true;
            this.cbTipoInmueble.Location = new System.Drawing.Point(381, 72);
            this.cbTipoInmueble.Name = "cbTipoInmueble";
            this.cbTipoInmueble.Size = new System.Drawing.Size(74, 20);
            this.cbTipoInmueble.TabIndex = 70;
            this.cbTipoInmueble.Text = "Tipo Inm.";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(759, 262);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(163, 60);
            this.btnCargarImagen.TabIndex = 69;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            // 
            // tbAgregado
            // 
            this.tbAgregado.Location = new System.Drawing.Point(477, 149);
            this.tbAgregado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAgregado.Name = "tbAgregado";
            this.tbAgregado.Size = new System.Drawing.Size(193, 26);
            this.tbAgregado.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Agregados";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(477, 108);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(193, 26);
            this.tbDescripcion.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Descripción";
            // 
            // tbPagoMensual
            // 
            this.tbPagoMensual.Location = new System.Drawing.Point(150, 149);
            this.tbPagoMensual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPagoMensual.Name = "tbPagoMensual";
            this.tbPagoMensual.Size = new System.Drawing.Size(193, 26);
            this.tbPagoMensual.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Pago Mensual";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(150, 108);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(193, 26);
            this.tbDireccion.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Dirección";
            // 
            // dgInmobiliario
            // 
            this.dgInmobiliario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInmobiliario.Location = new System.Drawing.Point(26, 387);
            this.dgInmobiliario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgInmobiliario.Name = "dgInmobiliario";
            this.dgInmobiliario.RowHeadersWidth = 51;
            this.dgInmobiliario.RowTemplate.Height = 24;
            this.dgInmobiliario.Size = new System.Drawing.Size(917, 268);
            this.dgInmobiliario.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(308, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 32);
            this.label7.TabIndex = 58;
            this.label7.Text = "Registro Inmueble";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBoxInmobiliario
            // 
            this.pictureBoxInmobiliario.Location = new System.Drawing.Point(741, 69);
            this.pictureBoxInmobiliario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxInmobiliario.Name = "pictureBoxInmobiliario";
            this.pictureBoxInmobiliario.Size = new System.Drawing.Size(202, 174);
            this.pictureBoxInmobiliario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInmobiliario.TabIndex = 60;
            this.pictureBoxInmobiliario.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Área";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 20);
            this.label8.TabIndex = 80;
            this.label8.Text = "Número de habitaciones";
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(97, 196);
            this.tbArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(193, 26);
            this.tbArea.TabIndex = 81;
            // 
            // tbNumeroHabitaciones
            // 
            this.tbNumeroHabitaciones.Location = new System.Drawing.Point(224, 246);
            this.tbNumeroHabitaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNumeroHabitaciones.Name = "tbNumeroHabitaciones";
            this.tbNumeroHabitaciones.Size = new System.Drawing.Size(193, 26);
            this.tbNumeroHabitaciones.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 83;
            this.label9.Text = "Id Usuario";
            // 
            // tbIdUsuario
            // 
            this.tbIdUsuario.Location = new System.Drawing.Point(469, 193);
            this.tbIdUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbIdUsuario.Name = "tbIdUsuario";
            this.tbIdUsuario.Size = new System.Drawing.Size(193, 26);
            this.tbIdUsuario.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 85;
            this.label10.Text = "Estado";
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(500, 246);
            this.tbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(193, 26);
            this.tbEstado.TabIndex = 86;
            // 
            // FormInmobilario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 698);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbIdUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbNumeroHabitaciones);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.tbInmueble_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrarInquilinos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbTipoInmueble);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.tbAgregado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPagoMensual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxInmobiliario);
            this.Controls.Add(this.dgInmobiliario);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInmobilario";
            this.Text = "FormInmobilario";
            this.Load += new System.EventHandler(this.FormInmobilario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInmobiliario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInmobiliario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.TextBox tbInmueble_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrarInquilinos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label cbTipoInmueble;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.TextBox tbAgregado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPagoMensual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxInmobiliario;
        private System.Windows.Forms.DataGridView dgInmobiliario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbNumeroHabitaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbIdUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEstado;
    }
}