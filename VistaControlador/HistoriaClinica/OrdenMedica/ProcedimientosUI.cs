using Galactus.Entidades.HistoriaClinica.OrdenMedica.Procedimientos;
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
    public partial class ProcedimientosUI : Form
    {
        public OrdenClinicaProcedimiento procedimientos { get; set; }
        public ProcedimientosUI()
        {
            InitializeComponent();
        }

        private void ProcedimientosUI_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }
        void inicializarForm()
        {

            dgvProcedimientos.Columns["descripcion"].DataPropertyName = "descripcion";
            dgvProcedimientos.Columns["cantidad"].DataPropertyName = "cantidad";
            dgvProcedimientos.AutoGenerateColumns = false;
            dgvProcedimientos.ReadOnly = true;
            if (procedimientos != null)
            {
                procedimientos.tblProcedimientos.Rows.Add();
                dgvProcedimientos.DataSource = procedimientos.tblProcedimientos;
            }

        }
    }
}
