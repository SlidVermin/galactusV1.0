﻿using System;
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
    public partial class ProveedorUI : Form
    {
        private Proveedor proveedor;
        public ProveedorUI()
        {
            InitializeComponent();
        }

        private void proveedorUI_Load(object sender, EventArgs e)
        {
            proveedor = new Proveedor();
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.deshabilitarControles(this);
            iniciarCombos();
            tsbNuevo.Enabled = true;
            tsbBuscar.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.habilitarControles(this);
            GeneralC.deshabilitarControles(pnlInformacion);
            desHabilitadoPermanentemente();
            GeneralC.limpiarControles(this);
            proveedor.codigo = null;
            tsbBuscarNit.Enabled = true;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.Modificar_FORM,Mensajes.NOMBRE_SOFT,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.habilitarControles(this);
                GeneralC.deshabilitarControles(pnlInformacion);
                validarFormaPago();
                desHabilitadoPermanentemente();
                tsbGuardar.Enabled = true;
                tsbCancelar.Enabled = true;
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.CANCELAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                proveedor.codigo = null;
                tsbNuevo.Enabled = true;
                tsbBuscar.Enabled = true;
                btnSalir.Enabled = true;
            }
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true) 
            {
                if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    try
                    {
                        crearNuevoproveedor();
                        ProveedorDAL.guardarproveedor(proveedor);
                        GeneralC.habilitarBotones(ref tstMenuPatron);
                        GeneralC.deshabilitarControles(this);
                        btnSalir.Enabled = true;
                        tsbGuardar.Enabled = false;
                        tsbCancelar.Enabled = false;
                        MessageBox.Show(Mensajes.CONFIRMACION_GUARDADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        
        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try {

                if(ProveedorDAL.anularproveedor(proveedor.codigo) == true) { 
                   GeneralC.deshabilitarBotones(ref tstMenuPatron);
                   GeneralC.limpiarControles(this);
                   GeneralC.deshabilitarControles(this);
                   btnSalir.Enabled = true;
                   tsbBuscar.Enabled = true;
                   tsbNuevo.Enabled = true;
                   MessageBox.Show(Mensajes.CONFIRMACION_ANULADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                 } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
           List<string> parametro = new List<string>();
           parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Query.BUSCAR_PROVEEDOR,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarproveedor),
                                    Titulos.TITULO_BUSCAR_PROVEEDOR,
                                    true, 
                                    listaParametroOculto());
        }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

} 
        private void tsbBuscarNit_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametro = new List<string>();
                parametro.Add(string.Empty);
                GeneralC.buscarDevuelveFila(Query.BUSCAR_TERCERO_PROVEEDOR,
                                          parametro,
                                          new GeneralC.cargarInfoFila(cargarTercero),
                                          Titulos.TITULO_BUSCAR_TERCERO,
                                          true);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void cbFormaPago_TextChanged(object sender, EventArgs e)
        {
            validarFormaPago();
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

        private void validarFormaPago() {
            if (cbFormaPago.SelectedIndex > 1)
            {
                GeneralC.habilitarControles(gbCuenta);        
            }
            else
            {
                GeneralC.deshabilitarControles(gbCuenta);
                GeneralC.limpiarControles(gbCuenta);
            }
        }

        private void cargarTercero(DataRow dRows) {
            proveedor.codigoTercero = dRows.Field<int>("codigo");
            txtNit.Text = dRows.Field<string>("Nit");
            txtRazonSocial.Text = dRows.Field<string>("RazonSocial");
            txtDireccion.Text = dRows.Field<string>("Direccion");
            txtTelefono.Text = dRows.Field<string>("Telefono");
            txtCelular.Text = dRows.Field<string>("Celular");
        }

        private void cargarproveedor(DataRow dRows) {
            try
            {
                proveedor.codigo = dRows.Field<int>("idproveedor").ToString();
                cbRegimen.SelectedValue = dRows.Field<int>("IdRegimen").ToString();
                cbFormaPago.SelectedValue = dRows.Field<int>("IdFormaPago").ToString();
                cbUbicacion.SelectedValue = dRows.Field<int>("idUbicacion").ToString();
                numEntrega.Value = dRows.Field<int>("Dia Entrega");
                numPlazo.Value = dRows.Field<int>("Dia Plazo");
                numDevolucion.Value = dRows.Field<int>("Dia Devolución");
                numVencimiento.Value = dRows.Field<int>("DiaVencimiento");
                txtCuentaPUC.Text = dRows.Field<string>("cuentaPuc");
                txtPUC.Text = dRows.Field<string>("NombrePuc");
                txtCuentaCIIU.Text = dRows.Field<string>("cuentaCIIU");
                txtCIIU.Text = dRows.Field<string>("NombreCIIU");
                cbBanco.SelectedValue = (dRows.Field<string>("IdBanco")== null ? ConstanteGeneral.PREDETERMINADA : dRows.Field<string>("IdBanco"));
                cbTipoCuenta.SelectedValue =(dRows.Field<string>("IdTipoCuenta") == null ? ConstanteGeneral.PREDETERMINADA : dRows.Field<string>("IdTipoCuenta"));
                txtIdentificacion.Text = dRows.Field<string>("Identificacion");
                txtCuenta.Text = dRows.Field<string>("Cuenta"); 
                cargarTercero(dRows);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,Mensajes.NOMBRE_SOFT,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }      
            GeneralC.posBuscar(this, tstMenuPatron, tsbNuevo, tstModificar, tsbBuscar, tsbAnular);
            btnSalir.Enabled = true;
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
        private void crearNuevoproveedor() {
            proveedor.codigoFormaPago =Convert.ToInt32(cbFormaPago.SelectedValue);
            proveedor.codigoRegimen = Convert.ToInt32(cbRegimen.SelectedValue);
            proveedor.codigoUbicacion = Convert.ToInt32(cbUbicacion.SelectedValue);
            proveedor.diaPlazo = Convert.ToInt32(numPlazo.Value);
            proveedor.diaEntrega = Convert.ToInt32(numEntrega.Value);
            proveedor.diaDevolucion = Convert.ToInt32(numDevolucion.Value);
            proveedor.diaVencimiento = Convert.ToInt32(numVencimiento.Value);
            proveedor.cuentaPuc = string.IsNullOrEmpty(txtCuentaPUC.Text) ? null : txtCuentaPUC.Text;
            proveedor.cuentaCIIU = string.IsNullOrEmpty(txtCuentaCIIU.Text) ? null : txtCuentaCIIU.Text;
            proveedor.codigoBanco = cbBanco.SelectedValue.ToString() == ConstanteGeneral.PREDETERMINADA ? null : cbBanco.SelectedValue.ToString();
            proveedor.codigoTipoCuenta = cbTipoCuenta.SelectedValue.ToString() == ConstanteGeneral.PREDETERMINADA ? null : cbTipoCuenta.SelectedValue.ToString();
            proveedor.identidicacion = string.IsNullOrEmpty(txtIdentificacion.Text) ? null : txtIdentificacion.Text;
            proveedor.cuenta = string.IsNullOrEmpty(txtCuenta.Text) ? null : txtCuenta.Text;
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
            parametro.Clear();
            parametro.Add(ConstanteGeneral.BANCO.ToString());
            cadena = GeneralC.obtenerParametros(parametro);
            GeneralC.llenarCombo(Query.PARAMETROS_CONSULTAR_DESCRIPCION + cadena, "Codigo", "Descripcion", cbBanco);
            GeneralC.llenarComboDatosDefinidor(proveedor.llenarComboFormaPago(),"Codigo", "Descripcion", cbFormaPago);
            GeneralC.llenarComboDatosDefinidor(proveedor.llenarComboUbicacion(),"Codigo", "Descripcion", cbUbicacion);
            GeneralC.llenarComboDatosDefinidor(proveedor.llenarComboTipoCuenta(), "Codigo", "Descripcion", cbTipoCuenta);
        }
        private List<string> listaParametroOculto() {
            List<string>paramtro= new List<string>();
            paramtro.Add("idproveedor");
            paramtro.Add("codigo");
            paramtro.Add("idRegimen");
			paramtro.Add("idFormaPago");
            paramtro.Add("idUbicacion");
            paramtro.Add("cuentaPuc");
            paramtro.Add("cuentaCIIU");
            paramtro.Add("NombrePuc");
            paramtro.Add("NombreCIIU");
            paramtro.Add("DiaVencimiento");
            paramtro.Add("IdTipoCuenta");
            paramtro.Add("IdBanco");
            paramtro.Add("Identificacion");
            paramtro.Add("Cuenta");
            return paramtro;
        }
    }
}
