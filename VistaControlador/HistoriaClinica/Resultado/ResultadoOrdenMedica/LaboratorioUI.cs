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
using Galactus.Entidades.HistoriaClinica.Resultado;
using Galactus.Util.Constantes;
using Galactus.VistaControlador.HistoriaClinica.Resultado;
using System.Resources;

namespace Galactus.VistaControlador.HistoriaClinica.OrdenMedica
{
    public partial class LaboratorioUI : Form
    {
        private int idAtencion;
        private int Auditoria;
        private ResultadoOrdenMedica resultadoLaboratorio = new ResultadoOrdenMedica();
        public ResultadoOrdenMedicaUI resulOrdenMedica;
 
        public LaboratorioUI(int idAtencion, int Auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.Auditoria = Auditoria;
        }

        private void LaboratorioUI_Load(object sender, EventArgs e)
        {
            validarGrilla();
            cargarExamenesLaboratorio();
        }

        private void cargarExamenesLaboratorio() {
            List<string> paramtro = new List<string>();
            paramtro.Add(Auditoria.ToString());
            paramtro.Add(idAtencion.ToString());  
            GeneralC.llenarTabla(Sentencias.LISTAR_RESULTADO_LABORATORIO, paramtro, resultadoLaboratorio.dtResultado);
            dgvResultadoLaboratorio.DataSource = resultadoLaboratorio.dtResultado;
            estadoRegistro();
        }

        private void validarGrilla() {
            dgvResultadoLaboratorio.Columns["dgIdSolicitud"].DataPropertyName= "idSolicitud";
            dgvResultadoLaboratorio.Columns["dgIdProcedimiento"].DataPropertyName = "idProcedimiento";
            dgvResultadoLaboratorio.Columns["dgDescripcionProcedimiento"].DataPropertyName = "Descripcion";
            dgvResultadoLaboratorio.Columns["dgLectura"].DisplayIndex = 3;
            dgvResultadoLaboratorio.AutoGenerateColumns = false;
        }

        private void estadoRegistro() {
            if (resultadoLaboratorio.dtResultado.Rows.Count > 0) {
                for (int posicion = 0; posicion <= resultadoLaboratorio.dtResultado.Rows.Count - 1; posicion++) {
                    if (resultadoLaboratorio.dtResultado.Rows[posicion].Field<int>("Estado") == ConstanteGeneral.ESTADO_LISTO) {
                        dgvResultadoLaboratorio.Rows[posicion].Cells["dgLectura"].Value = Properties.Resources.Actions_file_close_icon;
                    }
                    else {
                        dgvResultadoLaboratorio.Rows[posicion].Cells["dgLectura"].Value = Properties.Resources.checked__1_;
                    }
                }
            }
        }
        private void dgvResultadoLaboratorio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ResultadoLaboratorioUI resultadoLaboratorio;
            if (e.ColumnIndex == 3)
            {
                resultadoLaboratorio = new ResultadoLaboratorioUI();
                resultadoLaboratorio.ShowDialog();
            }
        }
        private void dgvResultadoLaboratorio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (resultadoLaboratorio.dtResultado.Rows.Count > 0) {
                resulOrdenMedica.txtBCodigoOrden.Text = resultadoLaboratorio.dtResultado.Rows[dgvResultadoLaboratorio.CurrentCell.RowIndex].Field<int>("idOrdenMedica").ToString();
                resulOrdenMedica.dtpFecha.Value = resultadoLaboratorio.dtResultado.Rows[dgvResultadoLaboratorio.CurrentCell.RowIndex].Field<DateTime>("Fecha");
            }
        }
    }
}
