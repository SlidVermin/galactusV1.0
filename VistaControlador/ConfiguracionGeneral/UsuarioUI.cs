using Galactus.Entidades.ConfiguracionGeneral;
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
    public partial class UsuarioUI : Form
    {
        Usuario usuario = new Usuario();
        public UsuarioUI()
        {
            InitializeComponent();
        }

        private void UsuarioUI_Load(object sender, EventArgs e)
        {
            GeneralC.posCargadoForm(this, tstMenuPatron, tBtNuevo, tBtBuscar);
        }
        private void tBtNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenuPatron, tBtGuardar, tBtCancelar);
        }
        private void tBtEditar_Click(object sender, EventArgs e)
        {
            GeneralC.fnEditarForm(this, tstMenuPatron, tBtGuardar, tBtCancelar);
        }
        private void tBtCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenuPatron, tBtNuevo, tBtBuscar);
        }

        private void tBtGuardar_Click(object sender, EventArgs e)
        {
            //if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    producto.idProducto = (txtBCodigo.Text.Equals(String.Empty) ? 0 : int.Parse(txtBCodigo.Text));
            //    producto.descripcion = txtDescripcion.Text;
            //    producto.registroSanitario = txtRegSanitario.Text;
            //    producto.codigoCUM = txtCUM.Text;
            //    producto.iva = (double)ndIva.Value;
            //    try
            //    {
            //        ProductoDAL.guardar(producto);
            //        GeneralC.posGuardar(this, tstMenuPatron, tBtNuevo, tBtBuscar, tBtEditar, tBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);
            //        txtBCodigo.Text = producto.idProducto.ToString();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void tBtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                //GeneralC.buscarDevuelveFila(Query.PRODUCTO_BUSCAR,
                //                            parametros,
                //                            new GeneralC.cargarInfoFila(cargarProducto),
                //                            Mensajes.BUSQUEDA_PRODUCTO,
                //                            true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void tBtAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //ProductoDAL.anular(producto);
                    //GeneralC.posAnular(this, tstMenuPatron, tBtNuevo, tBtBuscar, Mensajes.CONFIRMACION_ANULADO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        void cargarRol(DataRow fila) {
            usuario.idRol = fila.Field<int>("Código");
            txtBRol.Text = fila.Field<string>("Descripción");
        }
        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralC.buscarDevuelveFila(Query.ROL_BUSCAR, 
                                            parametros, 
                                            new GeneralC.cargarInfoFila(cargarRol), 
                                            Mensajes.BUSQUEDA_ROL,
                                            true);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
