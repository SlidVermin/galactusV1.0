using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Entidades.HistoriaClinica.Enfermeria;

namespace Galactus.VistaControlador.HistoriaClinica.Enfermeria
{
    public partial class GlucometriasUI : Form
    {
        EnfermeriaClinica enfermeria = new EnfermeriaClinica();
        public GlucometriasUI()
        {
            InitializeComponent();
        }

        private void GlucometriasUI_Load(object sender, EventArgs e)
        {
            establecerDatagridview();
        }

        public void establecerDatagridview()
        {
            dgvGlucometria.Columns["dgId"].DataPropertyName = "Id";
            dgvGlucometria.Columns["dgCodigo"].DataPropertyName = "Código";
            dgvGlucometria.Columns["dgDescripcion"].DataPropertyName = "Descripcion";
            dgvGlucometria.Columns["dgHora"].DataPropertyName = "Hora";
            dgvGlucometria.Columns["dgGlicemia"].DataPropertyName = "Glicemia";
            dgvGlucometria.Columns["dgInsulina"].DataPropertyName = "Insulina";
            dgvGlucometria.Columns["dgResponsable"].DataPropertyName = "Responsable";
            dgvGlucometria.Columns["dgUsuario"].DataPropertyName = "Usuario";
        }
    }
}
