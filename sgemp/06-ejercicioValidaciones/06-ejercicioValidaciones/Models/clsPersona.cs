using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _06_ejercicioValidaciones.Models
{
    public class clsPersona
    {


        //propiedades publicas
        public clsPersona()
        {
            idPersona = 0;
            nombre = "Gonzalo";
            apellido = "Gomez";
            fecha = DateTime.Now;
            direccion = "Calle aries";
            telefono = "647141695";
        }
        public clsPersona(int id, String nombre, String apellido, DateTime fecha, String direccion, String telefono)
        {
            this.idPersona = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        public int idPersona { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string nombre { get; set; }
        [MaxLength(40), Required]
        public string apellido { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd - MM - yyyy}",ApplyFormatInEditMode = true)]
        public DateTime fecha { get; set; }
        [MaxLength(200),Required]
        public string direccion { get; set; }
        [RegularExpression(@"^(\+34|0034|34)?[6|7|8|9][0-9]{8}$", ErrorMessage = "Telefono no valido")]
        public string telefono { get; set; }
    }
}
