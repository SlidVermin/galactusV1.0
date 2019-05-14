using Galactus.Entidades.HistoriaClinica.OrdenMedica.Oxigeno;
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
    public partial class OxigenoUI : Form
    {
        public bool edicion = false;
        public int idAtencion { get; set; }
        public OrdenClinicaOxigeno oxigeno { get; set; }
        public OxigenoUI()
        {
            InitializeComponent();
        }

        private void OxigenoUI_Load(object sender, EventArgs e)
        {

        }
        public void enlazarDgv()
        {
            if (oxigeno != null)
            {
                dgvOrdenOxigeno.AutoGenerateColumns = false;
                dgvOrdenOxigeno.DataSource = oxigeno.tblOxigeno;
            }
        }
    }
}
