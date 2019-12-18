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
            tsbNuevo.Enabled = true;
            tsbBuscar.Enabled = true;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.habilitarControles(this);
            GeneralC.limpiarControles(this);
            tsbCancelar.Enabled = true;
            tsbGuardar.Enabled = true;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                ManualServicioDAL.guardarManual(objManual);
                GeneralC.habilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                tsbGuardar.Enabled = false;
                tsbCancelar.Enabled = false;
                MessageBox.Show(Mensajes.CONFIRMACION_GUARDADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                tsbNuevo.Enabled = true;
                tsbBuscar.Enabled = true;
            }
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                ManualServicioDAL.AnularManual(txtCodigo.Text);
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                MessageBox.Show(Mensajes.CONFIRMACION_ANULADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void tabPestañas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tsbGuardar.Enabled == false &&  !string.IsNullOrEmpty(txtCodigo.Text))
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
            parametro.Add(txtCodigo.Text);
            objManual.dtSoat = GeneralC.cargarResultadosSQL(Sentencias.MANUAL_SERVICIO_CONSULTAR_SOAT, parametro);
            navegarSoat.DataSource = objManual.dtSoat;
            dgvSoat.DataSource =navegarSoat.DataSource;
        }
        private void cargarISS()
        {
            List<string> parametro = new List<string>();
            parametro.Add(txtCodigo.Text);
            objManual.dtISS = GeneralC.cargarResultadosSQL(Sentencias.MANUAL_SERVICIO_CONSULTAR_ISS, parametro);
            navegarIss.DataSource = objManual.dtISS;
            dgvIss.DataSource = navegarIss.DataSource;
        }
        private void cargarCUPS()
        {
            List<string> parametro = new List<string>();
            parametro.Add(txtCodigo.Text);
            objManual.dtCups = GeneralC.cargarResultadosSQL(Sentencias.MANUAL_SERVICIO_CONSULTAR_CUPS, parametro);
            navegarCups.DataSource = objManual.dtCups;
            dgvCups.DataSource = navegarCups.DataSource;
        }
        private void cargarInformacion(DataRow dRows ){
            List <string> parametro = new List<string>();

            txtCodigo.Text = dRows.GetParentRows("Codigo").ToString();
            parametro.Add(txtCodigo.Text);

            objManual.dtSoat = GeneralC.cargarResultadosSQL(Sentencias.MANUAL_SERVICIO_CARGAR_SOAT, parametro);
            objManual.dtISS = GeneralC.cargarResultadosSQL(Sentencias.MANUAL_SERVICIO_CARGAR_ISS, parametro);
            objManual.dtCups = GeneralC.cargarResultadosSQL(Sentencias.MANUAL_SERVICIO_CARGAR_CUPS, parametro);

            navegarSoat.DataSource = objManual.dtSoat;
            navegarIss.DataSource = objManual.dtISS;
            navegarCups.DataSource = objManual.dtCups;

            dgvSoat.DataSource = navegarSoat.DataSource;
            dgvIss.DataSource = navegarIss.DataSource;
            dgvCups.DataSource = navegarCups.DataSource;

            GeneralC.habilitarBotones(ref tstMenuPatron);
            GeneralC.deshabilitarControles(this);
            tsbCancelar.Enabled = true;
            tsbGuardar.Enabled = true;
        }

        private void tsbBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
