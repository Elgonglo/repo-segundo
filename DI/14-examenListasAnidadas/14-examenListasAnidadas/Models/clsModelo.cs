using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_examenListasAnidadas.Models
{
    class clsModelo
    {
        public clsModelo()
        {
            id = 0;
            nombre = " ";
        }
        public clsModelo(int id,String nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public int id{get; set;}

        public String nombre { get; set; }


    }
}
