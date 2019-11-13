using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _CRUD_personas_Entities
{ 
    public class clsDepartamento
    {
        public clsDepartamento()
        {
            nombre = "";
            id = 0;
        }
        public clsDepartamento(int id,String nombreDepartamento)
        {
            this.nombre = nombreDepartamento;
            this.id = id;
        }
        public string nombre { get; set; }
        public int id { get; }
    }

}