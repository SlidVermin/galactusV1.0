using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Galactus.Entidades.HistoriaClinica.Resultado
{
    class JustificacionAntibiotico
    {
        public string codigo { get; set; }
        public int codigoOrden { get; set; }
        public DataTable dtPatologia { get; set; }
        public DataTable dtAntibioticoAnterior { get; set; }
        public int codigoMedicamento { get; set; }
        public Boolean tomaMuestra { get; set; }
        public DateTime fechaMuestra { get; set; }
        public string tipoMuestra { get; set; }
        public string aislamientoMicrobiologico { get; set; }
        public string terapiaActual { get; set; }

        public  JustificacionAntibiotico() {
            dtPatologia = new DataTable();
            dtAntibioticoAnterior = new DataTable();

            dtAntibioticoAnterior.Columns.Add("codigo",Type.GetType("System.Int32"));
            dtAntibioticoAnterior.Columns.Add("Descripcion", Type.GetType("System.String"));
            dtAntibioticoAnterior.Columns.Add("Tiempo", Type.GetType("System.String"));

            dtPatologia.Columns.Add("codigo", Type.GetType("System.Int32"));
            dtPatologia.Columns.Add("descripcion", Type.GetType("System.String"));
        }
    }
}
