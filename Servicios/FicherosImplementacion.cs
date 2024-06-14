using JzarciaRecuperacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JzarciaRecuperacion.Servicios
{
    internal class FicherosImplementacion : FicherosInterfaz
    {

        public void cargaInicial()
        {
            StreamReader sr = null;
            try
            {
                string[] filas = File.ReadAllLines(Controladores.Program.rutaCargaInicial);
                long idPropietario;
                string dniPropietario;
                DateTime fchCompra;
                bool esHistorico = false;

                foreach (string s in filas)
                {
                    string[] campos = s.Split(":");
                    VehiculoDto nuevoVehiculo = new VehiculoDto();
                    nuevoVehiculo.IdVehiculo = Util.Utilidades.crearIdVehiculo();
                    string matricula = campos[0];
                    nuevoVehiculo.Matricula = campos[0];
                    DateTime fechMatriculacion = Convert.ToDateTime(campos[1]);
                    nuevoVehiculo.FchMatriculacion = fechMatriculacion;


                    idPropietario = Util.Utilidades.crearIdPropietario();
                    dniPropietario = campos[2];
                    fchCompra = Convert.ToDateTime(campos[3]);
                    

                    PropietarioDto nuevoPropietario = new PropietarioDto(idPropietario, dniPropietario,  fchCompra,  matricula,  esHistorico);

                }


            } catch (Exception ex)
            {

            }finally 
            { 
                if (sr != null) 
                    sr.Close();
            }

        }

        public void ficheroLog(string mensaje)
        {
            StreamWriter sr = null;
            try
            {
                sr = new StreamWriter(Controladores.Program.rutaFicheroLogCopleta, true);
                sr.WriteLine(mensaje);
                sr.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }

    }
}
