
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Galactus.Entidades.Admision.Configuracion
{

    class ManualServicio
    {
       public DataTable dtSoat = new DataTable();
       public DataTable dtISS = new DataTable();
       public DataTable dtCups = new DataTable();

        public void manualServicio() {
            dtSoat.Columns.Add("Codigo", Type.GetType("System.String"));
            dtSoat.Columns.Add("Descripcion", Type.GetType("System.String"));
            dtSoat.Columns.Add("Valor", Type.GetType("System.Decimal"));
        }

    }
}
