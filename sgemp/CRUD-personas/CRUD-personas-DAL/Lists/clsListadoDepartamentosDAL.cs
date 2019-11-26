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
                        if (!String.IsNullOrEmpty(miLector["NombreDepartamento"].ToString()))
                        {
                            depart.Nombre = (String)miLector["NombreDepartamento"];
                        }
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
