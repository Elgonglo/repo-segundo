using _CRUD_Personas_netcore_DAL.listado;
using CRUD_Personas_netcore_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Personas_netcore_BL.listado
{
    public class clsListadoPersonasBL
    {
        //mejor un list
        public IEnumerable<clsPersona> ListadoPersonas()
        {
            //instanciar una clase listadoP
            return ClsListadoPersonasDAL.listaPersonas();
        }
    }
}
