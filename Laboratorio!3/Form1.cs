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

namespace Laboratorio_3
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
            conexion.Open();
            MessageBox.Show("Se abrio la conexion con el servidor SQL Server y se selecciono la base de datos");
            conexion.Close();
            MessageBox.Show("Se cerro la conexion.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();

            string query = "SELECT ProductName From [dbo].[Products]";
            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataReader lector = comando.ExecuteReader();


            listBox1.Items.Clear();

            while (lector.Read())
            {
                listBox1.Items.Add(lector.GetString(0));
            }

            lector.Close();
        }
    }
}
