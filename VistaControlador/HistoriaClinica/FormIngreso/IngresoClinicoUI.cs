using Galactus.Entidades.HistoriaClinica;
using Galactus.Modelo.HistoriaClinica;
using Galactus.VistaControlador.HistoriaClinica.FormIngreso;
using System;
using System.Windows.Forms;

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class IngresoClinicoUI : Form
    {
        private int idAtencion;
        private ValoracionIngresoUI valoracionUI = new ValoracionIngresoUI();
        private AntecedentesIngresoUI antecedentesUI = new AntecedentesIngresoUI();
        private ExamenFisicoUI examenFisicoUI = new ExamenFisicoUI();
        private AnalisisUI analisisUI = new AnalisisUI();

        public IngresoClinicoUI()
        {
            InitializeComponent();
        }

        public IngresoClinicoUI(int idAtencion)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
        }

        private void IngresoClinicoUI_Load(object sender, EventArgs e)
        {
            GeneralC.cargarFormularioEnPestana(tpValoracion, valoracionUI);
            GeneralC.cargarFormularioEnPestana(tpAntecedentes, antecedentesUI);
            GeneralC.cargarFormularioEnPestana(tpExamenFisico, examenFisicoUI);
            GeneralC.cargarFormularioEnPestana(tpAnalisis, analisisUI);

            GeneralC.posCargadoForm(this, tsIngreso, tsbModificar, null);
        }

        private IngresoClinico crearIngreso()
        {
            IngresoClinico ingreso = new IngresoClinico();

            ingreso.IdAtencion = idAtencion;
            ingreso.Peso = "80";
            ingreso.MotivoIngreso = valoracionUI.txtMotivoIngreso.Text;
            ingreso.Paraclinicos = "PRUEBA";
            ingreso.AntecedentesMedicos = antecedentesUI.txtAntecedentesMedicos.Text;
            ingreso.AntecedentesQuirurgicos = antecedentesUI.txtAntecedentesQuirurgicos.Text;
            ingreso.AntecedentesTransfusionales = antecedentesUI.txtAntecedentesTransfusionales.Text;
            ingreso.AntecedentesAlergicos = antecedentesUI.txtAntecedentesAlergicos.Text;
            ingreso.AntecedentesTraumaticos = antecedentesUI.txtAntecedentesTraumaticos.Text;
            ingreso.AntecedentesToxicos = antecedentesUI.txtAntecedentesToxicos.Text;
            ingreso.AntecedentesFamiliares = antecedentesUI.txtAntecedentesFamiliares.Text;
            ingreso.RevisionSistema = antecedentesUI.txtRevisionSistema.Text;
            ingreso.Generales = examenFisicoUI.txtGenerales.Text;
            ingreso.SignosVitales = examenFisicoUI.txtSignosVitales.Text;
            ingreso.CabezaCuello = examenFisicoUI.txtCabezaCuello.Text;
            ingreso.Torax = examenFisicoUI.txtTorax.Text;
            ingreso.CardioPulmonar = examenFisicoUI.txtCardioPulmonar.Text;
            ingreso.Abdomen = examenFisicoUI.txtAbdomen.Text;
            ingreso.GenitalUrinario = examenFisicoUI.txtGenitalUrinario.Text;
            ingreso.Extremidades = examenFisicoUI.txtExtremidades.Text;
            ingreso.SistemaNervioso = examenFisicoUI.txtSistemaNervioso.Text;            
            ingreso.Analisis = analisisUI.txtAnalisis.Text;
            ingreso.Pronostico = analisisUI.txtPronostico.Text;
            /*ingreso.txtIdUsuario;
            ingreso.txtIdUsuarioOrigen;
            ingreso.txtFechaOrigen;
            ingreso.txtFechaActualizacion;*/


            return ingreso;
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            GeneralC.fnModificarForm(this, tsIngreso, tsbGuardar, tsbCancelar);
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            guardarIngreso();
        }

        private void guardarIngreso() {
            IngresoClinicoDAL.guardarIngreso(crearIngreso());
            MessageBox.Show("Guardado exitosamente");
        }
    }
}
