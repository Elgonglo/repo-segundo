using _08_CRUD_personas_DAL.Lists;
using _08_CRUD_personas_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CRUD_personas_BL.Lists
{
    public class ListaPersonas
    {
        public static IEnumerable<clsPersona> ListadoPersonas()
        {
            return clsListadoPersonasDAL.listaPersonas();
        }
    }
}
