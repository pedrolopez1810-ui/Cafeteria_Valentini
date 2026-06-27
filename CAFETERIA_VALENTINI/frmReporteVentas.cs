using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFETERIA_VALENTINI
{
    public partial class frmReporteVentas : Form
    {
        public frmReporteVentas()
        {
            InitializeComponent();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            dgvReporteVentas.Columns.Add("IDVenta", "ID Venta");
            dgvReporteVentas.Columns.Add("Fecha", "Fecha");
            dgvReporteVentas.Columns.Add("Total", "Total");
            dgvReporteVentas.Columns.Add("Metodo", "Método Pago");
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // Simulación de SELECT SUM(Total) FROM Ventas WHERE Fecha BETWEEN Inicio AND Fin
            dgvReporteVentas.Rows.Clear();
            dgvReporteVentas.Rows.Add("V001", DateTime.Now.ToShortDateString(), "15.00", "Yape");
            lblIngresoTotalValor.Text = "15.00";
        }

        private void btnCerrarReporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
