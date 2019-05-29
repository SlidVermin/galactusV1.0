using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.HistoriaClinica.Resultado
{
    class InformeQuirurgico
    {
        public int idInformeQX { get; set; }
        public int idOrdenMedica { get; set; }
        public int idProcedimiento { get; set; }
        public int idVia {get; set;} 
        public int idAyudante { get; set; }
        public int idAnastesiologo { get; set; }
        public int idAnastesia { get; set; }
        public int Auditoria { get; set; }
        public string notaQuirurgica { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }

        public InformeQuirurgico() {

        }

    }
}
