using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_PERSONAS_NETCORE_Entities
{ 
    public class clsDepartamento
    {
        private int _id;
        private String _nombre;

        public clsDepartamento()
        {
            _nombre = "";
            _id = 0;
        }
        public clsDepartamento(int id,String nombreDepartamento)
        {
            _nombre = nombreDepartamento;
            _id = id;
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public String Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
    }

}