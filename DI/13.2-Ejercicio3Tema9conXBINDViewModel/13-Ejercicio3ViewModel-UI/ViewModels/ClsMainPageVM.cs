using _13_Ejercicio3Tema9_Entities;
using _13_Ejercicio3ViewModel_UI.Models.Utilidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace _13_Ejercicio3ViewModel_UI.ViewModels 
{
    public class ClsMainPageVM : INotifyPropertyChanged
    {
        //despues se añade el notify

        //Atributos clase persona
        private clsPersona _personaSeleccionada;
        private ObservableCollection<clsPersona> _listadoPersonas;

        public ClsMainPageVM()
        {
            //se rellena la lista de personas
            ListadoPersonas listado = new ListadoPersonas();
            this._listadoPersonas= listado.ListarPersonas();
        }
        public clsPersona PersonaSeleccionada
        {
            
            get{
                    return _personaSeleccionada;
             }
            set{
                if (_personaSeleccionada != value)
                {
                    _personaSeleccionada = value;
                    NotifyPropertyChanged("PersonaSeleccionada");
                }
                 
            } 
        }

        public ObservableCollection<clsPersona> ListadoPersonas
        {
            get
            {
                return _listadoPersonas;
            }
            set
            {
                _listadoPersonas = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            ListadoPersonas.Remove(_personaSeleccionada);
        }

    }
}
