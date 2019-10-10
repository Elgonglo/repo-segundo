using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_HolaMundoPasarDatosALaVista.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //esto en una funcion aparte saludar que asigne a un string
            DateTime hora = new DateTime();
            hora = DateTime.Now;
            if (hora.Hour < 12 && hora.Hour >7 )
            {
                ViewData["Hora"] = hora;
            }
            else if(hora.Hour > 12 && hora.Hour < 21)
            {   

            }
            //ViewData["Nombre"] = “Fernando";	return View(); 
            return View();
        }

    }
   

}