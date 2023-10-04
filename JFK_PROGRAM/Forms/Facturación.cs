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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Logging;
using Microsoft.VisualBasic;

namespace Clientes
{
    public partial class Facturación : Form
    {
        public Facturación()
        {
            InitializeComponent();
            rellenarClientes();
        }

        //Condicionales que solo permiten valores numéricos enteros en cada caja de texto correspondiente.
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten ingresar valores númericos enteros");
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten ingresar valores númericos enteros");
                e.Handled = true;
                return;
            }
        }

        //Rellenar datagridview
        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Se utiliza un "try-catch" para manejar las posibles excepciones que puedan ocurrir.
            try
            {
                //Se inicia una conexión a la base de datos.
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                //Se abre dicha conexión.
                conexion.Open();
                //Se la tabla de datos con aquellos registros capturados por el adaptador sql.
                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter("select * from Facturación", conexion);
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
                //Se cierra la conexión con la base de datos para mantener un estándar de seguridad.
                conexion.Close();
            }
            //Se utiliza una exepción "Sql" porque se está realizando una conexión a una base de datos sql.
            catch (SqlException ex) { }
        }

        //Insertar datos en la tabla "Factura"
        private void button1_Click(object sender, EventArgs e)
        {
            //Se utiliza un "try-catch" para manejar las posibles exceptiones que puedan ocurrir.
            try
            {
                //Se inicia una conexión a la base de datos.
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                //Se abre dicha conexión.
                conexion.Open();

                //Se utiliza la variable "verificarID" para guardar una línea de texto que se utilizará como consulta (query).
                string verificarID = "SELECT COUNT(*) FROM Facturación WHERE id = '" + textBox1.Text + "'";
                //Se crea un comando de SQL que manda la consulta guardada en la variable string "verificarID".
                SqlCommand comandoVerificar = new SqlCommand(verificarID, conexion);
                /*
                Gracias al resultado de la consulta, se puede saber si el id de la factura se repite dentro de la tabla
                "Facturación" de la base de datos.
                */
                int count = Convert.ToInt32(comandoVerificar.ExecuteScalar());

                /*
                Se utiliza el siguiente condicional para verificar si el id existe, y si el caso es positivo,
                entonces se le manda un mensaje de advertencia al usuario.
                */
                if (count > 0)
                {
                    MessageBox.Show("El id de la factura ya existe en la base de datos. Por favor, elija otro id.");
                    conexion.Close();
                    return;
                }

                /*
                Una vez que se verifica que el id de la factura es único (llave primaria requerida en la tabla),
                se procede a usar la variable "cadena" para guardar la siguiente consulta que insertaría los datos de los campos
                de texto correspondientes en las respectivas columnas de la tabla "Facturación".
                */
                string cadena = "insert into facturación (id, id_cliente, id_proyecto, fecha_actual, total)"
                    + " values ('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker2.Text + "','" +
                    textBox4.Text + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //Se ejecuta el comando.
                comando.ExecuteNonQuery();
                //Se le avisa al usuario que el ingreso de datos fue satisfactorio.
                MessageBox.Show("Los datos se guardaron satisfactoriamente");
                //Se recarga la tabla con la información añadida
                DataTable dt = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter("select * from Facturación", conexion);
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;

                //Toda la información en los campos de texto se borra para evitar inconvenientes.
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker2.Text = "";
                textBox4.Text = "";

                //Se cierra la conexión con la base de datos para mantener un estándar de seguridad. 
                conexion.Close();
            }
            /*
            Se utiliza una excepción "Sql" porque se está realizando una conexión a una base de datos sql.
            En caso de que haya una excepción, se le muestra un mensaje al usuario en donde se le señala la necesidad de comprobar que 
            la información esté correcta.
            Toda la información en los campos de texto se borra para evitar inconvenientes.
            Esta excepción se utiliza también para evaluar si alguno de los id's, ya sea del cliente o proyecto, están repetidos o no 
            existen.
            */
            catch (SqlException ex)
            {
                MessageBox.Show("Favor de comprobar si el id del cliente o del proyecto existen dentro de las respectivas tablas");
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker2.Text = "";
                textBox4.Text = "";
            }
        }

        //Actualizar registro
        private void button2_Click(object sender, EventArgs e)
        {
            //Se utiliza un "try-catch" para manejar las posibles exceptiones que puedan ocurrir.
            try
            {
                //Se crea la conexión a la base de datos.
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                //Se ejecuta dicha conexión.
                conexion.Open();
                /*
                Se utiliza la variable "cadena" para guardar la consulta que actualizará los datos del registro que coincida con el id
                de factura ingresado en la caja de texto llamada "textBox1".
                */
                string cadena = "update facturación set id_cliente='" + comboBox1.Text + "'" +
                    ", id_proyecto='" + comboBox2.Text + "'" +
                    ", fecha_actual='" + dateTimePicker2.Text + "'" +
                    ", total='" + textBox4.Text + "'" +
                    " where id=" + textBox1.Text;

                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cantidad_modificados = comando.ExecuteNonQuery();

                //Estas condicionales ayudan a verificar y avisar si los datos fueron modificados o no.
                if (cantidad_modificados == 1)
                {
                    MessageBox.Show("Se modificaron los datos satisfactoriamente");
                    //Se recarga la tabla con la información modificada
                    DataTable dt = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter("select * from Facturación", conexion);
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //Se cierra la conexión con la base de datos para mantener un estándar de seguridad.
                    conexion.Close();
                }
                else
                    MessageBox.Show("No existe la identificación ingresada, intente de nuevo con otro id");
                conexion.Close();
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker2.Text = "";
                textBox4.Text = "";
            }
            //Se utiliza una excepción "Sql" porque se está realizando una conexión a una base de datos sql.
            catch (SqlException ex) { }
        }

        //Eliminar registro
        private void button3_Click(object sender, EventArgs e)
        {
            //Se utiliza un "try-catch" para manejar las posibles exceptiones que puedan ocurrir.
            try
            {
                //Se crea la conexión a la base de datos.
                SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
                //Se abre la conexión.
                conexion.Open();

                /*
                Se utiliza la variable "cadena" para guardar la consulta que eliminará los datos del registro que coincida con el id
                de factura ingresado en la caja de texto llamada "textBox1".
                */
                string cadena = "delete from facturación where id=" + textBox1.Text;
                SqlCommand comando = new SqlCommand(cadena, conexion);

                /*
                Este método provee información de cuántas filas han sido afectadas en la tabla "Facturación", como cada fila tiene una
                llave primaria distinta, entonces solamente puede afectar a una fila en concreto (aquella que tenga el id de factura ingresado
                en la caja de texto llamada "textbox1").

                */
                int cantidad_borrados = comando.ExecuteNonQuery();
                /*
                Estas condicionales ayudan a verificar y avisar si los datos fueron eliminados o no, utilizando la variable entera como argumento
                que permitirá conocer la cantidad de registros afectados.
                */
                if (cantidad_borrados == 1)
                {
                    MessageBox.Show("El registro fue borrado");
                    //Se actualiza la tabla con el registro que fue borrado.
                    DataTable dt = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter("select * from Facturación", conexion);
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                    MessageBox.Show("La identificación no existe");
                /*
                Una vez que se haya avisado si el registro fue borrado o no, a cada caja de texto se le borrará la información por cuestiones
                de orden.
                */
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker2.Text = "";
                textBox4.Text = "";
                //Se cierra la conexión con la base de datos para mantener un estándar de seguridad.
                conexion.Close();
            }
            //Se utiliza una excepción "Sql" porque se está realizando una conexión a una base de datos sql.
            catch (SqlException ex) { }
        }

        //Facturar
        private void button4_Click(object sender, EventArgs e)
        {
            /*
            Primeramente se revisa con un condicional si el id de factura ingresado en "textbox1" es nulo o esté vacío, en caso de que sí,
            se le solicita al usuario que ingrese el id de factura de forma correcta.
            */
            if (textBox1.Text == "" || textBox1.Text == null)
            {
                MessageBox.Show("Ingresa un id de factura en el campo correspondiente");
            }
            //En caso de que el id haya sido ingresado correctamente, se ejecturá la siguiente secuencia.
            else
            {
                //Se utiliza un "try-catch" para manejar las posibles exceptiones que puedan ocurrir.
                try
                {
                    //Se utiliza la creación a la conexión de la base de datos como argumento.
                    using (SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true"))
                    {
                        //Se abre dicha conexión.
                        conexion.Open();

                        /*
                        Se crea una variable llamada "consulta" que guardará el script que se enviará para revisar si el id de la factura
                        se encuentra en la tabla "Facturación".
                        */
                        string consulta = "SELECT * FROM Facturación WHERE id = " + textBox1.Text;
                        //Se utiliza un comando sql para ejecutar la consulta.
                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            /*
                            Se definen los parámetros del comando para evitar incongruencias lógicas.
                            Lo que se hace es definir que los parámetros de búsqueda de la consulta son la columna "id" que se encuentra en 
                            la tabla "Facturación" y el valor que se ingresa en el momento en el campo de texto llamado "textbox1".
                            */
                            comando.Parameters.AddWithValue("@id", textBox1.Text);
                            //Se utiliza un lector para ejecutar el comando y revisar si este fue ejecutado correctamente.
                            using (SqlDataReader reader = comando.ExecuteReader())
                            {
                                /*
                                Se utiliza un condicional que revisa si el lector logró ejecutar el comando y recibir respuesta           
                                directa de la base de datos.
                                */
                                if (reader.Read())
                                {
                                    /*
                                    En caso de que haya habido una respuesta consistente con algún registro, entonces se procede a utilizar 
                                    al lector como herramienta en la obtención y guardado en variables de toda la información que es necesaria
                                    para la facturación.
                                    */
                                    int id = reader.GetInt32(reader.GetOrdinal("id"));
                                    int id_cliente = reader.GetInt32(reader.GetOrdinal("id_cliente"));
                                    int id_proyecto = reader.GetInt32(reader.GetOrdinal("id_proyecto"));
                                    DateTime fecha_actual = reader.GetDateTime(reader.GetOrdinal("fecha_actual"));
                                    int total = reader.GetInt32(reader.GetOrdinal("total"));

                                    //Se cierra el lector para utilizar otro.
                                    reader.Close();

                                    /*
                                    Se utiliza la variable "consulta2" para guardar la consulta necesaria para averiguar el nombre del cliente que se
                                    encuentra en la tabla "Clientes", usando el id de la factura que está en la tabla "Facturación".
                                    */
                                    string consulta2 = "SELECT nombre_completo FROM Clientes where id = @id_cliente";

                                    //El comando que ejecuta la "consulta2" es utilizado como argumento.
                                    using (SqlCommand comando2 = new SqlCommand(consulta2, conexion))
                                    {
                                        /*
                                        Se definen los parámetros del comando para evitar incongruencias lógicas.
                                        Lo que se hace es definir que los parámetros de búsqueda de la consulta2 son la columna "id_cliente" 
                                        que se encuentra en la tabla "Clientes" y el valor guardado en la variable "id_cliente" que fue usado 
                                        anteriormente para obtener el dato de dicha columna en la tabla "Facturación".
                                        */
                                        comando2.Parameters.AddWithValue("@id_cliente", id_cliente);

                                        //Es necesario crear un objeto que almacene el resultado del método "ExecuteScalar()".
                                        object nombreClienteObj = comando2.ExecuteScalar();
                                        /*
                                        En una variable llamada "nombreCliente" se pasa a string lo que se obtuvo en el objeto y se le agrega
                                        un formato determinado que asegura que la variable recibirá un dato string vacío en caso de que el objeto sea
                                        nulo (null).
                                        Esto ayuda a evitar un problema ocasionado por el hecho de que podría intentarse guardar información nula en 
                                        una variable tipo string. Es una manera precisa y directa de controlar dicha excepción. 
                                        */
                                        string nombreCliente = nombreClienteObj?.ToString() ?? "";

                                        //Se guarda en una variable la ruta destino de la factura.

                                        string pdfFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ArchivosPDF");
                                        Directory.CreateDirectory(pdfFolder);
                                        string pdfFileRuta = Path.Combine(pdfFolder, $"{id}.pdf");
                                        /*
                                        Se crea un objeto tipo "documento".
                                        Es importante saber que para esto existe una librería foránea de Visual Studio que fue 
                                        importada con antelación.
                                        La libreía se llama "iTextSharp".
                                        */
                                        Document pdf = new Document();
                                        //Se crea el documento pdf en la ruta destino anteriormetne especificada. 
                                        PdfWriter.GetInstance(pdf, new FileStream(pdfFileRuta, FileMode.Create));
                                        //Se abre el pdf internamente para poder ser modificado.
                                        pdf.Open();

                                        //Se ingresan los datos pertinentes de la factura.
                                        pdf.Add(new Paragraph("----------------------------------------------------------------------------------------------"));
                                        pdf.Add(new Paragraph("        Alajuela, Desamparados, Residencial Prados de Florencia"));
                                        pdf.Add(new Paragraph("                         Teléfono: 506 8520 0402"));
                                        pdf.Add(new Paragraph("                         jfkprecision@gmail.com"));
                                        pdf.Add(new Paragraph(""));
                                        pdf.Add(new Paragraph(""));
                                        pdf.Add(new Paragraph("       Código de factura:                 " + id));
                                        pdf.Add(new Paragraph("       Fecha:                                   " + fecha_actual));
                                        pdf.Add(new Paragraph("-----------------------------------------------------------------------------------------------"));
                                        pdf.Add(new Paragraph("       Cliente:                                  " + nombreCliente));
                                        pdf.Add(new Paragraph("       Código del proyecto:             " + id_proyecto));
                                        pdf.Add(new Paragraph("       Total:                                     " + total));
                                        pdf.Add(new Paragraph("*********************************************************************************"));
                                        pdf.Add(new Paragraph("                   *** GRACIAS POR SU COMPRA ***"));
                                        pdf.Add(new Paragraph("-----------------------------------------------------------------------------------------------"));

                                        //Se le comunica al usuario que la creación de la factura fue exitosa.
                                        MessageBox.Show("Se ha facturado correctamente");
                                        //Se borra la información que está en las cajas de texto para evitar confusiones.
                                        textBox1.Text = "";
                                        comboBox1.Text = "";
                                        comboBox2.Text = "";
                                        dateTimePicker2.Text = "";
                                        textBox4.Text = "";

                                        pdf.Close();

                                    }
                                }
                                /*
                                En caso de que no haya habido una respuesta consistente con algún registro, se procede a informarle
                                al usuario.
                                */
                                else
                                {
                                    MessageBox.Show("Favor de ingresar un id de factura válido");
                                    //Se borra la información que está en las cajas de texto para evitar confusiones.
                                    textBox1.Text = "";
                                    comboBox1.Text = "";
                                    comboBox2.Text = "";
                                    dateTimePicker2.Text = "";
                                    textBox4.Text = "";
                                }
                            }
                        }
                        //Se cierra la conexión con la base de datos para mantener un estándar de seguridad.
                        conexion.Close();
                    }
                }
                //Se utiliza una exepción "Sql" porque se está realizando una conexión a una base de datos sql.
                catch (SqlException ex) { }
            }
        }

        private void rellenarClientes()
        {
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            string cadena = "select id from clientes";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            //Se leen los datos de todas las filas que existan, una por una
            while (lector.Read())
            {
                comboBox1.Items.Add(lector["id"]);
            }
            conexion.Close();
        }

        private void rellenarProyectos()
        {
            comboBox2.Items.Clear();

            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            string cadena = $"select id from proyectos where id_cliente={comboBox1.Text}";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            //Se leen los datos de todas las filas que existan, una por una
            while (lector.Read())
            {
                comboBox2.Items.Add(lector["id"]);
            }
            conexion.Close();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rellenarProyectos();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox4.Text = "";

            int costoTotal = 0;
            SqlConnection conexion = new SqlConnection($"server={Principal.ObtenerInstancia().nombreServidor}; database = BaseDeDatos_JFK; integrated security = true");
            conexion.Open();
            string cadena = $"select * from proyectos where id={comboBox2.Text}";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            //Se leen los datos de todas las filas que existan, una por una
            if (lector.Read())
            {
                costoTotal = (int) lector["costo_de_material"] + (int) lector["mano_de_obra"];
            }

            textBox4.Text = costoTotal+"";

            conexion.Close();
        }
    }
}
