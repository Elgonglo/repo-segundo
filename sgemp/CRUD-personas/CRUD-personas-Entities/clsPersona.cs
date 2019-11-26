using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.Mvc;

namespace _CRUD_personas_Entities
{
    public class clsPersona 
    {
              
        public clsPersona()
        {
            
        }
        public clsPersona(int IDpersona, String nombre, String apellido, DateTime fecha, String telefono, int IDdepartamento, byte[] foto)
        {
            this.idPersona = IDpersona;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;
            this.telefono = telefono;
            this.IDdepartamento = IDdepartamento;
            this.foto = foto;
        }


        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [MaxLength(40), Required]
        [Display(Name = "Apellido")]
        public string apellido { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime fecha { get; set; }

        public int IDdepartamento { get; set; }

        [RegularExpression(@"^(\+34|0034|34)?[6|7|8|9][0-9]{8}$"), Required]
        [Display(Name = "Telefono")]
        public String telefono { get; set; }

        [HiddenInput(DisplayValue = false)] 
        public int idPersona { get; set; }

        public byte[] foto { get; set; }

    }
}
