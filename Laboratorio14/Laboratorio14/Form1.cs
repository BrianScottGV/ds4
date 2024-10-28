using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio14
{
    public partial class frmProductos : Form
    {
        string connectionString = @"Server=.\sqlexpress;Database=Productos;Trusted_Connection=True;";
        bool nuevo;

        public frmProductos()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtNombre.Focus();
            nuevo = true;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql;

                if (nuevo)
                {
                    sql = "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK) VALUES (@Nombre, @Precio, @Stock)";
                }
                else
                {
                    sql = "UPDATE LAPTOPS SET NOMBRE = @Nombre, PRECIO = @Precio, STOCK = @Stock WHERE id = @Id";
                }

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@Stock", txtStock.Text);

                    if (!nuevo)
                    {
                        cmd.Parameters.AddWithValue("@Id", txtId.Text);
                    }

                    try
                    {
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show(nuevo ? "Registro ingresado correctamente!" : "Registro actualizado correctamente!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.ToString());
                    }
                }
            }

            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM LAPTOPS WHERE id = @Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Id", txtId.Text);

                try
                {
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro eliminado correctamente !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
            }

            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM LAPTOPS WHERE id = @Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Id", tstId.Text);
                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        tsbNuevo.Enabled = false;
                        tsbGuardar.Enabled = true;
                        tsbCancelar.Enabled = true;
                        tsbEliminar.Enabled = true;
                        tstId.Enabled = false;
                        tsbBuscar.Enabled = false;
                        txtNombre.Enabled = true;
                        txtPrecio.Enabled = true;
                        txtStock.Enabled = true;
                        txtNombre.Focus();
                        txtId.Text = reader["id"].ToString();
                        txtNombre.Text = reader["NOMBRE"].ToString();
                        txtPrecio.Text = reader["PRECIO"].ToString();
                        txtStock.Text = reader["STOCK"].ToString();
                        nuevo = false;
                    }
                    else
                    {
                        MessageBox.Show("Ningún registro encontrado con el Id ingresado !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            tstId.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
