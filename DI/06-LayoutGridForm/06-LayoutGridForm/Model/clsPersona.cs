using System;
using System.Collections.Generic;
using System.Text;

namespace _06_LayoutGridForm.Models
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
