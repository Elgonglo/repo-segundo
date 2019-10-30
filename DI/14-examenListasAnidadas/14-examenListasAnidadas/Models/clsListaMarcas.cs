using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_examenListasAnidadas.Models
{
    class clsListaMarcas
    {
        public List<clsMarca> ListarMarcas()
        {
            listaMarcas.Add(new clsMarca(0, "Ford"));
            listaMarcas.Add(new clsMarca(1, "Renault"));
            listaMarcas.Add(new clsMarca(2, "Seat"));

            return listaMarcas;
        }

        public List<clsMarca> listaMarcas { get; set; }
    }
}
