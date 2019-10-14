using _06_LayoutGridForm.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace _06_LayoutGridForm
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            

        }
          
        /// <summary>
        /// Boton de enviar que validará todo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            clsPersona persona = new clsPersona();
            DateTime cumple = new DateTime();
            persona.nombre = tbName.Text;
            persona.apellido = tbSurname.Text;
            

            if (string.IsNullOrEmpty(persona.nombre))
            {
                tblNameError.Text = "Esta vacio";
            }
            else
            {
                tblNameError.Text = "";
            }

            if (string.IsNullOrEmpty(persona.apellido))
            {
                tblSurnameError.Text = "Esta vacio";
            }
            else
            {
                tblSurnameError.Text = "";
            }

           
             if (string.IsNullOrEmpty(tbDate.Text))
            {
                tblDateError.Text = "La Fecha Esta Vacia";
            }
            else
            {
                if(DateTime.TryParse(tbDate.Text, out cumple))
                {
                    if (cumple > DateTime.Now)
                    {
                        tblDateError.Text = "La Fecha Es Incorrecto";
                    }
                    else
                    {
                        persona.fecha = cumple;
                        tblDateError.Text = "";
                    }
                    
                }
               
                
            }
        }
    }
}
