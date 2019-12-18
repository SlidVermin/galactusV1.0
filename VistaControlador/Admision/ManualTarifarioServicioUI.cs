using System;
using Galactus.Entidades.Admision;
using Galactus.Util.Mensajes;
using Galactus.Util;
using System.Collections.Generic;
using Galactus.Util.Constantes;
using Galactus.Modelo.Admision;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.VistaControlador.Admision
{
    public partial class ManualTarifarioServicioUI : Form
    {
        manualTarifarioServicio objManualTarifario = new manualTarifarioServicio();
        int indice;
        public ManualTarifarioServicioUI()
        {
            InitializeComponent();
        }

        private void ManualTarifarioServicioUI_Load(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.deshabilitarControles(this);
            tsbNuevo.Enabled = true;
            tsbBuscar.Enabled = true;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            habilitarBotonesBusqueda();
            GeneralC.limpiarControles(this);
            tsbCancelar.Enabled = true;
            tsbGuardar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.Modificar_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                habilitarBotonesBusqueda();
                tsbBuscarManual.Enabled = false;
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
                tsbNuevo.Enabled = true;
                tsbBuscar.Enabled = true;
            }
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (validarCampos() == true)
                {
                    cargarObjeto();
                    manualTarifarioServicioDAL.guardarManualTarifario(objManualTarifario);
                    GeneralC.habilitarBotones(ref tstMenuPatron);
                    GeneralC.deshabilitarControles(this);
                    tsbGuardar.Enabled = false;
                    tsbCancelar.Enabled = false;
                    MessageBox.Show(Mensajes.CONFIRMACION_GUARDADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            GeneralC.buscarDevuelveFila(Sentencias.MANUAL_SERVICIO_BUSCAR,
                                      null,
                                      cargarInformacion,
                                      Titulos.TITULO_MANUAL_SERVICIO,
                                      true);
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                manualTarifarioServicioDAL.anularManualTarifario(Convert.ToInt16(txtCodigoManual.Text));
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                MessageBox.Show(Mensajes.CONFIRMACION_ANULADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void tsbBuscarManual_Click(object sender, EventArgs e)
        {
            buscarGeneral("", Titulos.TITULO_MANUAL_SERVICIO, null, cargarDatos);
        }

        private void tsbBuscarCups_Click(object sender, EventArgs e)
        {
            List<string> paramstro = new List<string>();
            paramstro.Add(txtCodigoManual.Text);
            indice = ConstanteGeneral.METODO_CUPS;
            buscarGeneral("", Titulos.TITULO_MANUAL_SERVICIO_CUPS, paramstro, cargarDatos);
        }

        private void tsbBuscarSoat_Click(object sender, EventArgs e)
        {
            List<string> paramstro = new List<string>();
            paramstro.Add(txtCodigoManual.Text);
            indice = ConstanteGeneral.METODO_SOAT;
            buscarGeneral("", Titulos.TITULO_MANUAL_SERVICIO_SOAT, paramstro, cargarDatos);
        }

        private void tsbBuscarIss_Click(object sender, EventArgs e)
        {
            List<string> paramstro = new List<string>();
            paramstro.Add(txtCodigoManual.Text);
            indice = ConstanteGeneral.METODO_ISS;
            buscarGeneral("", Titulos.TITULO_MANUAL_SERVICIO_ISS, paramstro, cargarDatos);
        }
        private void cargarInformacion(DataRow dRows) {

        }

        private void buscarGeneral(string consulta,
                                   string titulo,
                                   List<string> paramstro, GeneralC.cargarInfoFila metodo) {

            GeneralC.buscarDevuelveFila(consulta,
                            paramstro,
                            metodo,
                            titulo,
                            true);
        }
        private void cargarDatos(DataRow dRows) {
            List<string> parametro = new List<string>();
            DataRow dDatos;
            DataTable dtDato = new DataTable();
            parametro.Add(dRows.GetParentRow("codigo").ToString());
            dtDato = GeneralC.cargarResultadosSQL("", parametro);
            dDatos = dtDato.Rows[0];
            cargarTxt(dDatos);
        }
        private void cargarTxt(DataRow dRows) {
            if (indice == ConstanteGeneral.METODO_CUPS)
            {
                txtCodigoCups.Text = dRows.GetParentRow("codigo").ToString();
                txtNombreCups.Text = dRows.GetParentRow("Descripcion").ToString();
            }
            else if (indice == ConstanteGeneral.METODO_SOAT)
            {
                txtCodigoSoat.Text = dRows.GetParentRow("codigo").ToString();
                txtNombreSoat.Text = dRows.GetParentRow("Descripcion").ToString();
            }
            else if (indice == ConstanteGeneral.METODO_ISS)
            {
                txtCodigoIss.Text = dRows.GetParentRow("codigo").ToString();
                txtNombreIss.Text = dRows.GetParentRow("Descripcion").ToString();
            }
            else
            {
                txtCodigoManual.Text = dRows.GetParentRow("codigo").ToString();
                txtNombreManual.Text = dRows.GetParentRow("Descripcion").ToString();
            }
        }
        private void cargarObjeto() {
            objManualTarifario.codigoManual = txtCodigoManual.Text;
            objManualTarifario.codigoCups = txtCodigoManual.Text;
            objManualTarifario.codigoSoat = txtCodigoSoat.Text;
            objManualTarifario.codigoIss = txtCodigoIss.Text;
        }
        private Boolean validarCampos() {
            if (txtCodigoManual.Text == string.Empty) {
                MessageBox.Show("",Mensajes.NOMBRE_SOFT,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtCodigoCups.Text == string.Empty){
                MessageBox.Show("", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                return true;
            }
            return false;
        }
        private void habilitarBotonesBusqueda() {
            tsbBuscarManual.Enabled = true;
            tsbBuscarCups.Enabled = true;
            tsbBuscarSoat.Enabled = true;
            tsbBuscarIss.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCodigoManual_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
