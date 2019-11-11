using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ejerciciodecomandos.Model
{
    public class clsPersona : INotifyPropertyChanged
    {

        //propiedades publicas
        public clsPersona()
        {
            this.nombre = "Gonzalo";
            this.apellido = "Gomez";
        }
        public clsPersona(String name, String surname)
        {
            this.nombre = name;
            this.apellido = surname;
        }

        private string _nombre;
        private string _apellido;

        public string nombre
        {

            get
            {

                return _nombre;

            }
            set
            {

                _nombre = value;
                NotifyPropertyChanged();

            }

        }
        public string apellido
        {

            get
            {

                return _apellido;

            }
            set
            {

                _apellido = value;
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
