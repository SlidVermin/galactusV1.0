using Galactus.Modelo.Facturacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.Facturacion
{
    class FacturaPaciente
    {
        public int idAdmision { get; set; }
        public int idContrato { get; set; }
        public string codigoFactura { get; set; }
        public DataTable dtCambiosCUPS = new DataTable();
        public DataTable dtCambiosOxigeno = new DataTable();
        public DataTable dtCambiosEquivalencia = new DataTable();
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaVencimiento { get; set; }
       
        public DataSet dsDatos = new DataSet();
        public void guardar()
        {
            prepararDT();
            FacturaPacienteDAL.guardar(this);
        }
        public void prepararDT()
        {
            dtCambiosCUPS = dsDatos.Tables["table"].Copy();
            dtCambiosOxigeno = dsDatos.Tables["table2"].Copy();
            dtCambiosEquivalencia = dsDatos.Tables["table3"].Copy();

            dtCambiosCUPS.Columns.Remove("Descripción");
            dtCambiosCUPS.Columns.Remove("Código");
            dtCambiosCUPS.Columns.Remove("Total");
            dtCambiosOxigeno.Columns.Remove("Descripción");
            dtCambiosOxigeno.Columns.Remove("Código");
            dtCambiosOxigeno.Columns.Remove("Total");
            dtCambiosEquivalencia.Columns.Remove("Descripción");
            dtCambiosEquivalencia.Columns.Remove("Código");
            dtCambiosEquivalencia.Columns.Remove("Total");
        }



        public void anular()
        {
            FacturaPacienteDAL.eliminar(this);
        }
       
        public void cargarDatos()
        {
            List<string> param = new List<string>();
            param.Add(Convert.ToString(idAdmision));
            dsDatos = GeneralC.llenarDataset(Sentencias.FACTURA_PACIENTE_CARGAR_ADMISION, param);

            
        }
    }
}
