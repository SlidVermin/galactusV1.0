using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Galactus.Modelo.HistoriaClinica.Resultado;

namespace Galactus.Entidades.HistoriaClinica.Resultado
{
    class JustificacionAntibiotico
    {
      public int idAtencion { get; set; }
      public int idOrdenMedica { get; set; }
        public Boolean auditoria { get; set; }
        public DataSet dsDatos = new DataSet();
        public int idJustificacion { get; set; }
        public string nombreMedicamentoActual { get; set; }
        public int idMedicamentoActual { get; set; }
        public string documentoIdentidad { get; set; }
        public string paciente { get; set; }
        public string cama { get; set; }
        public string estancia { get; set; }
        public string edad { get; set; }
        public string area { get; set; }
        public string entorno { get; set; }
        public string viaIngreso { get; set; }
        public string causaExterna { get; set; }
        public void cargarDatos()
        {
            JustificacionAntibioticoDAL.cargarDatos(this);

            DataTableCollection tablas = dsDatos.Tables;

            if (tablas["table"].Rows.Count > 0)
            {
                documentoIdentidad = tablas["table"].Rows[0]["DocumentoIdentificación"].ToString();
                paciente = tablas["table"].Rows[0]["paciente"].ToString();
                cama = tablas["table"].Rows[0]["cama"].ToString();
                estancia = tablas["table"].Rows[0]["estancia"].ToString();
                area = tablas["table"].Rows[0]["area"].ToString();
                entorno = tablas["table"].Rows[0]["entorno"].ToString();
                edad = tablas["table"].Rows[0]["edad"].ToString();
                viaIngreso = tablas["table"].Rows[0]["viaingreso"].ToString();
                causaExterna = tablas["table"].Rows[0]["causaExterna"].ToString();
            }
        }

    }
}
