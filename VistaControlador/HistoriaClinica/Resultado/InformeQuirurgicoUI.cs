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
    public partial class InformeQuirurgicoUI : Form
    {
        InformeQuirurgico informeQx;
        public InformeQuirurgicoUI()
        {
            InitializeComponent();
        }

        private void InformeQuirurgicoUI_Load(object sender, EventArgs e)
        {
            informeQx = new InformeQuirurgico();
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.deshabilitarControles(this);
            tsbBuscar.Enabled = true;
            tsbNuevo.Enabled = true;

        }

        private void tsbBuscarNit_Click(object sender, EventArgs e)
        {
            List<string> parametro = new List<string>();
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_PACIENTE_INFORME_QX,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarInformacionAtencion),
                                    Titulos.TITULO_BUSCAR_PACIENTE,
                                    true);
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.deshabilitarControles(pnlInformacion);
            GeneralC.habilitarControles(this);
            GeneralC.limpiarControles(this);

            informeQx.idInformeQX = ConstanteGeneral.PREDETERMINADO;
            tsbBuscarPaciente.Enabled = true;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
        }

        private void tstModificar_Click(object sender, EventArgs e)
        {
            if (Mensajes.preguntaSiNo(Mensajes.Modificar_FORM) == true)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.habilitarControles(this);
                GeneralC.deshabilitarControles(pnlInformacion);
                dtFecha.Enabled = true;
                tsbGuardar.Enabled = true;
                tsbCancelar.Enabled = true;
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (Mensajes.preguntaSiNo(Mensajes.CANCELAR_FORM) == true)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);

                informeQx.idInformeQX = ConstanteGeneral.PREDETERMINADO;
                tsbNuevo.Enabled = true;
                tsbBuscar.Enabled = true;
                btnSalir.Enabled = true;

            }
        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                if (Mensajes.preguntaGuardar())
                    try
                    {
                        crearNuevaInformeQx();

                        InformeQuirurgicoDAL.guardarInformeQuirurgico(informeQx);

                        GeneralC.habilitarBotones(ref tstMenuPatron);
                        GeneralC.deshabilitarControles(this);

                        btnSalir.Enabled = true;
                        tsbGuardar.Enabled = false;
                        tsbCancelar.Enabled = false;

                        Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_GUARDADO);

                    }
                    catch (Exception ex)
                    {
                        Mensajes.mensajeError(ex);
                    }
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            List<string> parametro = new List<string>();
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_INFORME_QX,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarInformeQX),
                                    Titulos.TITULO_BUSCAR_INFORME_QX,
                                    true,
                                    listaParametroOculto());
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (Mensajes.preguntaAnular())
            {
                try
                {

                    if (InformeQuirurgicoDAL.anularInformeQuirurgico(informeQx.idInformeQX) == true)
                    {
                        GeneralC.deshabilitarBotones(ref tstMenuPatron);
                        GeneralC.limpiarControles(this);
                        GeneralC.deshabilitarControles(this);

                        btnSalir.Enabled = true;
                        tsbBuscar.Enabled = true;
                        tsbNuevo.Enabled = true;

                        Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_ANULADO);
                    }

                }
                catch (Exception ex)
                {
                    Mensajes.mensajeError(ex);
                }
            }
        }

        private void tsbBuscarVia_Click(object sender, EventArgs e)
        {

        }

        private void tsbBuscarAyudante_Click(object sender, EventArgs e)
        {

        }

        private void tsbBuscarAnastesiologo_Click(object sender, EventArgs e)
        {

        }

        private void tsbBuscarAnastesia_Click(object sender, EventArgs e)
        {

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

        private void cargarInformacionAtencion(DataRow dRows) {
            txtAtencion.Text = dRows.Field<int>("idAtencion").ToString();
            txtPaciente.Text = dRows.Field<string>("paciente").ToString();
            txtIdentificacion.Text = dRows.Field<string>("identificacion").ToString();
            txtServicio.Text = dRows.Field<string>("servicio").ToString();
            txtOrdenMedica.Text = dRows.Field<string>("ordenMedica").ToString();
            txtCodigoAdministradora.Text = dRows.Field<int>("codigoAdministracion").ToString();
            txtAdministradora.Text = dRows.Field<string>("administracion").ToString();
        }

        private void crearNuevaInformeQx() {
            informeQx.notaQuirurgica = txtNota.Text;
            informeQx.fechaInicio = dtpFechaInicio.Value;
            informeQx.fechaFin = dtpFechaInicio.Value;
        }
        private void cargarInformeQX(DataRow dRows)
        {
            try
            {
                informeQx.idInformeQX = dRows.Field<int>("idInformeQX");
                informeQx.idVia = dRows.Field<int>("idVia");
                informeQx.idAnastesia = dRows.Field<int>("idAnastesia");
                informeQx.idAnastesiologo = dRows.Field<int>("idAnastesiologo");
                informeQx.idAyudante = dRows.Field<int>("idAyudante");
                informeQx.fechaInicio = dRows.Field<DateTime>("FechaInicio");
                informeQx.fechaFin = dRows.Field<DateTime>("FechaFin");
                informeQx.notaQuirurgica = dRows.Field<string>("Nota");

                cargarInformacionAtencion(dRows);
                GeneralC.posBuscar(this, tstMenuPatron, tsbNuevo, tstModificar, tsbBuscar, tsbAnular);
                btnSalir.Enabled = true;

            }
            catch (Exception ex)
            {
               Mensajes.mensajeError(ex);
            }        
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
            if (txtAtencion.Text == string.Empty)
            {
                Mensajes.mensajeAdvertencia("¡ Favor seleccionar el paciente !");
                return false;
            }
            else if (txtNota.Text == string.Empty)
            {
                Mensajes.mensajeAdvertencia("¡ Favor realice la nota correspondiente al resultado !");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
