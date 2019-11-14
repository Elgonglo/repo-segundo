using _CRUD_personas_DAL.Connection;
using _CRUD_personas_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_personas_DAL.Services
{
    public class ClsManejadoraPersonaDAL
    {
        /// <summary>
        /// Aqui se inserta la persona pasada por parametros
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int insertarPersona(clsPersona persona)
        {
            int filasAfectadas = 0;
            SqlConnection miConexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            clsMyConnection connection = new clsMyConnection();

            miConexion = connection.getConnection();
            miComando.CommandText = "INSERT INTO PD_Personas (NombrePersona,ApellidosPersona,IDDepartamento,FechaNacimientoPersona,TelefonoPersona) VALUES(@nombre,@apellido,@dep,@fecha,@tlfn)";
            miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.nombre;
            miComando.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar).Value = persona.apellido;
            miComando.Parameters.Add("@dep", System.Data.SqlDbType.Int).Value = persona.IDdepartamento;
            miComando.Parameters.Add("@fecha", System.Data.SqlDbType.DateTime).Value = persona.fecha;
            miComando.Parameters.Add("@tlfn", System.Data.SqlDbType.VarChar).Value = persona.telefono;

            miComando.Connection = miConexion;
            filasAfectadas = miComando.ExecuteNonQuery();

            connection.closeConnection(ref miConexion);

            return filasAfectadas;
        }
        /// <summary>
        /// Aqui se borra a la persona por el id pasado por parametro 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int borrarPersona(int id)
        {
            SqlConnection miConexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            clsMyConnection conexion = new clsMyConnection();
            int filas = 0;

            miConexion = conexion.getConnection();
            miComando.CommandText = "DELETE FROM PD_Personas WHERE IDpersona = @id";

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@id";
            param.SqlDbType = System.Data.SqlDbType.Int;
            param.Value = id;
            miComando.Parameters.Add(param);

            miComando.Connection = miConexion;
            filas = miComando.ExecuteNonQuery();

            conexion.closeConnection(ref miConexion);



            return filas;
        }
        /// <summary>
        /// Aqui se busca a la persona por el id que se le pasa por parametro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public clsPersona buscarPersona(int id)
        {
            clsPersona persona = new clsPersona();
            SqlConnection miConexion = new SqlConnection();
            SqlCommand elComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsMyConnection gestConexion = new clsMyConnection();
            miConexion = gestConexion.getConnection();
            elComando.CommandText = "SELECT * FROM PD_Personas WHERE IdPersona = @id";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@id";
            param.SqlDbType = System.Data.SqlDbType.Int;
            param.Value = id;
            elComando.Parameters.Add(param);
            elComando.Connection = miConexion;
            miLector = elComando.ExecuteReader();
            if (miLector.HasRows)
            {
                miLector.Read();
                persona = new clsPersona();
                if (!String.IsNullOrEmpty(miLector["FechaNacimientoPersona"].ToString()))
                {
                    persona.fecha = (DateTime)miLector["FechaNacimientoPersona"];
                }
                if (!String.IsNullOrEmpty(miLector["NombrePersona"].ToString()))
                {
                    persona.nombre = (string)miLector["NombrePersona"];
                }
                if (!String.IsNullOrEmpty(miLector["ApellidosPersona"].ToString()))
                {
                    persona.apellido = (string)miLector["ApellidosPersona"];
                }
                if (!String.IsNullOrEmpty(miLector["IDDepartamento"].ToString()))
                {
                    persona.IDdepartamento = (int)miLector["IDDepartamento"];
                }
                if (!String.IsNullOrEmpty(miLector["TelefonoPersona"].ToString()))
                {
                    persona.telefono = (string)miLector["TelefonoPersona"];
                }
                if (!String.IsNullOrEmpty(miLector["IdPersona"].ToString()))
                {
                    persona.idPersona = (int)miLector["idPersona"];
                }
            }
            miLector.Close();
            gestConexion.closeConnection(ref miConexion);
            return persona;
        }
    }
}
