using Galactus.Entidades.ConfiguracionGeneral;
using Galactus.Modelo.ConfiguracionGeneral;
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

namespace Galactus.VistaControlador.ConfiguracionGeneral
{
    public partial class ListaPrecioMedicamentoUI : Form
    {
        ListaPrecioEquivalencia objListaPrecio = new ListaPrecioEquivalencia();
        
        public ListaPrecioMedicamentoUI()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Eventos de los botones
        /// </summary>
        #region Botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void ListaPrecioMedicamentoUI_Load(object sender, EventArgs e)
        {
            GeneralC.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            enlazarGrilla();
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
            objListaPrecio.configuracionFuente();
            cargarTodaListaEquivalencia();
        }
        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
        }
        private void tsbBuscar_Click(object sender, EventArgs e)
        {

        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            dgvMedicamento.EndEdit();
            dgvMedicamento.CommitEdit(DataGridViewDataErrorContexts.Commit);
            
            if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objListaPrecio.idLista = (txtBCodigo.Text.Equals(String.Empty) ? 0 : int.Parse(txtBCodigo.Text));
                objListaPrecio.nombre = txtDescripcion.Text;
                objListaPrecio.activo = chkActiva.Checked;
                objListaPrecio.tablaEquivalencia.AcceptChanges();
                try
                {
                    ListaPrecioEquivalenciaDAL.guardar(objListaPrecio);
                    GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    txtBCodigo.Text = objListaPrecio.idLista.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
        /// <summary>
        /// Eventos de los botones
        /// </summary>
        #region Metodos y Funciones
        bool validarForm()
        {
            objListaPrecio.tablaEquivalencia.AcceptChanges();
            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar la descripción !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Focus();
                return false;
            }
            else if (objListaPrecio.tablaEquivalencia.Select("valor = 0").Count() == objListaPrecio.tablaEquivalencia.Rows.Count)
            {
                MessageBox.Show("Debe ingresar por lo menos el precio de 1 equivalencia!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMedicamento.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        void cargarTodaListaEquivalencia()
        {
            List<string> param = new List<string>();
            param.Add(string.Empty);
            GeneralC.llenarTabla(ConsultasConfiguracionGeneral.LISTA_PRECIO_EQUIVALENCIA_BUSCAR ,param, objListaPrecio.tablaEquivalencia);
            dgvMedicamento.DataSource = objListaPrecio.tblFuente;
        }
        void enlazarGrilla()
        {
         
            dgvMedicamento.Columns["dgCodigo"].DataPropertyName = "Id";
            dgvMedicamento.Columns["descripcionDiagCol"].DataPropertyName = "Nombre";
            dgvMedicamento.Columns["dgPrecio"].DataPropertyName = "Precio";
            dgvMedicamento.Columns["dgVisible"].DataPropertyName = "mostrar";
            dgvMedicamento.DataSource = objListaPrecio.tblFuente;
        }

        #endregion

        private void dgvMedicamento_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}