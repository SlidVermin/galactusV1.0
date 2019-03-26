using Galactus.Entidades.HistoriaClinica.OrdenMedica.Medicamentos;
using Galactus.Entidades.HistoriaClinica.OrdenMedica.Procedimientos;
using Galactus.Util.Constantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.HistoriaClinica.OrdenMedica
{
    public class OrdenClinica
    {
        public int idAtencion { get; set; }
        public int idOrden { get; set; }
        public DateTime fechaOrden { get; set; }
        public OrdenClinicaIndicacion indicacion { get; set; }
        public OrdenClinicaMedicamento medicamento { get; set; }
        public OrdenClinicaProcedimiento procedimiento { get; set; }
        public OrdenClinica()
        {
            indicacion = new OrdenClinicaIndicacion();
            medicamento = new OrdenClinicaMedicamento();
            procedimiento = new OrdenClinicaProcedimiento();
        }
        public void nuevaOrden()
        {
            idOrden = ConsultasHistoriaClinica.NUEVO;
            indicacion.indicacion = string.Empty;
            medicamento.tblMedicamentos.Clear();
            procedimiento.tblProcedimientos.Clear();

            medicamento.tblMedicamentos.Rows.Add();
            procedimiento.tblProcedimientos.Rows.Add();
        }
      
    }
}
