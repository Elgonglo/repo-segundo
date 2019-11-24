using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_personas_UWP_Entities
{
        public class clsDepartamento
        {
            /// <summary>
            /// Constructor por defecto
            /// </summary>
            public clsDepartamento()
            {
                ID = 0;
                nombre = "";
            }

            /// <summary>
            /// Constructor con parametros
            /// </summary>
            /// <param name="ID"></param>
            /// <param name="nombre"></param>
            public clsDepartamento(int ID, String nombre)
            {
                this.ID = ID;
                this.nombre = nombre;
            }
            public int ID { get; set; }
            public String nombre { get; set; }
        }
    }