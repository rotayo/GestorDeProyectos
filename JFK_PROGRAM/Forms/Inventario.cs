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

namespace Clientes
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                conexion.Open();

                string verificarID = "SELECT COUNT(*) FROM Inventario WHERE id = '" + textBox1.Text + "'";
                SqlCommand comandoVerificar = new SqlCommand(verificarID, conexion);
                int count = Convert.ToInt32(comandoVerificar.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("El id ya existe en la base de datos. Por favor, elija otro id.");
                    conexion.Close();
                    return;
                }

                string cadena = "INSERT INTO Inventario (id, nombre_del_producto, detalle, cantidad, precio)"
                    + " values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"
                    + textBox5.Text + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron sadisfactoriamente.");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                conexion.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                conexion.Open();
                string cadena = "UPDATE Inventario set nombre_del_producto='" + textBox2.Text + "'" +
                    ", detalle='" + textBox3.Text + "'" +
                    ", cantidad='" + textBox4.Text + "'" +
                    ", precio='" + textBox5.Text + "'" +
                    " where id=" + textBox1.Text;

                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cantidad_modificados = comando.ExecuteNonQuery();


                if (cantidad_modificados == 1)
                {
                    MessageBox.Show("Se modificaron los datos sadisfactoriamente");
                }
                else
                    MessageBox.Show("No existe una la identificación ingresada, intente de nuevo con otro id.");
                conexion.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                conexion.Open();

                string cadena = "DELETE from Inventario where id=" + textBox1.Text;
                SqlCommand comando = new SqlCommand(cadena, conexion);

                int cantidad_borrados = comando.ExecuteNonQuery();
                if (cantidad_borrados == 1)
                {
                    MessageBox.Show("El registro fue borrado.");
                }
                else
                    MessageBox.Show("La identificacion no existe.");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                conexion.Close();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter("select * from Inventario", conexion);
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
