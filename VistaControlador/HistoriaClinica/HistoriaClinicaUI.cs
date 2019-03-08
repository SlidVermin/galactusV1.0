using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Util.Mensajes;
using Galactus.VistaControlador.HistoriaClinica.FormIngreso;

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class HistoriaClinicaUI : Form
    {
        public HistoriaClinicaUI()
        {
            InitializeComponent();
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

        private void tabControlGalactus1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControlGalactus1.SelectedIndex == 0) {
                GeneralC.cargarFormularioPanel(panelIngreso,new AtencionIngresoUI());
            }
            else if (tabControlGalactus1.SelectedIndex == 1) {
                GeneralC.cargarFormularioPanel(pnlAntecFamiliares, new AntecedentesFamiliaresUI());
            }
            else if (tabControlGalactus1.SelectedIndex == 2) {
                GeneralC.cargarFormularioPanel(pnlAntecPersonales, new AntecedentesPersonalesUI());
            }
            else if (tabControlGalactus1.SelectedIndex == 3)
            {
                GeneralC.cargarFormularioPanel(pnlAntecMaterno, new AntecedentesMaternosUI());
            }
            else if (tabControlGalactus1.SelectedIndex == 4)
            {
                GeneralC.cargarFormularioPanel(pnlAntecRecienNacido, new AntecedenteRecienNacidoUI());
            }
            else if (tabControlGalactus1.SelectedIndex == 5)
            {
                GeneralC.cargarFormularioPanel(pnlEventoNacido, new EventoNacimientoUI());
            }
            else if (tabControlGalactus1.SelectedIndex == 6)
            {
                GeneralC.cargarFormularioPanel(pnlPronostico, new PronosticoUI());
            }
        }
    }
}
