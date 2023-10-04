using Clientes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Forms.MenuProyectos
{
    public partial class PresupuestoProyecto : Form
    {
        private ArrayList idProductos;
        public PresupuestoProyecto()
        {
            InitializeComponent();

            //Se llena el combo box con la lista de productos en el inventario, mostrando su nombre y precio
            RellenarListaProductos();

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            /*Metodo que verifica los campos y mediante la id de un producto guarda todos los datos en el array global "datosProyectoNuevo"*/

            //Se verifica que ningún campo esté vacío
            if (!string.IsNullOrEmpty(listaProductos.Text) &&
                !string.IsNullOrEmpty(cantidadProducto.Text) &&
                !(textBoxManoObra.Text.Equals("Ingrese un valor numerico") || string.IsNullOrWhiteSpace(textBoxManoObra.Text)))
            {
                //Se obtiene el indice del item seleccionado en el combobox "listaProductos"
                int productoSeleccionado = listaProductos.SelectedIndex;

                //Se crea la conexión con la tabla inventario
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                conexion.Open();

                // con la ayuda del indice seleccionado, se puede buscar en el array idProductos el id específico a encontrar en la tabla inventario
                string cadena = $"select * from inventario where id={idProductos[productoSeleccionado]}";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader lector = comando.ExecuteReader();

                //Se leen los datos de la fila del id especificado
                if (lector.Read())
                {
                    //Se guardan los datos en los indices del array "datosProyectoNuevo", para luego insertarlos en las tablas correspondientes.
                    //Tabla Proyecto: 1=costo de material; 2 = mano de obra.
                    //Tabla MaterialesProyecto: 5=id del producto; 6=nombre del producto; 7=cantidad del producto
                    /* se saltan los indices 3 y 4 porque serán utilizados para detalle y encargado de la tabla proyectos respectivamente*/
                    Principal.ObtenerInstancia().datosProyectoNuevo[1] = obtenerCosto((int)lector["precio"], int.Parse(cantidadProducto.Text));
                    Principal.ObtenerInstancia().datosProyectoNuevo[2] = textBoxManoObra.Text;
                    Principal.ObtenerInstancia().datosProyectoNuevo[5] = idProductos[productoSeleccionado];
                    Principal.ObtenerInstancia().datosProyectoNuevo[6] = lector["nombre_del_producto"];
                    Principal.ObtenerInstancia().datosProyectoNuevo[7] = cantidadProducto.Text;
                }
                conexion.Close();

                //Se abre la siguiente ventana
                Principal.ObtenerInstancia().CambiarFormHijo(new CrearProyecto());
            }
            else
                MessageBox.Show("Uno o más campos están vacíos");
        }

        private void RellenarListaProductos()
        {
            /*Metodo que rellena con datos el comboBox "listaProductos" y agrega el id de cada producto al array idProductos*/

            //Se declara el ArrayList
            idProductos = new ArrayList();

            //Se abre conexion y se selecciona la tabla inventario
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            string cadena = "select * from inventario";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            //Se leen los datos de todas las filas que existan, una por una
            while (lector.Read())
            {
                //Se agrega el id del producto al arraylist idProductos
                idProductos.Add(lector["id"]);
                //Se muestra en el comboBox listaProductos el nombre y el precio del producto
                listaProductos.Items.Add("Material:" + lector["nombre_del_producto"] + " Precio:" + lector["precio"]);
            }
            conexion.Close();
        }

        private void listaProductos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*Metodo que rellena con datos el comboBox "cantidadProductos" luego de haber seleccionado un item en el comboBox "listaProductos"*/

            //Se borran los datos, si existiensen previamente
            cantidadProducto.Items.Clear();

            //Se obtiene el índice del elemento seleccionado en el combo box listaProductos
            int productoSeleccionado = listaProductos.SelectedIndex;

            //Se crea la conexión
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            string cadena = $"select * from inventario where id={idProductos[productoSeleccionado]}";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            //Se leen los datos
            if (lector.Read())
            {
                //Se guarda la cantidad total de productos en un int, para luego iterar los numeros y mostrarlos en el combobox cantidadProducto
                int cantidadDelProducto = (int)lector["cantidad"];
                for (int i = 0; i < cantidadDelProducto; i++)
                {
                    cantidadProducto.Items.Add(i + 1);
                }
            }

            conexion.Close();
            cantidadProducto.Enabled = true;
        }

        private int obtenerCosto(int precio, int cantidad)
        {
            /*Metodo que calcula el costo*/
            return precio * cantidad;//Se multiplica el valor del producto seleccionado por la cantidad que se selecciono de este
        }

        //Métodos estéticos
        private void textBoxManoObra_Enter(object sender, EventArgs e)
        {
            if (textBoxManoObra.Text.Equals("Ingrese un valor numerico"))
            {
                textBoxManoObra.ForeColor = Color.FromArgb(93, 93, 180);
                textBoxManoObra.Text = "";
            }
        }

        private void textBoxManoObra_Leave(object sender, EventArgs e)
        {
            if (textBoxManoObra.Text.Equals(""))
            {
                textBoxManoObra.ForeColor = Color.FromArgb(54, 54, 124);
                textBoxManoObra.Text = "Ingrese un valor numerico";
            }
        }

        private void textBoxManoObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                textBoxManoObra.BackColor = Color.FromArgb(58, 33, 74);
            }
            else
            {
                textBoxManoObra.BackColor = Color.FromArgb(34, 33, 74);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal.ObtenerInstancia().CambiarFormHijo(new ValidarIdProyecto());
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(249, 118, 176);
            btnSalir.ForeColor = Color.FromArgb(34, 33, 74);
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.FromArgb(249, 118, 176);
            btnSalir.BackColor = Color.FromArgb(34, 33, 74);
        }

        private void btnValidar_MouseHover(object sender, EventArgs e)
        {
            btnValidar.BackColor = Color.FromArgb(249, 118, 176);
            btnValidar.ForeColor = Color.FromArgb(34, 33, 74);
        }

        private void btnValidar_MouseLeave(object sender, EventArgs e)
        {
            btnValidar.ForeColor = Color.FromArgb(249, 118, 176);
            btnValidar.BackColor = Color.FromArgb(34, 33, 74);
        }
    }
}
