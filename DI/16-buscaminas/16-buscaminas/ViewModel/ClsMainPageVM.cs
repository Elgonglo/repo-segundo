using _16_buscaminas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_buscaminas.ViewModel
{
    class ClsMainPageVM : INotifyPropertyChanged
    {
        private clsCarta _cartaSeleccionada;
        private ListaCartas _tablero;
        public ClsMainPageVM()
        {
            this._tablero = new ListaCartas();
        }

        public clsCarta CartaSeleccionada
        {

            get
            {
                return _cartaSeleccionada;
            }
            set
            {
                _cartaSeleccionada = value;
                NotifyPropertyChanged("CartaSeleccionada");
            }
        }
        public ListaCartas Tablero
        {
            get
            {
                ListaCartas listita = new ListaCartas();
                _tablero = listita.lista();
                return _tablero;
            }
            set
            {
                _tablero = value;
                NotifyPropertyChanged("Tablero");
            }
        }

        private void NotifyPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
