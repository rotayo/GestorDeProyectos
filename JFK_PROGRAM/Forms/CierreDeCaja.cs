using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes.Forms
{
    public partial class CierreDeCaja : Form
    {

        public CierreDeCaja()
        {
            InitializeComponent();
        }

        //Al cargar el formulario, se asigna que el textbox1 no pueda ser modificado, sino solo leído.     
        private void CierreDeCaja_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        //Mostrar facturas
        private void btn_facturas_Click(object sender, EventArgs e)
        {
            //Se utiliza un "try-catch" para manejar las posibles exceptiones que puedan ocurrir.
            try
            {
                //Se crea la conexión a la base de datos.
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                //Se abre dicha conexión.
                conexion.Open();
                //Se la tabla de datos con aquellos registros capturados por el adaptador sql.
                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter("select * from Facturación", conexion);
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
                //Se cierra la conexión a la base de datos para mantener un estándar de seguridad.
                conexion.Close();
            }
            catch (SqlException ex) { }
        }

        //Calcular
        private void btn_calculo_Click(object sender, EventArgs e)
        {
            //Se utiliza un "try-catch" para manejar las posibles exceptiones que puedan ocurrir.
            try
            {
                //Se crea la conexión a la base de datos.
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                //Se abre dicha conexión.
                conexion.Open();
                /*
                Se guarda en una variable llamada "suma" la consulta que será utilizada para sumar
                todos los valores de la columna "total" en la tabla "Facturación".
                */
                string suma = "SELECT SUM(total) FROM Facturación";
                //Se crea un comando que ejecute dicha consulta de suma.
                SqlCommand comandosum = new SqlCommand(suma, conexion);
                //Se guarda el valor de la suma en una variable entera llamada "count".
                int count = Convert.ToInt32(comandosum.ExecuteScalar());

                //Se procede a modificar el texto del textbox1 con la cifra de la suma convertida en string.
                textBox1.Text = "₡ " + count.ToString();
                //Se cierra la conexíón con la base de datos para mantener un estándar de seguridad.
                conexion.Close();
            }
            //Se utiliza una excepción "Sql" porque se está realizando una conexión a una base de datos sql.
            catch (Exception ex) {
                MessageBox.Show("Valor erroneo");
            }           
        }
    }
}
