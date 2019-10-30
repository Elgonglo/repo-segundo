using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_examenListasAnidadas.Models
{
    class clsMarca
    {
        public clsMarca()
        {
            id = 0;
            nombre = " ";
        }
        public clsMarca(int id, String nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public int id { get; set; }

        public String nombre { get; set; }


    }
}
