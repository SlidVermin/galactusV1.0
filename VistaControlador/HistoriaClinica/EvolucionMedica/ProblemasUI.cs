using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Entidades.HistoriaClinica.Evolucion;
using Galactus.Util.Mensajes;

namespace Galactus.VistaControlador.HistoriaClinica.EvolucionMedica
{
    public partial class ProblemasUI : Form
    {
        public Evolucion evolucionMedica = new Evolucion();
        public ProblemasUI()
        {
            InitializeComponent();
        }

        private void ProblemasUI_Load(object sender, EventArgs e)
        {
            establecerGridview();
        }

        public void establecerGridview()
        {
            evolucionMedica.establecerDt();

            dgvDiagnostico.Columns["dgId"].DataPropertyName = "Id";
            dgvDiagnostico.Columns["dgCodigo"].DataPropertyName = "Código";
            dgvDiagnostico.Columns["dgDescripcion"].DataPropertyName = "Descripcion";
            dgvDiagnostico.Columns["dgAgregar"].DataPropertyName = "Agregar";
            dgvDiagnostico.Columns["dgQuitar"].DataPropertyName = "Quitar";

            dgvDiagnostico.DataSource = evolucionMedica.dtDiagnostico;
        }
        public void cargarDiagnostico(DataRow filas)
        {
            dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgId"].Value = filas.Field<int>("Id");
            dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgCodigo"].Value = filas.Field<String>("Código cie");
            dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgDescripcion"].Value = filas.Field<String>("Descripcion");
           
        }

        public void obtenerDiagnosticoCargar(DataTable dtDiagnostico)
        {
            evolucionMedica.dtDiagnostico = dtDiagnostico.Copy();
            dgvDiagnostico.DataSource = evolucionMedica.dtDiagnostico;
        }
        private void dgvDiagnostico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgAgregar"].Selected == true ||
               dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgQuitar"].Selected == true)
            {
                try
                {
                    GeneralC.agregarRegistroDatagridView(buscarDiagnostico, verificarFila, quitarFila, dgvDiagnostico, dgvDiagnostico.Columns["dgcodigo"].Index);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void quitarFila()
        {
            dgvDiagnostico.Rows.RemoveAt(dgvDiagnostico.CurrentCell.RowIndex);
        }
        public void verificarFila()
        {
            if (string.IsNullOrEmpty(dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgcodigo"].Value.ToString()))
            {
                dgvDiagnostico.Rows.RemoveAt(dgvDiagnostico.CurrentCell.RowIndex);
            }
        }
        public void buscarDiagnostico()
        {
            List<string> parametros = new List<string>();

            GeneralC.buscarDevuelveFila(Sentencias.GENERAL_BUSCAR_DIAGNOSTICO,
                                               parametros,
                                               new GeneralC.cargarInfoFila(cargarDiagnostico),
                                               Mensajes.BUSQUEDA_PACIENTE, true);
        }
    }
}
