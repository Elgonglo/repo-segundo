using _08_CRUD_personas_BL.Lists;
using _08_CRUD_personas_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Personas_UI.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Index
        public ActionResult list()
        {
            try
            {
                return View(clsListadoPersonasBL.ListadoPersonas());
            }
            catch(Exception e)
            {
                return View("Error");//a una pagina de error
            }
            
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(clsPersona persona)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //TODO insertar en la base de datos llamamos a la capa bl que va a la dal
                    return View();//Esta vista retorna un mensaje de guardado correctamente(viewBag)
                }catch(Exception e)
                {
                    return View("Error");
                }
            }
            else
            {
                return View();
            }
            
        }
    }
}