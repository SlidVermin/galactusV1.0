using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Galactus.Entidades.Admision
{
    class Admisiones
    {
        public int idAtencion { get; set; }
        public int idPaciente { get; set; }
        public DataTable dtPaciente = new DataTable();
        public string identificacion { get; set; }
        public string nombrePaciente { get; set; }
        public string regimen { get; set; }
        public string estratoSocial { get; set; }
        public string tipoAfiliacion { get; set; }
        public string nombreEPS { get; set; }
        public void cargarPaciente()
        {
            List<string> param = new List<string>();
            param.Add(Convert.ToString(idPaciente));
            GeneralC.llenarTabla(Query.ADMISION_PACIENTE_CARGAR, param, dtPaciente);

            if (dtPaciente.Rows.Count > 0)
            {
                identificacion = dtPaciente.Rows[0].Field<string>("identificacion");
                nombrePaciente = dtPaciente.Rows[0].Field<string>("Paciente");
                regimen = dtPaciente.Rows[0].Field<string>("regimen");
                estratoSocial = dtPaciente.Rows[0].Field<string>("estratoSocial");
                tipoAfiliacion = dtPaciente.Rows[0].Field<string>("tipoAfiliacion");
                nombreEPS = dtPaciente.Rows[0].Field<string>("nombre");
            }
        }
    }
}
