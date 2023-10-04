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
                 * Secci�n para vereficar correctamente que exista una conexi�n a la base de datos y evitar errores,
                 * Primero, se crea una instancia del form CuadroInput y con la funci�n ShowDialog(), trabajar� como un input box, solo que de manera m�s personalizada
                 * El form no dejar� continuar si el textBox no tiene contenido
                 * Si se selecciona la opcion continuar (dada la respuesta "DialogResult.OK") intentar� abrir una conexi�n con la base de datos, si el nombre es correcto
                 * permitira la conexi�n con la base de datos y ejecutar� el progama, sino, mostrar� un mensaje de error.
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
                            MessageBox.Show("Error: nombre de servidor inv�lido, ingrese uno nuevo.\n\n" + ex.InnerException);
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