using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Declararamos un espacio de nombres. Los espacios de nombres se usan para agrupar tipos relacionados y aislarlos de los tipos de otros espacios de nombres.
namespace BaseDeDatos
{
    // Esta línea se usa para declarar una clase pública llamada DB. Las clases son los bloques de construcción principales para crear objetos.
    public class DB
    {

        // declararamos una variable privada de tipo cadena llamada _ConnectionString.
        private string _ConnectionString;

        // declararamos una variable protegida de tipo SqlConnection llamada _connection.
        protected SqlConnection _connection;

        // declaramos un constructor público
        public DB(string server, string db, string user, string password)
        {

            //  asignamos un valor a la variable _ConnectionString.
            _ConnectionString = $"Data source={server}; Initial Catalog{db};" +
             $"User Id={user}; Password={password}";
        }

        public void Connect()
        {
            // creamos una nueva instancia de la clase SqlConnection y asignarla a la variable _connection. 
            // El constructor de SqlConnection toma una cadena como parámetro para inicializar la conexión.
            _connection = new SqlConnection(_ConnectionString);
            // abrimos la conexión.
            _connection.Open();
        }

        public void Close()
        {
            // comprobamos si la conexión está abierta.
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
                // cerramos la conexión.
                _connection.Close();

        }
    }

}