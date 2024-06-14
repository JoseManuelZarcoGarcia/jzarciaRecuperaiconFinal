using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JzarciaRecuperacion.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenu()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("0. cerrar menu");
            Console.WriteLine("1. número de históricos");
            Console.WriteLine("2. alta nuevo propietario");
            Console.WriteLine("--------------");
            int opcionSeleccionada = Convert.ToInt32( Console.ReadLine());
            return opcionSeleccionada;
        }

    }
}
