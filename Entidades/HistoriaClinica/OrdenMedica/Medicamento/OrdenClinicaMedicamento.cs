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
        }
    }
}
