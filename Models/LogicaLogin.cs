using DAL_CSPharmaV2.Models;
using Npgsql;
using DAL_CSPharmaV2.Models;
using NuGet.Packaging.Signing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CSPharma_V2.Models
{
    /*
     * LogicaLogin --> Clase que se encarga de realizar la consulta para el login de nuestra aplicacion
     */

    public class LogicaLogin
    {
        public List<DlkCatAccEmpleado> loginEmpleado(string username, string password)
        {
            //Creamos una lista de empleados para almacenarlos en caso de que exista alguno con las credenciales recibidas
            List<DlkCatAccEmpleado> listEmpleado = new List<DlkCatAccEmpleado>();

            //Creamos la conexion con Postgre usando nuestra cadena de conexion almacenada en appsettings
            NpgsqlConnection connection = new NpgsqlConnection(connectionString: "PostgreSQL");
            connection.Open();

            //Creamos el commmand para ejecutar la querie
            NpgsqlCommand query = new NpgsqlCommand(String.Format("SELECT * FROM \"cspharma_informacional\".\"dlk_cat_acc_empleado\" WHERE cod_empleado='{0}' AND clave_empleado='{1}'", username, password), connection);

            //Creamos el lector de resultados y comprobamos si existe un registro que contenga los datos que hemos introducido
            NpgsqlDataReader lector = query.ExecuteReader();

            /*Comprobamos si existe el registro, en caso contrario saldremos del metodo directamente,
             * ya que no tiene sentido seguir ejecutandolo
            */
            if (lector is null)
            {
                //Cerramos la conexion
                connection.Close();
                return null;
            }

            /*
             * Si nuestro codigo llega a este punto, significa que existe un empleado con las credenciales obtenidas,
             * ahora lo guardaremos en la lista para poder utilizarlo en el controlador mas adelante
             */

            //Creamos el empleado con el constructor vacio aprovechando que c# por defecto nos permite crearlo asi
            DlkCatAccEmpleado empleado = new DlkCatAccEmpleado();

            //A continuacion aprovecharemos el encapsulamiento para darle valores
            empleado.MdUidd = (string)lector[0];
            empleado.MdDate = (TimeOnly)lector[1];
            empleado.CodEmpleado = (string)lector[2];
            empleado.ClaveEmpleado = (string)lector[3];
            empleado.NivelAccesoEmpleado = (Int32)lector[4];
            
            //Añadimos el empleado a la lista de empleados
            listEmpleado.Add(empleado);
            connection.Close();

            //Devolvemos la lista de empleado
            return listEmpleado;
        }

    }

}
