using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Acceso_Datos
{
    public class Conexion_Oracle
    {
        private readonly string connectionString;
        public Conexion_Oracle()
        {
            connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=DESKTOP-E1DPVHU)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=windows;Password=windows;";
        }
        protected OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }
    }
}
