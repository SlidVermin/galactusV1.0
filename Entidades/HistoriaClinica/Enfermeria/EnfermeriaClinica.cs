using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Galactus.Util.Constantes;
using Galactus.Modelo.HistoriaClinica.Enfermeria;

namespace Galactus.Entidades.HistoriaClinica.Enfermeria
{
  public  class EnfermeriaClinica
    {
        public DataTable dtInsumos;
        public DataTable dtGlucometria = new DataTable();
        public DataTable  dtInsumosCopia = new DataTable();
        public int idOrdenMedica { set; get; }
        public String tipo { set; get; }
        public int idInsumo { set; get; }
        public int idAtencion { set; get; }
        public DateTime fecha { set; get; }
        public int idNota { set; get; }
        public String nota { set; get; }
        public Boolean insumoAprovado { set; get; }
        public Boolean procedimientoAprobado { set; get; }
        public Boolean glucometriaAprobado { set; get; }
        public Boolean notaAprobado { set; get; }
        public DateTime fechaInsumo { set; get; }
        public DateTime fechaNota { set; get; }
        public Boolean Auditoria { set; get; }
        public DataSet dsInsumos = new DataSet();
        public DataTable dtNotas = new DataTable();
        public DateTime fechaProcedimiento { set; get; }
        public DataTable dtProcedimientos = new DataTable();
        public DataTable dtGlucometriaCopia = new DataTable();

        public void establecerDT()
        {
            dtInsumos = new DataTable();
            dtInsumos.Columns.Add("Id", typeof(int));
            dtInsumos.Columns.Add("Código", typeof(String));
            dtInsumos.Columns.Add("Descripcion", typeof(String));
            dtInsumos.Columns.Add("Cantidad", typeof(String));
            dtInsumos.Columns["Cantidad"].DefaultValue = 0;
        }

        public void guardarInsumos()
        {
            prepararInsumoDT();
            EnfermeriaDAL.guardarInsumos(this);
        }
        public void guardarGlucometria()
        {
            prepararGlucometriaDT();
            EnfermeriaDAL.guardarGlucometria(this);
        }

        public void guardarNota()
        {
            EnfermeriaDAL.guardarNota(this);
        }
       public void columnasGlucometria()
        {
            dtGlucometriaCopia.Columns.Add("Hora", typeof(TimeSpan));
            dtGlucometriaCopia.Columns.Add("Glicemia", typeof(String));
            dtGlucometriaCopia.Columns.Add("Insulina", typeof(String));
            dtGlucometriaCopia.Columns.Add("Usuario", typeof(int));
        }
        public void columnasInsumos()
        {
            dtInsumosCopia.Columns.Add("id", typeof(int));
            dtInsumosCopia.Columns.Add("cantidad", typeof(int));
            dtInsumosCopia.Columns.Add("idUsuario", typeof(int));
           
        }
        public void prepararGlucometriaDT()
        {
            DataTable dt = new DataTable();
            dtGlucometria.AcceptChanges();
            dt = dtGlucometria.Copy();
            dt.Columns.Remove("Código");
            dt.Columns.Remove("Id");
            dt.Columns.Remove("Descripcion");
            dt.Columns.Remove("Responsable");
            dtGlucometriaCopia.Clear();
            dtGlucometriaCopia.Reset();
            columnasGlucometria();
            for (int i = 0; i < dt.Rows.Count ; i++)
            {
                if(dt.Rows[i].Field<String>("Glicemia").ToString() != String.Empty)
                {
                    dt.Rows[i]["Usuario"] = Sesion.IdUsuario;
                    dtGlucometriaCopia.ImportRow(dt.Rows[i]);
                }
            }

        }
        public void prepararInsumoDT()
        {
            DataTable dt = new DataTable();
            dtInsumos.AcceptChanges();
            dt = dtInsumos.Copy();
            dt.Columns.Remove("Descripcion");
            dt.Columns.Remove("Código");
            dt.Columns.Add("idUsuario");
            dtInsumosCopia.Clear();
            dtInsumosCopia.Reset();
            columnasInsumos();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ( dt.Rows[i]["id"].ToString() != string.Empty)
                {
                    dt.Rows[i]["idUsuario"] = Sesion.IdUsuario;
                    dtInsumosCopia.ImportRow(dt.Rows[i]);
                }
            }
            if (dtInsumosCopia.Rows.Count > 0)
            {
                dtInsumos.Rows.RemoveAt(dtInsumos.Rows.Count - 1);
            }
        }

        public void cargarProcedimientos()
        {
            List<string> lista = new List<string>();
            lista.Add(Convert.ToString(Auditoria));
            lista.Add(Convert.ToString(idOrdenMedica));
            dtProcedimientos = GeneralC.cargarResultadosSQL(Sentencias.CARGAR_PROCEDIMIENTOS_ENFERMERIA, lista);
            if (dtProcedimientos.Rows.Count > 0)
            {
                procedimientoAprobado = true;
            }
        }
        public void cargarInsumos()
        {          
            List<string> lista = new List<string>();
            lista.Add(Convert.ToString(idInsumo));
            lista.Add(Convert.ToString(tipo));
           
            dsInsumos = GeneralC.llenarDataset(Sentencias.CARGAR_INSUMOS_ENFERMERIA, lista);
            DataTableCollection dt = dsInsumos.Tables;
            if (dt["table"].Rows.Count > 0)
            {
                fechaInsumo = dt["table"].Rows[0].Field<DateTime>("fecha");
                insumoAprovado = true;
            }
            if (dt["table1"].Rows.Count > 0)
            {
                dt["table1"].AcceptChanges();
                dtInsumos = dt["table1"].Copy();
                valorDefecto();
            }
        }
      public void valorDefecto()
        {
            dtInsumos.Columns["Cantidad"].DefaultValue = 0;
        }
        public void cargarNotas()
        {
            List<string> lista = new List<string>();
            lista.Add(Convert.ToString(Auditoria));
            lista.Add(Convert.ToString(idNota));
            lista.Add(Convert.ToString(tipo));
            dtNotas = GeneralC.cargarResultadosSQL(Sentencias.CARGAR_NOTA_ENFERMERIA, lista);
            if (dtNotas.Rows.Count > 0)
            {
                nota = dtNotas.Rows[0].Field<String>("nota");
                fechaNota= dtNotas.Rows[0].Field<DateTime>("fecha");
                notaAprobado = true;
            }
        }
        public void cargarGlucometria()
        {
            List<string> lista = new List<string>();
            lista.Add(Convert.ToString(Auditoria));
            lista.Add(Convert.ToString(idOrdenMedica));

            dtGlucometria = GeneralC.cargarResultadosSQL(Sentencias.CARGAR_GLUCOMETRIAS_ENFERMERIA, lista);
            if (dtGlucometria.Rows.Count >0)
            {
                glucometriaAprobado = true;
            }
        }
    }
}
