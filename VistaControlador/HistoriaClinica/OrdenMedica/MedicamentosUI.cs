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
    public partial class MedicamentosUI : Form
    {
        public OrdenClinicaMedicamento medicamentos { get; set; }
        public MedicamentosUI()
        {
            InitializeComponent();
        }

        private void MedicamentosUI_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }
        void inicializarForm()
        {
            dgvMedicamentos.Columns["Descripcion"].DataPropertyName = "descripcion";
            dgvMedicamentos.Columns["concentracion"].DataPropertyName = "concentracion";
            dgvMedicamentos.AutoGenerateColumns = false;
            dgvMedicamentos.ReadOnly = true;
            if (medicamentos != null)
            {
                medicamentos.tblMedicamentos.Rows.Add();
                dgvMedicamentos.DataSource = medicamentos.tblMedicamentos;
            }
            
        }
    }
}
