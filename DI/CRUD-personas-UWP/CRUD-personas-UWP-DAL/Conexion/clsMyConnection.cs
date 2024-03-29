﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_personas_UWP_DAL.Conexion
{
    public class clsMyConnection
    {
        //Atributos
        public String server { get; set; }
        public String dataBase { get; set; }
        public String user { get; set; }
        public String pass { get; set; }

        //Constructores
        //"server=gonglo.database.windows.net;database=PersonasDB;uid=gonglo;pwd=1q2w3e4r.;"
        public clsMyConnection()
        {
            this.server = "gonglo.database.windows.net";

            this.dataBase = "PersonasDB";
            this.user = "gonglo";
            //this.pass = "123";
            this.pass = "1q2w3e4r.";

        }
        public clsMyConnection(String server, String database, String user, String pass)
        {
            this.server = server;
            this.dataBase = database;
            this.user = user;
            this.pass = pass;
        }


        //METODOS

        /// <summary>
        /// Metodo para abrir la conexion con la base de datos
        /// </summary>
        /// <pre></pre>
        /// <returns>devuelve la conexion con la base de datos</returns>
        public SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection();

            try
            {

                //connection.ConnectionString = string.Format("server={0};database={1};uid={2};pwd={3};", server, dataBase, user, pass);
                connection.ConnectionString = $"server={server};database={dataBase};uid={user};pwd={pass};";
                connection.Open();
            }
            catch (SqlException)
            {
                throw;
            }

            return connection;

        }

        /// <summary>
        /// cierra la copnexion con la base de datos
        /// </summary>
        /// <post></post>
        /// <param name="connection">la conexión que vas a cerrar
        /// </param>
        public void closeConnection(ref SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }

}
