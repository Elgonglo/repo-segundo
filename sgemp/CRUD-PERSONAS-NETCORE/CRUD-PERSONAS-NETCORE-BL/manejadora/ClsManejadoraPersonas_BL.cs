using CRUD_PERSONAS_NETCORE_DAL.manejadora;
using CRUD_Personas_netcore_Entities;
using CRUD_PERSONAS_NETCORE_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PERSONAS_NETCORE_BL.manejadora
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
        /// <summary>
        /// Edita a la persona
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="telefono"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="idDepartamento"></param>
        /// <returns></returns>
        public bool editarPersona(int id, String nombre, String apellidos, String telefono, DateTime fechaNacimiento, int idDepartamento)
        {
            ClsManejadoraPersonaDAL manejadora = new ClsManejadoraPersonaDAL();
            return manejadora.editarPersona(id, nombre, apellidos, telefono, fechaNacimiento, idDepartamento);
        }
        /// <summary>
        /// obtiene los detalles de la persona
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public clsPersona obtenerPersona(int id)
        {
            ClsManejadoraPersonaDAL manejadora = new ClsManejadoraPersonaDAL();
            return manejadora.obtenerPersona(id);
        }

        public  List<clsDepartamento> obtenerListadoDeDepartamentos()
        {
            return ClsManejadoraPersonaDAL.obtenerListadoDeDepartamentos();
        }

        public clsDepartamento obtenerDepartamento(int id)
        {
            ClsManejadoraPersonaDAL manejadora = new ClsManejadoraPersonaDAL();
            return manejadora.obtenerDepartamento(id);
        }

    }
}
