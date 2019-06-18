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
using Galactus.Util.Mensajes;
using Galactus.Util.Constantes;

namespace Galactus.VistaControlador.HistoriaClinica.EvolucionMedica
{
    public partial class EvolucionMedicaUI : Form
    {
        private int idAtencion;
        private bool auditoria;
        Evolucion evolucionMedica = new Evolucion();
        private ProblemasUI problemas = new ProblemasUI();
        private ExamenFisicoUI examen = new ExamenFisicoUI();
        private InterpretacionUI interpretracion = new InterpretacionUI();
        private AnalisisUI analisis = new AnalisisUI();
        public EvolucionMedicaUI()
        {
            InitializeComponent();
        }

        public EvolucionMedicaUI(int idAtencion, bool auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.auditoria = auditoria;
        }
        private void tstPropiedadesOrdenMedica_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void EvolucionMedicaUI_Load(object sender, EventArgs e)
        {

            dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
            GeneralC.cargarFormularioEnPestana(tpProblemas, problemas);
            GeneralC.cargarFormularioEnPestana(tpExamenFisico, examen);
            GeneralC.cargarFormularioEnPestana(tpAnalisis, analisis);
            GeneralC.posCargadoForm(this, tstMenuEvolucion, tsBtNuevo, tsBtBuscar);
            evolucionMedica.idEvolucion = ConstanteGeneral.PREDETERMINADO;
        }

        private void opciones()
        {
            problemas.evolucionMedica.dtDiagnostico.Rows.Add();
        }
        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenuEvolucion, tsBtGuardar, tsBtCancelar);
            opciones();
            evolucionMedica.idEvolucion = ConstanteGeneral.PREDETERMINADO;
            dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
        }

        private void obtenerDatos()
        {
            evolucionMedica.IdAtencion = idAtencion;
            evolucionMedica.Subjetivos = problemas.txtSubjetivos.Text;
            evolucionMedica.Generales = examen.txtGenerales.Text;
            evolucionMedica.SignosVitales = examen.txtSignosVitales.Text;
            evolucionMedica.GenitalUrinario = examen.txtGenitalUrinario.Text;
            evolucionMedica.Torax = examen.txtTorax.Text;
            evolucionMedica.SistemaNervioso = examen.txtSistemaNervioso.Text;
            evolucionMedica.Abdomen = examen.txtAbdomen.Text;
            evolucionMedica.PielFanera = examen.txtPielFaneras.Text;
            evolucionMedica.Extremidades = examen.txtExtremidades.Text;
            evolucionMedica.CabezaCuello = examen.txtCabezaCuello.Text;
            evolucionMedica.CardioPulmonar = examen.txtCardioPulmonar.Text;
            evolucionMedica.Analisis = analisis.txtAnalisis.Text;
            evolucionMedica.Plan = analisis.txtPlan.Text;
            evolucionMedica.fechaEvolucion = dtpFecha.Value;
            alistarDt(problemas.evolucionMedica);
        }
        public void alistarDt(Evolucion evolucionMedica)
        {
            evolucionMedica.dtDiagnostico.AcceptChanges();
                  
            this.evolucionMedica.dtAlistar = evolucionMedica.dtDiagnostico.Copy();
            this.evolucionMedica.dtAlistar.Columns.Remove("Código");
            if (this.evolucionMedica.dtAlistar.Rows.Count > 0)
            {
                this.evolucionMedica.dtAlistar.Rows.RemoveAt(this.evolucionMedica.dtAlistar.Rows.Count - 1);
                evolucionMedica.dtDiagnostico.Rows.RemoveAt(evolucionMedica.dtDiagnostico.Rows.Count - 1);
            }
        }
        private bool validarForm()
        {
            return true;
        }
        private void tsBtGuardar_Click(object sender, EventArgs e)
        {
            if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    obtenerDatos();
                    evolucionMedica.guardar();
                    txtIdEvolucion.Text = Convert.ToString( evolucionMedica.idEvolucion);
                    GeneralC.posGuardar(this, tstMenuEvolucion, tsBtNuevo, tsBtBuscar, tsBtModificar, tsBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tsBtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(idAtencion));
                GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_EVOLUCION_MEDICA,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarDatos),
                                                   Mensajes.BUSCAR_EVOLUCION, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cargarDatos(DataRow filas)
        {
            evolucionMedica.idEvolucion = filas.Field<int>("idEvolucion");
            txtIdEvolucion.Text = Convert.ToString( filas.Field<int>("idEvolucion"));
            evolucionMedica.cargarDatos();
            problemas.txtSubjetivos.Text = evolucionMedica.Subjetivos;
            examen.txtGenerales.Text = evolucionMedica.Generales;
            examen.txtAbdomen.Text = evolucionMedica.Abdomen;
            examen.txtCabezaCuello.Text = evolucionMedica.CabezaCuello;
            examen.txtCardioPulmonar.Text = evolucionMedica.CardioPulmonar;
            examen.txtExtremidades.Text = evolucionMedica.Extremidades;
            examen.txtGenitalUrinario.Text = evolucionMedica.GenitalUrinario;
            examen.txtPielFaneras.Text = evolucionMedica.PielFanera;
            examen.txtSignosVitales.Text = evolucionMedica.SignosVitales;
            examen.txtSistemaNervioso.Text = evolucionMedica.SistemaNervioso;
            examen.txtTorax.Text = evolucionMedica.Torax;
            analisis.txtAnalisis.Text = evolucionMedica.Analisis;
            analisis.txtPlan.Text = evolucionMedica.Plan;
            problemas.obtenerDiagnosticoCargar(evolucionMedica.dtDiagnostico);
            tsBtModificar.Enabled = true;
            tsBtAnular.Enabled = true;
        }

        private void tsBtModificar_Click(object sender, EventArgs e)
        {
            GeneralC.habilitarControles(this);
            tsBtGuardar.Enabled = true;
            tsBtModificar.Enabled = false;
            tsBtAnular.Enabled = false;
            tsBtNuevo.Enabled = false;
            tsBtBuscar.Enabled = false;
            tsBtCancelar.Enabled = true;
            opciones();
        }

        private void tsBtCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenuEvolucion, tsBtNuevo, tsBtBuscar);
            evolucionMedica.idEvolucion = ConstanteGeneral.PREDETERMINADO;
            dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
        }

        private void tsBtAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    evolucionMedica.borrar();
                    GeneralC.posAnular(this, tstMenuEvolucion, tsBtNuevo, tsBtBuscar, Mensajes.CONFIRMACION_ANULADO);
                    evolucionMedica.idEvolucion = ConstanteGeneral.PREDETERMINADO;
                    dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
