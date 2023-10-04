using Proyecto.Forms.Utiles;
using System.Data.SqlClient;

namespace Clientes
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            /*
                 * Sección para vereficar correctamente que exista una conexión a la base de datos y evitar errores,
                 * Primero, se crea una instancia del form CuadroInput y con la función ShowDialog(), trabajará como un input box, solo que de manera más personalizada
                 * El form no dejará continuar si el textBox no tiene contenido
                 * Si se selecciona la opcion continuar (dada la respuesta "DialogResult.OK") intentará abrir una conexión con la base de datos, si el nombre es correcto
                 * permitira la conexión con la base de datos y ejecutará el progama, sino, mostrará un mensaje de error.
            */

            ApplicationConfiguration.Initialize();
            CuadroInput cuadroInput = new CuadroInput();

            string nombreDelServidor;
            bool permiso = false;

            while (!permiso)
            {
                switch (cuadroInput.ShowDialog())
                {
                    case DialogResult.OK:
                        nombreDelServidor = cuadroInput.Respuesta;
                        try
                        {
                            SqlConnection conexion = new SqlConnection($"server={nombreDelServidor}; database = BaseDeDatos_JFK; integrated security = true");
                            conexion.Open();
                            conexion.Close();
                            permiso = true;
                            Principal.ObtenerInstancia().nombreServidor = nombreDelServidor;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: nombre de servidor inválido, ingrese uno nuevo.\n\n" + ex.InnerException);
                        }

                        if (permiso)
                            Application.Run(Principal.ObtenerInstancia());

                        break;
                    case DialogResult.Cancel:
                        permiso = true;
                        break;
                }
            }
            
        }
    }
}