﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JzarciaRecuperacion.Servicios
{
    internal interface FicherosInterfaz
    {
        /// <summary>
        /// Metodo que recive un mensaje y lo escribe en el fichero log
        /// </summary>
        /// <param name="mensaje"></param>
        public void ficheroLog(string mensaje);

    }
}
