using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace _06_LayoutGridForm.Models
{
    public class clsPersona : INotifyPropertyChanged
    {
      
        //propiedades publicas
        public clsPersona()
        {
            this.nombre="Gonzalo";
         }
        

        private string _nombre;

        public string nombre {

            get {

                return _nombre;

            }
            set {

                _nombre = value;
                NotifyPropertyChanged();

            }

        }



        

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
