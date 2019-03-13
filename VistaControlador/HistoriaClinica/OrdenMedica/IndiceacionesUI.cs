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
    public partial class IndiceacionesUI : Form
    {
        public OrdenClinicaIndicacion indicacion { get; set; }
        public IndiceacionesUI()
        {
            InitializeComponent();
        }
        private void IndiceacionesUI_Load(object sender, EventArgs e)
        {
            txtIndicaciones.Text = indicacion.indicacion;
        }

        private void txtIndicaciones_TextChanged(object sender, EventArgs e)
        {
            indicacion.indicacion = txtIndicaciones.Text;
        }

        private void IndiceacionesUI_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
