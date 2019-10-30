using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_examenListasAnidadas.Models
{
    class clsListaModelos
    {
        public clsListaModelos()
        {
            listaModelos1.Add(new clsModelo(0, "Fiesta"));
            listaModelos1.Add(new clsModelo(1, "Focus"));
            listaModelos1.Add(new clsModelo(2, "Kuga"));

            listaModelos2.Add(new clsModelo(0, "Clio"));
            listaModelos2.Add(new clsModelo(1, "Megane"));
            listaModelos2.Add(new clsModelo(2, "Scenic"));

            listaModelos3.Add(new clsModelo(0, "Ibiza"));
            listaModelos3.Add(new clsModelo(1, "León"));
            listaModelos3.Add(new clsModelo(2, "Tarraco"));
        }

        public List<clsModelo> listaModelos1 { get; set; }
        public List<clsModelo> listaModelos2 { get; set; }
        public List<clsModelo> listaModelos3 { get; set; }
    }
}
