using CRUD_PERSONAS_NETCORE_BL.listado;
using CRUD_PERSONAS_NETCORE_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CRUD_PERSONAS_NETCORE_UI.Models
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
