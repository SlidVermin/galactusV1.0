using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Entidades.HistoriaClinica.Fisioterapeuta;
using Galactus.Util.Constantes;

namespace Galactus.VistaControlador.HistoriaClinica.Enfermeria
{
    public partial class FisioterapiaUI : Form
    {
        private int idAtencion;
        Fisioterapeutas fisio = new Fisioterapeutas();
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
        private void opciones()
        {
            insumos.enfermeria.dtInsumos.Rows.Add();
            insumos.dgvInsumos.ReadOnly = false;
        }
        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenu, tsBtGuardar, tsBtCancelar);
            opciones();
            dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
            fisio.idInsumo = ConstanteGeneral.PREDETERMINADO;
        }
    }
}
