using Galactus.Entidades.ConfiguracionGeneral;
using Galactus.Modelo.ConfiguracionGeneral;
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
            objListaPrecio.enlazarDt();
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
            enlazarGrilla();
            cargarTodaListaEquivalencia();
        }
        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
        }
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralC.buscarDevuelveFila(ConsultasConfiguracionGeneral.LISTA_PRECIO_EQUIVALENCIA_BUSCAR,
                                            parametros,
                                            new GeneralC.cargarInfoFila(cargarLista),
                                            Mensajes.BUSQUEDA_EQUIVALENCIA,
                                            true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            dgvMedicamento.EndEdit();
            dgvMedicamento.CommitEdit(DataGridViewDataErrorContexts.Commit);

            if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objListaPrecio.idLista = (txtBCodigo.Text.Equals(String.Empty) ? 0 : int.Parse(txtBCodigo.Text));
                objListaPrecio.nombre = txtDescripcion.Text;
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
        private void tstModificar_Click(object sender, EventArgs e)
        {
            if (GeneralC.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar))
            {
                List<string> param = new List<string>();
                param.Add(string.Empty);
                try {
                        DataTable tblTemp = new DataTable();
                        tblTemp = objListaPrecio.tablaEquivalencia.Clone();
                        GeneralC.llenarTabla(ConsultasConfiguracionGeneral.LISTA_PRECIO_EQUIVALENCIA_CARGAR_TODO, param, tblTemp);
                        objListaPrecio.tablaEquivalencia.Merge(tblTemp,true);
                    
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                objListaPrecio.enlazarDt();
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
            else if (objListaPrecio.tablaEquivalencia.Select("precio = 0").Count() == objListaPrecio.tablaEquivalencia.Rows.Count)
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
        bool verificarCeldasActivas(int columnaActual)
        {
            dgvMedicamento.ReadOnly = false;
            if (columnaActual == dgvMedicamento.Columns["Precio"].Index || columnaActual == dgvMedicamento.Columns["mostrar"].Index)
            {
                return false;
            }
            return true;
        }
        void cargarTodaListaEquivalencia()
        {

            List<string> param = new List<string>();
            param.Add(string.Empty);
            GeneralC.llenarTabla(ConsultasConfiguracionGeneral.LISTA_PRECIO_EQUIVALENCIA_CARGAR_TODO, param, objListaPrecio.tablaEquivalencia);
            enlazarGrilla();
        }
        void enlazarGrilla()
        {
            dgvMedicamento.DataSource = objListaPrecio.tblFuente;
            objListaPrecio.tablaEquivalencia.AcceptChanges();
            if (dgvMedicamento.Columns.Count > 0)
            {
                dgvMedicamento.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMedicamento.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvMedicamento.Columns["Precio"].DefaultCellStyle.Format = "C2";
                dgvMedicamento.Columns["mostrar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        void cargarLista(DataRow fila)
        {
            if (fila != null)
            {
                txtBCodigo.Text = fila.Field<int>("Código").ToString();
                txtDescripcion.Text = fila.Field<string>("Descripcion").ToString();
                cargarDetalleLista(fila.Field<int>("Código"));
            }
        }
        void cargarDetalleLista(int codigo)
        {
            List<string> param = new List<string>();
            param.Add(codigo.ToString());
            GeneralC.llenarTabla(ConsultasConfiguracionGeneral.LISTA_PRECIO_EQUIVALENCIA_CARGAR_DETALLE, param, objListaPrecio.tablaEquivalencia);
            objListaPrecio.enlazarDt();
            enlazarGrilla();
            GeneralC.posCargadoForm(this, tstMenuPatron, tsbBuscar, tstModificar, tsbAnular, tstImprimir);
        }
        #endregion
        /// <summary>
        /// Eventos de la grilla de equivalencias
        /// </summary>
        #region Metodos de dgvMedicamento
        private void dgvMedicamento_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dgvMedicamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tsbGuardar.Enabled)
            {
                dgvMedicamento.Columns[e.ColumnIndex].ReadOnly = verificarCeldasActivas(e.ColumnIndex);
            }
        }
        private void dgvMedicamento_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (tsbGuardar.Enabled)
            {
                dgvMedicamento.Columns[e.ColumnIndex].ReadOnly = verificarCeldasActivas(e.ColumnIndex);
            }
        }
        private void dgvMedicamento_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Funciones.validarValoresNumericos);
        }
        #endregion
    }
}