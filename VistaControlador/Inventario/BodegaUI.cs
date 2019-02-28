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
            GeneralC.colocarIconosMenu(tstMenuPatron);
            GeneralC.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
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
            GeneralC.posBuscar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstEditar, tsbAnular);
        }
        #endregion
        #region Eventos de botones
        private void tsbGuardar_Click(object sender, EventArgs e)
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
                        GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstEditar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                        txtBCodigo.Text = bodega.idBodega.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralC.buscarDevuelveFila(Query.ALMACEN_BUSCAR,
                                            parametros,
                                            new GeneralC.cargarInfoFila(cargarBodega),
                                            Mensajes.BUSQUEDA_BODEGA,
                                            true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
        }
        private void tstEditar_Click(object sender, EventArgs e)
        {
            GeneralC.fnEditarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar);
        }
        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
        }
        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BodegaDAL.anular(bodega);
                    GeneralC.posAnular(this,  tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
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
