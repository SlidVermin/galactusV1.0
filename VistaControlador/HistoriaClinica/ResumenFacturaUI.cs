using CrystalDecisions.Shared;
using Galactus.Reportes.HistoriaClinica;
using Galactus.Reportes.HistoriaClinica.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class ResumenFacturaUI : Form
    {
        private int idAtencion;
        private bool auditoria;
        public ResumenFacturaUI()
        {
            InitializeComponent();
        }
        public ResumenFacturaUI(int idAtencion, bool auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.auditoria = auditoria;
        }
        private void ResumenFacturaUI_Load(object sender, EventArgs e)
        {
            
        }
        public void cargar()
        {
            DataSet tablasResultados = new DataSet();
            List<string> Parametros = new List<string>();
            Parametros.Add(auditoria.ToString());
            Parametros.Add(idAtencion.ToString());
            tablasResultados = GeneralC.llenarDataset(Sentencias.RESUMEN_FACTURA_CARGAR, Parametros);
            dgvDetalle.DataSource = tablasResultados.Tables["table"];
            dgvAgrupado.DataSource = tablasResultados.Tables["table1"];
            dgvResumenDiario.DataSource = tablasResultados.Tables["table2"];
            dgvConsolidado.DataSource = tablasResultados.Tables["table3"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneralC.exportarReporte(generarReporte(), 
                                "Resumen Facturacion", 
                                null, 
                                ExportFormatType.PortableDocFormat);
        }
        public RptResumenAtencion generarReporte()
        {
            RptResumenAtencion rptResumenAtencion = new RptResumenAtencion();
            rptResumenAtencion.SetParameterValue("@pAuditoria", auditoria);
            rptResumenAtencion.SetParameterValue("@pIdAtencion", idAtencion);
            rptResumenAtencion.SetParameterValue("@pAuditoria", auditoria);
            rptResumenAtencion.SetParameterValue("@pIdAtencion", idAtencion);
            return rptResumenAtencion;
        }
        
    }
}
