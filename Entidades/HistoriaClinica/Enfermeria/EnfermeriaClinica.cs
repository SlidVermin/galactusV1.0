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
        public int idInsumo { set; get; }
        public int idAtencion { set; get; }
        public DateTime fecha { set; get; }
        public DateTime fechaProcedimiento { set; get; }
        public DataTable dtProcedimientos = new DataTable();
        public DataTable dtGlucometriaCopia = new DataTable();

        public void establecerDT()
        {
            dtInsumos = new DataTable();
            dtInsumos.Columns.Add("Código", typeof(int));
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
        public void prepararGlucometriaDT()
        {
            dtGlucometria.AcceptChanges();
            dtGlucometriaCopia = dtGlucometria.Copy();
            dtGlucometriaCopia.Columns.Remove("Código");
            dtGlucometriaCopia.Columns.Remove("Descripcion");
            dtGlucometriaCopia.Columns.Remove("Responsable");

            for (int i = 0; i < dtGlucometriaCopia.Rows.Count ; i++)
            {
                if(dtGlucometriaCopia.Rows[i].Field<String>("Glicemia").ToString() != String.Empty)
                {
                    dtGlucometriaCopia.Rows[i]["Usuario"] = Sesion.IdUsuario;
                }else
                {
                    dtGlucometriaCopia.Rows.RemoveAt(dtGlucometriaCopia.Rows.Count -1);
                }
            }

        }
        public void prepararInsumoDT()
        {
            dtInsumos.AcceptChanges();
            dtInsumosCopia = dtInsumos.Copy();
            dtInsumosCopia.Columns.Remove("Descripcion");
            if (dtInsumosCopia.Rows.Count > 0)
            {
                dtInsumosCopia.Rows.RemoveAt(dtInsumosCopia.Rows.Count - 1);
                dtInsumos.Rows.RemoveAt(dtInsumos.Rows.Count - 1);
            }
        }

        public void cargarProcedimientos()
        {
            dtInsumos = new DataTable();
            List<string> lista = new List<string>();
            lista.Add(Convert.ToString(idOrdenMedica));
            GeneralC.llenarTabla(Sentencias.CARGAR_PROCEDIMIENTOS_ENFERMERIA, lista, dtProcedimientos);
        }
        public void cargarInsumos()
        {
           
            List<string> lista = new List<string>();
            lista.Add(Convert.ToString(idInsumo));
            GeneralC.llenarTabla(Sentencias.CARGAR_INSUMOS_ENFERMERIA, lista, dtInsumos);
        }
        public void cargarGlucometria()
        {
            List<string> lista = new List<string>();
            lista.Add(Convert.ToString(idOrdenMedica));
            lista.Add(ConstanteGeneral.CODIGO_PROCEDIMIENTO_GLUCOMETRIA);
            lista.Add(ConstanteGeneral.CODIGO_PROCEDIMIENTO_GLUCOMETRIA_2);
            GeneralC.llenarTabla(Sentencias.CARGAR_GLUCOMETRIAS_ENFERMERIA, lista, dtGlucometria);
        }
    }
}
