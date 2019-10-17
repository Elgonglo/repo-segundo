using _04_PasarDatosDeLaVistaAlControlador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_PasarDatosDeLaVistaAlControlador.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Editar()//click derecho en editar y le pones edit
        {
            //Instanciamos un objeto de la clase persona con mis datos desde el constructor
            clsPersona persona = new clsPersona();
            //enviamos el objeto persona a la vista
            return View(persona);
        }
        [HttpPost]
        public ActionResult Editar(clsPersona persona)
        {
            return View("PersonasModificadas", persona);
        }
    }
}