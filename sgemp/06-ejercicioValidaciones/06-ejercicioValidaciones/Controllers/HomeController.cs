using _06_ejercicioValidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06_ejercicioValidaciones.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            clsPersona oPersona= new clsPersona();
            return View(oPersona);
        }



        // POST: Home/Create
        [HttpPost]
        public ActionResult Index( clsPersona oPersona)
        {
            if (!ModelState.IsValid)
            {          
                return View(oPersona);
            }
            else
            {                              
                return View("PersonasModificadas",oPersona);
            }

        }
    }
}
