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
using Galactus.VistaControlador.Inventario;

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class HistoriaClinicaUI : Form
    {
        ValoracionIngresoUI valoracionUI = new ValoracionIngresoUI();
        FormIngreso.ProductoUI antecedentesUI = new FormIngreso.ProductoUI();

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

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void tabControlGalactus1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabSeleccionado = tcIngresoClinico.SelectedIndex;

            switch (tabSeleccionado){
                case 0:
                    GeneralC.cargarFormularioEnPestana(tpValoracion, valoracionUI);
                    break;
                case 1:
                    GeneralC.cargarFormularioEnPestana(tpAntecedentes, antecedentesUI);
                    break;
                case 2:
                    GeneralC.cargarFormularioEnPestana(tpExamenFisico, valoracionUI);
                    break;
                case 3:
                    GeneralC.cargarFormularioEnPestana(tpAnalisis, valoracionUI);
                    break;
            }          
        }

        
    }
}
