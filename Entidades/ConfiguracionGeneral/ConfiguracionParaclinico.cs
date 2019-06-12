using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Galactus.Entidades.ConfiguracionGeneral
{
    class ConfiguracionParaclinico
    {
        public int idGrupo { get; set; }
        public int idTipoLaboratorio { get; set; }
        public int numPaginacion { get; set; }
        public bool editable { get; set; }
        public DataTable dtProcedimiento { get; set; }
        public DataTable dtExamen { get; set; }
        public DataTable dtRegistro { get; set; }
        public ConfiguracionParaclinico() {
            dtProcedimiento = new DataTable();
            dtExamen = new DataTable();
            dtRegistro = new DataTable();

            dtProcedimiento.Columns.Add("IdProcedimiento", Type.GetType("System.Int32"));
            dtProcedimiento.Columns.Add("cups", Type.GetType("System.String"));
            dtProcedimiento.Columns.Add("Descripcion", Type.GetType("System.String"));
            dtProcedimiento.Columns.Add("Estado", Type.GetType("System.Boolean"));
            dtExamen = dtProcedimiento.Clone();

            dtRegistro.Columns.Add("IdProcedimiento", Type.GetType("System.Int32"));
            dtRegistro.Columns.Add("Estado", Type.GetType("System.Boolean"));
            dtRegistro.Columns.Add("Registrado", Type.GetType("System.Int32"));
           
        }
    }
}
