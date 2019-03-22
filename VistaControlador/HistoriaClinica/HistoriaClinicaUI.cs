using System;
using System.Data;
using System.Windows.Forms;
using Galactus.Util.Mensajes;
using Galactus.Entidades.HistoriaClinica;
using Galactus.VistaControlador.HistoriaClinica.OrdenMedica;
using Galactus.VistaControlador.HistoriaClinica.FormIngreso;
using Galactus.Modelo.HistoriaClinica;

namespace Galactus.VistaControlador.HistoriaClinica
{

    public partial class HistoriaClinicaUI : Form
    {
        private HistoriaClinicaPaciente historiaClinica = new HistoriaClinicaPaciente();
        private ValoracionIngresoUI valoracionUI = new ValoracionIngresoUI();        
        private AntecedentesIngresoUI antecedentesUI = new AntecedentesIngresoUI();
        private ExamenFisicoUI examenFisico = new ExamenFisicoUI();
        private IndicacionesUI indicaciones = new IndicacionesUI();
        private PronosticoUI analisis = new PronosticoUI();
        private ProcedimientosUI procedimientos = new ProcedimientosUI();
        private MedicamentosUI medicamentos = new MedicamentosUI();

       
        public HistoriaClinicaUI()
        {
            InitializeComponent();           
        }

        #region btnSalir      
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion        

        private void HistoriaClinicaUI_Load(object sender, EventArgs e)
        {
            GeneralC.cargarFormularioEnPestana(tpValoracion, valoracionUI);
            GeneralC.cargarFormularioEnPestana(tpAntecedentes, antecedentesUI);
            GeneralC.cargarFormularioEnPestana(tpExamenFisico, examenFisico);
            GeneralC.cargarFormularioEnPestana(tpAnalisis, analisis);

            GeneralC.cargarFormularioEnPestana(tpIndicaciones, indicaciones);
            GeneralC.cargarFormularioEnPestana(tbProcedimientos, procedimientos);
            GeneralC.cargarFormularioEnPestana(tpMedicamentos, medicamentos);

            indicaciones.indicacion = historiaClinica.orden.indicacion;
            medicamentos.medicamentos = historiaClinica.orden.medicamento;
            procedimientos.procedimientos = historiaClinica.orden.procedimiento;

            GeneralC.posCargadoForm(this, tsIngreso, tsbModificarIngreso, null);
        }

        public  void obtenerDatosPaciente(ListadoPaciente listaPaciente,int idIngreso)
        {
            DataTable dtDatos = new DataTable();
            dtDatos = GeneralC.copiarNewDatatable(listaPaciente.dtPaciente, "Atencion", idIngreso);
            if (dtDatos.Rows.Count > 0)
            {
                txtAtencion.Text = Convert.ToString(dtDatos.Rows[0].Field<int>("Atencion"));
                txtAdmision.Text = Convert.ToString(dtDatos.Rows[0].Field<int>("Admision"));
                txtPaciente.Text = dtDatos.Rows[0].Field<String>("Paciente");
                txtEdad.Text = Convert.ToString(dtDatos.Rows[0].Field<String>("Edad"));
                txtContrato.Text = dtDatos.Rows[0].Field<String>("EPS");
                txtEstancia.Text = Convert.ToString(dtDatos.Rows[0].Field<int>("Estancia"));
                txtSexo.Text = dtDatos.Rows[0].Field<String>("Genero");
                txtServicio.Text = dtDatos.Rows[0].Field<String>("Entorno");
                txtfechaIngreso.Text = Convert.ToString(dtDatos.Rows[0].Field<DateTime>("Fecha ingreso"));
            }
        }
      
        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
            historiaClinica.orden.nuevaOrden();
            
        }

        private void tsbModificarIngreso_Click(object sender, EventArgs e)
        {
            modificarIngreso();
        }

        private void modificarIngreso() {
            GeneralC.fnModificarForm(tcIngresoClinico, tsIngreso, tsbGuardarIngreso, tsbCancelarIngreso);
        }

        private void tsbGuardarIngreso_Click(object sender, EventArgs e)
        {
            HistoriaClinicaDAL.guardarIngreso(crearIngreso());
        }


        private IngresoClinico crearIngreso()
        {
            IngresoClinico ingreso = new IngresoClinico();

            ingreso.IdAtencion = (int) txtAtencion.Text;
            ingreso.Peso = txtPeso.Text;
            ingreso.MotivoIngreso = txtMotivoIngreso.Text;
            ingreso.AntecedentesMedicos = txtAntecedentesMedicos.Text;
            ingreso.AntecedentesQuirurgicos = txtAntecedentesQuirurgicos.Text;
            ingreso.AntecedentesTransfusionales = txtAntecedentesTransfusionales.Text;
            ingreso.AntecedentesAlergicos = txtAntecedentesAlergicos.Text;
            ingreso.AntecedentesTraumaticos = txtAntecedentesTraumaticos.Text;
            ingreso.AntecedentesToxicos = txtAntecedentesToxicos.Text;
            ingreso.AntecedentesFamiliares = txtAntecedentesFamiliares.Text;
            ingreso.RevisionSistema = txtRevisionSistema.Text;
            ingreso.SignosVitales = txtSignosVitales.Text;
            ingreso.CabezaCuello = txtCabezaCuello.Text;
            ingreso.Torax = txtTorax.Text;
            ingreso.CardioPulmonar = txtCardioPulmonar.Text;
            ingreso.Abdomen = txtAbdomen.Text;
            ingreso.GenitalUrinario = txtGenitalUringario.Text;
            ingreso.Extremidades = txtExtremidades.Text;
            ingreso.SistemaNervioso = txtSistemaNervioso.Text;
            ingreso.Paraclinicos = txtParaclinicos.Text;
            ingreso.Analisis = txtAnalisis.Text;
            ingreso.Pronosticos = txtPronosticos.Text;
            ingreso.IdUsuario = Sesion.IdUsuario;
            ingreso.IdUsuarioOrigen = Sesion.IdUsuario;
            //ingreso.FechaOrigen = DBNull.Value;
            //ingreso.FechaActualizacion = null;


            return ingreso;
        }
    }
}
