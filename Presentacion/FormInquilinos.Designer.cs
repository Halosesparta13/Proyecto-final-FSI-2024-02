﻿namespace Presentacion
{
    partial class FormInquilinos
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
            this.lblmonto_Total = new System.Windows.Forms.Label();
            this.lblNombre_Usuario = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreCompleto = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgInquilinos = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgInquilinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmonto_Total
            // 
            this.lblmonto_Total.AutoSize = true;
            this.lblmonto_Total.Location = new System.Drawing.Point(211, 250);
            this.lblmonto_Total.Name = "lblmonto_Total";
            this.lblmonto_Total.Size = new System.Drawing.Size(82, 16);
            this.lblmonto_Total.TabIndex = 78;
            this.lblmonto_Total.Text = "monto_Total";
            // 
            // lblNombre_Usuario
            // 
            this.lblNombre_Usuario.AutoSize = true;
            this.lblNombre_Usuario.Location = new System.Drawing.Point(92, 412);
            this.lblNombre_Usuario.Name = "lblNombre_Usuario";
            this.lblNombre_Usuario.Size = new System.Drawing.Size(110, 16);
            this.lblNombre_Usuario.TabIndex = 77;
            this.lblNombre_Usuario.Text = "Nombre_Usuario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 76;
            this.label9.Text = "Fecha Fin";
            // 
            // dpFechaFin
            // 
            this.dpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFechaFin.Location = new System.Drawing.Point(214, 220);
            this.dpFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpFechaFin.Name = "dpFechaFin";
            this.dpFechaFin.Size = new System.Drawing.Size(145, 22);
            this.dpFechaFin.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Fecha Pago";
            // 
            // dpFechaPago
            // 
            this.dpFechaPago.CustomFormat = "dd/MM/yyyy";
            this.dpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFechaPago.Location = new System.Drawing.Point(214, 192);
            this.dpFechaPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpFechaPago.Name = "dpFechaPago";
            this.dpFechaPago.Size = new System.Drawing.Size(145, 22);
            this.dpFechaPago.TabIndex = 71;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(236, 290);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 46);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Location = new System.Drawing.Point(236, 342);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(110, 46);
            this.btnPagos.TabIndex = 69;
            this.btnPagos.Text = "Ver Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(109, 342);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 46);
            this.btnLimpiar.TabIndex = 67;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "Celular";
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(213, 130);
            this.tbCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCelular.MaxLength = 9;
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(145, 22);
            this.tbCelular.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Correo";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(214, 158);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(145, 22);
            this.tbCorreo.TabIndex = 63;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(214, 71);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDNI.MaxLength = 8;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(145, 22);
            this.tbDNI.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "DNI";
            // 
            // tbNombreCompleto
            // 
            this.tbNombreCompleto.Location = new System.Drawing.Point(214, 98);
            this.tbNombreCompleto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.Size = new System.Drawing.Size(145, 22);
            this.tbNombreCompleto.TabIndex = 60;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(109, 290);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 46);
            this.btnRegistrar.TabIndex = 59;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nombre Completo";
            // 
            // dgInquilinos
            // 
            this.dgInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInquilinos.Location = new System.Drawing.Point(388, 71);
            this.dgInquilinos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgInquilinos.Name = "dgInquilinos";
            this.dgInquilinos.RowHeadersWidth = 51;
            this.dgInquilinos.RowTemplate.Height = 24;
            this.dgInquilinos.Size = new System.Drawing.Size(419, 357);
            this.dgInquilinos.TabIndex = 57;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.barra_propietarios;
            this.pictureBox2.Location = new System.Drawing.Point(-7, -87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 616);
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 37);
            this.label8.TabIndex = 92;
            this.label8.Text = "Registro Inquilinos";
            // 
            // FormInquilinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 439);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblmonto_Total);
            this.Controls.Add(this.lblNombre_Usuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dpFechaFin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpFechaPago);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCelular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombreCompleto);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgInquilinos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormInquilinos";
            this.Text = "FormInquilinos";
            ((System.ComponentModel.ISupportInitialize)(this.dgInquilinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmonto_Total;
        private System.Windows.Forms.Label lblNombre_Usuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dpFechaFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpFechaPago;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreCompleto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgInquilinos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
    }
}