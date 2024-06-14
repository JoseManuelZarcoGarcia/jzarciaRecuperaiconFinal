using JzarciaRecuperacion.Dtos;
using JzarciaRecuperacion.Servicios;

namespace JzarciaRecuperacion.Controladores
{
    /// <summary>
    /// Clase principal por la que iniciara el programa
    /// </summary>
    class Program
    {
        static public string rutaCargaInicial = "C:\\Users\\csi22-jzarcia\\source\\repos\\JzarciaRecuperacion\\Ficheros\\datosIniciales.txt";
        static public string rutaFicheroLog = "C:\\Users\\csi22-jzarcia\\source\\repos\\JzarciaRecuperacion\\Ficheros\\";
        static public string rutaFicheroLogCopleta = string.Concat("C:\\Users\\csi22-jzarcia\\source\\repos\\JzarciaRecuperacion\\Ficheros\\", Util.Utilidades.crearNombreFicheroLog());
        static public List<PropietarioDto> listaPropietarios = new List<PropietarioDto>();
        static public List<VehiculoDto> listaVehiculos = new List<VehiculoDto>();

        static void Main(string[] args)
        {
            FicherosInterfaz fi = new FicherosImplementacion();
            MenuInterfaz mi= new MenuImplementacion();
            bool cerrarMenu = false;
            int opcionSeleccionada;
            fi.cargaInicial();

            try
            {
                do
                {
                    opcionSeleccionada = mi.mostrarMenu();
                    switch(opcionSeleccionada)
                    {
                        case 0:
                            fi.ficheroLog("Se ha seleccionado la opcion 0");
                            cerrarMenu = true;
                            break;
                        case 1:
                            fi.ficheroLog("Se ha seleccionado la opcion 1");
                            break;
                        case 2:
                            fi.ficheroLog("Se ha seleccionado la opcion 2");
                            break;
                        default:
                            fi.ficheroLog("Se ha seleccionado la opcion default");
                            Console.WriteLine("No es una opcion valida");
                            break;
                    }

                } while (!cerrarMenu);
            
            }catch(Exception ex)
            {
                fi.ficheroLog("Ha ocurrido un error en el menu");
            }

        }
    }
}