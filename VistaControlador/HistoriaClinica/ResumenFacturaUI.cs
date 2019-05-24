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
    public partial class ResumenFacturaUI : Form
    {
        private int idAtencion;
        private bool auditoria;
        public ResumenFacturaUI()
        {
            InitializeComponent();
        }
        public ResumenFacturaUI(int idAtencion, bool auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.auditoria = auditoria;
        }
        private void ResumenFacturaUI_Load(object sender, EventArgs e)
        {

        }
    }
}
