using Clientes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Forms.MenuProyectos
{
    public partial class ValidarIdProyecto : Form
    {

        public ValidarIdProyecto()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            /*Metodo que verifica si el id del cliente existe*/

            //Se asegura que el campo no este vacío
            if (!(textBoxIDcliente.Text.Equals("") || textBoxIDcliente.Text.Equals("Ingrese el ID de un Cliente")))
            {
                //Se abre conexión y se hace una consulta a la tabla clientes, buscando el id ingresado en el textbox
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                conexion.Open();
                string consulta = "select count(*) from clientes where id=" + textBoxIDcliente.Text + "";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int cuenta = Convert.ToInt32(comando.ExecuteScalar());

                //Si la cuenta es mayor a cero, significa que sí existe el id
                if ((cuenta > 0))
                {
                    //Una vez se haya verificado el id, se declara el array creado en el form Principal
                    //Este array contendrá todos los datos a guardar en las tablas "Proyectos", "MaterialesProyectos" y Fechas
                    Principal.ObtenerInstancia().datosProyectoNuevo = new object[10];

                    //El índice 0 contendrá el id del cliente de la tabla Proyecto:
                    Principal.ObtenerInstancia().datosProyectoNuevo[0] = textBoxIDcliente.Text;

                    //Se abre la siguiente ventana
                    Principal.ObtenerInstancia().CambiarFormHijo(new PresupuestoProyecto());
                }
                else
                {
                    MessageBox.Show("El id del cliente ingresado no existe, porfavor ingrese un id de cliente ya registrado");
                }
            }
            else
                MessageBox.Show("Se ha ingresado un valor erroneo");

        }

        //Metodos estéticos
        private void textBoxIDcliente_Enter(object sender, EventArgs e)
        {
            if (textBoxIDcliente.Text.Equals("Ingrese el ID de un Cliente"))
            {
                textBoxIDcliente.ForeColor = Color.FromArgb(93, 93, 180);
                textBoxIDcliente.Text = "";
            }
        }

        private void textBoxIDcliente_Leave(object sender, EventArgs e)
        {
            if (textBoxIDcliente.Text.Equals(""))
            {
                textBoxIDcliente.ForeColor = Color.FromArgb(54, 54, 124);
                textBoxIDcliente.Text = "Ingrese el ID de un Cliente";
            }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal.ObtenerInstancia().CambiarFormHijo(new Proyectos());
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
    }
}
