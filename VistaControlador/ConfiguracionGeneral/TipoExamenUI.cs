using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Entidades.ConfiguracionGeneral;
using Galactus.Util.Mensajes;
using Galactus.Util.Constantes;
using Galactus.Util;
using Galactus.Modelo.ConfiguracionGeneral;

namespace Galactus.VistaControlador.ConfiguracionGeneral
{
    public partial class TipoExamenUI : Form
    {
        TipoExamen tipoExamen = new TipoExamen();
        public TipoExamenUI()
        {
            InitializeComponent();
        }

        private void TipoExamenUI_Load(object sender, EventArgs e)
        {
            GeneralC.deshabilitarControles(this);
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.llenarComboDatosDefinidor(tipoExamen.llenarComboTipoArchivo(), "Codigo", "Descripcion", cmbTipo);
            tsbNuevo.Enabled = true;
            tsbBuscar.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.habilitarControles(this);
            GeneralC.limpiarControles(this);
            txtCodigo.ReadOnly = true;
            tipoExamen.idTipoExamen = ConstanteGeneral.PREDETERMINADO;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
        }

        private void tstModificar_Click(object sender, EventArgs e)
        {
            if (Mensajes.preguntaSiNo(Mensajes.Modificar_FORM) == true) {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.habilitarControles(this);
                txtCodigo.ReadOnly = true;
                tsbGuardar.Enabled = true;
                tsbCancelar.Enabled = true;
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (Mensajes.preguntaSiNo(Mensajes.CANCELAR_FORM) == true) {
                GeneralC.deshabilitarControles(this);
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.limpiarControles(this);
                tsbNuevo.Enabled = true;
                tsbBuscar.Enabled = true;
                btnSalir.Enabled = true;
            }
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos() == true)
                {
                    if (Mensajes.preguntaGuardar())
                    {
                        objetoTipoExamenCrear();
                        TipoExamenDAL.guardarTipoExamen(tipoExamen);
                        txtCodigo.Text = tipoExamen.idTipoExamen.ToString();
                        GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tstModificar, tsbBuscar, tsbAnular);
                        btnSalir.Enabled = true;
                        Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_GUARDADO);
                    }
                }
            }
            catch (Exception ex) {
                Mensajes.mensajeError(ex);
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            List<string> parametro = new List<string>();
            parametro.Add(string.Empty);
            try
            {
                GeneralC.buscarDevuelveFila(Sentencias.TIPO_EXAMEN_BUSCAR,
                                        parametro,
                                        new GeneralC.cargarInfoFila(cargarRegistro),
                                        Titulos.TITULO_BUSCAR_TIPO_LABORATORIO,
                                        true,
                                        listaParametroOculto());
            }
            catch (Exception ex) {
                Mensajes.mensajeError(ex);
            }
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mensajes.preguntaAnular() == true) { 
                    TipoExamenDAL.anularTipoExamen(Convert.ToInt32(txtCodigo.Text));
                    GeneralC.deshabilitarBotones(ref tstMenuPatron);
                    GeneralC.deshabilitarControles(this);
                    GeneralC.limpiarControles(this);
                    tsbNuevo.Enabled = true;
                    tsbBuscar.Enabled = true;
                    btnSalir.Enabled = true;
                    Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_ANULADO);
            }
            }
            catch (Exception ex) {
                Mensajes.mensajeError(ex);
            }
        }
        #region btnSalir

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightCoral;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Control.DefaultBackColor;
        }
        #endregion
        private bool validarDatos() {
            if (txtDescripcion.Text == string.Empty)
            {
                Mensajes.mensajeAdvertencia("Favor digitar el tipo de examen");
            }
            else if (cmbTipo.SelectedIndex == 0)
            {
                Mensajes.mensajeAdvertencia("Favor seleccionar el tipo");
            }
            else {
             return true;
            }

            return false;
        }

        private void cargarRegistro(DataRow dRows) {
            txtCodigo.Text = dRows.Field<int>("Codigo").ToString();
            tipoExamen.idTipoExamen= dRows.Field<int>("Codigo");
            txtDescripcion.Text = dRows.Field<string>("Nombre");
            rbAgrupable.Checked = dRows.Field<bool>("Agrupado");
            cmbTipo.SelectedValue = dRows.Field<int>("TipoArchivo");
            GeneralC.posBuscar(this, tstMenuPatron, tsbNuevo, tstModificar, tsbBuscar, tsbAnular);
        }

        private List<string> listaParametroOculto() {
            List<string> paramtro = new List<string>();
            paramtro.Add("TipoArchivo");
            paramtro.Add("Agrupado");                
            return paramtro;
        }
        private void objetoTipoExamenCrear() {
            tipoExamen.descripcion = txtDescripcion.Text;
            tipoExamen.ckAgrupable = rbAgrupable.Checked;
            tipoExamen.tipo = Convert.ToInt32(cmbTipo.SelectedValue);
        }
    }
}
