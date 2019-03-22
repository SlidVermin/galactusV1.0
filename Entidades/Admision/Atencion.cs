using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Galactus.Modelo.Admision;

namespace Galactus.Entidades.Admision
{
    class Atencion
    {
        public int idAtencion { get; set; }
        public int idAdmision { get; set; }
        public string idCama { get; set; }
        public string idViaIngreso { get; set; }
        public string idCausaExterna { get; set; }
        public string idEntorno{ get; set; }
        public string idArea { get; set; }
        public string idInstitucion { get; set; }
        public string observacion { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int idEstadoAtencion { get; set; }
        public int numeroAutorizacion { get; set; }
        public DateTime fechaAdmision { get; set; }
        public string nombrePaciente { get; set; }
        public DataTable dtDiagnostico = new DataTable();


        public DataSet dsDatos = new DataSet();
            public void establecerDt()
        {
            dtDiagnostico.Columns.Add("Código cie", typeof(String));
            dtDiagnostico.Columns.Add("Descripcion", typeof(String));
        }

        public void cargarDatos()
        {
            List<string> param = new List<string>();
            param.Add(Convert.ToString(idAtencion));
            dsDatos = GeneralC.llenarDataset(Sentencias.ATENCION_CARGAR, param);

            DataTableCollection tables = dsDatos.Tables;

            if (tables["table"].Rows.Count > 0)
            {
                idAtencion = tables["table"].Rows[0].Field<int>("idAtencion");
                idAdmision = tables["table"].Rows[0].Field<int>("idadmision");
                idArea = Convert.ToString( tables["table"].Rows[0].Field<int>("idarea"));
                idViaIngreso = Convert.ToString(tables["table"].Rows[0].Field<int>("idviaIngreso"));
                idEntorno = Convert.ToString(tables["table"].Rows[0].Field<int>("identorno"));
                idCama = Convert.ToString(tables["table"].Rows[0].Field<int>("idcama"));
                idCausaExterna = Convert.ToString(tables["table"].Rows[0].Field<int>("idcausaExterna"));
                idInstitucion = Convert.ToString(tables["table"].Rows[0].Field<int>("idinstitucion"));
                observacion = tables["table"].Rows[0].Field<String>("observacion");
                fechaIngreso = tables["table"].Rows[0].Field<DateTime>("fechaingreso");
                idEstadoAtencion = tables["table"].Rows[0].Field<int>("idEstadoAtencion");
                numeroAutorizacion = Convert.ToUInt16( tables["table"].Rows[0].Field<String>("numeroautorizacion"));
                cargarPacienteAtencion();
            }

            if (tables["table1"].Rows.Count > 0)
            {
                dtDiagnostico = tables["table1"].Copy();
            }
        }

        public void anular()
        {
            AtencionDAL.anular(this);
        }
        public void cargarPacienteAtencion()
        {
            List<string> param = new List<string>();
            param.Add(Convert.ToString(idAdmision));
            DataTable dt = new DataTable();
            GeneralC.llenarTabla(Sentencias.ATENCION_PACIENTE_ATENCION, param,dt);
            if (dt.Rows.Count > 0)
            {
                idAdmision = dt.Rows[0].Field<int>("admision");
                nombrePaciente = dt.Rows[0].Field<String>("paciente");
                fechaAdmision = dt.Rows[0].Field<DateTime>("fechaadmision");
            }
        }
        public void guardar()
        {
            AtencionDAL.guardar(this);
        }
    } 
}
