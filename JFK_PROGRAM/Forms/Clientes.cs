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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                conexion.Open();

                string verificarID = "SELECT COUNT(*) FROM Clientes WHERE id = '" + textBox1.Text + "'";
                SqlCommand comandoVerificar = new SqlCommand(verificarID, conexion);
                int count = Convert.ToInt32(comandoVerificar.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("El id ya existe en la base de datos. Por favor, elija otro id.");
                    conexion.Close();
                    return;
                }

                string cadena = "insert into clientes (id, nombre_completo, correo_electrónico, teléfono, dirección)"
                    + " values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"
                    + textBox5.Text + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron sadisfactoriamente");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                conexion.Close();
            }
            else
                MessageBox.Show("Porfavor ingrese un ID");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                conexion.Open();

                string cadena = "delete from clientes where id=" + textBox1.Text;
                SqlCommand comando = new SqlCommand(cadena, conexion);

                int cantidad_borrados = comando.ExecuteNonQuery();
                if (cantidad_borrados == 1)
                {
                    MessageBox.Show("El registro fue borrado");
                }
                else
                    MessageBox.Show("La identificacion no existe");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                conexion.Close();
            }
            else
                MessageBox.Show("Porfavor ingrese un ID");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                conexion.Open();
                string cadena = "update clientes set nombre_completo='" + textBox2.Text + "'" +
                ", correo_electrónico='" + textBox3.Text + "'" +
                ", teléfono='" + textBox4.Text + "'" +
                ", dirección='" + textBox5.Text + "'" +
                " where id=" + textBox1.Text;

                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cantidad_modificados = comando.ExecuteNonQuery();


                if (cantidad_modificados == 1)
                {
                    MessageBox.Show("Se modificaron los datos sadisfactoriamente");
                }
                else
                    MessageBox.Show("No existe una la identificación ingresada, intente de nuevo con otro id");
                conexion.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else
                MessageBox.Show("Porfavor ingrese un ID");

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter("select * from clientes", conexion);
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Botón_Clientes_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

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
