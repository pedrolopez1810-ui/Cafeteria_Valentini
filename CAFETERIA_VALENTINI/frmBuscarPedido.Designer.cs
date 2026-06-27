namespace CAFETERIA_VALENTINI
{
    partial class frmBuscarPedido
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
            this.btnVerDetallePedido = new System.Windows.Forms.Button();
            this.dgvResultadosPedidos = new System.Windows.Forms.DataGridView();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.txtFiltroBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 35);
            this.label4.TabIndex = 19;
            this.label4.Text = "BUSCAR PEDIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Seleccionar fecha para filtrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ingresar ID de pedido o DNI del cliente.";
            // 
            // btnVerDetallePedido
            // 
            this.btnVerDetallePedido.Location = new System.Drawing.Point(231, 379);
            this.btnVerDetallePedido.Name = "btnVerDetallePedido";
            this.btnVerDetallePedido.Size = new System.Drawing.Size(141, 23);
            this.btnVerDetallePedido.TabIndex = 16;
            this.btnVerDetallePedido.Text = "Ver Detalle Pedido";
            this.btnVerDetallePedido.UseVisualStyleBackColor = true;
            this.btnVerDetallePedido.Click += new System.EventHandler(this.btnVerDetallePedido_Click);
            // 
            // dgvResultadosPedidos
            // 
            this.dgvResultadosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosPedidos.Location = new System.Drawing.Point(25, 232);
            this.dgvResultadosPedidos.Name = "dgvResultadosPedidos";
            this.dgvResultadosPedidos.Size = new System.Drawing.Size(545, 130);
            this.dgvResultadosPedidos.TabIndex = 15;
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.Location = new System.Drawing.Point(240, 190);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPedido.TabIndex = 14;
            this.btnBuscarPedido.Text = "Buscar";
            this.btnBuscarPedido.UseVisualStyleBackColor = true;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Location = new System.Drawing.Point(287, 147);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPedido.TabIndex = 13;
            // 
            // txtFiltroBusqueda
            // 
            this.txtFiltroBusqueda.Location = new System.Drawing.Point(287, 111);
            this.txtFiltroBusqueda.Name = "txtFiltroBusqueda";
            this.txtFiltroBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroBusqueda.TabIndex = 12;
            // 
            // frmBuscarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerDetallePedido);
            this.Controls.Add(this.dgvResultadosPedidos);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.dtpFechaPedido);
            this.Controls.Add(this.txtFiltroBusqueda);
            this.Name = "frmBuscarPedido";
            this.Text = "frmBuscarPedido";
            this.Load += new System.EventHandler(this.frmBuscarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerDetallePedido;
        private System.Windows.Forms.DataGridView dgvResultadosPedidos;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.TextBox txtFiltroBusqueda;
    }
}