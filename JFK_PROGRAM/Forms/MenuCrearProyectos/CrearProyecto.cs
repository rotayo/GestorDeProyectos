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

namespace Proyecto.Forms.MenuProyectos
{
    public partial class CrearProyecto : Form
    {
        string IdProyecto;
        public CrearProyecto()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Se verifica que ningún espacio se encuentre vacío, y en el caso de las fechas que no sean iguales
            if (!(string.IsNullOrWhiteSpace(descripcionTexto.Text) || descripcionTexto.Text.Equals("Descripción del proyecto")) &&
                !string.IsNullOrEmpty(listaEncargados.Text) &&
                !FechaInicio.Text.Equals(FechaEntrega.Text))
            {
                //Se agregan los datos a los índices del array "datosProyectoNuevo":
                //Tabla Proyectos: 3=detalle, 4=encargado
                //Tabla Fechas: 8=Fecha Inicio 9=Fecha de entrega
                Principal.ObtenerInstancia().datosProyectoNuevo[3] = descripcionTexto.Text;
                Principal.ObtenerInstancia().datosProyectoNuevo[4] = listaEncargados.Text;
                Principal.ObtenerInstancia().datosProyectoNuevo[8] = FechaInicio.Text;
                Principal.ObtenerInstancia().datosProyectoNuevo[9] = FechaEntrega.Text;

                //Se agregan los datos a las tablas
                AgregarProyecto();
                AgregarMaterialesProyecto();
                AgregarFechasProyecto();

                MessageBox.Show("Se creó el Proyecto correctamente");

                //imprimir();

                Principal.ObtenerInstancia().CambiarFormHijo(new Proyectos());
            }
            else
                MessageBox.Show("Algunos espacios se encuentra vacios o ambas fechas son iguales");
        }

        private void AgregarProyecto()
        {
            /*Metodo que inserta los datos en la tabla Proyectos, utilizando los datos recolectados en el array global "datosProyectoNuevo" y creando el id del proyecto*/

            //Se abre conexion
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();

            //Se obtiene el arreglo de datos y se asigna un valor aleatorio a id proyecto
            //Se utiliza un bucle generando un nuevo id en cada repeticion hasta que el id generado no sea repetido, para evitar dos id iguales
            object[] datosDelProyecto = Principal.ObtenerInstancia().datosProyectoNuevo;
            do
            {
                IdProyecto = crearIdAleatorio();
            } while (!VerificarID(IdProyecto, "Proyectos"));

            //Se hace un insert con los datos recoletados en el arreglo y se agrega el proyecto
            string cadena = "insert into proyectos (id, id_cliente, costo_de_material, mano_de_obra, detalle, encargado, estado)"
                + $" values ('{IdProyecto}','{datosDelProyecto[0] + ""}','{datosDelProyecto[1] + ""}','{datosDelProyecto[2] + ""}','{datosDelProyecto[3] + ""}','{datosDelProyecto[4] + ""}','EnProceso')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            //Se cierra conexion
            conexion.Close();
        }

        private void AgregarMaterialesProyecto()
        {
            /*Metodo que inserta datos en la tabala MaterialesProyecto, utilizando los datos recolectados en el array global "datosProyectoNuevo"*/

            //Se abre conexcion
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();

            //Se obtienen los datos recolectados
            object[] datosDelProyecto = Principal.ObtenerInstancia().datosProyectoNuevo;

            //Se hace un insert en la tabla MaterialesProyecto con todos los datos
            string cadena = "insert into MaterialesProyectos (id_proyecto, id_producto, nombre_producto, cantidad)"
                + $" values ('{IdProyecto}','{datosDelProyecto[5] + ""}','{datosDelProyecto[6]}','{datosDelProyecto[7] + ""}')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            //Se cierra conexion
            conexion.Close();
        }

        private void AgregarFechasProyecto()
        {
            /*Metodo que inserta datos en la tabla Fecha, utilizando los datos recolectados en el array global "datosProyectoNuevo" y se genera su propio id*/

            //Se abre conexion
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();

            //Se crea un id especifico para las Fechas del proyecto
            string idFechas;
            do
            {
                idFechas = crearIdAleatorio();
            } while (!VerificarID(idFechas, "Fechas"));

            //Se obtienen los datos recolectados
            object[] datosDelProyecto = Principal.ObtenerInstancia().datosProyectoNuevo;

            //Se hace un insert en la tabla Fechas con todos los datos
            string cadena = "insert into Fechas (id, id_proyecto, fecha_inicio, fecha_de_entrega)"
                + $" values ('{idFechas}','{IdProyecto}','{datosDelProyecto[8] + ""}','{datosDelProyecto[9] + ""}')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();


            //Se cierra conexion
            conexion.Close();
        }

        private string crearIdAleatorio()
        {
            //Metodo que crea un Id aleatorio

            Random random = new Random();
            int id = random.Next(10000); // Genera un número aleatorio entre 0 y 9999
            string numeroFormateado = id.ToString("D4"); //Genera el formato para que siempre sea de 4 digitos (Ejemplo: 0022 o 9999)
            return numeroFormateado;
        }

        private bool VerificarID(string ID, string tabla)
        {
            /*Metodo que se encarga de que no existan ID repetidos, retorna true si el id generado aleatoriamente no esta ocupado, por el contrario retorna false*/

            //Abre conexion
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();

            //Se busca en la tabla seleccionada el id y hace una cuenta si este ya es utilizado
            string verificarID = $"select count(*) from {tabla} where id={ID}";
            SqlCommand comandoVerificar = new SqlCommand(verificarID, conexion);
            int cuenta = Convert.ToInt32(comandoVerificar.ExecuteScalar());

            if (cuenta > 0)
            {
                //El ID ya existe, retorna false
                conexion.Close();
                return false;
            }
            else
            {
                //El ID no existe en la tabla y puede ser agregado
                conexion.Close();
                return true;
            }
        }

        private void imprimir()
        {
            //Metodo de prueba :v
            object[] datosDelProyecto = Principal.ObtenerInstancia().datosProyectoNuevo;

            MessageBox.Show("Se agregaron los siguientes datos:\n\n" +

                $"Tabla Proyecto: \nid:{IdProyecto},\n id cliente:{datosDelProyecto[0]},\n" +
                $"costo del material: {datosDelProyecto[1]},\n mano de obra: {datosDelProyecto[2]},\n" +
                $"detalle: {datosDelProyecto[3]},\n encargado: {datosDelProyecto[4]},\n estado: EnProceso \n\n" +

                $"Tabla MaterialesProyecto: \nid del proyecto:{IdProyecto},\nid del producto:{datosDelProyecto[5]},\n" +
                $"nombre del producto: {datosDelProyecto[6]},\n cantidad de producto:{datosDelProyecto[7]}\n\n" +

                $"Tabla Fechas: \nid del proyecto: {IdProyecto},\n fecha de inicio: {datosDelProyecto[8]},\n fecha final: {datosDelProyecto[9]}\n");
        }

        //Metodos Esteticos
        private void descripcionTexto_Leave(object sender, EventArgs e)
        {
            if (descripcionTexto.Text.Equals(""))
            {
                descripcionTexto.ForeColor = Color.FromArgb(54, 54, 124);
                descripcionTexto.Text = "Descripción del proyecto";
            }
        }

        private void descripcionTexto_Enter(object sender, EventArgs e)
        {
            if (descripcionTexto.Text.Equals("Descripción del proyecto"))
            {
                descripcionTexto.ForeColor = Color.FromArgb(93, 93, 180);
                descripcionTexto.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal.ObtenerInstancia().CambiarFormHijo(new PresupuestoProyecto());
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

        private void btnCrear_MouseHover(object sender, EventArgs e)
        {
            btnCrear.BackColor = Color.FromArgb(249, 118, 176);
            btnCrear.ForeColor = Color.FromArgb(34, 33, 74);
        }

        private void btnCrear_MouseLeave(object sender, EventArgs e)
        {
            btnCrear.ForeColor = Color.FromArgb(249, 118, 176);
            btnCrear.BackColor = Color.FromArgb(34, 33, 74);
        }
    }
}
