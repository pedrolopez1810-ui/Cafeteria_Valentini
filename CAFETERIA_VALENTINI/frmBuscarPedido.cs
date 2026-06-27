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
    public partial class frmBuscarPedido : Form
    {
        public frmBuscarPedido()
        {
            InitializeComponent();
        }

        private void frmBuscarPedido_Load(object sender, EventArgs e)
        {
            dgvResultadosPedidos.Columns.Add("ID", "ID Pedido");
            dgvResultadosPedidos.Columns.Add("Cliente", "Cliente");
            dgvResultadosPedidos.Columns.Add("Fecha", "Fecha");
            dgvResultadosPedidos.Columns.Add("Total", "Total");
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            // Simulación de búsqueda. Se reemplazará con un SELECT a la BD usando txtFiltroBusqueda.Text
            dgvResultadosPedidos.Rows.Clear();
            dgvResultadosPedidos.Rows.Add("001", "Juan Perez", dtpFechaPedido.Value.ToShortDateString(), "25.50");
        }

        private void btnVerDetallePedido_Click(object sender, EventArgs e)
        {
            if (dgvResultadosPedidos.CurrentRow != null)
            {
                string id = dgvResultadosPedidos.CurrentRow.Cells["ID"].Value.ToString();
                MessageBox.Show($"Mostrando detalles del pedido {id} (Simulación)");
            }
            else
            {
                MessageBox.Show("Seleccione un pedido de la lista.");
            }
        }

    }
}
