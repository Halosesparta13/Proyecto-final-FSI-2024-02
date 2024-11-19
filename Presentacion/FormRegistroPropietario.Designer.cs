﻿namespace Presentacion
{
    partial class FormRegistroPropietario
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
            this.label8 = new System.Windows.Forms.Label();
            this.tbRUC = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreCompleto = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPropietarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPropietarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "RUC";
            // 
            // tbRUC
            // 
            this.tbRUC.Location = new System.Drawing.Point(151, 239);
            this.tbRUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRUC.MaxLength = 11;
            this.tbRUC.Name = "tbRUC";
            this.tbRUC.Size = new System.Drawing.Size(145, 22);
            this.tbRUC.TabIndex = 38;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(93, 320);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 44);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(262, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Registro Propietarios";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(163, 272);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 44);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Celular";
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(152, 213);
            this.tbCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCelular.MaxLength = 9;
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(145, 22);
            this.tbCelular.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Contraseña";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(152, 185);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(145, 22);
            this.tbContraseña.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Correo";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(152, 157);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(145, 22);
            this.tbCorreo.TabIndex = 28;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(152, 131);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDNI.MaxLength = 8;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(145, 22);
            this.tbDNI.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "DNI";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(152, 103);
            this.tbNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(145, 22);
            this.tbNombreUsuario.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre Usuario";
            // 
            // tbNombreCompleto
            // 
            this.tbNombreCompleto.Location = new System.Drawing.Point(152, 75);
            this.tbNombreCompleto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.Size = new System.Drawing.Size(145, 22);
            this.tbNombreCompleto.TabIndex = 23;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(37, 272);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(111, 44);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre Completo";
            // 
            // dgPropietarios
            // 
            this.dgPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPropietarios.Location = new System.Drawing.Point(326, 58);
            this.dgPropietarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPropietarios.Name = "dgPropietarios";
            this.dgPropietarios.RowHeadersWidth = 51;
            this.dgPropietarios.RowTemplate.Height = 24;
            this.dgPropietarios.Size = new System.Drawing.Size(403, 367);
            this.dgPropietarios.TabIndex = 20;
            // 
            // FormRegistroPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbRUC);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombreCompleto);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPropietarios);
            this.Name = "FormRegistroPropietario";
            this.Text = "FormPropietarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgPropietarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRUC;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreCompleto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPropietarios;
    }
}