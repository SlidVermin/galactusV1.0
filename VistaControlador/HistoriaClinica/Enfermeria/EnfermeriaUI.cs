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
    public partial class EnfermeriaUI : Form
    {
        InsumosUI insumos = new InsumosUI();
        NotasUI notas = new NotasUI();
        ParaclinicosUI paraclinicos = new ParaclinicosUI();
        HemoderivadosUI hemoderivados = new HemoderivadosUI();
        GlucometriasUI glucometrias = new GlucometriasUI();
        public EnfermeriaUI()
        {
            InitializeComponent();
        }

        private void EnfermeriaUI_Load(object sender, EventArgs e)
        {
            fecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
            GeneralC.cargarFormularioEnPestana(tpInsumos, insumos);
            GeneralC.cargarFormularioEnPestana(tpNotas, notas);
            GeneralC.cargarFormularioEnPestana(tpParaclinicos, paraclinicos);
            GeneralC.cargarFormularioEnPestana(tpHemoderivados, hemoderivados);
            GeneralC.cargarFormularioEnPestana(tpGlucometria, glucometrias);
        }
    }
}
