using _17_CRUD_Personas_UWP_DAL.Listado;
using _17_CRUD_Personas_UWP_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CRUD_Personas_UWP_BL.Listado
{
    public class clsListadoPersonasBL
    {
        //mejor un list
        public static IEnumerable<clsPersona> ListadoPersonas()
        {
            //instanciar una clase listadoP
            return clsListadoPersonasDAL.listaPersonas();
        }
    }
}
