using _CRUD_personas_Entities;
using _CRUD_Personas_UWP_DAL.Listado;
using System.Collections.Generic;

namespace _CRUD_Personas_UWP_BL.Listado
{
    public class clsListadoPersonasBL
    {
        //mejor un list
        public  IEnumerable<clsPersona> ListadoPersonas()
        {
            //instanciar una clase listadoP
            return clsListadoPersonasDAL.listaPersonas();
        }
    }
}
