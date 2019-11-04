using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_buscaminas.Model
{
    public class clsCarta : INotifyPropertyChanged
    {
        private String imagen;

        public event PropertyChangedEventHandler PropertyChanged;

        public int posicion { get; set; }
        public Boolean bomba { get; set; }

        public Boolean presionada { get; set; }
        public string Imagen{
            get
            {
                cambiarImagen();
                return imagen;
            }
            
        }
        public clsCarta(int pos,Boolean bomb)
        {
            posicion = pos;
            bomba = bomb;
            presionada = false;
            imagen = "Assets/presionar.png";
        }
        public void cambiarImagen()
        {
            if (!presionada)
            {
                presionada = true;
                if (bomba)
                {
                    imagen = "Assets/bomba.png";
                }
                else
                {
                    imagen = "Assets/salvado.png";
                }
                NotifyPropertyChanged("Imagen");
            }
            
        }
        private void NotifyPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }
    }
}
