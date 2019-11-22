﻿using _CRUD_personas_BL.Lists;
using _CRUD_personas_Entities;
using CRUD_personas_BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD_personas_UI.Controllers
{
    public class PersonaApiController : ApiController
    {
        // GET: api/PersonaApi
        public IEnumerable<clsPersona> Get()
        {
            clsListadoPersonasBL listado =  new clsListadoPersonasBL();
            return listado.ListadoPersonas();
        }

        // GET: api/PersonaApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PersonaApi
        public void Post([FromBody]clsPersona value)
        {
            ClsManejadoraPersonas_BL manejadora = new ClsManejadoraPersonas_BL();
            manejadora.insertarPersona_BL(value);
        }

        // PUT: api/PersonaApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PersonaApi/5
        public void Delete(int id)
        {
            ClsManejadoraPersonas_BL manejadora = new ClsManejadoraPersonas_BL();
            manejadora.borrarPersona_BL(id);
        }
    }
}