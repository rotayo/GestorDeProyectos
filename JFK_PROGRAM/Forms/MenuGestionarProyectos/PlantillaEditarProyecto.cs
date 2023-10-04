using Clientes;
using Microsoft.IdentityModel.Tokens;
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
    public partial class PlantillaEditarProyecto : Form
    {
        private string encargado;
        public PlantillaEditarProyecto(string id, string cliente, string encargado, string material,
            string cantidadMaterial, string fechaInicio, string fechaFinal, string detalles, string costo, string manoObra)
        {
            InitializeComponent();
            LabelProyecto.Text = id;
            LabelCliente.Text = cliente;
            this.encargado = encargado;
            LabelMaterial.Text = material;
            LabelCantidad.Text = cantidadMaterial;
            LabelFechaInicio.Text = fechaInicio;
            LabelFechaFinal.Text = fechaFinal;
            LabelDetalles.Text = detalles;
            LabelCosto.Text = costo;
            LabelMano.Text = manoObra;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (ListaEncargados.Text.IsNullOrEmpty())
                actualizarProyecto(encargado);
            else
            {
                actualizarProyecto(ListaEncargados.Text); 
                encargado = ListaEncargados.Text;
            }

            actualizarFechas();
            Principal.ObtenerInstancia().CambiarFormHijo(new PlantillaProyecto(LabelProyecto.Text, LabelCliente.Text, encargado));
        }

        private void actualizarProyecto(string encargado)
        {
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            string cadena = $"update proyectos set " +
                $"mano_de_obra='{LabelMano.Text}'," +
                $"detalle='{LabelDetalles.Text}'," +
                $"encargado='{encargado}'" +
                $"where id={LabelProyecto.Text}";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        private void actualizarFechas()
        {
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            string cadena = $"update fechas set " +
                $"fecha_inicio='{LabelFechaInicio.Text}'," +
                $"fecha_de_entrega='{LabelFechaFinal.Text}'" +
                $"where id_proyecto={LabelProyecto.Text}";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Principal.ObtenerInstancia().CambiarFormHijo(new VistaDeProyectos());
        }

    }
}
