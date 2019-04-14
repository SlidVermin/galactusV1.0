using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.HistoriaClinica.OrdenMedica.Medicamentos
{
    public class OrdenClinicaMedicamento
    {
        public DataTable tblMedicamentos { get; set; }
        public OrdenClinicaMedicamento()
        {
            tblMedicamentos = new DataTable();
            tblMedicamentos.Columns.Add("codigo",Type.GetType("System.Int32"));
            tblMedicamentos.Columns.Add("descripcion", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("concentracion", Type.GetType("System.Double"));
            tblMedicamentos.Columns["concentracion"].DefaultValue = 0.0;
        }
    }
}
