using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JzarciaRecuperacion.Dtos
{
    /// <summary>
    /// Clase que representa la entidad del vehiculo
    /// </summary>
    internal class VehiculoDto
    {

        // Atrubutos
        long idVehiculo;
        string matricula = "1111zzz";
        DateTime fchMatriculacion = DateTime.Now;


        // Getter and Setter
        public long IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FchMatriculacion { get => fchMatriculacion; set => fchMatriculacion = value; }
    }



    // Constructores

}
