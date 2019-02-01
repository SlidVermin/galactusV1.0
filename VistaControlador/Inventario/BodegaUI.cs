using Galactus.Entidades.Inventario;
using Galactus.Modelo.Inventario;
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

namespace Galactus.VistaControlador.Inventario
{
    public partial class BodegaUI : Form
    {
        Bodega bodega = new Bodega();
        public BodegaUI()
        {
            InitializeComponent();
        }
        private void BodegaUI_Load(object sender, EventArgs e)
        {
            List<ToolStripButton> listaBotonesHab = new List<ToolStripButton>();
            listaBotonesHab.Add(tBtNuevo);
            listaBotonesHab.Add(tBtBuscar);
            GeneralC.posCargadoForm(this, ref tstMenuPatron, ref listaBotonesHab);
        }
        #region Metodos y funciones
        bool validarForm()
        {
            bool resp = false;
            if (txtDescripcion.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe colocar la descripción de la bodega");
            }
            else
            {
                resp = true;
            }
            return resp;
        }
        void cargarBodega(DataRow fila)
        {
            txtBCodigo.Text = fila.Field<int>(0).ToString();
            txtDescripcion.Text = fila.Field<string>(1);
            List<ToolStripButton> listaBotones = new List<ToolStripButton>();
            listaBotones.Add(tBtNuevo);
            listaBotones.Add(tBtBuscar);
            listaBotones.Add(tBtEditar);
            listaBotones.Add(tBtAnular);
            GeneralC.posBuscar(this, ref tstMenuPatron, ref listaBotones);
        }
        #endregion
        #region Eventos de botones
        private void tBtGuardar_Click(object sender, EventArgs e)
        {
            if (validarForm())
            {
                if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bodega.idBodega = (txtBCodigo.Text.Equals(String.Empty) ? 0 : int.Parse(txtBCodigo.Text));
                    bodega.descripcion = txtDescripcion.Text;

                    try
                    {
                        BodegaDAL.guardar(bodega);
                        List<ToolStripButton> listaBotones = new List<ToolStripButton>();
                        listaBotones.Add(tBtNuevo);
                        listaBotones.Add(tBtBuscar);
                        listaBotones.Add(tBtEditar);
                        listaBotones.Add(tBtAnular);
                        GeneralC.posGuardar(this, ref tstMenuPatron, ref listaBotones, Mensajes.CONFIRMACION_GUARDADO);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void tBtBuscar_Click(object sender, EventArgs e)
        {
            List<string> parametros = new List<string>();
            parametros.Add("");
            GeneralC.buscarDevuelveFila(Query.BODEGA_BUSCAR,
                                        parametros,
                                        new GeneralC.cargarInfoFila(cargarBodega),
                                        Mensajes.BUSQUEDA_BODEGA,
                                        true);
        }
        private void tBtNuevo_Click(object sender, EventArgs e)
        {
            List<ToolStripButton> listaBotones = new List<ToolStripButton>();
            listaBotones.Add(tBtGuardar);
            listaBotones.Add(tBtCancelar);
            GeneralC.formNuevo(this,
                               ref tstMenuPatron,
                               ref listaBotones);
        }
        private void tBtEditar_Click(object sender, EventArgs e)
        {
            List<ToolStripButton> listaBotones = new List<ToolStripButton>();
            listaBotones.Add(tBtGuardar);
            listaBotones.Add(tBtCancelar);
            GeneralC.fnEditarForm(this,
                                  ref tstMenuPatron,
                                  ref listaBotones);
        }
        private void tBtCancelar_Click(object sender, EventArgs e)
        {
            List<ToolStripButton> listaBotones = new List<ToolStripButton>();
            listaBotones.Add(tBtNuevo);
            listaBotones.Add(tBtBuscar);
            GeneralC.fnCancelarForm(this, ref tstMenuPatron, ref listaBotones);
        }
        private void tBtAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BodegaDAL.anular(bodega);
                    List<ToolStripButton> listaBotones = new List<ToolStripButton>();
                    listaBotones.Add(tBtNuevo);
                    listaBotones.Add(tBtBuscar);
                    GeneralC.posAnular(this, ref tstMenuPatron, ref listaBotones, Mensajes.CONFIRMACION_ANULADO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        #endregion


    }
}
