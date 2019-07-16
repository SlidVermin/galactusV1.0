using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galactus.Entidades.HistoriaClinica.Resultado;

namespace Galactus.Modelo.HistoriaClinica.Resultado
{
    class JustificacionAntibioticoDAL
    {
        public static void guardar(JustificacionAntibiotico justificacion)
        {
            try
            {

            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void cargarDatos(JustificacionAntibiotico justificacion)
        {
            try
            {
                List<string> lista = new List<string>();
                lista.Add(Convert.ToString(justificacion.idAtencion));
                lista.Add(Convert.ToString(justificacion.idJustificacion));
                lista.Add(Convert.ToString(justificacion.auditoria));
                justificacion.dsDatos = GeneralC.llenarDataset(Sentencias.CARGAR_JUSTIFICACION_ANT, lista);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
