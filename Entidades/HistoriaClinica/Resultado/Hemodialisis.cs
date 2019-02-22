using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.HistoriaClinica.Resultado
{
    class Hemodialisis
    {
      public string codigo { get; set; }
      public  int codigoAtencion { get; set; }
      public DateTime fecha { get; set; }
      public  string nota { get; set; }
      public  string notaSigno { get; set; }

        public Hemodialisis() {

        }
    }
}
