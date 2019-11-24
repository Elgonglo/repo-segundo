using CRUD_personas_UWP_DAL.Conexion;
using CRUD_personas_UWP_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_personas_UWP_DAL.Listado
{
    public class clsListadoDepartamentosDAL
    {
        /// <summary>
        /// devuelve la lista de departamentos que hay en la BBDD
        /// </summary>
        /// <returns></returns>
        public List<clsDepartamento> listadoDepartamentosDAL()
        {
            List<clsDepartamento> listaDepartamentos = new List<clsDepartamento>();
            clsDepartamento departamento;

            clsMyConnection miConexion = new clsMyConnection();
            SqlConnection conexion = null;

            SqlCommand listar = new SqlCommand();
            SqlDataReader miLector = null;

            conexion = miConexion.getConnection();

            listar.CommandText = "SELECT * FROM PD_Departamentos";
            listar.Connection = conexion;
            miLector = listar.ExecuteReader();

            if (miLector.HasRows)
            {
                while (miLector.Read())
                {
                    departamento = new clsDepartamento();
                    departamento.ID = (int)miLector["IdDepartamento"];
                    departamento.nombre = (String)miLector["NombreDepartamento"];
                    listaDepartamentos.Add(departamento);
                }
            }
            miConexion.closeConnection(ref conexion);
            return listaDepartamentos;
        }
    }
}
