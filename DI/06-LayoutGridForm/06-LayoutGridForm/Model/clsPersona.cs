using System;
using System.Collections.Generic;
using System.Text;

namespace _06_LayoutGridForm.Models
{
    public class clsPersona
    {
        //atributos privados
        private string _nombre;
       
        //propiedades publicas
        public clsPersona()
        {

        }
        public clsPersona(String nombre,String apellido,DateTime fecha)
        {
            _nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;
        }
        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;   
            }
        }

        public string apellido { get; set; }
        public DateTime fecha { get; set; }
    }
}
