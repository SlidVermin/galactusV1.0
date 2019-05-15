using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.VistaControlador.HistoriaClinica;

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class SabanaEnfermeriaUI : Form

    {
        private int idAtencion;
        private bool auditoria;
        public SabanaEnfermeriaUI()
        {
            InitializeComponent();

        }
        public SabanaEnfermeriaUI(int idAtencion , bool auditoria) {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.auditoria = auditoria;
        }
    }
}
