using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Entidades.ConfiguracionGeneral;
using Galactus.Util.Constantes;
using Galactus.Util.Mensajes;

namespace Galactus.VistaControlador.ConfiguracionGeneral
{
    public partial class ConfiguracionExamenLaboratorioUI : Form
    {
        ConfiguracionParaclinico clasificacionParaclinico = new ConfiguracionParaclinico();
        public ConfiguracionExamenLaboratorioUI()
        {
            InitializeComponent();
        }

        private void cargarListaProcedimiento(string valor) {
            List<string> paramtro = new List<string>();
            paramtro.Add(valor);
            GeneralC.llenarTabla(Sentencias.CLASIFICACION_PROCEDIMIENTO_PAGINACION, paramtro, clasificacionParaclinico.dtProcedimiento);
            ((ListBox)ckListaProcedimiento).DataSource = clasificacionParaclinico.dtProcedimiento;
            ((ListBox)ckListaProcedimiento).ValueMember = "idProcedimiento";
            ((ListBox)ckListaProcedimiento).DisplayMember = "Descripcion";
            lbRegistros.Text = "N° Registro: " + (clasificacionParaclinico.dtProcedimiento.Rows.Count).ToString();
        }

        private void paginacion(object sender, LinkLabelLinkClickedEventArgs e)
        {
            remarcarLinkLaber();
            cargarListaProcedimiento(((LinkLabel)sender).Tag.ToString());
            ((LinkLabel)sender).LinkVisited = true;
        }
        private void remarcarLinkLaber() {
            foreach (LinkLabel linklabel in pnPaginador.Controls) {
                linklabel.LinkVisited = false;
            }
        }

        private void ConfiguracionExamenLaboratorioUI_Load(object sender, EventArgs e)
        {
            cargarListaProcedimiento(ConstanteGeneral.SIN_VALOR_NUMERICO.ToString());
            linkInicio.LinkVisited = true;
        }

        #region btnSalir

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightCoral;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Control.DefaultBackColor;
        }
        #endregion

    }
}
