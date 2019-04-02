using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Galactus.Modelo.HistoriaClinica;

namespace Galactus.Entidades.HistoriaClinica.Evolucion
{
  public class Evolucion
    {
        public int IdAtencion { get; set; }
        public DateTime fechaEvolucion { get; set; }
        public int idEvolucion { get; set; }
        public String Subjetivos { get; set; }
        public String PielFanera { get; set; }
        public String Generales { get; set; }
        public String SignosVitales { get; set; }
        public String CabezaCuello { get; set; }
        public String Torax { get; set; }
        public String CardioPulmonar { get; set; }
        public String Abdomen { get; set; }
        public String GenitalUrinario { get; set; }
        public String Extremidades { get; set; }
        public String SistemaNervioso { get; set; }
        public String Analisis { get; set; }
        public String Plan { get; set; }
        public DataTable dtDiagnostico = new DataTable();
        public DataTable dtAlistar = new DataTable();
        public DataSet dsDatos = new DataSet();

        public void cargarDatos()
        {
            EvolucionMedicaDAL.cargarDatos(this);
            DataTableCollection dt = dsDatos.Tables;

            if (dt["table"].Rows.Count>0)
            {
                Generales = dt["table"].Rows[0].Field<String>("generales");
                Subjetivos = dt["table"].Rows[0].Field<String>("subjetivos");
                fechaEvolucion = dt["table"].Rows[0].Field<DateTime>("fecha");
                Torax = dt["table"].Rows[0].Field<String>("torax");
                SignosVitales = dt["table"].Rows[0].Field<String>("SignosVitales");
                CabezaCuello = dt["table"].Rows[0].Field<String>("cabezaCuello");
                CardioPulmonar = dt["table"].Rows[0].Field<String>("cardioPulmonar");
                Abdomen = dt["table"].Rows[0].Field<String>("abdomen");
                GenitalUrinario = dt["table"].Rows[0].Field<String>("genitourinario");
                Extremidades = dt["table"].Rows[0].Field<String>("extremidades");
                SistemaNervioso = dt["table"].Rows[0].Field<String>("sistemanervioso");           
                Analisis = dt["table"].Rows[0].Field<String>("analisis");
                Plan = dt["table"].Rows[0].Field<String>("plan");
                PielFanera = dt["table"].Rows[0].Field<String>("pielFaneras");
            }
            if (dt["table1"].Rows.Count > 0)
            {
                dtDiagnostico = dt["table1"].Copy();
            }
        }
        public void establecerDt()
        {
            dtDiagnostico.Columns.Add("Id", typeof(String));
            dtDiagnostico.Columns.Add("Código", typeof(String));
            dtDiagnostico.Columns.Add("Descripcion", typeof(String));
        }
        public void guardar()
        {
            EvolucionMedicaDAL.guardarEvolucion(this);
        }
        public void borrar()
        {
            EvolucionMedicaDAL.borrarEvolucion(this);
        }
    }
}
