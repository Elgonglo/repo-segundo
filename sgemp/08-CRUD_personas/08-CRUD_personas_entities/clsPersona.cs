using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace _08_CRUD_personas_entities
{
    public class clsPersona : INotifyPropertyChanged
    {
      
        //propiedades publicas
        public clsPersona()
        {
            this.nombre="Gonzalo";
            this.apellido = "Gomez";
            IDdepartamento = 1;
        }
        public clsPersona(String nombre, String apellido, DateTime fecha, int IDdepartamento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;
            this.IDdepartamento = IDdepartamento;
        }



        public string nombre {

            get {

                return nombre;

            }
            set {

                nombre = value;
                NotifyPropertyChanged();

            }

        }
        public string apellido
        {

            get
            {

                return apellido;

            }
            set
            {

                apellido = value;
                NotifyPropertyChanged();

            }

        }

        public DateTime fecha { 
            get {
                return fecha;
            }
            set {
                fecha = value;
                NotifyPropertyChanged();
            } 
        }
        public int IDdepartamento { 
            get {
                return IDdepartamento;       
            } 
            set {
                IDdepartamento = value;
                NotifyPropertyChanged();
            } }



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
