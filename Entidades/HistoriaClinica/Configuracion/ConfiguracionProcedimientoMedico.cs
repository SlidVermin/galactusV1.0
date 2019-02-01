using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.Entidades.HistoriaClinica.Configuracion
{
    class ConfiguracionProcedimientoMedico
    {
        public int idConfiguracion { get; set; }
        public string idItem { get; set; }
        public string descripcionItem { get; set; }
        public string descripcionCliente { get; set; }
        public int idCliente { get; set; }
        public int usuario { get; set; }
        public Boolean moduloHc { get; set; }
        public Boolean moduloFc { get; set; }
        public Boolean noRepetible { get; set; }
        public Boolean paquete { get; set; }
        public string tipo { get; set; }
        public DataTable tablaAreaAtencion { get; set; }
        public DataTable tablaProcedimiento { get; set; }
        public DataTable tablaMedicamentoInsumo { get; set; }
        public BindingSource enlace;
    }
}

