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
            this.lblNombrePropiedad = new System.Windows.Forms.Label();
            this.dpFecha = new System.Windows.Forms.DateTimePicker();
            this.tbNombrePropiedad = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cmbMetodosPago = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgPagos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(451, 135);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(81, 30);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblNombrePropiedad
            // 
            this.lblNombrePropiedad.AutoSize = true;
            this.lblNombrePropiedad.Location = new System.Drawing.Point(25, 74);
            this.lblNombrePropiedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombrePropiedad.Name = "lblNombrePropiedad";
            this.lblNombrePropiedad.Size = new System.Drawing.Size(129, 13);
            this.lblNombrePropiedad.TabIndex = 1;
            this.lblNombrePropiedad.Text = "Nombre de la propiedad : ";
            // 
            // dpFecha
            // 
            this.dpFecha.Location = new System.Drawing.Point(133, 102);
            this.dpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(133, 20);
            this.dpFecha.TabIndex = 2;
            // 
            // tbNombrePropiedad
            // 
            this.tbNombrePropiedad.Location = new System.Drawing.Point(155, 72);
            this.tbNombrePropiedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombrePropiedad.Name = "tbNombrePropiedad";
            this.tbNombrePropiedad.Size = new System.Drawing.Size(93, 20);
            this.tbNombrePropiedad.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(25, 106);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(107, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha y hora actual :";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(283, 76);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 13);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto :";
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(329, 74);
            this.tbMonto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(93, 20);
            this.tbMonto.TabIndex = 6;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(329, 133);
            this.tbEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(93, 20);
            this.tbEstado.TabIndex = 7;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(280, 105);
            this.lblMetodo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(91, 13);
            this.lblMetodo.TabIndex = 8;
            this.lblMetodo.Text = "Método de pago :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(280, 135);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 135);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre :";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(77, 135);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(93, 20);
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
            this.cmbMetodosPago.Location = new System.Drawing.Point(373, 103);
            this.cmbMetodosPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMetodosPago.Name = "cmbMetodosPago";
            this.cmbMetodosPago.Size = new System.Drawing.Size(97, 21);
            this.cmbMetodosPago.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(451, 370);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 30);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgPagos
            // 
            this.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagos.Location = new System.Drawing.Point(19, 179);
            this.dgPagos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgPagos.Name = "dgPagos";
            this.dgPagos.RowHeadersWidth = 62;
            this.dgPagos.RowTemplate.Height = 28;
            this.dgPagos.Size = new System.Drawing.Size(503, 178);
            this.dgPagos.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(200, 19);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(74, 13);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "Registro Pago";
            // 
            // FormPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 408);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgPagos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbMetodosPago);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.tbNombrePropiedad);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.lblNombrePropiedad);
            this.Controls.Add(this.btnPagar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPagos";
            this.Text = "FormPagos";
            this.Load += new System.EventHandler(this.FormPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblNombrePropiedad;
        private System.Windows.Forms.DateTimePicker dpFecha;
        private System.Windows.Forms.TextBox tbNombrePropiedad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cmbMetodosPago;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgPagos;
        private System.Windows.Forms.Label lblTitulo;
    }
}