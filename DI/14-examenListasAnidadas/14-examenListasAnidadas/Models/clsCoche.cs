using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_examenListasAnidadas.Models
{
    class clsCoche
    {
        public clsCoche()
        {
            id = 0;
            idMarca = 0;
            idModelo = 0;
        }
        public clsCoche(int id,int idMarca,int idModelo)
        {
            this.id = id;
            this.idMarca = idMarca;
            this.idModelo = idModelo;
        }
        public int id { get; set; }
        public int idMarca { get; set; }
        public int idModelo { get; set; }
    }
}
