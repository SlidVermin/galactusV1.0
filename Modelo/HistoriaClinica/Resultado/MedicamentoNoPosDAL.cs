using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Galactus.Entidades.HistoriaClinica.Resultado;

namespace Galactus.Modelo.HistoriaClinica.Resultado
{
    class MedicamentoNoPosDAL
    {
        public static void cargarDatos(MedicamentosNoPos medicamentoNoPos)
        {
            try
            {
                List<string> lista = new List<string>();
                medicamentoNoPos.dsDatos = GeneralC.llenarDataset(Sentencias.BUSCAR_ORDEN_MEDICAMENTO_NOPOS, lista);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
