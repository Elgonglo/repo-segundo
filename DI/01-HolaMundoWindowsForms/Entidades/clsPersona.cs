using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class clsPersona
    {
        //atributos privados
        private string _nombre;
        private string _apellido;
        //propiedades publicas
        public clsPersona()
        {

        }
        public clsPersona(String nombre,String ape)
        {
            _nombre = nombre;
            _apellido = ape;

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
    }
}
