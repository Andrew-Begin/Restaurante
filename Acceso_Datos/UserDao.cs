using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using Capa_Transversal;

namespace Acceso_Datos
{
    public class UserDao : Conexion_Oracle
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand("fn_login(:v_usuario,:v_clave)"))
                {
                    command.Connection = connection;
                    command.CommandText = ("SELECT us.id,us.nombre||' '||us.apellidos as Nombre,us.usuario,us.contrasena,us.email,us.fono,us.rol_id,ro.rol_descripcion,us.estado FROM usuario us JOIN roles ro ON us.rol_id = ro.rol_id where USUARIO=:usuario and CONTRASENA=:contrasena");

                    command.Parameters.Add(":usuario", user);
                    command.Parameters.Add(":contrasena", pass);
                    command.CommandType = System.Data.CommandType.Text;

                    OracleDataReader reader;
                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            
                            CacheInicioSesion.ID = reader.GetInt32(0);
                            CacheInicioSesion.Nombre = reader.GetString(1);
                            CacheInicioSesion.Usuario = reader.GetString(2);
                            CacheInicioSesion.Contrasena = reader.GetString(3);
                            CacheInicioSesion.Email = reader.GetString(4);
                            CacheInicioSesion.Fono = reader.GetString(5);
                            CacheInicioSesion.Rol_id = reader.GetInt32(6);
                            CacheInicioSesion.Rol = reader.GetString(7);
                            CacheInicioSesion.Estado = reader.GetString(8);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
