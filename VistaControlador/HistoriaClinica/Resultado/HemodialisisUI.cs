using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Entidades.HistoriaClinica.Resultado;
using Galactus.Util;
using Galactus.Util.Mensajes;
using Galactus.Util.Constantes;
using Galactus.Modelo.HistoriaClinica.Resultado;


namespace Galactus.VistaControlador.HistoriaClinica.Resultado
{
    public partial class HemodialisisUI : Form
    {
        Hemodialisis hemodialisis;
        public HemodialisisUI()
        {
            InitializeComponent();
        }

        private void HemodialisisUI_Load(object sender, EventArgs e)
        {
            hemodialisis = new Hemodialisis();
            GeneralC.deshabilitarBotones(ref TostMenu);
            GeneralC.deshabilitarControles(this);
            btBuscar.Enabled = true;
            btNuevo.Enabled = true;

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

        private void btAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    if (HemodialisisDAL.anularHemodialisis(hemodialisis.codigo))
                    {
                        GeneralC.deshabilitarBotones(ref TostMenu);
                        GeneralC.limpiarControles(this);
                        GeneralC.deshabilitarControles(this);
                        btnSalir.Enabled = true;
                        btBuscar.Enabled = true;
                        btNuevo.Enabled = true;
                        MessageBox.Show(Mensajes.CONFIRMACION_ANULADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            List<string> parametro = new List<string>();
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Query.BUSCAR_CLIENTE,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarHemodialisis),
                                    Titulos.TITULO_BUSCAR_CLIENTE,
                                    true,
                                    listaParametroOculto());
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.CANCELAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref TostMenu);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                hemodialisis.codigo = null;
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
                        crearNuevaHemodialisis();
                        HemodialisisDAL.guardarHemodialisis(hemodialisis);
                        GeneralC.habilitarBotones(ref TostMenu);
                        GeneralC.deshabilitarControles(this);
                        btnSalir.Enabled = true;
                        btGuardar.Enabled = false;
                        btCancelar.Enabled = false;
                        MessageBox.Show(Mensajes.CONFIRMACION_GUARDADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.EDITAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref TostMenu);
                GeneralC.habilitarControles(this);
                GeneralC.deshabilitarControles(pnlInformacion);
                dtFecha.Enabled = true;
                btGuardar.Enabled = true;
                btCancelar.Enabled = true;
            }
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref TostMenu);
            GeneralC.habilitarControles(this);
            GeneralC.deshabilitarControles(pnlInformacion);
            GeneralC.limpiarControles(this);
            hemodialisis.codigo=null;
            dtFecha.Enabled = true;
            btnBuscarNit.Enabled = true;
            btGuardar.Enabled = true;
            btCancelar.Enabled = true;
        }

        private void btnBuscarNit_Click(object sender, EventArgs e)
        {
            List<string> parametro = new List<string>();
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Query.BUSCAR_CLIENTE,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarInformacionAtencion),
                                    Titulos.TITULO_BUSCAR_CLIENTE,
                                    true);
        }

        private void cargarInformacionAtencion(DataRow dRows) {

        }

        private void crearNuevaHemodialisis() {
            hemodialisis.nota = txtNota.Text;
            hemodialisis.fecha = dtFecha.Value;
            hemodialisis.notaSigno = string.IsNullOrEmpty(txtNotaSigno.Text) ? null : txtNotaSigno.Text;
        }
        private void cargarHemodialisis(DataRow dRows)
        {
            try
            {
                //cliente.codigo = dRows.Field<int>("idCliente").ToString();
                //cbRegimen.SelectedValue = dRows.Field<int>("IdRegimen").ToString();
                //cbFormaPago.SelectedValue = dRows.Field<int>("IdFormaPago").ToString();
                //cbUbicacion.SelectedValue = dRows.Field<int>("idUbicacion").ToString();
                //numEntrega.Value = dRows.Field<int>("Dia Entrega");
                //numPlazo.Value = dRows.Field<int>("Dia Plazo");
                //numDevolucion.Value = dRows.Field<int>("Dia Devolución");
                //txtCuentaPUC.Text = dRows.Field<string>("cuentaPuc");
                //txtPUC.Text = dRows.Field<string>("NombrePuc");
                //txtCuentaCIIU.Text = dRows.Field<string>("cuentaCIIU");
                //txtCIIU.Text = dRows.Field<string>("NombreCIIU");
                //cargarTercero(dRows);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GeneralC.posBuscar(this, TostMenu, btNuevo, btEditar, btBuscar, btAnular);
            btnSalir.Enabled = true;
        }
        private List<string> listaParametroOculto()
        {
            List<string> paramtro = new List<string>();
            //paramtro.Add("idCliente");
            //paramtro.Add("codigo");
            //paramtro.Add("idRegimen");
            //paramtro.Add("idFormaPago");
            //paramtro.Add("idUbicacion");
            //paramtro.Add("cuentaPuc");
            //paramtro.Add("cuentaCIIU");
            //paramtro.Add("NombrePuc");
            //paramtro.Add("NombreCIIU");
            return paramtro;
        }
        private Boolean validarCampos()
        {
            if (txtRegistro.Text == string.Empty)
            {
                MessageBox.Show("¡ Favor seleccionar el paciente !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNota.Text == string.Empty)
            {
                MessageBox.Show("¡ Favor realice la nota correspondiente al resultado !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
