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
            ((System.ComponentModel.ISupportInitialize)(this.dgInmobiliario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInmobiliario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(489, 210);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(107, 48);
            this.btnReportes.TabIndex = 78;
            this.btnReportes.Text = "Ver Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // tbInmueble_Id
            // 
            this.tbInmueble_Id.Location = new System.Drawing.Point(131, 100);
            this.tbInmueble_Id.Name = "tbInmueble_Id";
            this.tbInmueble_Id.Size = new System.Drawing.Size(172, 22);
            this.tbInmueble_Id.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 76;
            this.label6.Text = "Inmueble Id";
            // 
            // btnRegistrarInquilinos
            // 
            this.btnRegistrarInquilinos.Location = new System.Drawing.Point(376, 210);
            this.btnRegistrarInquilinos.Name = "btnRegistrarInquilinos";
            this.btnRegistrarInquilinos.Size = new System.Drawing.Size(107, 48);
            this.btnRegistrarInquilinos.TabIndex = 75;
            this.btnRegistrarInquilinos.Text = "Registrar Inquilinos";
            this.btnRegistrarInquilinos.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(264, 210);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 48);
            this.btnLimpiar.TabIndex = 74;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(151, 210);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 48);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(38, 210);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(107, 48);
            this.btnRegistrar.TabIndex = 72;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Casa",
            "Departamento",
            "Terreno"});
            this.cbTipo.Location = new System.Drawing.Point(424, 98);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(172, 24);
            this.cbTipo.TabIndex = 71;
            // 
            // cbTipoInmueble
            // 
            this.cbTipoInmueble.AutoSize = true;
            this.cbTipoInmueble.Location = new System.Drawing.Point(339, 103);
            this.cbTipoInmueble.Name = "cbTipoInmueble";
            this.cbTipoInmueble.Size = new System.Drawing.Size(62, 16);
            this.cbTipoInmueble.TabIndex = 70;
            this.cbTipoInmueble.Text = "Tipo Inm.";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(675, 210);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(145, 48);
            this.btnCargarImagen.TabIndex = 69;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            // 
            // tbAgregado
            // 
            this.tbAgregado.Location = new System.Drawing.Point(424, 156);
            this.tbAgregado.Name = "tbAgregado";
            this.tbAgregado.Size = new System.Drawing.Size(172, 22);
            this.tbAgregado.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "Agregados";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(424, 128);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(172, 22);
            this.tbDescripcion.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Descripción";
            // 
            // tbPagoMensual
            // 
            this.tbPagoMensual.Location = new System.Drawing.Point(131, 156);
            this.tbPagoMensual.Name = "tbPagoMensual";
            this.tbPagoMensual.Size = new System.Drawing.Size(172, 22);
            this.tbPagoMensual.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Pago Mensual";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(131, 128);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(172, 22);
            this.tbDireccion.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Dirección";
            // 
            // dgInmobiliario
            // 
            this.dgInmobiliario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInmobiliario.Location = new System.Drawing.Point(24, 274);
            this.dgInmobiliario.Name = "dgInmobiliario";
            this.dgInmobiliario.RowHeadersWidth = 51;
            this.dgInmobiliario.RowTemplate.Height = 24;
            this.dgInmobiliario.Size = new System.Drawing.Size(815, 214);
            this.dgInmobiliario.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 29);
            this.label7.TabIndex = 58;
            this.label7.Text = "Registro Inmueble";
            // 
            // pictureBoxInmobiliario
            // 
            this.pictureBoxInmobiliario.Location = new System.Drawing.Point(659, 55);
            this.pictureBoxInmobiliario.Name = "pictureBoxInmobiliario";
            this.pictureBoxInmobiliario.Size = new System.Drawing.Size(180, 139);
            this.pictureBoxInmobiliario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInmobiliario.TabIndex = 60;
            this.pictureBoxInmobiliario.TabStop = false;
            // 
            // FormInmobilario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 501);
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
            this.Name = "FormInmobilario";
            this.Text = "FormInmobilario";
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
    }
}