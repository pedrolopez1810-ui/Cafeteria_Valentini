using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CAFETERIA_VALENTINI
{
    public partial class frmRegistrarPedido : Form
    {
        private decimal totalPagar = 0;

        // Usa la cadena de conexión que creamos antes
        string cadenaConexion = Conexion.cadena;


        public frmRegistrarPedido()
        {
            InitializeComponent();
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    // Consulta para obtener nombre y precio
                    string query = "SELECT IDProducto, Nombre, Precio FROM Productos";
                    SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Configurar el ComboBox
                    cboProducto.DataSource = dt;
                    cboProducto.DisplayMember = "Nombre"; // Lo que ve el usuario
                    cboProducto.ValueMember = "IDProducto"; // El valor oculto (ID)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void frmRegistrarPedido_Load(object sender, EventArgs e)
        {

            CargarProductos();
            // Configurar columnas de la grilla
            //dgvDetallePedido.Columns.Add("Producto", "Producto");
            //dgvDetallePedido.Columns.Add("Cantidad", "Cantidad");
            //dgvDetallePedido.Columns.Add("Precio", "Precio Unit.");
            //dgvDetallePedido.Columns.Add("Subtotal", "Subtotal");

            // Cargar datos de prueba en el ComboBox temporalmente
            //cboProducto.Items.Add("Café Americano - 5.00");
            //cboProducto.Items.Add("Empanada de Carne - 4.50");
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex == -1 || nudCantidad.Value == 0)
            {
                MessageBox.Show("Seleccione un producto y una cantidad válida.");
                return;
            }

            // 1. Obtener los datos del producto seleccionado (usando DataRowView)
            DataRowView row = (DataRowView)cboProducto.SelectedItem;

            string nombre = row["Nombre"].ToString();

            // Convertimos el valor de la columna "Precio" a decimal
            decimal precio = Convert.ToDecimal(row["Precio"]);

            // 2. Obtener la cantidad ingresada
            int cantidad = (int)nudCantidad.Value;

            // 3. Calcular el subtotal
            decimal subtotal = precio * cantidad;

            // 4. Agregar a la grilla (DataGridView)
            dgvDetallePedido.Rows.Add(nombre, cantidad, precio, subtotal);

            // 5. Actualizar Total
            // (Asumiendo que 'totalPagar' ya está declarada al inicio de tu clase/formulario)
            totalPagar += subtotal;
            lblTotalPagar.Text = totalPagar.ToString("0.00");





            
            // Cálculos matemáticos basados en el prototipo
            //decimal total = listaVentas.Sum(v => v.Subtotal);
            decimal valorVenta = totalPagar / 1.18m; // Se divide para extraer la base sin IGV
            decimal igv = totalPagar - valorVenta;

            // Mostrar en los TextBox con el símbolo de moneda y 2 decimales
            txtValorVenta.Text = "S/ " + valorVenta.ToString("N2");
            txtIGV.Text = "S/ " + igv.ToString("N2");
            txtTotal.Text = "S/ " + totalPagar.ToString("N2");






            // Simulación de extracción de datos (Esto se reemplazará con Base de Datos)
            //string producto = cboProducto.SelectedItem.ToString().Split('-')[0].Trim();
            //decimal precio = Convert.ToDecimal(cboProducto.SelectedItem.ToString().Split('-')[1].Trim());
            //int cantidad = (int)nudCantidad.Value;
            //decimal subtotal = precio * cantidad;

            // Agregar a la grilla
            //dgvDetallePedido.Rows.Add(producto, cantidad, precio, subtotal);

            // Actualizar Total
            //totalPagar += subtotal;
            //lblTotalPagar.Text = totalPagar.ToString("0.00");
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un DNI
            if (string.IsNullOrWhiteSpace(txtDniCliente.Text))
            {
                MessageBox.Show("Por favor, ingrese un DNI para buscar.");
                return;
            }

            // Tu cadena de conexión (recuerda cambiar "TU_SERVIDOR")
            string cadenaConexion = "Server=PC-PEDROPE\\SQLEXPRESS;Database=CafeteriaValentini;Integrated Security=True;";

            // Consulta SQL para buscar solo por el DNI ingresado
            string query = "SELECT Nombre FROM Clientes WHERE DNI = @DNI";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@DNI", txtDniCliente.Text);

                        // Ejecutamos el lector de datos
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read()) // Si Read() es true, significa que encontró un registro
                            {
                                // Jalamos el nombre y lo mostramos en el textbox
                                txtNombreCliente.Text = reader["Nombre"].ToString();
                            }
                            else
                            {
                                // Si es false, no encontró el DNI
                                MessageBox.Show("Cliente no encontrado. Se abrirá la ventana para registrarlo.");

                                // Instanciamos y abrimos el formulario de registro
                                frmRegistrarCliente frmRegistro = new frmRegistrarCliente();
                                frmRegistro.ShowDialog(); // ShowDialog pausa este formulario hasta que cierres el de registro
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el cliente: " + ex.Message);
                }
            }
        }
    }
}
