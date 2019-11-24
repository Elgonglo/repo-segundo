using _CRUD_personas_Entities;
using _CRUD_Personas_UWP_BL.Listado;
using CRUD_personas_UWP_BL.Listado;
using CRUD_personas_UWP_BL.Manejadora;
using CRUD_personas_UWP_Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Xaml.Controls;

namespace CRUD_personas_UWP_UI.ViewModel
{
    public class ClsMainPageVM : INotifyPropertyChanged
    {

        private clsPersona personaSeleccionada;
        private ObservableCollection<clsPersona> listadoPersonas;
        private ObservableCollection<clsDepartamento> listadoDepartamentos;
        private String textoBuscar;
        private int filas;
        private String mensajeDeError;
        private bool selectedItem;//Para activar y desactivar los botones
        private DelegateCommand eliminarCommand;
        private DelegateCommand buscarCommand;
        private DelegateCommand nuevoCommand;
        private DelegateCommand guardarCommand;
        private DelegateCommand refreshCommand;

        public ClsMainPageVM()
        {
            selectedItem = false;
            clsListadoPersonasBL listado = new clsListadoPersonasBL();
            clsListadoDepartamentosBL listadoDepart = new clsListadoDepartamentosBL();
            personaSeleccionada = new clsPersona();
            try
            {
                listadoPersonas = new ObservableCollection<clsPersona>(listado.ListadoPersonas());
                listadoDepartamentos = new ObservableCollection<clsDepartamento>(listadoDepart.listadoDepartamentosBL());
            }catch(SqlException e)
            {
                muestraMensajeError();
            }
           
            eliminarCommand = new DelegateCommand(eliminarCommand_Executed, eliminarCommand_CanExecute);
            buscarCommand = new DelegateCommand(buscarCommand_Executed, buscarCommand_CanExecute);
            refreshCommand = new DelegateCommand(refreshCommand_Executed);
            nuevoCommand = new DelegateCommand(nuevoCommand_Executed,nuevoCommand_CanExecute);
            guardarCommand = new DelegateCommand(guardarCommand_Executed, guardarCommand_CanExecute);
        }

        #region propiedades
        public String TextoBuscar
        {
            get
            {
                return textoBuscar;
            }
            set
            {
                textoBuscar = value;
                buscarCommand.RaiseCanExecuteChanged();
                if (String.IsNullOrEmpty(textoBuscar))
                {
                    refreshCommand_Executed();
                }
            }
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
                    selectedItem = true;
                    NotifyPropertyChanged("PersonaSeleccionada");
                    NotifyPropertyChanged("EliminarCommand");
                    eliminarCommand.RaiseCanExecuteChanged();
                    guardarCommand.RaiseCanExecuteChanged();
                    nuevoCommand.RaiseCanExecuteChanged();
                }

            }
        }

        public bool SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                NotifyPropertyChanged("SelectedItem");
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
                NotifyPropertyChanged("ListadoPersonas");
            }
        }

        public ObservableCollection<clsDepartamento> ListadoDepartamentos
        {
            get
            {
                return listadoDepartamentos;
            }
            set
            {
                listadoDepartamentos = value;
            }
        }

        public String MensajeDeError
        {
            get
            {
                return mensajeDeError;
            }
            set
            {
                mensajeDeError = value;
                NotifyPropertyChanged("MensajeDeError");
            }
        }

        #endregion

        #region Comandos
        public DelegateCommand EliminarCommand
        {
            get
            {
                return eliminarCommand;
            }
        }

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
                manejadoraBL manejadora = new manejadoraBL();
                filas = manejadora.eliminarPersonaBL(personaSeleccionada.idPersona);
                muestraMensaje();
                refreshCommand_Executed();
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

        private void buscarCommand_Executed()
        {
            clsListadoPersonasBL listadoP = new clsListadoPersonasBL();
            ListadoPersonas = listadoP.filtrado(listadoPersonas, textoBuscar);
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

        public DelegateCommand GuardarCommand
        {
            get
            {
                return guardarCommand;
            }
        }

        private void guardarCommand_Executed()
        {
            manejadoraBL manejadora = new manejadoraBL();
            filas = manejadora.editarPersonaBL(personaSeleccionada);
            muestraMensaje();
        }

        public bool guardarCommand_CanExecute()
        {
            bool ret = false;
            if (personaSeleccionada != null && selectedItem == true)
            {
                ret = true;
            }
            return ret;
        }

        public DelegateCommand RefreshCommand
        {
            get
            {
                return refreshCommand;
            }
        }

        private void refreshCommand_Executed()
        {
            clsListadoPersonasBL lista = new clsListadoPersonasBL();
            ListadoPersonas = new ObservableCollection<clsPersona>(lista.ListadoPersonas());
            SelectedItem = false;
            personaSeleccionada = new clsPersona();
            NotifyPropertyChanged("PersonaSeleccionada");
        }

        public DelegateCommand NuevoCommand
        {
            get
            {
                return nuevoCommand;
            }
        }

        private void nuevoCommand_Executed()
        {
            manejadoraBL manejadora = new manejadoraBL();

            if(personaSeleccionada.IDdepartamento != 0)
            {
                filas = manejadora.insertarPersonaBL(personaSeleccionada);
                MensajeDeError = "";
            }
            else
            {
                filas = 0;
                MensajeDeError = "No has seleccionado departamento";
            }
            muestraMensaje();
        }

        private bool nuevoCommand_CanExecute()
        {
            Boolean ret = true;

            if (guardarCommand_CanExecute())
            { 
                ret = false;
            }
            return ret;
        }


        #endregion

        public void filtrar()
        {
            ObservableCollection<clsPersona> listadoPersonasFiltradas = new ObservableCollection<clsPersona>(ListadoPersonas.ToList().FindAll(persona => String.Concat(persona.nombre, " ", persona.apellido).Contains(textoBuscar)));
        }

        private async void muestraMensaje()
        {
            ContentDialog info = new ContentDialog();
            info.Title = "Informacion";
            info.Content = "Filas afectadas: " + filas;
            info.SecondaryButtonText = "Aceptar";
            ContentDialogResult resultado = await info.ShowAsync();
        }

        private async void muestraMensajeError()
        {
            ContentDialog noWifiDialog = new ContentDialog()
            {
                Title = "Error de conexion",
                Content = "La aplicacion procede a cerrarse",
                CloseButtonText = "OK"
            };

            await noWifiDialog.ShowAsync();
            CoreApplication.Exit();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
