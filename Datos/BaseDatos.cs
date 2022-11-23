using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class BaseDatos
    {
        string cadena = "user id=system;password=123456;data source=" +
                        "(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)" +
                        "(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=" +
                        "(SERVICE_NAME=xe)))";
       public OracleConnection cnn = null;
        public BaseDatos() 
        {
            cnn = new OracleConnection();
            cnn.ConnectionString= cadena;
        }  
    }
}
