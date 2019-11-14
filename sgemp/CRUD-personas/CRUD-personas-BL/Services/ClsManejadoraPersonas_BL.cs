﻿using _CRUD_personas_Entities;
using CRUD_personas_DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_personas_BL.Services
{
    public class ClsManejadoraPersonas_BL
    {
        /// <summary>
        /// Inserta la eprsona teniendo en cuenta la BL
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int insertarPersona_BL(clsPersona persona)
        {
            int filas = 0;
            ClsManejadoraPersonaDAL manejadora = new ClsManejadoraPersonaDAL();
            filas = manejadora.insertarPersona(persona);

            return filas;
        }
        /// <summary>
        /// Borra la persona teniendo en cuenta la BL
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int borrarPersona_BL(int id)
        {
            int filas = 0;
            ClsManejadoraPersonaDAL manejadora = new ClsManejadoraPersonaDAL();
            filas = manejadora.borrarPersona(id);
            return filas;
        }
        /// <summary>
        /// Busca a la persona teniendo en cuenta la BL
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public clsPersona buscarPersona_BL(int id)
        {
            clsPersona persona = new clsPersona();
            ClsManejadoraPersonaDAL manejadora = new ClsManejadoraPersonaDAL();
            persona = manejadora.buscarPersona(id);
            return persona;
        }
        
    }
}
