using System;
using System.Data;
using System.Windows.Forms;
using Galactus.Util.Mensajes;
using Galactus.Entidades.HistoriaClinica;
using Galactus.VistaControlador.HistoriaClinica.OrdenMedica;
using Galactus.VistaControlador.HistoriaClinica.FormIngreso;

namespace Galactus.VistaControlador.HistoriaClinica
{

    public partial class HistoriaClinicaUI : Form
    {
        private HistoriaClinicaPaciente historiaClinica = new HistoriaClinicaPaciente();
        ValoracionIngresoUI valoracionUI = new ValoracionIngresoUI();        
        AntecedentesIngresoUI antecedentesUI = new AntecedentesIngresoUI();
        ExamenFisicoUI examenFisico = new ExamenFisicoUI();
        IndicacionesUI indicaciones = new IndicacionesUI();
        PronosticoUI analisis = new PronosticoUI();
        ProcedimientosUI procedimientos = new ProcedimientosUI();
        MedicamentosUI medicamentos = new MedicamentosUI();

       
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

        private void tabHistoriaClinica_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
            historiaClinica.orden.nuevaOrden();
            
        }
    }
}
