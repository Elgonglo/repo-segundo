using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace _04_BotonesEnTiempoDeEjecucion
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Button b3;

        public MainPage()
        {
            this.InitializeComponent();
            dynamicControl();
        }
        private void dynamicControl()
        {
            Button b3 = new Button();
            b3.Content = "Boton 3";
            b3.Width = 200;
            b3.Height = 70;
            b3.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Blue);
            b3.VerticalAlignment = VerticalAlignment.Center;
            b3.HorizontalAlignment = HorizontalAlignment.Center;
            b3.FontFamily = new FontFamily("Verdana");
            b3.FontSize = 16;
            b3.FontWeight = Windows.UI.Text.FontWeights.Bold;
            b3.BorderBrush = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Yellow);
            b3.Click += b3_Click;

            Stack.Children.Add(b3);
        }
        private void b3_Click(object sender,RoutedEventArgs e)
        {
            b3.Content = "Pulsado";
        }
    }
}
