using CRUD_PERSONAS_NETCORE_DAL.conexion;
using CRUD_PERSONAS_NETCORE_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PERSONAS_NETCORE_DAL.listado
{
   public class clsListadoDepartamentosDAL
    {
        public static List<clsDepartamento> listadoDepartamentos_DAL()
        {
            List<clsDepartamento> listado = new List<clsDepartamento>();
            clsMyConnection conexion = new clsMyConnection();
            SqlConnection connection = conexion.getConnection();
            SqlCommand sqlcommand = new SqlCommand();
            SqlDataReader miLector = null;
            clsDepartamento depart;

            sqlcommand.CommandText = "SELECT * FROM PD_Departamentos";
            sqlcommand.Connection = connection;
            try
            {
                miLector = sqlcommand.ExecuteReader();
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                            depart = new clsDepartamento();
                            depart.Id = (int)miLector["IdDepartamento"];
                            depart.Nombre = (String)miLector["NombreDepartamento"];
                            listado.Add(depart);
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
