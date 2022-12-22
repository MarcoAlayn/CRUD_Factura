using System;
using System.Data.SqlClient;

// definimos un espacio de nombres que contendra varias clases
namespace BaseDeDatos
{
    class Program
    {
        // definimos un método estático Main como el punto de entrada de la aplicación.
        static void Main(string[] args)
        {
            try
            {

                // creamos una nueva instancia de la clase DB, pasando los parámetros necesarios para la conexión a la base de datos
                DB db = new DB("master", "GrupacDB", "sa", "P@$$w0rd");

                //  llamamos al método Connect para abrir la conexión con la base de datos
                db.Connect();

                //  llamamos al método Close para cerrar la conexión con la base de datos
                db.Close();
            }
            catch (SqlException)
            {
                // capturamos cualquier excepción de tipo SqlException generada por la conexión a la base de datos
                Console.WriteLine("no pudimos conectarnos a la base de datos");
            }
        }
    }
}