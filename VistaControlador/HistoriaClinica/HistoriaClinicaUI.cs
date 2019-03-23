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
        private int idAtencion;
        private HistoriaClinicaPaciente historiaClinica = new HistoriaClinicaPaciente();
        private IndicacionesUI indicaciones = new IndicacionesUI();
        private ProcedimientosUI procedimientos = new ProcedimientosUI();
        private MedicamentosUI medicamentos = new MedicamentosUI();
        private IngresoClinicoUI ingreso;
  

       
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
            ingreso = new IngresoClinicoUI(idAtencion);
          

            GeneralC.cargarFormularioEnPestana(tpIngresoClinico, ingreso);
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
                tcHistoriaClinica.Text = dtDatos.Rows[0].Field<String>("EPS");
                txtEstancia.Text = Convert.ToString(dtDatos.Rows[0].Field<int>("Estancia"));
                txtSexo.Text = dtDatos.Rows[0].Field<String>("Genero");
                txtServicio.Text = dtDatos.Rows[0].Field<String>("Entorno");
                txtfechaIngreso.Text = Convert.ToString(dtDatos.Rows[0].Field<DateTime>("Fecha ingreso"));

                idAtencion = int.Parse(txtAtencion.Text);
            }
        }
      
        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
            historiaClinica.orden.nuevaOrden();            
        }

        private void tsbGuardarIngreso_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
