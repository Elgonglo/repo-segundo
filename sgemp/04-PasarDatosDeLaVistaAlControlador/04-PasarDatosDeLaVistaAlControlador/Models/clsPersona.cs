using System;
using System.Collections.Generic;
using System.Text;

namespace _04_PasarDatosDeLaVistaAlControlador.Models
{
    public class clsPersona
    {
        
      
        //propiedades publicas
        public clsPersona()
        {
            nombre = "Gonzalo";
            apellido = "Gomez";
        }
        public clsPersona(String nombre,String apellido,DateTime fecha)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;
        }
        

        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha { get; set; }
    }
}
