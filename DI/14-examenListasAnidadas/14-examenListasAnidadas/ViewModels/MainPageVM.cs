using _14_examenListasAnidadas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_examenListasAnidadas.ViewModels
{
    class MainPageVM : INotifyPropertyChanged
    {
        private clsMarca _marcaSeleccionada;
        private List<clsMarca> _listadoMarcas;

        public MainPageVM()
        {
            clsListaMarcas listado = new clsListaMarcas();
            this._listadoMarcas = listado.ListarMarcas();
        }

        public clsMarca marcaSeleccionada
        {
            get
            {
                return _marcaSeleccionada;
            }
            set
            {
                _marcaSeleccionada = value;
                INotifyPropertyChanged("marcaSeleccionada");
            }
        }

        public List<clsMarca> listadoMarcas
        {
            get
            {
                return _listadoMarcas;
            }
        }

        private void INotifyPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
