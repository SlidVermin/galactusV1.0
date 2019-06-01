﻿using System;
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
        public DataTable dtImpresion = new DataTable();

        public DataTable dtAlistar = new DataTable();
        public String edadMadre { get; set; }
        public String edadGestional { get; set; }
        public String fum { get; set; }
        public String obstreticos { get; set; }
        public String hemoclasificacionMadre { get; set; }
        public String hemoclasificacionPadre { get; set; }
        public String vacunacion { get; set; }
        public String preeclampcia { get; set; }
        public String controlPrenatal { get; set; }
        public String medicamentoDuranteEmbarazo { get; set; }
        public String hipertensionGestacional { get; set; }
        public String habitos { get; set; }
        public String infeccionEmbarazo { get; set; }
        public String enfermedadTiroidea { get; set; }
        public String diabeteMellitius { get; set; }
        public String diabeteGestacional { get; set; }
        public String torch { get; set; }
        public DataTable dtMaterno = new DataTable();
        public void cargarDiagnostico()
        {
            IngresoClinicoDAL.cargarDiagnostico(this);
        }

        public void establecerDt()
        {
            dtImpresion.Columns.Add("Id", typeof(String));
            dtImpresion.Columns.Add("Código", typeof(String));
            dtImpresion.Columns.Add("Descripcion", typeof(String));
          
        }
        public void establecerDtMaterno()
        {
            dtMaterno.Reset();
            dtMaterno.Columns.Add("idAtencion", typeof(int));
            dtMaterno.Columns.Add("EdadMadre", typeof(String));
            dtMaterno.Columns.Add("EdadGestacional", typeof(String));
            dtMaterno.Columns.Add("Preclampsia", typeof(String));
            dtMaterno.Columns.Add("Fum", typeof(String));
            dtMaterno.Columns.Add("obstetricos", typeof(String));
            dtMaterno.Columns.Add("hemoclasificacionMadre", typeof(String));
            dtMaterno.Columns.Add("hemoclasificacionPadre", typeof(String));
            dtMaterno.Columns.Add("vacunacion", typeof(String));
            dtMaterno.Columns.Add("controlPrenatal", typeof(String));
            dtMaterno.Columns.Add("medicamentoDuranteEmbarazo", typeof(String));
            dtMaterno.Columns.Add("hipertensionGestacional", typeof(String));
            dtMaterno.Columns.Add("habitos", typeof(String));
            dtMaterno.Columns.Add("infeccionDuranteEmbarazo", typeof(String));
            dtMaterno.Columns.Add("enfermedadTiroidea", typeof(String));
            dtMaterno.Columns.Add("diabeteGestacional", typeof(String));
            dtMaterno.Columns.Add("diabeteMellitus", typeof(String));
            dtMaterno.Columns.Add("torch", typeof(String));
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

        public void cargarDiagnosticoImpresion()
        {
            IngresoClinicoDAL.cargarDiagnosticoImpresion(this);
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
