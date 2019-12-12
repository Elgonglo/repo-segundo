using chatUWP.Model;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace chatUWP.ViewModel
{
    class MainPageVM : INotifyPropertyChanged
    {
        private DelegateCommand comandoEnviar;
        private ObservableCollection<clsMensaje> listaMensaje;
        private clsMensaje mensaje;
        private HubConnection conn;
        private IHubProxy proxy;

        #region constructores

        public MainPageVM()
        {
            conn = new HubConnection("https://chatgonglo.azurewebsites.net/");
            proxy = conn.CreateHubProxy("chatHub");
            conn.Start();
            comandoEnviar = new DelegateCommand(Enviar_Execute);
            mensaje = new clsMensaje();
            listaMensaje = new ObservableCollection<clsMensaje>();

            proxy.On<String,String>("broadcastMessage", mostrarMensaje);
        }

        private void Enviar_Execute()
        {
            proxy.Invoke("Send",mensaje.nombre,mensaje.mensaje);
        }
        #endregion
        private async void mostrarMensaje(String nombre,String mensaje)
        {

            clsMensaje msg = new clsMensaje(nombre,mensaje);


            
             await Windows.ApplicationModel.Core.CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                    {
                        listaMensaje.Add(msg);
                    });  
             
        }

        public clsMensaje Mensaje
        {
            get
            {
                return mensaje;
            }
            set
            {
                mensaje = value;
            }
        }

        public DelegateCommand ComandoEnviar
        {
            get
            {
               return comandoEnviar;
            }
            set
            {
                comandoEnviar = value;
            }
        }

        public ObservableCollection<clsMensaje> ListaMensaje
        {
            get
            {
                return listaMensaje;
            }
            set
            {
                listaMensaje = value;
            }
        }


        private void NotifyPropertyChanged(String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
