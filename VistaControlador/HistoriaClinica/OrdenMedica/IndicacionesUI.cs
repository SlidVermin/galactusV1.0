using Galactus.Entidades.HistoriaClinica.OrdenMedica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.VistaControlador.HistoriaClinica.OrdenMedica
{
    public partial class IndicacionesUI : Form
    {
        public OrdenClinicaIndicacion indicacion;
        public IndicacionesUI()
        {
            InitializeComponent();
        }
        public IndicacionesUI(int idAtencion)
        {
            InitializeComponent();
            
        }
        private void IndiceacionesUI_Load(object sender, EventArgs e)
        {

        }

        private void txtIndicaciones_TextChanged(object sender, EventArgs e)
        {
            indicacion.indicacion = txtIndicaciones.Text;
        }

        private void IndiceacionesUI_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        public void visualizarIndicacionCargada()
        {
            txtIndicaciones.Text = indicacion.indicacion;
        }
    }
}
