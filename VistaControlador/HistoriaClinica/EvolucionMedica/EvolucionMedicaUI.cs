using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.VistaControlador.HistoriaClinica.FormIngreso;
using Galactus.Entidades.HistoriaClinica.Evolucion;

namespace Galactus.VistaControlador.HistoriaClinica.EvolucionMedica
{
    public partial class EvolucionMedicaUI : Form
    {
        Evolucion evolucionMedica = new Evolucion();
        private ProblemasUI problemas = new ProblemasUI();
        private ExamenFisicoEvoUI examen = new ExamenFisicoEvoUI();
        private InterpretacionUI interpretracion = new InterpretacionUI();
        private AnalisisUI analisis = new AnalisisUI();
        public EvolucionMedicaUI()
        {
            InitializeComponent();
        }

        private void tstPropiedadesOrdenMedica_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void EvolucionMedicaUI_Load(object sender, EventArgs e)
        {
            GeneralC.cargarFormularioEnPestana(tpProblemas, problemas);
            GeneralC.cargarFormularioEnPestana(tpExamenFisico, examen);
            GeneralC.cargarFormularioEnPestana(tpInterpretacion, interpretracion);
            GeneralC.cargarFormularioEnPestana(tpAnalisis, analisis);
            GeneralC.posCargadoForm(this, tstMenuEvolucion, tsBtNuevo, tsBtBuscar);
        }

        private void opciones()
        {
            problemas.evolucionMedica.dtDiagnostico.Rows.Add();
        }
        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenuEvolucion, tsBtGuardar, tsBtCancelar);
            opciones();
        }
    }
}
