using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0666_conexion_bbdd
{

    public class clsPersona
    {
       
        public clsPersona()
        {

        }



        public clsPersona(int idPersona, String nombre, String apellidos, DateTime fechaNacimiento, String direccion, String telefono, int idDepartamento)
        {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            this.direccion = direccion;
            this.idDepartamento = idDepartamento;
        }

        public int idPersona { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public int idDepartamento { get; set; }

    }
}