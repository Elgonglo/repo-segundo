using _CRUD_personas_BL.Lists;
using _CRUD_personas_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_personas_UI.Models
{
    public class clsPersonaConNombreDepartamento : clsPersona
    {
        public List<clsPersonaConDepartamento> obtenerListadoPersonasConDepartamento()
        {
            clsListadoPersonasBL listado = new clsListadoPersonasBL();
            List<clsPersonaConDepartamento> listadoPersonasConDepartamento = new List<clsPersonaConDepartamento>();
            List<clsPersona> listadoPersonas = listado.ListadoPersonas();
            clsPersona persona;

            for (int i = 0; i < listadoPersonas.Count; i++)
            {
                persona = listadoPersonas.ElementAt(i);
                listadoPersonasConDepartamento.Add(new clsPersonaConDepartamento(persona));
            }
            return listadoPersonasConDepartamento;
        }
    }
}