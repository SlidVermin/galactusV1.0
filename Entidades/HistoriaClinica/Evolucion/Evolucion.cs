using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Galactus.Entidades.HistoriaClinica.Evolucion
{
  public class Evolucion
    {
        public DataTable dtDiagnostico = new DataTable();
        public void establecerDt()
        {
            dtDiagnostico.Columns.Add("Id", typeof(String));
            dtDiagnostico.Columns.Add("Código", typeof(String));
            dtDiagnostico.Columns.Add("Descripcion", typeof(String));
        }
    }
}
