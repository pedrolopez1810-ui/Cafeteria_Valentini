namespace CAFETERIA_VALENTINI
{
    partial class frmConsultarInventario
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvInventarioGeneral = new System.Windows.Forms.DataGridView();
            this.cboFiltroCategoriaInv = new System.Windows.Forms.ComboBox();
            this.txtBuscarInventario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "En esta grilla se mostrará todos los productyos y su stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(452, 35);
            this.label4.TabIndex = 20;
            this.label4.Text = "CONSULTAR INVENTARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Filtrar tabla por categoría";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Escribir nombre para filtrar rápido";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSalirInventario_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Actualizar Vista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnActualizarVista_Click);
            // 
            // dgvInventarioGeneral
            // 
            this.dgvInventarioGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioGeneral.Location = new System.Drawing.Point(19, 170);
            this.dgvInventarioGeneral.Name = "dgvInventarioGeneral";
            this.dgvInventarioGeneral.Size = new System.Drawing.Size(604, 160);
            this.dgvInventarioGeneral.TabIndex = 15;
            // 
            // cboFiltroCategoriaInv
            // 
            this.cboFiltroCategoriaInv.FormattingEnabled = true;
            this.cboFiltroCategoriaInv.Location = new System.Drawing.Point(165, 122);
            this.cboFiltroCategoriaInv.Name = "cboFiltroCategoriaInv";
            this.cboFiltroCategoriaInv.Size = new System.Drawing.Size(121, 21);
            this.cboFiltroCategoriaInv.TabIndex = 14;
            // 
            // txtBuscarInventario
            // 
            this.txtBuscarInventario.Location = new System.Drawing.Point(186, 85);
            this.txtBuscarInventario.Name = "txtBuscarInventario";
            this.txtBuscarInventario.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarInventario.TabIndex = 13;
            // 
            // frmConsultarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 427);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvInventarioGeneral);
            this.Controls.Add(this.cboFiltroCategoriaInv);
            this.Controls.Add(this.txtBuscarInventario);
            this.Name = "frmConsultarInventario";
            this.Text = "frmConsultarInventario";
            this.Load += new System.EventHandler(this.frmConsultarInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvInventarioGeneral;
        private System.Windows.Forms.ComboBox cboFiltroCategoriaInv;
        private System.Windows.Forms.TextBox txtBuscarInventario;
    }
}