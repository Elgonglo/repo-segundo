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
       
        public static IEnumerable<clsPersona> listaPersonas()
        {
            List<clsPersona> lista = new List<clsPersona>();
            clsMyConnection conexion = new clsMyConnection();
            SqlConnection connection = conexion.getConnection();
            SqlCommand sqlcommand = new SqlCommand();
            SqlDataReader Lector;
            clsPersona persona;

            sqlcommand.CommandText = "SELECT * FROM PD_Personas";
            sqlcommand.Connection = connection;
            //aqui un try catch
            Lector = sqlcommand.ExecuteReader();

            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    persona = new clsPersona();
                    persona.nombre = (string)Lector["NombrePersona"];
                    persona.apellido = (string)Lector["ApellidosPersona"];
                    lista.Add(persona);
                }
            }
            //cerrar datareader
            conexion.closeConnection(ref connection);

            return lista;
        }
    }
}
