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
using Galactus.VistaControlador.HistoriaClinica;

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class ListadoPacienteUI : Form
    {
        public ListadoPacienteUI()
        {
            InitializeComponent();
        }

        private void ListadoPaciente_Load(object sender, EventArgs e)
        {
            dgvListaPaciente.Rows.Add();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dgvListaPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HistoriaClinicaUI formHistoriaClinica = new HistoriaClinicaUI();
            formHistoriaClinica.ShowDialog();
        }
    }
}
