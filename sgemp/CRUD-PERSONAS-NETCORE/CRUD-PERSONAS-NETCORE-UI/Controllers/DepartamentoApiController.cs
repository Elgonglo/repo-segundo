using CRUD_PERSONAS_NETCORE_BL.manejadora;
using CRUD_PERSONAS_NETCORE_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD_PERSONAS_NETCORE_UI.Controllers
{
    public class DepartamentoApiController : ApiController
    {
        // GET: api/DepartamentoApi
        public IEnumerable<clsDepartamento> Get()
        {
            ClsManejadoraPersonas_BL manejadora = new ClsManejadoraPersonas_BL();
            return manejadora.obtenerListadoDeDepartamentos();
        }

        // GET: api/DepartamentoApi/5
       /* public string Get(int id)
        {
            return "value";
        }*/

    }
}
