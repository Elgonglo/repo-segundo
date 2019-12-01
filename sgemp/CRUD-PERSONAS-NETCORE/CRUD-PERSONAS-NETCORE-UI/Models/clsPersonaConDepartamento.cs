using CRUD_PERSONAS_NETCORE_BL.manejadora;
using CRUD_PERSONAS_NETCORE_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_PERSONAS_NETCORE_UI.Models
{
    public class clsPersonaConDepartamento : clsPersona
    {
        private clsDepartamento _departamento;

        public clsPersonaConDepartamento(clsPersona persona) : base(persona.idPersona, persona.nombre, persona.apellido, persona.fecha, persona.telefono, persona.IDdepartamento, persona.foto)
        {
            ClsManejadoraPersonas_BL manejadora = new ClsManejadoraPersonas_BL();
            _departamento = manejadora.obtenerDepartamento(persona.IDdepartamento);
        }

        public clsDepartamento Departamento
        {
            get
            {
                return _departamento;
            }
            set
            {
                _departamento = value;
            }
        }
    }
}