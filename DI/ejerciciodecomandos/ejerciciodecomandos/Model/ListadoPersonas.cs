using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejerciciodecomandos.Model
{
    public class ListadoPersonas
    {
        /// <summary>
        /// Aqui añade las personas y devuelve la lista
        /// </summary>
        /// <returns>List<clsPersona></returns>
        public ObservableCollection<clsPersona> ListarPersonas()
        {
            ObservableCollection<clsPersona> personas = new ObservableCollection<clsPersona>();
            personas.Add(new clsPersona());
            personas.Add(new clsPersona("Daniel", "Gordillo"));
            personas.Add(new clsPersona("Yeary", "Campanario"));
            personas.Add(new clsPersona("Pablo", "Prats"));
            personas.Add(new clsPersona("Angela", "Vazquez"));
            return personas;

        }
        public ObservableCollection<clsPersona> filtrar(ObservableCollection<clsPersona> lista, String nombre)
        {
            ObservableCollection<clsPersona> personas = new ObservableCollection<clsPersona>();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].nombre.Equals(nombre))
                {
                    personas.Add(lista[i]);
                }
            }

            return personas;
        }

    }
}