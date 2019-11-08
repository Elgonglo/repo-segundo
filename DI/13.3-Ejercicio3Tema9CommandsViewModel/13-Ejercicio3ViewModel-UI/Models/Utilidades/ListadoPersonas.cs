using _13_Ejercicio3Tema9_Entities ;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace _13_Ejercicio3ViewModel_UI.Models.Utilidades
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
            personas.Add(new clsPersona("Daniel","Gordillo"));
            personas.Add(new clsPersona("Yeary","Campanario"));
            personas.Add(new clsPersona("Pablo","Prats"));
            personas.Add(new clsPersona("Angela","Vazquez"));
            return personas;

        }
        

    }
}