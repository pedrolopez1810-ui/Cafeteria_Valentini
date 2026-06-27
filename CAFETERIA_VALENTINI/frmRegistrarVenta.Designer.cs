namespace CAFETERIA_VALENTINI
{
    partial class frmRegistrarVenta
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVueltoValor = new System.Windows.Forms.Label();
            this.cboMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblTotalVentaValor = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnProcesarVenta = new System.Windows.Forms.Button();
            this.btnCargarPedido = new System.Windows.Forms.Button();
            this.txtMontoRecibido = new System.Windows.Forms.TextBox();
            this.txtIdPedidoVenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ingresar precio de venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Elegir categoría (Bebidas, Postres, etc.).";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(344, 35);
            this.label7.TabIndex = 29;
            this.label7.Text = "REGISTRAR VENTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ingresar el ID del pedido a cobrar";
            // 
            // lblVueltoValor
            // 
            this.lblVueltoValor.AutoSize = true;
            this.lblVueltoValor.Location = new System.Drawing.Point(193, 440);
            this.lblVueltoValor.Name = "lblVueltoValor";
            this.lblVueltoValor.Size = new System.Drawing.Size(189, 13);
            this.lblVueltoValor.TabIndex = 27;
            this.lblVueltoValor.Text = "Aquí se Mostrará el cambio a devolver";
            // 
            // cboMetodoPago
            // 
            this.cboMetodoPago.FormattingEnabled = true;
            this.cboMetodoPago.Location = new System.Drawing.Point(230, 360);
            this.cboMetodoPago.Name = "cboMetodoPago";
            this.cboMetodoPago.Size = new System.Drawing.Size(121, 21);
            this.cboMetodoPago.TabIndex = 26;
            // 
            // lblTotalVentaValor
            // 
            this.lblTotalVentaValor.AutoSize = true;
            this.lblTotalVentaValor.Location = new System.Drawing.Point(193, 328);
            this.lblTotalVentaValor.Name = "lblTotalVentaValor";
            this.lblTotalVentaValor.Size = new System.Drawing.Size(158, 13);
            this.lblTotalVentaValor.TabIndex = 25;
            this.lblTotalVentaValor.Text = "Aquí se Muestra el total a pagar";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(24, 159);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.Size = new System.Drawing.Size(566, 150);
            this.dgvDetalleVenta.TabIndex = 24;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(357, 475);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarVenta.TabIndex = 23;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnProcesarVenta
            // 
            this.btnProcesarVenta.Location = new System.Drawing.Point(172, 475);
            this.btnProcesarVenta.Name = "btnProcesarVenta";
            this.btnProcesarVenta.Size = new System.Drawing.Size(100, 23);
            this.btnProcesarVenta.TabIndex = 22;
            this.btnProcesarVenta.Text = "Procesar Venta";
            this.btnProcesarVenta.UseVisualStyleBackColor = true;
            this.btnProcesarVenta.Click += new System.EventHandler(this.btnProcesarVenta_Click);
            // 
            // btnCargarPedido
            // 
            this.btnCargarPedido.Location = new System.Drawing.Point(259, 120);
            this.btnCargarPedido.Name = "btnCargarPedido";
            this.btnCargarPedido.Size = new System.Drawing.Size(108, 23);
            this.btnCargarPedido.TabIndex = 21;
            this.btnCargarPedido.Text = "Cargar Pedido";
            this.btnCargarPedido.UseVisualStyleBackColor = true;
            this.btnCargarPedido.Click += new System.EventHandler(this.btnCargarPedido_Click);
            // 
            // txtMontoRecibido
            // 
            this.txtMontoRecibido.Location = new System.Drawing.Point(251, 396);
            this.txtMontoRecibido.Name = "txtMontoRecibido";
            this.txtMontoRecibido.Size = new System.Drawing.Size(100, 20);
            this.txtMontoRecibido.TabIndex = 20;
            this.txtMontoRecibido.TextChanged += new System.EventHandler(this.txtMontoRecibido_TextChanged);
            // 
            // txtIdPedidoVenta
            // 
            this.txtIdPedidoVenta.Location = new System.Drawing.Point(331, 84);
            this.txtIdPedidoVenta.Name = "txtIdPedidoVenta";
            this.txtIdPedidoVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdPedidoVenta.TabIndex = 19;
            // 
            // frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVueltoValor);
            this.Controls.Add(this.cboMetodoPago);
            this.Controls.Add(this.lblTotalVentaValor);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnProcesarVenta);
            this.Controls.Add(this.btnCargarPedido);
            this.Controls.Add(this.txtMontoRecibido);
            this.Controls.Add(this.txtIdPedidoVenta);
            this.Name = "frmRegistrarVenta";
            this.Text = "frmRegistrarVenta";
            this.Load += new System.EventHandler(this.frmRegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVueltoValor;
        private System.Windows.Forms.ComboBox cboMetodoPago;
        private System.Windows.Forms.Label lblTotalVentaValor;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnProcesarVenta;
        private System.Windows.Forms.Button btnCargarPedido;
        private System.Windows.Forms.TextBox txtMontoRecibido;
        private System.Windows.Forms.TextBox txtIdPedidoVenta;
    }
}