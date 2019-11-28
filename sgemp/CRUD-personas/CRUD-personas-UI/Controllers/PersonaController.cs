using _CRUD_personas_BL;
using _CRUD_personas_BL.Lists;
using _CRUD_personas_Entities;
using CRUD_personas_BL.Lists;
using CRUD_personas_BL.Services;
using CRUD_personas_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_personas_UI.Controllers
{
    public class PersonaController : Controller
    {
        /// <summary>
        /// Se va a la lista
        /// </summary>
        /// <returns></returns>
        public ActionResult list()
        {
            try
            {
                clsListadoPersonasBL listado = new clsListadoPersonasBL();
                return View(listado.ListadoPersonas());
            }
            catch (Exception e)
            {
                return View("Error"); //Pagina de error
            }

        }
        /// <summary>
        /// se va a la vista crear
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            try
            {
                clsPersonaConListaDepartamentos personaConDepartamento = new clsPersonaConListaDepartamentos();
                clsListadoDepartamentosBL listaDep = new clsListadoDepartamentosBL();
                personaConDepartamento.Departamentos = clsListadoDepartamentosBL.listadoDepartamentosBL();
                return View(personaConDepartamento);
            }
            catch (Exception)
            {
                return View("Error");
            }
            
        }

        [HttpPost]
        public ActionResult Create(clsPersonaConListaDepartamentos personaConDepart)
        {
            ClsManejadoraPersonas_BL manejadora = new ClsManejadoraPersonas_BL();
            List<clsPersona> lista = new List<clsPersona>();
            clsPersona persona = new clsPersona(personaConDepart.IDdepartamento, personaConDepart.nombre, personaConDepart.apellido, personaConDepart.fecha, personaConDepart.telefono, personaConDepart.IDdepartamento,personaConDepart.foto);
            clsListadoPersonasBL listado = new clsListadoPersonasBL();

            if (ModelState.IsValid)
            { 
                try
                {
                    manejadora.insertarPersona_BL(persona);
                    ViewData["Mensaje"] = $"Se ha insertado Correctamente";
                    return RedirectToAction("list");
                }
                catch (Exception e)
                {
                    return View("Error");
                }
            }
            else
            {
                return View(); 
            }
        }
        /// <summary>
        /// Aqui se borra
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            ClsManejadoraPersonas_BL manejadora = new ClsManejadoraPersonas_BL();
            clsPersona persona = new clsPersona();
            persona = manejadora.buscarPersona_BL(id);
            clsPersonaConDepartamento personaDepart = new clsPersonaConDepartamento(persona);
            return View(personaDepart);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            ClsManejadoraPersonas_BL manejadora = new ClsManejadoraPersonas_BL();
            int filas = 0;

            try
            {
                filas = manejadora.borrarPersona_BL(id);
                ViewData["FilasAfectadas"] = $"Se ha borrado  {filas} ";
            }
            catch (Exception e)
            {
                return View("Error");
            }

            clsListadoPersonasBL listado = new clsListadoPersonasBL();

            return View("list", listado.ListadoPersonas());
        }
        /// <summary>
        /// Aqui se edita
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            ClsManejadoraPersonas_BL manejadora = new ClsManejadoraPersonas_BL();
            clsPersona persona = manejadora.obtenerPersona(id);
            clsPersonaConListaDepartamentos personaConDepartamentos = new clsPersonaConListaDepartamentos(persona);

            return View(personaConDepartamentos);
        }
        [HttpPost]
        public ActionResult Edit(clsPersonaConListaDepartamentos personaConDepartamentos)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ClsManejadoraPersonas_BL manejadora = new ClsManejadoraPersonas_BL();
                    if (manejadora.editarPersona(personaConDepartamentos.idPersona, personaConDepartamentos.nombre, personaConDepartamentos.apellido, personaConDepartamentos.telefono, personaConDepartamentos.fecha, personaConDepartamentos.IDdepartamento))
                    {
                        ViewBag.MensajePersonaModificada = "La persona se ha modificado correctamente.";
                    }
                    else
                    {
                        ViewBag.MensajePersonaModificada = "La persona no se ha podido modificar.";
                    }

                    return View(personaConDepartamentos);
                }
                catch (Exception e)
                {
                    return View("Error");
                }
            }
            else
            {
                return View();
            }
        }
        /// <summary>
        /// Aqui se ve los detalles de la persona
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            ClsManejadoraPersonas_BL manejadora = new ClsManejadoraPersonas_BL();
            clsPersona clsPersona = manejadora.obtenerPersona(id);

            clsPersonaConDepartamento personaConDepartamento = new clsPersonaConDepartamento(clsPersona);
            return View(personaConDepartamento);
        }
    }
}
