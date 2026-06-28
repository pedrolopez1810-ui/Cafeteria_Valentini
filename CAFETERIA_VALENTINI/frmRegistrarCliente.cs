using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Necesario para conectar a SQL Server

namespace CAFETERIA_VALENTINI
{
    public partial class frmRegistrarCliente : Form
    {
        public frmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // 2. Definir la cadena de conexión
            // IMPORTANTE: Cambia "TU_SERVIDOR" por el nombre de tu servidor de SQL Server (ej. "localhost", "SQLEXPRESS", etc.)
            string cadenaConexion = "Server=PC-PEDROPE\\SQLEXPRESS;Database=CafeteriaValentini;Integrated Security=True;";

            // 3. Crear la consulta SQL (Asegúrate de que las columnas se llamen así en tu tabla Clientes)
            string query = "INSERT INTO Clientes (DNI, Nombre, Telefono) VALUES (@DNI, @Nombres, @Telefono)";

            // 4. Ejecutar la conexión y el comando
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Pasar los valores de las cajas de texto a los parámetros de SQL
                        comando.Parameters.AddWithValue("@DNI", txtDNI.Text);
                        comando.Parameters.AddWithValue("@Nombres", txtNombres.Text);
                        comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text);

                        // Ejecutar la inserción
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente registrado exitosamente.");

                            // Limpiar las cajas de texto para un nuevo registro
                            txtDNI.Clear();
                            txtNombres.Clear();
                            txtTelefono.Clear();
                            txtDNI.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el cliente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
