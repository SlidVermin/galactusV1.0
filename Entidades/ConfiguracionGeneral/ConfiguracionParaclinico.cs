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
        public int id { get; set; }
        public DataTable dtProcedimiento { get; set; }

        public ConfiguracionParaclinico() {
            dtProcedimiento = new DataTable();
            dtProcedimiento.Columns.Add("IdProcedimiento", Type.GetType("System.Int32"));
            dtProcedimiento.Columns.Add("Descripcion", Type.GetType("System.String"));
        }
    }
}
