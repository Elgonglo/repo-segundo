using _03_HolaMundoPasarDatosALaVista.Models;
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
            //Declaracion
            DateTime hora = new DateTime();
            clsPersona persona;
            //instanciacion
            hora = DateTime.Now;
            persona = new clsPersona();
            ViewBag.fecha = hora.ToLongDateString();
            persona.nombre = "Gonzalo";
            persona.apellido = "Gomez";
            if (hora.Hour >= 12 && hora.Hour <= 19)
            {
                ViewData["Saludo"] = "Buenas tardes";
            }
            else if (hora.Hour >= 20 && hora.Hour <= 6)
            {
                ViewData["Saludo"] = "Buenas noches";
            }
            else
            {
                ViewData["Saludo"] = "Buenos dias";
            }
           
            return View(persona);
        }
        public ActionResult ListadoPersonas()
        {
            ListadoPersonas listaPersonas = new ListadoPersonas();
            return View(listaPersonas);
        }
    }
   

}