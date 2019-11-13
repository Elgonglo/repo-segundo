using _CRUD_personas_Entities;
using CRUD_personas_DAL.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CRUD_personas_BL
{
    public class clsListadoPersonasBL
    {
        //mejor un list
        public static IEnumerable<clsPersona> ListadoPersonas()
        {
            //instanciar una clase listadoP
            return ClsListadoPersonasDAL.listaPersonas();
        }
    }
}
