using JzarciaRecuperacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JzarciaRecuperacion.Servicios
{
    internal class PropietarioImplementacion : PropietarioInterfaz
    {

        public void altaPropietario()
        {
            PropietarioDto nuevoPropietario = new PropietarioDto();
            Console.WriteLine("Escriba su dni: ");
            nuevoPropietario.DniPropietario = Console.ReadLine();
            nuevoPropietario.IdPropietario = Util.Utilidades.crearIdPropietario();


        }

        private string comprovarDni()
        {
            Console.WriteLine("");
            string valido = Console.ReadLine();

            return valido;
        }

    }
}
