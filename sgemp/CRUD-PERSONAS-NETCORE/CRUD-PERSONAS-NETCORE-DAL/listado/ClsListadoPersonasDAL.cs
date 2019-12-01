using _CRUD_Personas_netcore_DAL.Conexion;
using CRUD_Personas_netcore_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CRUD_Personas_netcore_DAL.listado
{
    public class ClsListadoPersonasDAL
    {
        public static IEnumerable<clsPersona> listaPersonas()
        {
            clsPersona persona;
            List<clsPersona> listado = new List<clsPersona>();
            clsMyConnection conexion = new clsMyConnection();
            SqlConnection connection = conexion.getConnection();
            SqlCommand sqlcommand = new SqlCommand();
            SqlDataReader miLector = null;

            sqlcommand.CommandText = "SELECT * FROM PD_Personas";
            sqlcommand.Connection = connection;
            try
            {
                miLector = sqlcommand.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        persona = new clsPersona();
                        persona.nombre = (string)miLector["NombrePersona"];
                        persona.apellido = (string)miLector["ApellidosPersona"];
                        persona.IDdepartamento = (int)miLector["IDDepartamento"];
                        persona.idPersona = (int)miLector["IdPersona"];
                        if (!String.IsNullOrEmpty(miLector["FechaNacimientoPersona"].ToString()))
                        {
                            persona.fecha = (DateTime)miLector["FechaNacimientoPersona"];
                        }
                        if (!String.IsNullOrEmpty(miLector["TelefonoPersona"].ToString()))
                        {
                            persona.telefono = (string)miLector["TelefonoPersona"];
                        }
                        listado.Add(persona);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                miLector.Close();
                conexion.closeConnection(ref connection);
            }
            return listado;
        }
    }
}
