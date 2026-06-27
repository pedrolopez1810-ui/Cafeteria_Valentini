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
    public partial class frmConsultarInventario : Form
    {
        public frmConsultarInventario()
        {
            InitializeComponent();
        }

        private void frmConsultarInventario_Load(object sender, EventArgs e)
        {
            dgvInventarioGeneral.Columns.Add("Codigo", "Código");
            dgvInventarioGeneral.Columns.Add("Producto", "Producto");
            dgvInventarioGeneral.Columns.Add("Categoria", "Categoría");
            dgvInventarioGeneral.Columns.Add("Stock", "Stock Actual");
            dgvInventarioGeneral.Columns.Add("Precio", "Precio");
        }

        private void btnActualizarVista_Click(object sender, EventArgs e)
        {
            // Simulación de SELECT * FROM Productos
            dgvInventarioGeneral.Rows.Clear();
            dgvInventarioGeneral.Rows.Add("P01", "Café Americano", "Bebidas", "50", "5.00");
        }

        private void btnSalirInventario_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
