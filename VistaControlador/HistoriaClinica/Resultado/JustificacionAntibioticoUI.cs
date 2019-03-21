using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Entidades.HistoriaClinica.Resultado;
using Galactus.Util.Mensajes;
using Galactus.Util;

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class JustificacionAntibioticoUI : Form
    {

        JustificacionAntibiotico objJustificacionAnt;
        public JustificacionAntibioticoUI()
        {
            InitializeComponent();
        }

        private void JustificacionAntibioticoUI_Load(object sender, EventArgs e)
        {
            objJustificacionAnt = new JustificacionAntibiotico();
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.deshabilitarControles(this);
            tsbNuevo.Enabled = true;
            tsbBuscar.Enabled = true;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.habilitarControles(this);
            GeneralC.limpiarControles(this);
            objJustificacionAnt.codigo = null;
            tsbCancelar.Enabled = true;
            tsbGuardar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.Modificar_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.habilitarControles(this);
                tsbCancelar.Enabled = true;
                tsbGuardar.Enabled = true;
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.CANCELAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                objJustificacionAnt.codigo = null;
                tsbNuevo.Enabled = true;
                tsbBuscar.Enabled = true;
            }
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               // ManualServicioDAL.guardarManual(objManual);
                GeneralC.habilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                tsbGuardar.Enabled = false;
                tsbCancelar.Enabled = false;
                MessageBox.Show(Mensajes.CONFIRMACION_GUARDADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            GeneralC.buscarDevuelveFila(Query.MANUAL_SERVICIO_BUSCAR,
                                      null,
                                      cargarInformacion,
                                      Titulos.TITULO_MANUAL_SERVICIO,
                                      true);
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //ManualServicioDAL.AnularManual(cbListaManual.SelectedValue.ToString());
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                MessageBox.Show(Mensajes.CONFIRMACION_ANULADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cargarInformacion(DataRow dRows) {

        }
        private void cargarPatologia(int codigo) {
            List<string> parametro = new List<string>();
            parametro.Add(codigo.ToString());
            GeneralC.llenarTabla("", parametro, objJustificacionAnt.dtPatologia);
            dgvDiagnostico.DataSource = objJustificacionAnt.dtPatologia;
        }
        public void cargarDatosPaciente(DataRow dRows) {
            txtRegistro.Text = dRows.GetParentRows("Registro").ToString();
            txtRegistro.Text = dRows.GetParentRows("Identificacion").ToString();
            txtRegistro.Text = dRows.GetParentRows("OrdenMedica").ToString();
            txtRegistro.Text = dRows.GetParentRows("Paciente").ToString();
            txtRegistro.Text = dRows.GetParentRows("Servicio").ToString();
            txtRegistro.Text = dRows.GetParentRows("CodAdmin").ToString();
            txtRegistro.Text = dRows.GetParentRows("Administradora").ToString();
            cargarPatologia(Convert.ToUInt16(dRows.GetParentRows("Registro")));

        }
    }
}
