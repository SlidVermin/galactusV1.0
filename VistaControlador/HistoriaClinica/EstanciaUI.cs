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
    public partial class EstanciaUI : Form
    {
        private int idAtencion;
        public EstanciaUI()
        {
            InitializeComponent();
        }

        public EstanciaUI(int idAtencion)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
        }
    }
}
