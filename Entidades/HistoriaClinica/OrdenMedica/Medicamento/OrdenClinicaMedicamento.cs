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

        public DataTable tblInfusionImpregnacion { get; set; }
        public DataTable tblMezcla { get; set; }
        public OrdenClinicaMedicamento()
        {
            tblMedicamentos = new DataTable();
            tblMedicamentos.Columns.Add("idMedicamento", Type.GetType("System.Int32"));
            tblMedicamentos.Columns.Add("idEquivalencia", Type.GetType("System.Int32"));
            tblMedicamentos.Columns.Add("Descripción", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("tipoMedicamento", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("idViaAdmon", Type.GetType("System.Int32"));
            tblMedicamentos.Columns.Add("Via admin.", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("Dosis", Type.GetType("System.Double"));
            tblMedicamentos.Columns["Dosis"].DefaultValue = 0.0;
            tblMedicamentos.Columns.Add("Unidad", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("Horario", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("Hora inicial", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("Dias Tto", Type.GetType("System.String"));
            tblMedicamentos.Columns.Add("Suspender", Type.GetType("System.Boolean"));

            tblInfusionImpregnacion = new DataTable();
            tblInfusionImpregnacion.Columns.Add("idMedicamento", Type.GetType("System.Int32"));
            tblInfusionImpregnacion.Columns.Add("tipo", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("idEquivalencia", Type.GetType("System.Int32"));
            tblInfusionImpregnacion.Columns.Add("Descripción", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("tipoMedicamento", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("Dosis", Type.GetType("System.Double"));
            tblInfusionImpregnacion.Columns["Dosis"].DefaultValue = 0.0;
            tblInfusionImpregnacion.Columns.Add("Unidad", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("cc/hora", Type.GetType("System.Double"));
            tblInfusionImpregnacion.Columns.Add("idEquivalenciaDisolvente", Type.GetType("System.Int32"));
            tblInfusionImpregnacion.Columns.Add("Disolvente", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("Cantidad", Type.GetType("System.Int32"));
            tblInfusionImpregnacion.Columns.Add("Hora inicial", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("Mezcla", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("Dias Tto", Type.GetType("System.String"));
            tblInfusionImpregnacion.Columns.Add("Suspender", Type.GetType("System.Boolean"));
            tblInfusionImpregnacion.Columns.Add("Acepta disolvente", Type.GetType("System.Boolean"));


            tblMezcla = new DataTable();
            tblMezcla.Columns.Add("idMedicamento", Type.GetType("System.Int32"));
            tblMezcla.Columns.Add("idEquivalencia", Type.GetType("System.Int32"));
            tblMezcla.Columns.Add("Descripción", Type.GetType("System.String"));
            tblMezcla.Columns.Add("Unidad", Type.GetType("System.String"));
            tblMezcla.Columns.Add("Dosis", Type.GetType("System.Double"));
            tblMezcla.Columns["Dosis"].DefaultValue = 0.0;
        }
    }
}
