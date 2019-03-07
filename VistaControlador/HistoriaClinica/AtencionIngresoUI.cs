using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class AtencionIngresoUI : Form
    {
        public AtencionIngresoUI()
        {
            InitializeComponent();
        }

        private void AtencionIngresoUI_Load(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.deshabilitarControles(this);
            tstEditar.Enabled = true;
        }

        private void tstEditar_Click(object sender, EventArgs e)
        {
            GeneralC.habilitarControles(this);
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
        }
    }
}
