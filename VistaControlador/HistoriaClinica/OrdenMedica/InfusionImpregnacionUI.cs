using Galactus.Entidades.HistoriaClinica.OrdenMedica.Medicamentos;
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
    public partial class InfusionImpregnacionUI : Form
    {
        public bool edicion = false;
        public bool auditoria { get; set; }
        public int idAtencion { get; set; }
        public DateTime fecha { get; set; }
        public OrdenClinicaMedicamento medicamentos { get; set; }
        public InfusionImpregnacionUI()
        {
            InitializeComponent();
        }

        private void InfusionImpregnacionUI_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }

        void inicializarForm()
        {
          
        }
        public void enlazarDgv()
        {
            if (medicamentos != null)
            {
                dgvOrdenInfusionImpregnacion.AutoGenerateColumns = false;
                dgvOrdenInfusionImpregnacion.DataSource = medicamentos.tblInfusionImpregnacion;
            }
        }
    }
}
