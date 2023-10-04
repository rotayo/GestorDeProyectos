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
    public partial class PlantillaProyecto : Form
    {
        public PlantillaProyecto(string id, string cliente, string encargado)
        {
            InitializeComponent();
            LabelProyecto.Text = id;
            LabelCliente.Text = cliente;
            LabelEncargado.Text = encargado;
            LabelMaterial.Text = buscarDato(id, "nombre_producto", "MaterialesProyectos", "id_proyecto");
            LabelCantidad.Text = buscarDato(id, "cantidad", "MaterialesProyectos", "id_proyecto");
            string[] fechaInicio = buscarDato(id, "fecha_inicio", "fechas", "id_proyecto").Split(' ');
            string[] fechaEntrega = buscarDato(id, "fecha_de_entrega", "fechas", "id_proyecto").Split(' ');
            LabelFechaInicio.Text = fechaInicio[0];
            LabelFechaFinal.Text = fechaEntrega[0];
            LabelDetalles.Text = buscarDato(id, "detalle", "Proyectos", "id");
            LabelCosto.Text = buscarDato(id, "costo_de_material", "Proyectos", "id");
            LabelManoObra.Text = buscarDato(id, "mano_de_obra", "Proyectos", "id");
        }

        private string buscarDato(string id, string columna, string tabla, string primaryKey)
        {
            string dato = "";
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            string cadena = $"select * from {tabla} where {primaryKey}={id}";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                dato = lector[$"{columna}"] + "";
            }

            conexion.Close();

            return dato;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Principal.ObtenerInstancia().CambiarFormHijo(new PlantillaEditarProyecto(LabelProyecto.Text, LabelCliente.Text, LabelEncargado.Text, LabelMaterial.Text,
                LabelCantidad.Text, LabelFechaInicio.Text, LabelFechaFinal.Text, LabelDetalles.Text, LabelCosto.Text, LabelManoObra.Text));
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            borrarDatos("MaterialesProyectos", "id_proyecto");
            borrarDatos("fechas", "id_proyecto");
            borrarDatos("proyectos", "id");
            Principal.ObtenerInstancia().CambiarFormHijo(new VistaDeProyectos());
        }

        private void borrarDatos(string tabla, string primaryKey)
        {
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            string cadena = $"delete from {tabla} where {primaryKey}={LabelProyecto.Text}";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cantidad_borrados = comando.ExecuteNonQuery();
            conexion.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal.ObtenerInstancia().CambiarFormHijo(new VistaDeProyectos());
        }

    }
}
