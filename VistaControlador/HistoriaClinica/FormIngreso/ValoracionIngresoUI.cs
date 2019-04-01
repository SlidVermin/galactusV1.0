using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Modelo.HistoriaClinica;
using Galactus.Entidades.HistoriaClinica;
using Galactus.Util.Mensajes;

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class ValoracionIngresoUI : Form
    {

        
        public IngresoClinico ingreso = new IngresoClinico();
        private int idAtencion;
        
        public ValoracionIngresoUI()
        {
            InitializeComponent();
        }

        public ValoracionIngresoUI(int idAtencion)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
        }
        private void ValoracionIngresoUI_Load(object sender, EventArgs e)
        {
            establecerGridview();
            cargarDatos();
        }

        public void obtenerIdAtencion(int idAtencion)
        {
            this.idAtencion = idAtencion;
        }

        private void cargarDatos()
        {
            ingreso.IdAtencion = idAtencion;
            ingreso.cargarDatosAtencion();
            ingreso.cargarDiagnosticoImpresion();
            txtAutorizacion.Text = ingreso.numeroAutorizacion;
            txtcama.Text = ingreso.cama;
            txtcausaexterna.Text = ingreso.causaExterna;
            txtviaingreso.Text = ingreso.viaIngreso;
            txtinstitucion.Text = ingreso.institucion;
            ingreso.cargarDiagnostico();
            dgvRemision.DataSource = ingreso.dtDiagnostico;
        }

        public void establecerGridview()
        {
            ingreso.establecerDt();

            dgvImpresionN.Columns["dgId"].DataPropertyName = "Id";
            dgvImpresionN.Columns["dgCodigo"].DataPropertyName = "Código";
            dgvImpresionN.Columns["dgDescripcion"].DataPropertyName = "Descripcion";
            dgvImpresionN.Columns["dgAgregar"].DataPropertyName = "Agregar";
            dgvImpresionN.Columns["dgQuitar"].DataPropertyName = "Quitar";

            dgvImpresionN.DataSource = ingreso.dtImpresion;
        }
        private void dgvImpresionN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void cargarDiagnostico(DataRow filas)
        {
            dgvImpresionN.Rows[dgvImpresionN.CurrentCell.RowIndex].Cells["dgId"].Value = filas.Field<int>("Id");
            dgvImpresionN.Rows[dgvImpresionN.CurrentCell.RowIndex].Cells["dgCodigo"].Value = filas.Field<String>("Código cie");
            dgvImpresionN.Rows[dgvImpresionN.CurrentCell.RowIndex].Cells["dgDescripcion"].Value = filas.Field<String>("Descripcion");
           
        }

        private void dgvImpresionN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvImpresionN.Rows[dgvImpresionN.CurrentCell.RowIndex].Cells["dgAgregar"].Selected==true || 
                dgvImpresionN.Rows[dgvImpresionN.CurrentCell.RowIndex].Cells["dgQuitar"].Selected == true)
            {
                try
                {
                    GeneralC.agregarRegistroDatagridView(buscarDiagnostico, verificarFila, quitarFila, dgvImpresionN, dgvImpresionN.Columns["dgcodigo"].Index);
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }   
        }
        public void quitarFila()
        {
            dgvImpresionN.Rows.RemoveAt(dgvImpresionN.CurrentCell.RowIndex);
        }
        public void verificarFila()
        {
            if (string.IsNullOrEmpty(dgvImpresionN.Rows[dgvImpresionN.CurrentCell.RowIndex].Cells["dgcodigo"].Value.ToString()))
            {
                dgvImpresionN.Rows.RemoveAt(dgvImpresionN.CurrentCell.RowIndex);
            }
        }
        public void buscarDiagnostico()
        {
            List<string> parametros = new List<string>();

            GeneralC.buscarDevuelveFila(Sentencias.GENERAL_BUSCAR_DIAGNOSTICO,
                                               parametros,
                                               new GeneralC.cargarInfoFila(cargarDiagnostico),
                                               Mensajes.BUSQUEDA_PACIENTE, true);
        }

        private void dgvImpresionN_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
