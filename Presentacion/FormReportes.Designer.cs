namespace Presentacion
{
    partial class FormReportes
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
            this.btnReporte1 = new System.Windows.Forms.Button();
            this.btnReporte2 = new System.Windows.Forms.Button();
            this.btnReporte3 = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label123 = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.tbNumeroHabitaciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReporte1
            // 
            this.btnReporte1.Location = new System.Drawing.Point(83, 62);
            this.btnReporte1.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte1.Name = "btnReporte1";
            this.btnReporte1.Size = new System.Drawing.Size(264, 63);
            this.btnReporte1.TabIndex = 0;
            this.btnReporte1.Text = "Ordenar Inmuebles registrados por precio de alquiler";
            this.btnReporte1.UseVisualStyleBackColor = true;
            this.btnReporte1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporte2
            // 
            this.btnReporte2.Location = new System.Drawing.Point(83, 184);
            this.btnReporte2.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte2.Name = "btnReporte2";
            this.btnReporte2.Size = new System.Drawing.Size(264, 63);
            this.btnReporte2.TabIndex = 1;
            this.btnReporte2.Text = "Ordenar Inmuebles registrados por tipo de inmueble";
            this.btnReporte2.UseVisualStyleBackColor = true;
            this.btnReporte2.Click += new System.EventHandler(this.btnReporte2_Click);
            // 
            // btnReporte3
            // 
            this.btnReporte3.Location = new System.Drawing.Point(83, 291);
            this.btnReporte3.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte3.Name = "btnReporte3";
            this.btnReporte3.Size = new System.Drawing.Size(264, 63);
            this.btnReporte3.TabIndex = 2;
            this.btnReporte3.Text = "Ordenar de forma ascede inmuebles por número de habitaciones";
            this.btnReporte3.UseVisualStyleBackColor = true;
            this.btnReporte3.Click += new System.EventHandler(this.btnReporte3_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(370, 62);
            this.dgvReporte.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.Size = new System.Drawing.Size(546, 351);
            this.dgvReporte.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.barra_propietarios;
            this.pictureBox2.Location = new System.Drawing.Point(-4, -43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 576);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(144, 362);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 51);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 37);
            this.label8.TabIndex = 94;
            this.label8.Text = "Reportes";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Casa",
            "Departamento",
            "Terreno"});
            this.cbTipo.Location = new System.Drawing.Point(175, 153);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(172, 24);
            this.cbTipo.TabIndex = 100;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(90, 158);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(62, 16);
            this.label123.TabIndex = 99;
            this.label123.Text = "Tipo Inm.";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Location = new System.Drawing.Point(80, 440);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(75, 16);
            this.lbNombreUsuario.TabIndex = 101;
            this.lbNombreUsuario.Text = "Bienvenido";
            // 
            // tbNumeroHabitaciones
            // 
            this.tbNumeroHabitaciones.Location = new System.Drawing.Point(224, 262);
            this.tbNumeroHabitaciones.Name = "tbNumeroHabitaciones";
            this.tbNumeroHabitaciones.Size = new System.Drawing.Size(123, 22);
            this.tbNumeroHabitaciones.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 103;
            this.label1.Text = "N# de habitaciones";
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 492);
            this.Controls.Add(this.tbNumeroHabitaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.btnReporte3);
            this.Controls.Add(this.btnReporte2);
            this.Controls.Add(this.btnReporte1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReporte1;
        private System.Windows.Forms.Button btnReporte2;
        private System.Windows.Forms.Button btnReporte3;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.TextBox tbNumeroHabitaciones;
        private System.Windows.Forms.Label label1;
    }
}