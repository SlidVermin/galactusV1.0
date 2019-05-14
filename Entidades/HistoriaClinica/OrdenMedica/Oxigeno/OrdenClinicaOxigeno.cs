using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.HistoriaClinica.OrdenMedica.Oxigeno
{
    public class OrdenClinicaOxigeno
    {
        public DataTable tblOxigeno { get; set; }
        public OrdenClinicaOxigeno()
        {
            tblOxigeno = new DataTable();
            tblOxigeno.Columns.Add("idOxigeno", Type.GetType("System.Int32"));
            tblOxigeno.Columns.Add("Descripción", Type.GetType("System.String"));
            tblOxigeno.Columns.Add("Suspender", Type.GetType("System.Boolean"));
            tblOxigeno.Columns["Suspender"].DefaultValue = false;
            tblOxigeno.Columns.Add("Observación", Type.GetType("System.String"));
        }
    }
}
