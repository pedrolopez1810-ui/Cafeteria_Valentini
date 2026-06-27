namespace CAFETERIA_VALENTINI
{
    partial class frmActualizarInventario
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarAjuste = new System.Windows.Forms.Button();
            this.btnActualizarStock = new System.Windows.Forms.Button();
            this.cboMotivoAjuste = new System.Windows.Forms.ComboBox();
            this.nudCantidadAjuste = new System.Windows.Forms.NumericUpDown();
            this.lblStockActualValor = new System.Windows.Forms.Label();
            this.lblStockActualTexto = new System.Windows.Forms.Label();
            this.cboSeleccionarProducto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAjuste)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(463, 35);
            this.label4.TabIndex = 21;
            this.label4.Text = "ACTUALIZAR INVENTARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Elegir (Ingreso por compra, Merma, etc.).";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cantidad a sumar o restar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Elegir el producto a actualizar";
            // 
            // btnCancelarAjuste
            // 
            this.btnCancelarAjuste.Location = new System.Drawing.Point(326, 328);
            this.btnCancelarAjuste.Name = "btnCancelarAjuste";
            this.btnCancelarAjuste.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAjuste.TabIndex = 17;
            this.btnCancelarAjuste.Text = "Cancelar";
            this.btnCancelarAjuste.UseVisualStyleBackColor = true;
            this.btnCancelarAjuste.Click += new System.EventHandler(this.btnCancelarAjuste_Click);
            // 
            // btnActualizarStock
            // 
            this.btnActualizarStock.Location = new System.Drawing.Point(121, 328);
            this.btnActualizarStock.Name = "btnActualizarStock";
            this.btnActualizarStock.Size = new System.Drawing.Size(123, 23);
            this.btnActualizarStock.TabIndex = 16;
            this.btnActualizarStock.Text = "Actualizar Inventario";
            this.btnActualizarStock.UseVisualStyleBackColor = true;
            this.btnActualizarStock.Click += new System.EventHandler(this.btnActualizarStock_Click);
            // 
            // cboMotivoAjuste
            // 
            this.cboMotivoAjuste.FormattingEnabled = true;
            this.cboMotivoAjuste.Location = new System.Drawing.Point(147, 258);
            this.cboMotivoAjuste.Name = "cboMotivoAjuste";
            this.cboMotivoAjuste.Size = new System.Drawing.Size(121, 21);
            this.cboMotivoAjuste.TabIndex = 15;
            // 
            // nudCantidadAjuste
            // 
            this.nudCantidadAjuste.Location = new System.Drawing.Point(148, 220);
            this.nudCantidadAjuste.Name = "nudCantidadAjuste";
            this.nudCantidadAjuste.Size = new System.Drawing.Size(120, 20);
            this.nudCantidadAjuste.TabIndex = 14;
            // 
            // lblStockActualValor
            // 
            this.lblStockActualValor.AutoSize = true;
            this.lblStockActualValor.Location = new System.Drawing.Point(247, 159);
            this.lblStockActualValor.Name = "lblStockActualValor";
            this.lblStockActualValor.Size = new System.Drawing.Size(215, 13);
            this.lblStockActualValor.TabIndex = 13;
            this.lblStockActualValor.Text = "Aquí se Mostrará el número del stock actual";
            // 
            // lblStockActualTexto
            // 
            this.lblStockActualTexto.AutoSize = true;
            this.lblStockActualTexto.Location = new System.Drawing.Point(144, 159);
            this.lblStockActualTexto.Name = "lblStockActualTexto";
            this.lblStockActualTexto.Size = new System.Drawing.Size(91, 13);
            this.lblStockActualTexto.TabIndex = 12;
            this.lblStockActualTexto.Text = "STOCK ACTUAL:";
            // 
            // cboSeleccionarProducto
            // 
            this.cboSeleccionarProducto.FormattingEnabled = true;
            this.cboSeleccionarProducto.Location = new System.Drawing.Point(250, 113);
            this.cboSeleccionarProducto.Name = "cboSeleccionarProducto";
            this.cboSeleccionarProducto.Size = new System.Drawing.Size(121, 21);
            this.cboSeleccionarProducto.TabIndex = 11;
            this.cboSeleccionarProducto.SelectedIndexChanged += new System.EventHandler(this.cboSeleccionarProducto_SelectedIndexChanged);
            // 
            // frmActualizarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelarAjuste);
            this.Controls.Add(this.btnActualizarStock);
            this.Controls.Add(this.cboMotivoAjuste);
            this.Controls.Add(this.nudCantidadAjuste);
            this.Controls.Add(this.lblStockActualValor);
            this.Controls.Add(this.lblStockActualTexto);
            this.Controls.Add(this.cboSeleccionarProducto);
            this.Name = "frmActualizarInventario";
            this.Text = "frmActualizarInventario";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAjuste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelarAjuste;
        private System.Windows.Forms.Button btnActualizarStock;
        private System.Windows.Forms.ComboBox cboMotivoAjuste;
        private System.Windows.Forms.NumericUpDown nudCantidadAjuste;
        private System.Windows.Forms.Label lblStockActualValor;
        private System.Windows.Forms.Label lblStockActualTexto;
        private System.Windows.Forms.ComboBox cboSeleccionarProducto;
    }
}