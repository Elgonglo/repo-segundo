using _CRUD_personas_Entities;
using CRUD_personas_UWP_DAL.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_personas_UWP_DAL.Manejadora
{
    public class manejadoraDAL
    {
        /// <summary>
        /// inserta la persona en la BBDD
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>las filas insertadas</returns>
        public int insertarPersonaDAL(clsPersona persona)
        {
            int fila = 0;
            clsMyConnection miConexion = new clsMyConnection();
            SqlConnection conexion = miConexion.getConnection();
            SqlCommand insertar = new SqlCommand();
            insertar.CommandText= "INSERT INTO PD_Personas(NombrePersona, ApellidosPersona, IDDepartamento, FechaNacimientoPersona, TelefonoPersona) values (@NombrePersona, @ApellidosPersona, @IDDepartamento ,@FechaNacimientoPersona, @TelefonoPersona)";
            insertar.Parameters.Add("@NombrePersona", SqlDbType.VarChar).Value = persona.nombre;
            insertar.Parameters.Add("@ApellidosPersona", SqlDbType.VarChar).Value = persona.apellido;
            insertar.Parameters.Add("@IDDepartamento", SqlDbType.Int).Value = persona.IDdepartamento;
            insertar.Parameters.Add("@FechaNacimientoPersona", SqlDbType.Date).Value = persona.fecha;
            insertar.Parameters.Add("@TelefonoPersona", SqlDbType.VarChar).Value = persona.telefono;
            insertar.Connection = conexion;
            fila = insertar.ExecuteNonQuery();
            miConexion.closeConnection(ref conexion);
            return fila;
        }
        /// <summary>
        /// Edita los datos de la persona
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int editarPersonaDAL(clsPersona persona)
        {
            int fila = 0;
            clsMyConnection miConexion = new clsMyConnection();
            SqlConnection conexion = miConexion.getConnection();
            SqlCommand editar = new SqlCommand();
            editar.CommandText= "UPDATE PD_Personas SET NombrePersona = @Nombre, ApellidosPersona = @Apellidos, IDDepartamento = @IdDepartamento, FechaNacimientoPersona = @FechaNacimiento, TelefonoPersona = @Telefono WHERE IdPersona = @Id";
            editar.Parameters.Add("@Id", SqlDbType.Int).Value = persona.idPersona;
            editar.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = persona.nombre;
            editar.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = persona.apellido;
            editar.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = persona.fecha;
            editar.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = persona.telefono;
            editar.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = persona.IDdepartamento;
            editar.Connection = conexion;
            fila = editar.ExecuteNonQuery();
            miConexion.closeConnection(ref conexion);
            return fila;
        }
        /// <summary>
        /// elimina a la persona de la BBDD
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int eliminarPersonaDAL(int ID)
        {
            int fila = 0;
            clsMyConnection miConexion = new clsMyConnection();
            SqlConnection conexion = miConexion.getConnection();
            SqlCommand eliminar = new SqlCommand();
            eliminar.CommandText = "DELETE FROM PD_Personas WHERE IdPersona = @Id";
            eliminar.Parameters.Add("@Id", SqlDbType.Int).Value = ID;
            eliminar.Connection = conexion;
            fila = eliminar.ExecuteNonQuery();
            miConexion.closeConnection(ref conexion);
            return fila;
        }
    }
}
