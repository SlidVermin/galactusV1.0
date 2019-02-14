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
                btNuevo.Enabled = true;
                btBuscar.Enabled = true;
                btnSalir.Enabled = true;
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (validarCampos() == true) {
                    try
                    {
                        cargarObjeto();
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
                                    cargarPersona,
                                    Titulos.TITULO_BUSCAR_CLIENTE,
                                    true);
        } 
        private void btnBuscarNit_Click(object sender, EventArgs e)
        {
            GeneralC.buscarDevuelveFila(Query.BUSCAR_PERSONA,
                                      null,
                                      cargarPersona,
                                      Titulos.TITULO_BUSCAR_PERSONA,
                                      true);
        }

        #region btnSalir

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightCoral;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Control.DefaultBackColor;
        }
        #endregion
        private void cargarPersona(DataRow dRows) {

        }
        private void cargarCliente(DataRow dRows) {

        }
        private Boolean validarCampos() {
            if (txtNit.Text == string.Empty)
            {
                return false;
            }
            else {
                return true;
            }      
        }
        private void cargarObjeto() {
            cliente.codigoFormaPago =Convert.ToInt32(cbFormaPago.SelectedValue.ToString());
            cliente.codigoRegimen = Convert.ToInt32(cbFormaPago.SelectedValue.ToString());
            cliente.codigoUbicacion = Convert.ToInt32(cbFormaPago.SelectedValue.ToString());
            cliente.diaPlazo = Convert.ToInt32(numPlazo.Value.ToString());
            cliente.diaEntrega = Convert.ToInt32(numEntrega.Value.ToString());
            cliente.diaDevolucion = Convert.ToInt32(numDevolucion.Value.ToString());
            cliente.cuentaPuc = txtCuentaPUC.Text;
            cliente.cuentaCIIU = txtCuentaCIIU.Text;
        }
        private void desHabilitadoPermanentemente() {
            txtCuentaCIIU.ReadOnly = true;
            txtCIIU.ReadOnly = true;
            txtPUC.ReadOnly = true;
            txtCuentaPUC.ReadOnly = true;
        }
        private void iniciarCombos() {
           // GeneralC.llenarCombo("", "", "", cbRegimen);
            GeneralC.llenarComboDatosDefinidor(cliente.llenarComboFormaPago(),"Codigo", "Descripcion", cbFormaPago);
            GeneralC.llenarComboDatosDefinidor(cliente.llenarComboUbicacion(),"Codigo", "Descripcion", cbUbicacion);
        }  
    }
}
