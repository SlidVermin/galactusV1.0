using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.HistoriaClinica
{
    class IngresoClinico
    {
        public int IdAtencion { get; set; }
        public String Peso { get; set; }
        public String MotivoIngreso { get; set; }
        public String AntecedentesMedicos { get; set; }
        public String AntecedentesQuirurgicos { get; set; }
        public String AntecedentesTransfusionales { get; set; }
        public String AntecedentesAlergicos { get; set; }
        public String AntecedentesTraumaticos { get; set; }
        public String AntecedentesToxicos { get; set; }
        public String AntecedentesFamiliares { get; set; }
        public String RevisionSistema { get; set; }
        public String SignosVitales { get; set; }
        public String CabezaCuello { get; set; }
        public String Torax { get; set; }
        public String CardioPulmonar { get; set; }
        public String Abdomen { get; set; }
        public String GenitalUrinario { get; set; }
        public String Extremidades { get; set; }
        public String SistemaNervioso { get; set; }
        public String Paraclinicos { get; set; }
        public String Analisis { get; set; }
        public String Pronosticos { get; set; }
        public int IdUsuario { get; set; }
        public int IdUsuarioOrigen { get; set; }
        public DateTime FechaOrigen { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
