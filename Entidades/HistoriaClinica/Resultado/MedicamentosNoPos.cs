using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Galactus.Modelo.HistoriaClinica.Resultado;

namespace Galactus.Entidades.HistoriaClinica.Resultado
{
    class MedicamentosNoPos
    {
        public DataSet dsDatos = new DataSet();
        public int idAtencion { set; get; }
        public void cargarDatos()
        {
            MedicamentoNoPosDAL.cargarDatos(this);
            DataTableCollection dtDatos = dsDatos.Tables;
        }
    }
}
