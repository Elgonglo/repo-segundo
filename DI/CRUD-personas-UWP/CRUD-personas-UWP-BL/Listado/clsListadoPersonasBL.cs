using _CRUD_personas_Entities;
using _CRUD_Personas_UWP_DAL.Listado;
using CRUD_personas_UWP_DAL.Manejadora;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _CRUD_Personas_UWP_BL.Listado
{
    public class clsListadoPersonasBL
    {
        /// <summary>
        /// Obiene la lista de personas
        /// </summary>
        /// <returns></returns>
        public  List<clsPersona> ListadoPersonas()
        {
            clsListadoPersonasDAL lista = new clsListadoPersonasDAL();
            return lista.ListaPersonas();
        }

        /// <summary>
        /// filtra la loista de persona
        /// </summary>
        /// <param name="listado"></param>
        /// <param name="texto"></param>
        /// <returns></returns>
        public ObservableCollection<clsPersona> filtrado(ObservableCollection<clsPersona> listado, String texto)
        {
            clsListadoPersonasDAL listadoDAL = new clsListadoPersonasDAL();

            listado = listadoDAL.Filtrado(listado, texto);
            return listado;
        }

    }
}
