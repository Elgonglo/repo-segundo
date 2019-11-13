using _CRUD_personas_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_personas_Entities
{
    public class clsPersonaConListaDepartamentos : clsPersona
    {
        public clsPersonaConListaDepartamentos() : base()
        {
        }
            public List<clsDepartamento> departamentos { get; set; }
        }
    
}
