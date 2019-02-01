using Galactus.Entidades.ConfiguracionGeneral;
using Galactus.Modelo.ConfiguracionGeneral;
using Galactus.Util.Constantes;
using Galactus.Util.Mensajes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.VistaControlador.ConfiguracionGeneral
{
    public partial class ConfiguracionGeneralUI : Form
    {
        Entidades.ConfiguracionGeneral.ConfiguracionGeneral objConfiguracionGeneral = new Entidades.ConfiguracionGeneral.ConfiguracionGeneral();
        public ConfiguracionGeneralUI()
        {
            InitializeComponent();
        }
        private void ConfiguracionGeneralUI_Load(object sender, EventArgs e)
        {
            List<ToolStripButton> listaBotonesHab = new List<ToolStripButton>();
            GeneralC.posCargadoForm(this, ref tstMenuPatron, ref listaBotonesHab);
            DataGridViewColumnCollection columnas = dgvDetalle.Columns;
            columnas["Código"].DataPropertyName = "Código";
            columnas["Descripción"].DataPropertyName = "Descripción";
            btBuscarParametro.Enabled = true;
            dgvDetalle.Enabled = true;
            btlimpiar.Enabled = true;
        }
        void cargarParametro(DataRow fila)
        {
            objConfiguracionGeneral.idParametro = fila.Field<int>("Código");
            txtBParametro.Text = fila.Field<string>("Descripción");
            txtBCodigo.ResetText();
            txtDescripción.ResetText();
            txtDescripción.Enabled = true;
            tBtGuardar.Enabled = true;
            llenarGrilla();
        }
        void llenarGrilla()
        {
            try
            {
                objConfiguracionGeneral.llenarDocumentos();
                enlazarGrilla();
                txtBusqueda.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void enlazarGrilla()
        {
            dgvDetalle.DataSource = objConfiguracionGeneral.enlace.DataSource;
            dgvDetalle.Enabled = true;
        }
        bool validarForm()
        {
            if (txtBParametro.Text.Equals(""))
            {
                MessageBox.Show("Debe escoger el parametro padre ! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btBuscarParametro.Focus();
                return false;
            }
            else if (txtDescripción.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar la descripción del parametro ! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripción.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        void posAccion()
        {
            txtBCodigo.Text = "";
            txtDescripción.Text = "";
            tBtAnular.Enabled = false;
            btBuscarParametro.Enabled = true;
            btlimpiar.Enabled = true;
            txtDescripción.Enabled = true;
            llenarGrilla();
        }
        private void btBuscarParametro_Click(object sender, EventArgs e)
        {
            List<string> parametros = new List<string>();
            parametros.Add("");
            GeneralC.buscarDevuelveFila(Query.PARAMETROS_CARGAR,
                                        parametros,
                                        new GeneralC.cargarInfoFila(cargarParametro),
                                        "Busqueda de Parametros",
                                        true);
        }
        private void tBtGuardar_Click(object sender, EventArgs e)
        {
            if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    objConfiguracionGeneral.idDocumento = (txtBCodigo.Text.Equals("") ? -1 : int.Parse(txtBCodigo.Text));
                    objConfiguracionGeneral.descripcionDocumento = txtDescripción.Text;
                    ConfiguracionGeneralDAL.guardar(objConfiguracionGeneral);
                    MessageBox.Show(Mensajes.CONFIRMACION_GUARDADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    posAccion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btlimpiar_Click(object sender, EventArgs e)
        {
            txtDescripción.ResetText();
            txtBCodigo.ResetText();
        }
        private void tBtAnular_Click(object sender, EventArgs e)
        {
            if (txtDescripción.Text.Equals("") && txtBCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debe escoger un parametro hijo para anularlo!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show(Mensajes.ANULAR_FORM, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        ConfiguracionGeneralDAL.anular(objConfiguracionGeneral);
                        MessageBox.Show(Mensajes.CONFIRMACION_ANULADO, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        posAccion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objConfiguracionGeneral.enlace.Filter = "[Descripción] like '%" + txtBusqueda.Text + "%'";
                enlazarGrilla();
            }
        }
        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GeneralC.filaValida(e.RowIndex))
            {
                objConfiguracionGeneral.idDocumento = int.Parse(dgvDetalle["Código", e.RowIndex].Value.ToString());
                objConfiguracionGeneral.descripcionDocumento = dgvDetalle["Descripción", e.RowIndex].Value.ToString();
                txtBCodigo.Text = dgvDetalle["Código", e.RowIndex].Value.ToString();
                txtDescripción.Text = dgvDetalle["Descripción", e.RowIndex].Value.ToString();
                txtDescripción.Enabled = true;
                tBtGuardar.Enabled = true;
                tBtAnular.Enabled = true;
            }
        }

    }
}
