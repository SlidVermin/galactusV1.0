using System;
using System.Data;
using System.Windows.Forms;
using Galactus.Util.Mensajes;
using Galactus.Entidades.HistoriaClinica;
using Galactus.Entidades.HistoriaClinica.OrdenMedica;
using Galactus.VistaControlador.HistoriaClinica.OrdenMedica;
using Galactus.VistaControlador.HistoriaClinica.EvolucionMedica;
using Galactus.VistaControlador.HistoriaClinica.Remision;

namespace Galactus.VistaControlador.HistoriaClinica
{

    public partial class HistoriaClinicaUI : Form
    {
        private int idAtencion;
        private bool auditoria;
        private DateTime fechaEgreso;
        private HistoriaClinicaPaciente historiaClinica = new HistoriaClinicaPaciente();
        private EvolucionMedicaUI EvolucionMedica;
        private OrdenMedicaUI OrdenClinica;
        private ResultadoOrdenMedicaUI resulOrdenMedica;
        private IngresoClinicoUI ingreso;
        private EgresoUI egreso;
        private EstanciaUI  estancia;
        private  RemisionUI remision;

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

            ingreso = new IngresoClinicoUI(idAtencion, auditoria);
            OrdenClinica = new OrdenMedicaUI(idAtencion, auditoria);
            EvolucionMedica = new EvolucionMedicaUI(idAtencion, auditoria);
            resulOrdenMedica = new ResultadoOrdenMedicaUI(idAtencion,Convert.ToInt32(auditoria));
            egreso = new EgresoUI (idAtencion, auditoria);
            estancia = new EstanciaUI(idAtencion, auditoria);
            remision = new RemisionUI(idAtencion, auditoria);

            GeneralC.cargarFormularioEnPestana(tpIngresoClinico, ingreso);
            GeneralC.cargarFormularioEnPestana(tpOrdenMedica, OrdenClinica);
            GeneralC.cargarFormularioEnPestana(tpLaboratorios,resulOrdenMedica);
            GeneralC.cargarFormularioEnPestana(tpEvolucion, EvolucionMedica);
            GeneralC.cargarFormularioEnPestana(tpEgreso, egreso);
            GeneralC.cargarFormularioEnPestana(tpEstancia , estancia);
            GeneralC.cargarFormularioEnPestana(tpRemision, remision);

        }
        public void obtenerDatosPaciente(ListadoPaciente listaPaciente, int idIngreso,bool vAuditoria)
        {
            DataTable dtDatos = new DataTable();
            dtDatos = GeneralC.copiarNewDatatable(listaPaciente.dtPaciente, "Atencion", idIngreso);
            if (dtDatos.Rows.Count > 0)
            {
                txtAtencion.Text = Convert.ToString(dtDatos.Rows[0].Field<int>("Atencion"));
                txtAdmision.Text = Convert.ToString(dtDatos.Rows[0].Field<int>("Admision"));
                txtPaciente.Text = dtDatos.Rows[0].Field<String>("Paciente");
                txtEdad.Text = Convert.ToString(dtDatos.Rows[0].Field<String>("Edad"));
                tcHistoriaClinica.Text = dtDatos.Rows[0].Field<String>("Cliente");
                txtEstancia.Text = Convert.ToString(dtDatos.Rows[0].Field<String>("Estancia"));
                txtSexo.Text = dtDatos.Rows[0].Field<String>("Genero");
                txtServicio.Text = dtDatos.Rows[0].Field<String>("Entorno");
                txtfechaIngreso.Text = Convert.ToString(dtDatos.Rows[0].Field<DateTime>("Fecha ingreso"));
                fechaEgreso = (dtDatos.Rows[0].Field<DateTime>("Fecha egreso"));
                idAtencion = int.Parse(txtAtencion.Text);
                auditoria = vAuditoria;
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

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
