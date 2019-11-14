using _CRUD_personas_DAL.Connection;
using _CRUD_personas_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_personas_DAL.Lists
{
    public class ClsListadoPersonasDAL
    {
        public static IEnumerable<clsPersona> listaPersonas()
        {
            List<clsPersona> listado = new List<clsPersona>();
            clsMyConnection conexion = new clsMyConnection();
            SqlConnection connection = conexion.getConnection();
            SqlCommand sqlcommand = new SqlCommand();
            SqlDataReader miLector = null;
            clsPersona persona;

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
                        //persona.fecha = (DateTime)miLector["FechaNacimientoPersona"];
                        persona.nombre = (string)miLector["NombrePersona"];
                        persona.apellido = (string)miLector["ApellidosPersona"];
                        persona.IDdepartamento = (int)miLector["IDDepartamento"];
                        persona.telefono = (string)miLector["TelefonoPersona"];
                        persona.idPersona = (int)miLector["IdPersona"];
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
