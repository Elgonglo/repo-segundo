using _CRUD_personas_Entities;
using CRUD_personas_DAL.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CRUD_personas_BL.Lists
{
    public class clsListadoPersonasBL
    {
        //mejor un list
        public List<clsPersona> ListadoPersonas()
        {
            ClsListadoPersonasDAL listado = new ClsListadoPersonasDAL();
            return listado.listaPersonas();
        }
    }
}
