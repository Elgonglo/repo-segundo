using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_HolaMundoMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        

        public ActionResult holaMundo()
        {
            return View();
        }
        public ActionResult index()
        {
            return View();
        }
    }
}