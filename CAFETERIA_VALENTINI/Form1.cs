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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            frmRegistrarPedido frm = new frmRegistrarPedido();
            frm.ShowDialog();
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            frmRegistrarProducto frm = new frmRegistrarProducto();
            frm.ShowDialog();
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            frmBuscarPedido frm = new frmBuscarPedido();
            frm.ShowDialog();
        }

        private void btnActualizarInventario_Click(object sender, EventArgs e)
        {
            frmActualizarInventario frm = new frmActualizarInventario();
            frm.ShowDialog();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            frmRegistrarVenta frm = new frmRegistrarVenta();
            frm.ShowDialog();
        }

        private void btnConsultarInventario_Click(object sender, EventArgs e)
        {
            frmConsultarInventario frm = new frmConsultarInventario();
            frm.ShowDialog();
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            frmReporteVentas frm = new frmReporteVentas();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
