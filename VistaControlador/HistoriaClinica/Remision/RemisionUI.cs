using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.VistaControlador.HistoriaClinica.Remision;

namespace Galactus.VistaControlador.HistoriaClinica.Remision
{
    public partial class RemisionUI : Form
    {
        private int idAtencion;
        private Anexo9UI anexo9 = new Anexo9UI();
        public RemisionUI()
        {
            InitializeComponent();
        }
        public RemisionUI(int idAtencion)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
        }
        private void tstPropiedadesOrdenMedica_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RemisionUI_Load(object sender, EventArgs e)
        {
            GeneralC.cargarFormularioEnPestana(tpAnexo, anexo9);
        }
    }
}
