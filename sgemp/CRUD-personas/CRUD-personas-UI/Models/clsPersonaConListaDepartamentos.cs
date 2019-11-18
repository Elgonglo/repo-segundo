using _CRUD_personas_BL.Lists;
using _CRUD_personas_Entities;
using CRUD_personas_BL.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CRUD_personas_UI.Models
{
    public class clsPersonaConListaDepartamentos : clsPersona
    {
        public clsPersonaConListaDepartamentos() : base()
        {
            Departamentos = clsListadoDepartamentosBL.listadoDepartamentosBL();
        }
        public clsPersonaConListaDepartamentos(int IDpersona, String nombre, String apellido, DateTime fecha, String telefono, int IDdepartamento) : base(IDpersona, nombre, apellido, fecha, telefono, IDdepartamento)
        {
            Departamentos = clsListadoDepartamentosBL.listadoDepartamentosBL();
        }
        public IEnumerable<clsDepartamento> Departamentos { get; set; }
        }
    
}
