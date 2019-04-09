using System;
using System.Data;
using System.Windows.Forms;
using Galactus.Util.Mensajes;
using Galactus.Entidades.HistoriaClinica;
using Galactus.Entidades.HistoriaClinica.OrdenMedica;
using Galactus.VistaControlador.HistoriaClinica.OrdenMedica;
using Galactus.VistaControlador.HistoriaClinica.Enfermeria;

namespace Galactus.VistaControlador.HistoriaClinica
{

    public partial class FichaEnfermeriaUI : Form
    {
        private int idAtencion;
       
        EnfermeriaUI Enfermeria;
      
        public FichaEnfermeriaUI()
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
            Enfermeria = new EnfermeriaUI();
            GeneralC.cargarFormularioEnPestana(tpEnfermeria, Enfermeria);
        }
        public void obtenerDatosPaciente(ListadoPaciente listaPaciente, int idIngreso)
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
                txtEstancia.Text = Convert.ToString(dtDatos.Rows[0].Field<String>("Estancia"));
                txtSexo.Text = dtDatos.Rows[0].Field<String>("Genero");
                txtServicio.Text = dtDatos.Rows[0].Field<String>("Entorno");
                txtfechaIngreso.Text = Convert.ToString(dtDatos.Rows[0].Field<DateTime>("Fecha ingreso"));

                idAtencion = int.Parse(txtAtencion.Text);
            }
        }

        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
          
        }

        private void tsbGuardarIngreso_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
