using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.HistoriaClinica.Resultado
{
    class Hemodialisis
    {
      public int idHemodialisis { get; set; }
      public  int idOrdenMedica { get; set; }
      public int idProcedimiento { get; set; }
      public int auditoria { get; set; }
      public DateTime fecha { get; set; }
      public  string nota { get; set; }
      public  string notaSigno { get; set; }
    }
}
