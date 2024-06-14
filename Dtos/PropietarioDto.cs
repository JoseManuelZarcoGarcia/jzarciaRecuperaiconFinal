using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JzarciaRecuperacion.Dtos
{
    /// <summary>
    /// Clase que representa la entidad del propietario
    /// </summary>
    internal class PropietarioDto
    {

        // Atributos
        long idPropietario;
        string dniPropietario = "aaa";
        DateTime fchCompra = DateTime.Now;
        string matricula = "1111zzz";
        bool esHistorico = false;

        
        // Getter and Setter
        public long IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string DniPropietario { get => dniPropietario; set => dniPropietario = value; }
        public DateTime FchCompra { get => fchCompra; set => fchCompra = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public bool EsHistorico { get => esHistorico; set => esHistorico = value; }


        // Constructores
        public PropietarioDto(long idPropietario, string dniPropietario, DateTime fchCompra, string matricula, bool esHistorico)
        {
            this.idPropietario = idPropietario;
            this.dniPropietario = dniPropietario;
            this.fchCompra = fchCompra;
            this.matricula = matricula;
            this.esHistorico = esHistorico;
        }

        public PropietarioDto() { }
    }
}
