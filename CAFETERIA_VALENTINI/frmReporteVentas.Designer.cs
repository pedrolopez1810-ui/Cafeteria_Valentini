namespace CAFETERIA_VALENTINI
{
    partial class frmReporteVentas
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
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnCerrarReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReporteVentas = new System.Windows.Forms.DataGridView();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblIngresoTotalValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Seleccionar fecha de fin del reporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Seleccionar fecha de inicio del reporte";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(151, 443);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(170, 23);
            this.btnExportarExcel.TabIndex = 28;
            this.btnExportarExcel.Text = "Exportar Reporte a Excel ";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.frmReporteVentas_Load);
            // 
            // btnCerrarReporte
            // 
            this.btnCerrarReporte.Location = new System.Drawing.Point(404, 443);
            this.btnCerrarReporte.Name = "btnCerrarReporte";
            this.btnCerrarReporte.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarReporte.TabIndex = 27;
            this.btnCerrarReporte.Text = "Cerrar";
            this.btnCerrarReporte.UseVisualStyleBackColor = true;
            this.btnCerrarReporte.Click += new System.EventHandler(this.btnCerrarReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Suma total de las ventas:   S/";
            // 
            // dgvReporteVentas
            // 
            this.dgvReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteVentas.Location = new System.Drawing.Point(25, 230);
            this.dgvReporteVentas.Name = "dgvReporteVentas";
            this.dgvReporteVentas.Size = new System.Drawing.Size(583, 149);
            this.dgvReporteVentas.TabIndex = 25;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(250, 192);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(137, 23);
            this.btnGenerarReporte.TabIndex = 24;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(317, 152);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 35);
            this.label4.TabIndex = 22;
            this.label4.Text = "REPORTE DE VENTAS";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(317, 115);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 21;
            // 
            // lblIngresoTotalValor
            // 
            this.lblIngresoTotalValor.AutoSize = true;
            this.lblIngresoTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoTotalValor.Location = new System.Drawing.Point(524, 398);
            this.lblIngresoTotalValor.Name = "lblIngresoTotalValor";
            this.lblIngresoTotalValor.Size = new System.Drawing.Size(57, 20);
            this.lblIngresoTotalValor.TabIndex = 31;
            this.lblIngresoTotalValor.Text = "label5";
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 502);
            this.Controls.Add(this.lblIngresoTotalValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnCerrarReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReporteVentas);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "frmReporteVentas";
            this.Text = "frmReporteVentas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnCerrarReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReporteVentas;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblIngresoTotalValor;
    }
}