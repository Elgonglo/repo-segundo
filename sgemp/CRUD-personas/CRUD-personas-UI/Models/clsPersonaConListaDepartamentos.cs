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
        private List<clsDepartamento> _departamentos;
        public clsPersonaConListaDepartamentos() : base()
        {
            _departamentos = clsListadoDepartamentosBL.listadoDepartamentosBL();
        }
        public clsPersonaConListaDepartamentos(clsPersona persona) : base(persona.idPersona, persona.nombre, persona.apellido, persona.fecha, persona.telefono, persona.IDdepartamento, persona.foto)
        {
            _departamentos = clsListadoDepartamentosBL.listadoDepartamentosBL();
        }
        public clsPersonaConListaDepartamentos(int IDpersona, String nombre, String apellido, DateTime fecha, String telefono, int IDdepartamento,byte[] foto) : base(0, nombre, apellido, fecha, telefono, IDdepartamento,foto)
        {
            _departamentos = clsListadoDepartamentosBL.listadoDepartamentosBL();
        }
        public List<clsDepartamento> Departamentos
        {
            get
            {
                return _departamentos;
            }
            set
            {
                _departamentos = value;
            }

        }

    }
}
