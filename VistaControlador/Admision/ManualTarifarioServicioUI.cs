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
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            habilitarBotonesBusqueda();
            GeneralC.limpiarControles(this);
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.EDITAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                habilitarBotonesBusqueda();
                btnBuscarManual.Enabled = false;
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.CANCELAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                btnNuevo.Enabled = true;
                btnBuscar.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (validarCampos() == true)
                {
                    cargarObjeto();
                    manualTarifarioServicioDAL.guardarManualTarifario(objManualTarifario);
                    GeneralC.habilitarBotones(ref tstMenuPatron);
                    GeneralC.deshabilitarControles(this);
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    MessageBox.Show(Mensajes.CONFIRMACION_GUARDADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GeneralC.buscarDevuelveFila(Query.MANUAL_SERVICIO_BUSCAR,
                                      null,
                                      cargarInformacion,
                                      Titulos.TITULO_MANUAL_SERVICIO,
                                      true);
        }

        private void btnAnular_Click(object sender, EventArgs e)
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
        private void btnBuscarManual_Click(object sender, EventArgs e)
        {
            buscarGeneral("", Titulos.TITULO_MANUAL_SERVICIO, null, cargarDatos);
        }

        private void btnBuscarCups_Click(object sender, EventArgs e)
        {
            List<string> paramstro = new List<string>();
            paramstro.Add(txtCodigoManual.Text);
            indice = ConstanteGeneral.METODO_CUPS;
            buscarGeneral("", Titulos.TITULO_MANUAL_SERVICIO_CUPS, paramstro, cargarDatos);
        }

        private void btnBuscarSoat_Click(object sender, EventArgs e)
        {
            List<string> paramstro = new List<string>();
            paramstro.Add(txtCodigoManual.Text);
            indice = ConstanteGeneral.METODO_SOAT;
            buscarGeneral("", Titulos.TITULO_MANUAL_SERVICIO_SOAT, paramstro, cargarDatos);
        }

        private void btnBuscarIss_Click(object sender, EventArgs e)
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
            GeneralC.llenarTabla("", parametro, dtDato);
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
            btnBuscarManual.Enabled = true;
            btnBuscarCups.Enabled = true;
            btnBuscarSoat.Enabled = true;
            btnBuscarIss.Enabled = true;
        }
    }
}
