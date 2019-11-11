using ejerciciodecomandos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ejerciciodecomandos.ViewModel
{
    public class ClsMainPageVM : INotifyPropertyChanged
    {
        //despues se añade el notify

        //Atributos clase persona
        private DelegateCommand commandEliminar;
        private clsPersona _personaSeleccionada;
        private DelegateCommand commandBuscar;
        private ObservableCollection<clsPersona> _listadoPersonas;
        private string stringPersona;

        public ClsMainPageVM()
        {
            //se rellena la lista de personas
            commandEliminar = new DelegateCommand(Eliminar, puedeEliminar);
            commandBuscar = new DelegateCommand(Buscar, puedeBuscar);
            ListadoPersonas listado = new ListadoPersonas();
            this._listadoPersonas = listado.ListarPersonas();
        }
        public clsPersona PersonaSeleccionada
        {

            get
            {
                return _personaSeleccionada;
            }
            set
            {
                if (_personaSeleccionada != value)
                {
                    _personaSeleccionada = value;
                    NotifyPropertyChanged("PersonaSeleccionada");
                    commandEliminar.RaiseCanExecuteChanged();
                }

            }
        }
        public String buscar { get; set; }
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

        public async void Eliminar()
        {
            ContentDialog confirmacion = new ContentDialog();

            confirmacion.Title = "Eliminar";
            confirmacion.Content = "¿Esta seguro de que quiere borrar?";
            confirmacion.PrimaryButtonText = "Cancelar";
            confirmacion.SecondaryButtonText = "Aceptar";
            ContentDialogResult resultado = await confirmacion.ShowAsync();

            if (resultado == ContentDialogResult.Secondary)
            {
                ListadoPersonas.Remove(_personaSeleccionada);
                NotifyPropertyChanged("ListadoPersonas");
                NotifyPropertyChanged("PersonaSeleccionada");
            }
        }
        public void Buscar()
        {
            ListadoPersonas listado = new ListadoPersonas();
            _listadoPersonas = listado.filtrar(ListadoPersonas, stringPersona);
            NotifyPropertyChanged("ListadoPersonas");
        }
        public bool puedeEliminar()
        {
            bool devol = false;

            if (PersonaSeleccionada != null)
            {
                devol = true;
            }
            return devol;
        }
        public bool puedeBuscar()
        {
            bool devol = false;

            if (!String.IsNullOrEmpty(stringPersona))
            { 
                devol = true;
            }

            return devol;
        }
        public String StringPersona
        {
            get
            {
                return stringPersona;
            }
            set
            {
                stringPersona = value;
                NotifyPropertyChanged("StringPersona");
                commandBuscar.RaiseCanExecuteChanged();
                if (String.IsNullOrEmpty(stringPersona))
                {
                    ListadoPersonas listado = new ListadoPersonas();
                    _listadoPersonas = listado.ListarPersonas();
                    NotifyPropertyChanged("ListadoPersonas");
                }
            }
        }
        public DelegateCommand CommandEliminar{get;}
        public DelegateCommand CommandBuscar { get;}
    }
}
