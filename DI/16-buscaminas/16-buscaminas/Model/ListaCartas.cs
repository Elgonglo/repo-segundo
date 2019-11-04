using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_buscaminas.Model
{
    public class ListaCartas
    {
        public  List<clsCarta> lista { get { return lista; }set { lista = value; } }
        public ListaCartas()
        {
            
            Random r = new Random();
            int bomba1 = r.Next(0, 16);
            int bomba2 = r.Next(0, 16);
            int bomba3 = r.Next(0, 16);
            int i = 0;
           while(bomba1== bomba2 || bomba1 == bomba3)
            {
                bomba1 = r.Next(0, 16);
            }
            while (bomba2 == bomba3)
            {
                bomba2 = r.Next(0, 16);
            }
            while (i < 15)
            {
                if (i == bomba1 || i == bomba2 || i == bomba3)
                {
                    lista.Add(new clsCarta(i, true));
                }
                else
                {
                    lista.Add(new clsCarta(i, false));
                }
                i++;
            }
        }
        
    }

}
