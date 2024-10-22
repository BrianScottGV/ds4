using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {

        string connectionString = @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            string query = "SELECT ProductName FROM [dbo].[Products]";
            
            conexion.Open();
            MessageBox.Show("Se abrio la conexion con el servidor SQL Server y se selecciono la base de datos");

            
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                listBox1.Items.Clear();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["ProductName"].ToString());
                }

            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
            conexion.Close();
            MessageBox.Show("Se cerro la conexion");
        } 
    }
}
