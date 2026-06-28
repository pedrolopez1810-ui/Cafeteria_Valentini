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
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txtDNI.Focus(); // Pone el cursor en la primera caja de texto
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos de registro no estén vacíos
            if (string.IsNullOrWhiteSpace(txtDNI.Text) || string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtUsuarioNuevo.Text) || string.IsNullOrWhiteSpace(txtClaveNueva.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos del nuevo usuario.");
                return;
            }

            // Recuerda poner el nombre de tu servidor, por lo que veo en tu captura podría ser: "Server=PC-PEDROPE\\SQLEXPRESS;..."
            string cadenaConexion = "Server=PC-PEDROPE\\SQLEXPRESS;Database=CafeteriaValentini;Integrated Security=True;";
            string query = "INSERT INTO Usuarios (DNI, Nombre, usuario, pass) VALUES (@DNI, @Nombre, @user, @pass)";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@DNI", txtDNI.Text);
                        comando.Parameters.AddWithValue("@Nombre", txtNombres.Text);
                        comando.Parameters.AddWithValue("@user", txtUsuarioNuevo.Text);
                        comando.Parameters.AddWithValue("@pass", txtClaveNueva.Text);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario registrado exitosamente. Ya puedes iniciar sesión.");

                            // Limpiamos las cajas de texto
                            txtDNI.Clear();
                            txtNombres.Clear();
                            txtUsuarioNuevo.Clear();
                            txtClaveNueva.Clear();

                            // Ocultamos el GroupBox automáticamente
                            groupBox1.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el usuario.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el usuario: " + ex.Message);
                }
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.");
                return;
            }

            // 2. Cadena de conexión (recuerda ajustar "TU_SERVIDOR")
            string cadenaConexion = "Server=PC-PEDROPE\\SQLEXPRESS;Database=CafeteriaValentini;Integrated Security=True;";
            string query = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @user AND pass = @pass";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // 3. Pasar los parámetros de las cajas de texto
                        comando.Parameters.AddWithValue("@user", txtUsuario.Text);
                        comando.Parameters.AddWithValue("@pass", txtClave.Text);

                        // 4. Ejecutar la consulta
                        int usuarioValido = Convert.ToInt32(comando.ExecuteScalar());

                        if (usuarioValido > 0)
                        {
                            // Si el usuario existe y la clave es correcta, abrimos el menú
                            this.Hide(); // Oculta la ventana de login
                            frmMenu frm = new frmMenu();
                            frm.ShowDialog();
                            this.Close(); // Cierra completamente la aplicación al salir del menú
                        }
                        else
                        {
                            // Si no coincide, mostramos error
                            MessageBox.Show("Usuario o contraseña incorrectos. Si no tiene cuenta, por favor regístrese.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión con la base de datos: " + ex.Message);
                }
            }
        }
    }
}
