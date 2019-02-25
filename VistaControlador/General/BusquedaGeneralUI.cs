using Galactus.Entidades.General;
using Galactus.Modelo.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.VistaControlador.General
{
    public partial class BusquedaGeneralUI : Form
    {

        internal Busqueda objBusqueda = new Busqueda();
        internal GeneralC.cargarInfoCodigo metodoPorCodigo;
        internal GeneralC.cargarInfoFila metodoPorFila;
        internal List<string> listaColumnasOcultar;

        public BusquedaGeneralUI()
        {
            InitializeComponent();
        }
        void cargarCodigo(string codigo) { }
        private void BusquedaGeneralUI_Load(object sender, EventArgs e)
        {
            dgvBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBusqueda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            llenarTabla();
            ocultarColumnas();
        }
        private void ocultarColumnas()
        {
            if (listaColumnasOcultar != null)
            {
                foreach (var item in listaColumnasOcultar)
                {
                    if (dgvBusqueda.Columns.Contains(item))
                    {
                        dgvBusqueda.Columns[item].Visible = false;
                    }
                }
            }
        }
        private void dgvBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GeneralC.filaValida(e.RowIndex))
            {
                if (objBusqueda.BusquedaPorCodigo)
                {
                    string codigo = dgvBusqueda.Rows[dgvBusqueda.CurrentRow.Index].Cells[0].Value.ToString();
                    if (metodoPorCodigo != null)
                    {
                        metodoPorCodigo.Invoke(codigo);
                    }
                }
                else
                {
                    DataGridViewRow filaSeleccionada = dgvBusqueda.Rows[dgvBusqueda.CurrentRow.Index];
                    DataRow filaDevuelta = ((DataRowView)filaSeleccionada.DataBoundItem).Row;
                    metodoPorFila.Invoke(filaDevuelta);
                }
                DialogResult = DialogResult.OK;
            }
        }
        void llenarTabla()
        {
            //int cantidadParamatros = objBusqueda.parametros.Count - 1;
            //if (cantidadParamatros > -1)
            //{
            //    objBusqueda.parametros.RemoveAt(cantidadParamatros);
            //    objBusqueda.parametros.Add(txtBusqueda.Text);
            //}

            objBusqueda.TablaResultados = BusquedaDAL.llenarResultado(objBusqueda.Query, objBusqueda.parametros);
            dgvBusqueda.DataSource = objBusqueda.TablaResultados;
            configurarDgv();
        }
        void configurarDgv()
        {
            int sumaTotal = 0;
            foreach (DataGridViewColumn item in dgvBusqueda.Columns)
            {
                sumaTotal += item.Width;
            }
            if (sumaTotal < (dgvBusqueda.Width / 2))
            {
                this.Width = 472;
            }
            else
            {
                this.Width = 968;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (objBusqueda.BuscarConEnter == false)
            {
                busqueda();
            }
        }
        void busqueda()
        {
            txtBusqueda.Text = GeneralC.validarComillas(txtBusqueda.Text);
            llenarTabla();
            txtBusqueda.SelectionStart = txtBusqueda.TextLength;
        }
        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else
            {
                if (objBusqueda.BuscarConEnter && e.KeyCode == Keys.Enter)
                {
                    busqueda();
                }
            }
        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            busqueda();
        }
    }
}
