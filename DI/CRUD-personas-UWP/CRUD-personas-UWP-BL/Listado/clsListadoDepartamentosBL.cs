using CRUD_personas_UWP_DAL.Listado;
using CRUD_personas_UWP_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_personas_UWP_BL.Listado
{
    public class clsListadoDepartamentosBL
    {
        public List<clsDepartamento> listadoDepartamentosBL()
        {
            clsListadoDepartamentosDAL listaDAL = new clsListadoDepartamentosDAL();
            List<clsDepartamento> lista = new List<clsDepartamento>();
            lista = listaDAL.listadoDepartamentosDAL();
            return lista;
        }
    }
}
