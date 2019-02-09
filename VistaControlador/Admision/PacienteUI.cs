using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.VistaControlador
{
    public partial class PacienteUI : Form
    {
        public PacienteUI()
        {
            InitializeComponent();
        }

        private void buscarEpsBtn_Click(object sender, EventArgs e)
        {

        }

        private void nuevoBtn_Click(object sender, EventArgs e)
        {

        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {

        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {

        }

        private void editarBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {

        }

        private void anularBtn_Click(object sender, EventArgs e)
        {

        }

        private void PacienteUI_Load(object sender, EventArgs e)
        {
            GeneralC.llenarCombo(Query.CARGARPAIS,
                                Util.Constantes.ConstanteGeneral.VALUEMEMBER_PAIS, 
                                Util.Constantes.ConstanteGeneral.DISPLAYMEMBER_PAIS, 
                                paisBox);
        }

        private void paisBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (paisBox.SelectedIndex > 0)
            {

                GeneralC.llenarCombo(Query.CARGAR_DEPARTAMENTO + " " + paisBox.SelectedValue + "",
                                    Util.Constantes.ConstanteGeneral.VALUEMEMBER_DEPARTAMENTO,
                                    Util.Constantes.ConstanteGeneral.DISPLAYMEMBER_DEPARTAMENTO,
                                    departBox);
            }
        }
    }
}
