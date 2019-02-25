using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.HistoriaClinica.Resultado
{
    class InformeQuirurgico
    {
        public string codigo { get; set; }
        public int codigoAtencion { get; set; }
        public int codigoVia {get; set;} 
        public int codigoAyudante { get; set; }
        public int codigoAnastesiologo { get; set; }
        public int codigoAnastesia { get; set; }
        public string notaQuirurgica { get; set; }
        public DateTime fecha { get; set; }

        public InformeQuirurgico() {

        }

    }
}
