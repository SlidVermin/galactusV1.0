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

                    if (InformeQuirurgicoDAL.anularInformeQuirurgico(informeQx.codigo))
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

            GeneralC.buscarDevuelveFila(Query.BUSCAR_INFORME_QX,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarHemodialisis),
                                    Titulos.TITULO_BUSCAR_INFORME_QX,
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
                informeQx.codigo = null;
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
                        crearNuevaInformeQx();
                        InformeQuirurgicoDAL.guardarInformeQuirurgico(informeQx);
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
            informeQx.codigo=null;
            dtFecha.Enabled = true;
            btnBuscarPaciente.Enabled = true;
            btGuardar.Enabled = true;
            btCancelar.Enabled = true;
        }

        private void btnBuscarNit_Click(object sender, EventArgs e)
        {
            List<string> parametro = new List<string>();
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Query.BUSCAR_PACIENTE_INFORME_QX,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarInformacionAtencion),
                                    Titulos.TITULO_BUSCAR_PACIENTE,
                                    true);
        }

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
            informeQx.fecha = dtFecha.Value;
        }
        private void cargarHemodialisis(DataRow dRows)
        {
            try
            {
                informeQx.codigo = dRows.Field<int>("idCliente").ToString();
                cargarInformacionAtencion(dRows);
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
            if (txtAtencion.Text == string.Empty)
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
        private void desHabilitadoPermanente() {

        }

    }
}
