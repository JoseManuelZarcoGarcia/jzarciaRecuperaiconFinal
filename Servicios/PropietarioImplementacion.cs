using JzarciaRecuperacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JzarciaRecuperacion.Servicios
{

    /// <summary>
    /// clase que contiene lso metodos de propietarios
    /// </summary>
    internal class PropietarioImplementacion : PropietarioInterfaz
    {

        public void altaPropietario()
        {
            string valido = "n";
            Console.WriteLine("Escriba su dni: ");
            string respuestaUsu = Console.ReadLine();

            PropietarioDto nuevoPropietario = new PropietarioDto();
            do
            {
                respuestaUsu = Console.ReadLine();

                comprovarDni(respuestaUsu);

            } while (valido != "n");
            nuevoPropietario.DniPropietario = Console.ReadLine();
            nuevoPropietario.IdPropietario = Util.Utilidades.crearIdPropietario();
            Controladores.Program.listaPropietarios.Add(nuevoPropietario);

        }

        /// <summary>
        /// metodo que comprueva que el dni sean 9 caracteres
        /// </summary>
        /// <param name="respuestaUsu"></param>
        /// <returns></returns>
        private string comprovarDni(string respuestaUsu)
        {
            int numChr = respuestaUsu.Length;
            string valido = "s";

            if (numChr < 9)
            {
                valido = "n";
            }

            return valido;
        }

    }
}
