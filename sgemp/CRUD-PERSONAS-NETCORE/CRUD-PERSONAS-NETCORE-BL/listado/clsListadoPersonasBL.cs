using CRUD_PERSONAS_NETCORE_DAL.listado;
using CRUD_PERSONAS_NETCORE_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PERSONAS_NETCORE_BL.listado
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
