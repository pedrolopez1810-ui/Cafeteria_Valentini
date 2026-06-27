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
    public partial class frmRegistrarVenta : Form
    {
        public frmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void frmRegistrarVenta_Load(object sender, EventArgs e)
        {
            dgvDetalleVenta.Columns.Add("Producto", "Producto");
            dgvDetalleVenta.Columns.Add("Subtotal", "Subtotal");
            cboMetodoPago.Items.AddRange(new string[] { "Efectivo", "Tarjeta", "Yape" });
        }

        private void btnCargarPedido_Click(object sender, EventArgs e)
        {
            // Simulación de carga de pedido
            dgvDetalleVenta.Rows.Clear();
            dgvDetalleVenta.Rows.Add("Café Americano", "5.00");
            lblTotalVentaValor.Text = "5.00";
        }

        private void txtMontoRecibido_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMontoRecibido.Text, out decimal montoRecibido) &&
                decimal.TryParse(lblTotalVentaValor.Text, out decimal total))
            {
                decimal vuelto = montoRecibido - total;
                lblVueltoValor.Text = vuelto >= 0 ? vuelto.ToString("0.00") : "Falta dinero";
            }
            else
            {
                lblVueltoValor.Text = "0.00";
            }
        }

        private void btnProcesarVenta_Click(object sender, EventArgs e)
        {
            if (cboMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un método de pago.");
                return;
            }

            // Aquí irá el INSERT en la tabla Ventas
            MessageBox.Show("Venta registrada con éxito.");
            this.Close();
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
