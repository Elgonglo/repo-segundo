using _08_CRUD_personas_entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CRUD_personas_DAL.Lists
{
    public class clsListadoPersonasDAL
    {
        //TODO: Funcion que devuelva un listado de personas

        public static IEnumerable<clsPersona> listaPersonas()
        {
            List<clsPersona> lista = new List<clsPersona>();
            clsMyConnection conexion = new clsMyConnection();
            SqlConnection connection = conexion.getConnection();
            SqlCommand sqlcommand = new SqlCommand();
            SqlDataReader miLector;
            clsPersona persona;

            sqlcommand.CommandText = "SELECT * FROM PD_Personas";
            sqlcommand.Connection = connection;
            miLector = sqlcommand.ExecuteReader();

            if (miLector.HasRows)
            {
                while (miLector.Read())
                {
                    persona = new clsPersona();
                    //persona.fecha = (DateTime)miLector["FechaNacimientoPersona"];
                    persona.nombre = (string)miLector["NombrePersona"];
                    persona.apellido = (string)miLector["ApellidosPersona"];
                    lista.Add(persona);
                }
            }

            conexion.closeConnection(ref connection);

            return lista;
        }
    }
}
