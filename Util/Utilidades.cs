using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JzarciaRecuperacion.Util
{
    /// <summary>
    /// Clase estatica que tendra los metodos para los 
    /// </summary>
    internal static class Utilidades
    {

        public static string crearNombreFicheroLog() 
        { 
        
            DateTime fechaActual = DateTime.Now;
            string fecha = fechaActual.ToString("ddMMyyyy");
            string nombreFicheroLog = string.Concat("log-", fecha,".txt");

            return nombreFicheroLog;
        }

        public static long crearIdPropietario()
        {
            int tamanyoLista = Controladores.Program.listaPropietarios.Count;
            long id = 0;
            if (tamanyoLista > 0)
            {

                id = Controladores.Program.listaPropietarios[tamanyoLista - 1].IdPropietario + 1;

            }
            else
            {
                id = 0;
            }
            return id;
        }

        public static long crearIdVehiculo()
        {
            int tamanyoLista = Controladores.Program.listaVehiculos.Count;
            long id = 0;
            if (tamanyoLista > 0)
            {

                id = Controladores.Program.listaVehiculos[tamanyoLista - 1].IdVehiculo +1;

            }
            else
            {
                id = 0;
            }
            return id;
        }
    }
}
