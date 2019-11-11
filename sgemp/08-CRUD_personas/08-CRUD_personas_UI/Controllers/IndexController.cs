using _08_CRUD_personas_BL.Lists;
using _08_CRUD_personas_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Personas_UI.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult MainPage()
        {
            return View(ListaPersonas.ListadoPersonas());
        }
    }
}