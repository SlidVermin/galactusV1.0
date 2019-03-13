using Galactus.Entidades.HistoriaClinica.OrdenMedica.Medicamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.HistoriaClinica.OrdenMedica
{
    public class OrdenClinica
    {
        public int idOrden { get; set; }
        public DateTime fechaOrden { get; set; }
        public OrdenClinicaIndicacion indicacion { get; set; }
        public OrdenClinicaMedicamento medicamento { get; set; }
        public OrdenClinica()
        {
            indicacion = new OrdenClinicaIndicacion();
            medicamento = new OrdenClinicaMedicamento();
        }
        public void nuevaOrden()
        {
            idOrden = -1;
            indicacion.indicacion = string.Empty;
        }
    }
}
