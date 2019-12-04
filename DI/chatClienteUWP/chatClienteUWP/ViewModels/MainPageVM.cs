using chatClienteUWP.Models;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace chatClienteUWP.ViewModels
{
   public class MainPageVM
    {
        public ObservableCollection<clsMensaje> Messages { get; set; } = new ObservableCollection<clsMensaje>();

        private HubConnection conn { get; set; }
        private IHubProxy proxy { get; set; }

        //comando delegate broadcast

        public MainPageVM()
        {
            SignalR();
        }
        private void SignalR()
        {
            conn = new HubConnection("http://<  ;your-mobile-app>.azurewebsites.net");
            proxy = conn.CreateHubProxy("ChatHub");
            conn.Start();

            proxy.On<clsMensaje>("broadcastMessage", OnMessage);

        }

        ///Aqui hay errores
        public void Broadcast(String nombre,String mensaje )
        {
            proxy.Invoke("Send",nombre, mensaje);
        }
        private async void OnMessage(String nombre,String mensaje)
        {
            await Windows.ApplicationModel.Core.CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Messages.Add(nombre,mensaje);
            });
        }
    }
}
