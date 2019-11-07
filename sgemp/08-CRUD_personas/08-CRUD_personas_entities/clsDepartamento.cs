using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _08_CRUD_personas_entities
{
    public class clsDepartamento
    {
        public clsDepartamento()
        {
            nombreDepartamento = "ventas";
            id = 0;
        }
        public clsDepartamento(String nombreDepartamento,int id)
        {
            this.nombreDepartamento = nombreDepartamento;
            this.id = id;
        }
        public string nombreDepartamento { get; set; }
        public int id { get; }
    }

}