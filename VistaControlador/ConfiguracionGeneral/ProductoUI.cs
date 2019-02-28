using Galactus.Entidades.Inventario;
using Galactus.Modelo.Inventario;
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

namespace Galactus.VistaControlador.Inventario
{
    public partial class ProductoUI : Form
    {
        Producto producto = new Producto();
        public ProductoUI()
        {
            InitializeComponent();
        }
        private void ProductoUI_Load(object sender, EventArgs e)
        {
            GeneralC.colocarIconosMenu(tstMenuPatron);
            GeneralC.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
        }
        #region Metodos y Funciones
        bool validarForm()
        {
            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar la descripción !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Focus();
                return false;
            }
            else if (txtBMarca.Text.Equals(""))
            {
                MessageBox.Show("Debe escoger la marca !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tsbBuscarMarca.Focus();
                return false;
            }
            else if (txtBEquivalencia.Text.Equals(""))
            {
                MessageBox.Show("Debe escoger la equivalencia !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tsbBuscarEquivalencia.Focus();
                return false;
            }
            else if (txtBPresentacion.Text.Equals(""))
            {
                MessageBox.Show("Debe escoger la presentación !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tsbBuscarPresentacion.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        void cargarProducto(DataRow fila)
        {
            producto.idProducto = fila.Field<int>("Código");
            List<string> listaParametros = new List<string>();
            listaParametros.Add(producto.idProducto.ToString());
            DataRow filaResultado = null;
            try
            {
                filaResultado = GeneralC.obtenerRegistroCompleto(Query.PRODUCTO_CARGAR, listaParametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            if (filaResultado != null)
            {
                producto.descripcion = filaResultado.Field<string>("Descripcion");
                producto.idMarca = filaResultado.Field<int>("idMarca");
                producto.idEquivalencia = filaResultado.Field<int>("idEquivalencia");
                producto.idPresentacion = filaResultado.Field<int>("idPresentacion");
                producto.registroSanitario = filaResultado.Field<string>("RegistroSanitario");
                producto.codigoCUM = filaResultado.Field<string>("CodigoCUM");
                producto.iva = (double)filaResultado.Field<decimal>("Iva");

                txtBMarca.Text = filaResultado.Field<string>("Marca");
                txtBEquivalencia.Text = filaResultado.Field<string>("Equivalencia");
                txtBPresentacion.Text = filaResultado.Field<string>("Presentacion");

                txtBCodigo.Text = producto.idProducto.ToString();
                txtDescripcion.Text = producto.descripcion;
                txtRegSanitario.Text = producto.registroSanitario;
                txtCUM.Text = producto.codigoCUM;
                ndIva.Value = (decimal)producto.iva;
                GeneralC.posBuscar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstEditar, tsbAnular);
            }


        }
        void cargarEquivalencia(DataRow fila)
        {
            producto.idEquivalencia = fila.Field<int>("Código");
            txtBEquivalencia.Text = fila.Field<string>("Descripción");
        }
        void cargarMarca(DataRow fila)
        {
            producto.idMarca = fila.Field<int>("Código");
            txtBMarca.Text = fila.Field<string>("Descripción");
        }
        void cargarPresentacion(DataRow fila)
        {
            producto.idPresentacion = fila.Field<int>("Código");
            txtBPresentacion.Text = fila.Field<string>("Descripción");
        }
        #endregion
        #region Eventos de botones
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
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralC.buscarDevuelveFila(Query.PRODUCTO_BUSCAR,
                                            parametros,
                                            new GeneralC.cargarInfoFila(cargarProducto),
                                            Mensajes.BUSQUEDA_PRODUCTO,
                                            true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void tsbBuscarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(ConstanteGeneral.MARCA.ToString());
                parametros.Add("");
                GeneralC.listarDocumentosGenerales(Query.PARAMETROS_LISTAR_DOCUMENTOS,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarMarca),
                                                   Mensajes.BUSQUEDA_MARCA);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void tsbBuscarEquivalencia_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralC.buscarDevuelveFila(Query.PRODUCTO_LISTAR_EQUIVALENCIA,
                                            parametros,
                                            new GeneralC.cargarInfoFila(cargarEquivalencia),
                                            Mensajes.BUSQUEDA_EQUIVALENCIA,
                                            true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btPresentacion_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(ConstanteGeneral.PRESENTACION.ToString());
                parametros.Add("");
                GeneralC.listarDocumentosGenerales(Query.PARAMETROS_LISTAR_DOCUMENTOS,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarPresentacion),
                                                   Mensajes.BUSQUEDA_PRESENTACION);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                producto.idProducto = (txtBCodigo.Text.Equals(String.Empty) ? 0 : int.Parse(txtBCodigo.Text));
                producto.descripcion = txtDescripcion.Text;
                producto.registroSanitario = txtRegSanitario.Text;
                producto.codigoCUM = txtCUM.Text;
                producto.iva = (double)ndIva.Value;
                try
                {
                    ProductoDAL.guardar(producto);
                    GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstEditar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    txtBCodigo.Text = producto.idProducto.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ProductoDAL.anular(producto);
                    GeneralC.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
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
