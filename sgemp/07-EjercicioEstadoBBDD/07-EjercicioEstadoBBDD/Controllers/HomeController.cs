using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace _07_EjercicioEstadoBBDD.Controllers
{
    public class HomeController : Controller
    {
       
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost,ActionName("Index")]
        public ActionResult IndexPost()
        {
            SqlConnection miConexion = new SqlConnection();
            try
            {
                miConexion.ConnectionString = "server=gonglo.database.windows.net;database=PersonasDB;uid=gonglo;pwd=1q2w3e4r.;";
                miConexion.Open();
                ViewData["estado"] = miConexion.State;
            }
            catch (SqlException)
            {
                return View("ErrorView");
            }
            finally
            {
                miConexion.Close();
            }

            return View();
        }
    }
}