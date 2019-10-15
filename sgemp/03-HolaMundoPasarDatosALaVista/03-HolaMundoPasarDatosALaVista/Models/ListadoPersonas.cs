using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _03_HolaMundoPasarDatosALaVista.Models
{
    public class ListadoPersonas
    {
        /// <summary>
        /// Aqui añade las personas y devuelve la lista
        /// </summary>
        /// <returns>List<clsPersona></returns>
        public List<clsPersona> ListarPersonas()
        {
            List<clsPersona> personas = new List<clsPersona>();
            personas.Add(new clsPersona());
            personas.Add(new clsPersona());
            personas.Add(new clsPersona());
            personas.Add(new clsPersona());
            personas.Add(new clsPersona());
            return personas;

        }
        

    }
}