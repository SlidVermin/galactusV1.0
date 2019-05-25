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

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class SolicitudMedicamentoNoPosUI : Form
    {
        public SolicitudMedicamentoNoPosUI()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SolicitudMedicamentoNoPosUI_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btBuscarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();

                GeneralC.buscarDevuelveFila(Sentencias.ADMISION_PACIENTE_BUSCAR,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarRegistro),
                                                   Mensajes.BUSQUEDA_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cargarRegistro(DataRow resultado)
        {

        }
    }
}
