using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace _08_CRUD_personas_entities
{
    public class clsPersona 
    {
              
        public clsPersona()
        {
            this.nombre="Gonzalo";
            this.apellido = "Gomez";
            IDdepartamento = 0;
        }
        public clsPersona(String nombre, String apellido, DateTime fecha, int IDdepartamento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;
            this.IDdepartamento = IDdepartamento;
        }


        [Required]
        public string nombre { get; set; }

        public int IDpersona { get; }
        public string apellido { get; set; }
       

        public DateTime fecha { get; set; }
            
        public int IDdepartamento { get; set; }

    }
}
