using Galactus.Entidades.HistoriaClinica;
using Galactus.Entidades.HistoriaClinica.OrdenMedica;
using Galactus.Modelo.HistoriaClinica;
using Galactus.Util;
using Galactus.Util.Constantes;
using Galactus.Util.Mensajes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Galactus.VistaControlador.HistoriaClinica.OrdenMedica
{
    public partial class ResultadoOrdenMedicaUI : Form
    {
        private int idAtencion;
        private int auditoria;
        private LaboratorioUI laboratorio;
        private LaboratorioUI imagenologia;

        public ResultadoOrdenMedicaUI(int idAtencion, int auditoria)
        {
            InitializeComponent();

            this.idAtencion = idAtencion;
            this.auditoria = auditoria;

        }

        private void ResultadoOrdenMedicaUI_Load(object sender, EventArgs e)
        {
            GeneralC.deshabilitarControles(this);
            dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());

            laboratorio = new LaboratorioUI(idAtencion,auditoria,ConstanteGeneral.ID_LABORATORIO);
            laboratorio.resulOrdenMedica = this; 
            GeneralC.cargarFormularioEnPestana(tpLaboratorio, laboratorio);

            imagenologia = new LaboratorioUI(idAtencion, auditoria, ConstanteGeneral.ID_IMAGENOLOGIA);
            imagenologia.resulOrdenMedica = this;
            GeneralC.cargarFormularioEnPestana(tpImagenologia, imagenologia);

               
        }

    }
}
