using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Util.Mensajes;
using Galactus.Util.Constantes;
using Galactus.Entidades.Inventario;
using Galactus.Util;
using Galactus.Modelo.Gestion;

namespace Galactus.VistaControlador.Gestion
{
    public partial class ClienteUI : Form
    {
        private Cliente cliente;
        public ClienteUI()
        {
            InitializeComponent();
        }

        private void ClienteUI_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();
            GeneralC.deshabilitarBotones(ref TostMenu);
            GeneralC.deshabilitarControles(this);
            iniciarCombos();
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref TostMenu);
            GeneralC.habilitarControles(this);
            GeneralC.deshabilitarControles(pnlInformacion);
            desHabilitadoPermanentemente();
            GeneralC.limpiarControles(this);
            cliente.codigo = 0;
            btnBuscarNit.Enabled = true;
            btGuardar.Enabled = true;
            btCancelar.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.EDITAR_FORM,Mensajes.NOMBRE_SOFT,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) {
                GeneralC.deshabilitarBotones(ref TostMenu);
                GeneralC.habilitarControles(this);
                GeneralC.deshabilitarControles(pnlInformacion);
                desHabilitadoPermanentemente();
                btGuardar.Enabled = true;
                btCancelar.Enabled = true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.CANCELAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref TostMenu);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                cliente.codigo = 0;
                btNuevo.Enabled = true;
                btBuscar.Enabled = true;
                btnSalir.Enabled = true;
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true) 
            {
                if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    try
                    {
                        crearNuevoCliente();
                        ClienteDAL.guardarCliente(cliente);
                        GeneralC.habilitarBotones(ref TostMenu);
                        GeneralC.deshabilitarControles(this);
                        btnSalir.Enabled = true;
                        btGuardar.Enabled = true;
                        btCancelar.Enabled = true;
                        MessageBox.Show(Mensajes.CONFIRMACION_GUARDADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        
        private void btAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClienteDAL.anularCliente(cliente.codigo);
                GeneralC.deshabilitarBotones(ref TostMenu);
                GeneralC.limpiarControles(this);
                GeneralC.deshabilitarControles(this);
                btBuscar.Enabled = true;
                btNuevo.Enabled = true;
            }
        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            GeneralC.buscarDevuelveFila(Query.BUSCAR_CLIENTE,
                                    null,
                                    cargarCliente,
                                    Titulos.TITULO_BUSCAR_CLIENTE,
                                    true);
        } 
        private void btnBuscarNit_Click(object sender, EventArgs e)
        {
            List<string> parametro = new List<string>();
            parametro.Add(string.Empty);
            GeneralC.buscarDevuelveFila(Query.BUSCAR_TERCERO,
                                      parametro,
                                      new GeneralC.cargarInfoFila(cargarTercero),
                                      Titulos.TITULO_BUSCAR_TERCERO,
                                      true);
        }

        #region btnSalir

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightCoral;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM,Mensajes.NOMBRE_SOFT,MessageBoxButtons.YesNo,MessageBoxIcon.Information)== DialogResult.Yes) {          
                Close();
            }
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Control.DefaultBackColor;
        }
        #endregion

        private void cargarTercero(DataRow dRows) {
            cliente.codigo = dRows.Field<Int32>("codigo");
            txtNit.Text = dRows.Field<string>("Nit");
            txtRazonSocial.Text = dRows.Field<string>("RazonSocial");
            txtDireccion.Text = dRows.Field<string>("Direccion");
            txtTelefono.Text = dRows.Field<string>("Telefono");
            txtCelular.Text = dRows.Field<string>("Celular");
        }
        private void cargarCliente(DataRow dRows) {

        }
        private Boolean validarCampos() {
            if (txtNit.Text == string.Empty)
            {
                MessageBox.Show("¡ Favor seleccionar el tercero !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cbRegimen.SelectedIndex == 0) {
                MessageBox.Show("¡ Favor seleccionar el regimen !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cbFormaPago.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccionar la forma de pago !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cbUbicacion.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccionar la ubicación !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else {
                return true;
            }      
        }
        private void crearNuevoCliente() {
            cliente.codigoFormaPago =Convert.ToInt32(cbFormaPago.SelectedValue);
            cliente.codigoRegimen = Convert.ToInt32(cbFormaPago.SelectedValue);
            cliente.codigoUbicacion = Convert.ToInt32(cbFormaPago.SelectedValue);
            cliente.diaPlazo = Convert.ToInt32(numPlazo.Value);
            cliente.diaEntrega = Convert.ToInt32(numEntrega.Value);
            cliente.diaDevolucion = Convert.ToInt32(numDevolucion.Value);
            cliente.cuentaPuc = string.IsNullOrEmpty(txtCuentaPUC.Text) ? null : txtCuentaPUC.Text;
            cliente.cuentaCIIU = string.IsNullOrEmpty(txtCuentaCIIU.Text) ? null : txtCuentaCIIU.Text;
        }
        private void desHabilitadoPermanentemente() {
            txtCuentaCIIU.ReadOnly = true;
            txtCIIU.ReadOnly = true;
            txtPUC.ReadOnly = true;
            txtCuentaPUC.ReadOnly = true;
        }
        private void iniciarCombos() {
            List<string> parametro = new List<string>();
            string cadena;
            parametro.Add(ConstanteGeneral.REGIMEN_SOCIO_ECONOMICO.ToString());
            cadena = GeneralC.obtenerParametros(parametro);
            GeneralC.llenarCombo(Query.PARAMETROS_CONSULTAR_DESCRIPCION + cadena, "Codigo", "Descripcion", cbRegimen);
            GeneralC.llenarComboDatosDefinidor(cliente.llenarComboFormaPago(),"Codigo", "Descripcion", cbFormaPago);
            GeneralC.llenarComboDatosDefinidor(cliente.llenarComboUbicacion(),"Codigo", "Descripcion", cbUbicacion);
        }  
    }
}
