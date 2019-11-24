
using _CRUD_personas_Entities;
using CRUD_personas_UWP_DAL.Conexion;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CRUD_Personas_UWP_DAL.Listado
{
    public class clsListadoPersonasDAL
    {
       
        public List<clsPersona> ListaPersonas()
        {
            List<clsPersona> lista = new List<clsPersona>();
            clsMyConnection conexion = new clsMyConnection();
            SqlConnection connection = conexion.getConnection();
            SqlCommand sqlcommand = new SqlCommand();
            SqlDataReader lector;
            clsPersona persona;

            sqlcommand.CommandText = "SELECT * FROM PD_Personas";
            sqlcommand.Connection = connection;
            lector = sqlcommand.ExecuteReader();

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    persona = new clsPersona();
                    persona.idPersona = (int)lector["IdPersona"];
                    persona.nombre = (lector["NombrePersona"] is DBNull) ? "NULL" : (string)lector["NombrePersona"];
                    persona.apellido = (lector["ApellidosPersona"] is DBNull) ? "NULL" : (string)lector["ApellidosPersona"];
                    persona.fecha = (lector["FechaNacimientoPersona"] is DBNull) ? new DateTime() : (DateTime)lector["FechaNacimientoPersona"];
                    persona.telefono = (lector["TelefonoPersona"] is DBNull) ? "NULL" : (string)lector["TelefonoPersona"];
                    persona.foto = (lector["FotoPersona"] is DBNull) ? new byte[0] : (Byte[])lector["FotoPersona"];
                    persona.IDdepartamento = (int)lector["IDDepartamento"];
                    lista.Add(persona);
                }
            }
            conexion.closeConnection(ref connection);

            return lista;
        }
        /// <summary>
        /// en este metodo se filtra la lista de personas segun lo que s ele pasa por parametros
        /// </summary>
        /// <param name="listado"></param>
        /// <param name="texto"></param>
        /// <returns></returns>
        public ObservableCollection<clsPersona> Filtrado(ObservableCollection<clsPersona> listado, String texto)
        {
            ObservableCollection<clsPersona> listadoFiltrado = new ObservableCollection<clsPersona>(listado.ToList().FindAll(persona => String.Concat(persona.nombre, " ", persona.apellido).Contains(texto)));

            return listadoFiltrado;
        }
    }
}
