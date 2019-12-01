using CRUD_PERSONAS_NETCORE_BL.listado;
using CRUD_PERSONAS_NETCORE_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_PERSONAS_NETCORE_UI.Models
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