using _CRUD_personas_Entities;
using CRUD_personas_DAL.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_personas_BL.Lists
{
    public class clsListadoDepartamentosBL
    {
        
        public static IEnumerable<clsDepartamento> listadoDepartamentosDAL()
        {
            return clsListadoDepartamentosDAL.listadoDepartamentos_DAL();
        }

    }
}
