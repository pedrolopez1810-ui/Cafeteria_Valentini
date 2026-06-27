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
    public partial class frmActualizarInventario : Form
    {
        public frmActualizarInventario()
        {
            InitializeComponent();
        }

        private void frmActualizarInventario_Load(object sender, EventArgs e)
        {
            cboSeleccionarProducto.Items.Add("Café Americano");
            cboMotivoAjuste.Items.Add("Ingreso por Compra");
            cboMotivoAjuste.Items.Add("Merma");
        }

        private void cboSeleccionarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Simula cargar el stock actual desde la BD
            lblStockActualValor.Text = "50";
        }

        private void btnActualizarStock_Click(object sender, EventArgs e)
        {
            if (cboSeleccionarProducto.SelectedIndex == -1 || nudCantidadAjuste.Value == 0)
            {
                MessageBox.Show("Seleccione un producto y una cantidad.");
                return;
            }

            // Aquí irá el UPDATE en la base de datos
            MessageBox.Show("Inventario actualizado correctamente.");
            lblStockActualValor.Text = "0";
            nudCantidadAjuste.Value = 0;
            cboSeleccionarProducto.SelectedIndex = -1;
        }

        private void btnCancelarAjuste_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
