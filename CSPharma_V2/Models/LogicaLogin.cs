using Npgsql;
using System.Configuration;

namespace CSPharma_V2.Models


{
    public class LogicaLogin
    {
        //Creamos la conexion con Postgre usando nuestra cadena de conexion almacenada en appsettings
        NpgsqlConnection conn = new NpgsqlConnection(connectionString: "PostgreSQL");




    }
}
