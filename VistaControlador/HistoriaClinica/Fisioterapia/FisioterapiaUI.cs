using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.VistaControlador.HistoriaClinica.Enfermeria
{
    public partial class FisioterapiaUI : Form
    {
        private int idAtencion;
        InsumosUI insumos = new InsumosUI();
        NotasUI notas = new NotasUI();
        public FisioterapiaUI()
        {
            InitializeComponent();
        }
        public FisioterapiaUI(int idAtencion)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
        }

        private void FisioterapiaUI_Load(object sender, EventArgs e)
        {
            dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
            GeneralC.cargarFormularioEnPestana(tpInsumos, insumos);
            GeneralC.cargarFormularioEnPestana(tpNotas, notas);
        }
    }
}
