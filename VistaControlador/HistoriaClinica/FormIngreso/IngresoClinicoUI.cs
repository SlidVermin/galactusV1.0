using Galactus.Entidades.HistoriaClinica;
using Galactus.Modelo.HistoriaClinica;
using Galactus.VistaControlador.HistoriaClinica.FormIngreso;
using System;
using System.Windows.Forms;
using Galactus.Util.Mensajes;

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class IngresoClinicoUI : Form
    {
        private int idAtencion;
        private bool auditoria;
        IngresoClinico ingreso = new IngresoClinico();
        private ValoracionIngresoUI valoracionUI = new ValoracionIngresoUI();
        private AntecedentesIngresoUI antecedentesUI = new AntecedentesIngresoUI();
        private AntecedentesMaternosUI antecedentesMaternosUI = new AntecedentesMaternosUI();
        private AntecedenteRecienNacidoUI antecedenteRecienNacidoUI = new AntecedenteRecienNacidoUI();
        private EventoNacimientoUI eventoNacimientoUI = new EventoNacimientoUI();
        private ExamenFisicoUI examenFisicoUI = new ExamenFisicoUI();
        private AnalisisUI analisisUI = new AnalisisUI();
        
        public IngresoClinicoUI()
        {
            InitializeComponent();
        }

        public IngresoClinicoUI(int idAtencion,bool auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.auditoria = auditoria;
        }

        private void IngresoClinicoUI_Load(object sender, EventArgs e)
        {
            valoracionUI = new ValoracionIngresoUI(idAtencion);

            GeneralC.cargarFormularioEnPestana(tpValoracion, valoracionUI);
            GeneralC.cargarFormularioEnPestana(tpAntecedentes, antecedentesUI);
            GeneralC.cargarFormularioEnPestana(tpAntecedentesMaterno, antecedentesMaternosUI);
            GeneralC.cargarFormularioEnPestana(tpAntecedentesNacimiento, eventoNacimientoUI);
            GeneralC.cargarFormularioEnPestana(tpRecienNacido, antecedenteRecienNacidoUI);
            GeneralC.cargarFormularioEnPestana(tpExamenFisico, examenFisicoUI);
            GeneralC.cargarFormularioEnPestana(tpAnalisis, analisisUI);

            GeneralC.posCargadoForm(this, tsIngreso, tsbModificar, null);
            cargarIngreso();
        }

        private void cargarIngreso()
        {
            IngresoClinico ingreso = new IngresoClinico();
            ingreso.IdAtencion = idAtencion;
            ingreso.cargarDatos();

            valoracionUI.txtMotivoIngreso.Text = ingreso.MotivoIngreso;
            valoracionUI.txtResumenClinico.Text = ingreso.resumenClinico;
            antecedentesUI.txtAnteM.Text = ingreso.AntecedentesMedicos;
            antecedentesUI.txtAntecedentesAlergicos.Text = ingreso.AntecedentesAlergicos;
            antecedentesUI.txtAntecedentesFamiliares.Text = ingreso.AntecedentesFamiliares;
            antecedentesUI.txtAntecedentesQuirurgicos.Text = ingreso.AntecedentesQuirurgicos;
            antecedentesUI.txtAntecedentesToxicos.Text = ingreso.AntecedentesToxicos;
            antecedentesUI.txtAntecedentesTransfusionales.Text = ingreso.AntecedentesTransfusionales;
            antecedentesUI.txtAntecedentesTraumaticos.Text = ingreso.AntecedentesTraumaticos;
            antecedentesUI.txtRevisionSistema.Text = ingreso.RevisionSistema;
            examenFisicoUI.txtAbdomen.Text = ingreso.Abdomen;
            examenFisicoUI.txtCabezaCuello.Text = ingreso.CabezaCuello;
            examenFisicoUI.txtCardioPulmonar.Text = ingreso.CardioPulmonar;
            examenFisicoUI.txtExtremidades.Text = ingreso.Extremidades;
            examenFisicoUI.txtGenitalUrinario.Text = ingreso.GenitalUrinario;
            examenFisicoUI.txtSignosVitales.Text = ingreso.SignosVitales;
            examenFisicoUI.txtSistemaNervioso.Text = ingreso.SistemaNervioso;
            examenFisicoUI.txtTorax.Text = ingreso.Torax;
            examenFisicoUI.txtGenerales.Text = ingreso.Generales;
            examenFisicoUI.txtPielFaneras.Text = ingreso.pielFaneras;
            analisisUI.txtAnalisis.Text = ingreso.Analisis;
            analisisUI.txtPronostico.Text = ingreso.Pronostico;
        }

        private IngresoClinico crearIngreso()
        {
          

            ingreso.IdAtencion = idAtencion;
            ingreso.Peso = "80";
            ingreso.MotivoIngreso = valoracionUI.txtMotivoIngreso.Text;
            ingreso.resumenClinico = valoracionUI.txtResumenClinico.Text;
            ingreso.Paraclinicos = "PRUEBA";
            ingreso.AntecedentesMedicos = antecedentesUI.txtAnteM.Text;
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
            ingreso.pielFaneras = examenFisicoUI.txtPielFaneras.Text;
            alistarDt(valoracionUI.ingreso);
            /*ingreso.txtIdUsuario;
            ingreso.txtIdUsuarioOrigen;
            ingreso.txtFechaOrigen;
            ingreso.txtFechaActualizacion;*/


            return ingreso;
        }
        public void alistarDt(IngresoClinico ingreso)
        {
          this.ingreso.dtAlistar = ingreso.dtImpresion.Copy();
          this.ingreso.dtAlistar.Columns.Remove("Código");
          if(this.ingreso.dtAlistar.Rows.Count > 0)
            {
                this.ingreso.dtAlistar.Rows.RemoveAt(this.ingreso.dtAlistar.Rows.Count -1);
                ingreso.dtImpresion.Rows.RemoveAt(ingreso.dtImpresion.Rows.Count - 1);
            }
        }
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            GeneralC.fnModificarForm(this, tsIngreso, tsbGuardar, tsbCancelar);
            valoracionUI.ingreso.dtImpresion.Rows.Add();
            
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            guardarIngreso();
        }
        public bool validarForm()
        {
            return true;
        }
        private void guardarIngreso() {
           
            if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    IngresoClinicoDAL.guardarIngreso(crearIngreso());
                    GeneralC.posGuardar(this, tsIngreso, tsbModificar, null, null, null, null, Mensajes.CONFIRMACION_GUARDADO);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
