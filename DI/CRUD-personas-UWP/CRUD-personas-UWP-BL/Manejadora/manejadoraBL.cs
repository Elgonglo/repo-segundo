using _CRUD_personas_Entities;
using CRUD_personas_UWP_DAL.Manejadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_personas_UWP_BL.Manejadora
{
    public class manejadoraBL
    {
        /// <summary>
        /// inserta la persona en la BBDD
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int insertarPersonaBL(clsPersona persona)
        {
            int fila = 0;
            manejadoraDAL gestion = new manejadoraDAL();
            fila = gestion.insertarPersonaDAL(persona);
            return fila;
        }
        /// <summary>
        /// edita los datos de la persona
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int editarPersonaBL(clsPersona persona)
        {
            int fila = 0;
            manejadoraDAL gestion = new manejadoraDAL();
            fila = gestion.editarPersonaDAL(persona);
            return fila;
        }
        /// <summary>
        /// Elimina a una persona de la BBDD
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int eliminarPersonaBL(int ID)
        {
            int fila = 0;
            manejadoraDAL gestion = new manejadoraDAL();
            fila = gestion.eliminarPersonaDAL(ID);
            return fila;
        }
    }
}
