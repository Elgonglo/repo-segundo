﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Signalr_chat
{
    public class clsMensaje
    {


        public clsMensaje(String nombre, String mensaje)
        {
            this.nombre = nombre;
            this.mensaje = mensaje;

        }
        public String nombre { get; set; }
        public String mensaje{ get; set; }
    }
}