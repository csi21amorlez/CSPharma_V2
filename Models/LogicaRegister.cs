using Npgsql;

namespace CSPharma_V2.Models
{
    /*
     *  LogicaRegister  --> Clase que gestionara la insercion de nuevos empleados en la base de datos
     */

    public class LogicaRegister
    {
        public void registUsuario(string username, string password, int rol)
        {
            //Creamos la conexion con Postgre usando nuestra cadena de conexion almacenada en appsettings
            NpgsqlConnection connection = new NpgsqlConnection(connectionString: "PostgreSQL");
            connection.Open();

            // Creamos el commmand para ejecutar la querie
            NpgsqlCommand query = new NpgsqlCommand(String.Format("INSERT INTO  \"public\".\"dlk_cat_acc_empleado\" VALUES (\'null\', \'null\',\'{0}\',\'{1}\',{2}) ", username, password, rol), connection);



        }


    }
}
