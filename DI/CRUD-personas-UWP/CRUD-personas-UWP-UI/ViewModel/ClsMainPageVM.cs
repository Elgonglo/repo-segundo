using _CRUD_personas_Entities;
using _CRUD_Personas_UWP_BL.Listado;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace CRUD_personas_UWP_UI.ViewModel
{
    class ClsMainPageVM : INotifyPropertyChanged
    {
        private clsPersona personaSeleccionada;
        private ObservableCollection<clsPersona> listadoPersonas;
        private String textoBuscar;
        private DelegateCommand eliminarCommand;
        private DelegateCommand buscarCommand;
        private DelegateCommand nuevoCommand;
        private DelegateCommand guardarCommand;

        public ClsMainPageVM()
        {
            clsListadoPersonasBL listado = new clsListadoPersonasBL();
            listadoPersonas = new ObservableCollection<clsPersona>(collection: listado.ListadoPersonas());
            eliminarCommand = new DelegateCommand(eliminarCommand_Executed, eliminarCommand_CanExecute);
            buscarCommand = new DelegateCommand(buscarCommand_Executed, buscarCommand_CanExecute);
        }

        public clsPersona PersonaSeleccionada
        {

            get
            {
                return personaSeleccionada;
            }
            set
            {
                if (personaSeleccionada != value)
                {
                    personaSeleccionada = value;
                    NotifyPropertyChanged("PersonaSeleccionada");
                    NotifyPropertyChanged("EliminarCommand");
                    eliminarCommand.RaiseCanExecuteChanged();
                }

            }
        }

        public ObservableCollection<clsPersona> ListadoPersonas
        {
            get
            {
                return listadoPersonas;
            }
            set
            {
                listadoPersonas = value;
            }
        }

        public DelegateCommand EliminarCommand
        {
            get
            {
                return eliminarCommand;
            }
        }

        /// <summary>
        /// aqui borra y pregunta si quiere borrarlo
        /// </summary>
        private async void eliminarCommand_Executed()
        {       
            ContentDialog confirmarBorrado = new ContentDialog();

            confirmarBorrado.Title = "Eliminar";
            confirmarBorrado.Content = "¿Esta seguro de que quiere borrar?";
            confirmarBorrado.PrimaryButtonText = "Cancelar";
            confirmarBorrado.SecondaryButtonText = "Aceptar";
            ContentDialogResult resultado = await confirmarBorrado.ShowAsync();

            if (resultado == ContentDialogResult.Secondary)
            {
                ListadoPersonas.Remove(personaSeleccionada);
                NotifyPropertyChanged("ListadoPersonas");
                NotifyPropertyChanged("PersonaSeleccionada");
            }

        }

       
        private bool eliminarCommand_CanExecute()
        {
            bool ret = false;

            if (PersonaSeleccionada != null)
            {
                ret = true;
            }
            return ret;
        }

        public DelegateCommand BuscarCommand
        {
            get
            {
                return buscarCommand;
            }
        }

        /// <summary>
        /// Obtiene un listado de personas filtrado y notifica los cambios.
        /// </summary>
        private void buscarCommand_Executed()
        {
            //aqui el buscar persona.

            NotifyPropertyChanged("ListadoPersonas");
        }

        private bool buscarCommand_CanExecute()
        {
            bool ret = false;

            if (!String.IsNullOrEmpty(textoBuscar))
            { 
                ret = true;
            }

            return ret;
        }

        public String TextoBuscar
        {
            get
            {
                return textoBuscar;
            }
            set
            {
                textoBuscar = value;
                NotifyPropertyChanged("TextoBuscar");
                buscarCommand.RaiseCanExecuteChanged();
                if (String.IsNullOrEmpty(textoBuscar))
                {
                    //aqui tiene que pillar el listado de personas
                    NotifyPropertyChanged("ListadoPersonas");
                }
            }
        }

        public void filtrar()
        {
            ObservableCollection<clsPersona> listadoPersonasFiltradas = new ObservableCollection<clsPersona>(ListadoPersonas.ToList().FindAll(persona => String.Concat(persona.nombre, " ", persona.apellido).Contains(textoBuscar)));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
