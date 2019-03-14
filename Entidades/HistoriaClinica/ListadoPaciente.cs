using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Galactus.Util.Constantes;

namespace Galactus.Entidades.HistoriaClinica
{
    class ListadoPaciente
    {
      public  DataTable dtPaciente = new DataTable();
        public String idMenu { get; set; }
        public int idEntorno { get; set; }
        public int idArea { get; set; }
        public int idEstadoAtencion { get; set; }

     
        public void listarPacientes()
        {
            List<String> param = new List<string>();
            param.Add(Convert.ToString(idArea));
            param.Add(Convert.ToString(idEntorno));
            param.Add(Convert.ToString(idEstadoAtencion));
            GeneralC.llenarTabla(ConsultasHistoriaClinica.LISTAR_PACIENTE, param, dtPaciente);
        }
    }
}
