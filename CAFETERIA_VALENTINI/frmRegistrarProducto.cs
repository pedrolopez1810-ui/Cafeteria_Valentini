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
    public partial class frmRegistrarProducto : Form
    {
        public frmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtCodigoProducto.Text) || string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Código y Nombre).");
                return;
            }

            // Aquí irá el código SQL de INSERT INTO Productos...

            MessageBox.Show("Producto registrado correctamente (Simulación).");
            LimpiarCampos();
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            nudStockInicial.Value = 0;
            cboCategoria.SelectedIndex = -1;
            txtCodigoProducto.Focus();
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
