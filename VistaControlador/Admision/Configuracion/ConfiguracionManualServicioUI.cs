using System;
using System.Collections.Generic;
using Galactus.Entidades.Admision.Configuracion;
using Galactus.Util.Mensajes;
using Galactus.Util;
using Galactus.Modelo.Admision.Configuracion;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.VistaControlador.Admision.Configuracion
{
    public partial class ConfiguracionManualServicioUI : Form
    {
        ManualServicio objManual = new ManualServicio();

        BindingSource navegarSoat = new BindingSource();
        BindingSource navegarIss = new BindingSource();
        BindingSource navegarCups = new BindingSource();

        public ConfiguracionManualServicioUI()
        {

            InitializeComponent();
        }

        private void ConfiguracionManualServicioUI_Load(object sender, EventArgs e)
        {
            objManual.manualServicio();
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.deshabilitarControles(this);
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.habilitarControles(this);
            GeneralC.limpiarControles(this);
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                ManualServicioDAL.guardarManual(objManual);
                GeneralC.habilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(Mensajes.CONFIRMACION_GUARDADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.EDITAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.habilitarControles(this);
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

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                ManualServicioDAL.AnularManual(cbListaManual.SelectedValue.ToString());
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                MessageBox.Show(Mensajes.CONFIRMACION_ANULADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void tabPestañas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnGuardar.Enabled == false & cbListaManual.SelectedIndex > 0 )
            {
                return;
            }

            if (tabPestañas.SelectedIndex == 0)
            {
                cargarSOAT();
            }

            else if (tabPestañas.SelectedIndex == 1)
            {
                cargarISS();
            }

            else if (tabPestañas.SelectedIndex == 2)
            {
                cargarCUPS();
            }

          }
        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                if (tabPestañas.SelectedIndex == 0)
                {
                    navegarSoat.Filter = "codigo like '%" + txtFiltro.Text + "%' and Descripcion like '%" + txtFiltro.Text + "%'";
                }
                else if (tabPestañas.SelectedIndex == 1)
                {
                    navegarIss.Filter = "codigo like '%" + txtFiltro.Text + "%' and Descripcion like '%" + txtFiltro.Text + "%'";
                }
                else if (tabPestañas.SelectedIndex == 2)
                {
                    navegarCups.Filter = "codigo like '%" + txtFiltro.Text + "%' and Descripcion like '%" + txtFiltro.Text + "%'";
                }
            }
        }
        private void cargarSOAT()
        {
            List<string> parametro = new List<string>();
            parametro.Add(cbListaManual.SelectedValue.ToString());
            GeneralC.llenarTabla(Query.MANUAL_SERVICIO_CONSULTAR_SOAT, parametro, objManual.dtSoat);
            navegarSoat.DataSource = objManual.dtSoat;
            dgvSoat.DataSource =navegarSoat.DataSource;
        }
        private void cargarISS()
        {
            List<string> parametro = new List<string>();
            parametro.Add(cbListaManual.SelectedValue.ToString());
            GeneralC.llenarTabla(Query.MANUAL_SERVICIO_CONSULTAR_ISS, parametro, objManual.dtISS);
            navegarIss.DataSource = objManual.dtISS;
            dgvIss.DataSource = navegarIss.DataSource;
        }
        private void cargarCUPS()
        {
            List<string> parametro = new List<string>();
            parametro.Add(cbListaManual.SelectedValue.ToString());
            GeneralC.llenarTabla(Query.MANUAL_SERVICIO_CONSULTAR_CUPS, parametro, objManual.dtCups);
            navegarCups.DataSource = objManual.dtCups;
            dgvCups.DataSource = navegarCups.DataSource;
        }
        private void cargarInformacion(DataRow dRows ){
            List <string> parametro = new List<string>();

            cbListaManual.SelectedValue= dRows.GetParentRows("Codigo");
            parametro.Add(cbListaManual.SelectedValue.ToString());

            GeneralC.llenarTabla(Query.MANUAL_SERVICIO_CARGAR_SOAT, parametro, objManual.dtSoat);
            GeneralC.llenarTabla(Query.MANUAL_SERVICIO_CARGAR_ISS, parametro, objManual.dtISS);
            GeneralC.llenarTabla(Query.MANUAL_SERVICIO_CARGAR_CUPS, parametro, objManual.dtCups);

            navegarSoat.DataSource = objManual.dtSoat;
            navegarIss.DataSource = objManual.dtISS;
            navegarCups.DataSource = objManual.dtCups;

            dgvSoat.DataSource = navegarSoat.DataSource;
            dgvIss.DataSource = navegarIss.DataSource;
            dgvCups.DataSource = navegarCups.DataSource;

            GeneralC.habilitarBotones(ref tstMenuPatron);
            GeneralC.deshabilitarControles(this);
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

    }
}
