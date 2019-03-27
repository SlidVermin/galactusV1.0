using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Galactus.Modelo.HistoriaClinica;
namespace Galactus.Entidades.HistoriaClinica
{
   public class IngresoClinico
    {
        public int IdAtencion { get; set; }
        public String Peso { get; set; }
        public String MotivoIngreso { get; set; }
        public String AntecedentesMedicos { get; set; }
        public String AntecedentesQuirurgicos { get; set; }
        public String AntecedentesTransfusionales { get; set; }
        public String AntecedentesAlergicos { get; set; }
        public String AntecedentesTraumaticos { get; set; }
        public String AntecedentesToxicos { get; set; }
        public String AntecedentesFamiliares { get; set; }
        public String RevisionSistema { get; set; }
        public String Generales { get; set; }
        public String SignosVitales { get; set; }
        public String CabezaCuello { get; set; }
        public String Torax { get; set; }
        public String CardioPulmonar { get; set; }
        public String Abdomen { get; set; }
        public String GenitalUrinario { get; set; }
        public String Extremidades { get; set; }
        public String SistemaNervioso { get; set; }
        public String Paraclinicos { get; set; }
        public String Analisis { get; set; }
        public String Pronostico { get; set; }
        public int IdUsuario { get; set; }
        public String resumenClinico { get; set;}
        public String pielFaneras { get; set; }
        public DateTime FechaOrigen { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public DataTable dtDiagnostico = new DataTable();
        public DataTable dtDatos = new DataTable();
        public DataTable dtDatosAtencion = new DataTable();
        public String numeroAutorizacion { get; set; }
        public String cama { get; set; }
        public String institucion { get; set; }
        public String causaExterna { get; set; }
        public String viaIngreso { get; set; }
        public void cargarDiagnostico()
        {
            IngresoClinicoDAL.cargarDiagnostico(this);
        }
        public void cargarDatosAtencion()
        {
            List<string> list = new List<string>();
            list.Add(Convert.ToString(IdAtencion));
            GeneralC.llenarTabla(Sentencias.CARGAR_DATOS_ATENCION, list, dtDatosAtencion);
            if (dtDatosAtencion.Rows.Count > 0)
            {
                numeroAutorizacion = dtDatosAtencion.Rows[0].Field<String>("numAutorizacion");
                cama = dtDatosAtencion.Rows[0].Field<String>("cama");
                institucion = dtDatosAtencion.Rows[0].Field<String>("institucion");
                causaExterna = dtDatosAtencion.Rows[0].Field<String>("causaExterna");
                viaIngreso = dtDatosAtencion.Rows[0].Field<String>("viaIngreso");
            }
        }
        public void cargarDatos()
        {
            IngresoClinicoDAL.cargarDatos(this);
            if (dtDatos.Rows.Count > 0)
            {
                Peso = dtDatos.Rows[0].Field<String>("peso");
                MotivoIngreso = dtDatos.Rows[0].Field<String>("motivoingreso");
                AntecedentesMedicos = dtDatos.Rows[0].Field<String>("AntecedentesMedicos");
                AntecedentesQuirurgicos = dtDatos.Rows[0].Field<String>("AntecedentesQuirurgicos");
                AntecedentesTransfusionales = dtDatos.Rows[0].Field<String>("AntecedentesTransfusionales");
                AntecedentesAlergicos = dtDatos.Rows[0].Field<String>("AntecedentesAlergicos");
                AntecedentesTraumaticos = dtDatos.Rows[0].Field<String>("AntecedentesTraumaticos");
                AntecedentesFamiliares = dtDatos.Rows[0].Field<String>("AntecedentesFamiliares");
                RevisionSistema = dtDatos.Rows[0].Field<String>("revisionSistema");
                SignosVitales = dtDatos.Rows[0].Field<String>("SignosVitales");
                CabezaCuello = dtDatos.Rows[0].Field<String>("cabezaCuello");
                CardioPulmonar = dtDatos.Rows[0].Field<String>("cardioPulmonar");
                Abdomen = dtDatos.Rows[0].Field<String>("abdomen");
                GenitalUrinario = dtDatos.Rows[0].Field<String>("genitalurinario");
                Extremidades = dtDatos.Rows[0].Field<String>("extremidades");
                SistemaNervioso = dtDatos.Rows[0].Field<String>("sistemanervioso");
                Paraclinicos = dtDatos.Rows[0].Field<String>("paraclinicos");
                Analisis = dtDatos.Rows[0].Field<String>("analisis");
                Pronostico = dtDatos.Rows[0].Field<String>("pronosticos");
                Torax = dtDatos.Rows[0].Field<String>("torax");
                AntecedentesToxicos = dtDatos.Rows[0].Field<String>("antecedentesToxicos");
                Generales = dtDatos.Rows[0].Field<String>("generales");
                resumenClinico = dtDatos.Rows[0].Field<String>("resumenClinico");
                pielFaneras = dtDatos.Rows[0].Field<String>("pielFaneras");
            }
        }
    }
}
