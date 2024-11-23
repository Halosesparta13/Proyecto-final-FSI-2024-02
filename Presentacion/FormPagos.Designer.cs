namespace Presentacion
{
    partial class FormPagos
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
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cmbMetodosPago = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgPagos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre_Usuario = new System.Windows.Forms.Label();
            this.pictureBoxInmobiliario = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInmobiliario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(344, 191);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(108, 37);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(5, 23);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(50, 16);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto :";
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(67, 20);
            this.tbMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(123, 22);
            this.tbMonto.TabIndex = 6;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(228, 22);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(113, 16);
            this.lblMetodo.TabIndex = 8;
            this.lblMetodo.Text = "Método de pago :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(228, 62);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 16);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre :";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(67, 56);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(123, 22);
            this.tbNombre.TabIndex = 12;
            // 
            // cmbMetodosPago
            // 
            this.cmbMetodosPago.FormattingEnabled = true;
            this.cmbMetodosPago.Items.AddRange(new object[] {
            "Yape",
            "Plin ",
            "Tarjeta ",
            "Efectivo"});
            this.cmbMetodosPago.Location = new System.Drawing.Point(352, 20);
            this.cmbMetodosPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMetodosPago.Name = "cmbMetodosPago";
            this.cmbMetodosPago.Size = new System.Drawing.Size(128, 24);
            this.cmbMetodosPago.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(458, 191);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 37);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgPagos
            // 
            this.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagos.Location = new System.Drawing.Point(86, 232);
            this.dgPagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPagos.Name = "dgPagos";
            this.dgPagos.RowHeadersWidth = 62;
            this.dgPagos.RowTemplate.Height = 28;
            this.dgPagos.Size = new System.Drawing.Size(671, 219);
            this.dgPagos.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(314, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 37);
            this.label8.TabIndex = 93;
            this.label8.Text = "Registro Pago";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(352, 56);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(128, 24);
            this.cbEstado.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.cmbMetodosPago);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblMetodo);
            this.groupBox1.Controls.Add(this.tbMonto);
            this.groupBox1.Controls.Add(this.lblMonto);
            this.groupBox1.Location = new System.Drawing.Point(86, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 91);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pago";
            // 
            // lblNombre_Usuario
            // 
            this.lblNombre_Usuario.AutoSize = true;
            this.lblNombre_Usuario.Location = new System.Drawing.Point(83, 470);
            this.lblNombre_Usuario.Name = "lblNombre_Usuario";
            this.lblNombre_Usuario.Size = new System.Drawing.Size(110, 16);
            this.lblNombre_Usuario.TabIndex = 97;
            this.lblNombre_Usuario.Text = "Nombre_Usuario";
            // 
            // pictureBoxInmobiliario
            // 
            this.pictureBoxInmobiliario.Image = global::Presentacion.Properties.Resources.pagos;
            this.pictureBoxInmobiliario.Location = new System.Drawing.Point(577, 60);
            this.pictureBoxInmobiliario.Name = "pictureBoxInmobiliario";
            this.pictureBoxInmobiliario.Size = new System.Drawing.Size(180, 139);
            this.pictureBoxInmobiliario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInmobiliario.TabIndex = 96;
            this.pictureBoxInmobiliario.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.barra_propietarios;
            this.pictureBox2.Location = new System.Drawing.Point(-7, -35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 576);
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // FormPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 498);
            this.Controls.Add(this.lblNombre_Usuario);
            this.Controls.Add(this.pictureBoxInmobiliario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgPagos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPagar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPagos";
            this.Text = "FormPagos";
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInmobiliario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cmbMetodosPago;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgPagos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxInmobiliario;
        private System.Windows.Forms.Label lblNombre_Usuario;
    }
}