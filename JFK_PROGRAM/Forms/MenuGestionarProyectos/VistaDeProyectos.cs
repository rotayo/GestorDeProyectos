using Clientes;
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

namespace Proyecto.Forms.MenuGestionarProyectos
{
    public partial class VistaDeProyectos : Form
    {
        public VistaDeProyectos()
        {
            InitializeComponent();
            RellenarVista();
        }

        private void RellenarVista()
        {
            int contador = 0;
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            string cadena = "select * from proyectos";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            //Se leen los datos de todas las filas que existan, una por una
            while (lector.Read())
            {
                contador++;
                var miniatura = new MiniaturaProyecto(lector["id"] + "", obtenerNombreCliente(lector["id_cliente"] + ""),
                    lector["encargado"] + "", obtenerFechaProyecto(lector["id"] + ""));
                VistaMenus.Controls.Add(miniatura);
            }
            if (contador == 0)
                MessageBox.Show("No existe ningun proyecto");
        }

        private string obtenerNombreCliente(string id)
        {
            string nombre = "";
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            string cadena = $"select * from clientes where id={id}";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                nombre = lector["nombre_completo"] + "";
            }

            conexion.Close();

            return nombre;
        }

        private string obtenerFechaProyecto(string id)
        {
            string fecha = "";
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            string cadena = $"select * from fechas where id_proyecto={id}";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                fecha = lector["fecha_de_entrega"] + "";
            }
            return fecha;
        }
    }
}
