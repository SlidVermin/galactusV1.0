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
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.deshabilitarControles(this);
            tsbBuscar.Enabled = true;
            tsbNuevo.Enabled = true;
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

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    if (HemodialisisDAL.anularHemodialisis(hemodialisis.codigo))
                    {
                        GeneralC.deshabilitarBotones(ref tstMenuPatron);
                        GeneralC.limpiarControles(this);
                        GeneralC.deshabilitarControles(this);
                        btnSalir.Enabled = true;
                        tsbBuscar.Enabled = true;
                        tsbNuevo.Enabled = true;
                        MessageBox.Show(Mensajes.CONFIRMACION_ANULADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            List<string> parametro = new List<string>();
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_HEMODIALISIS,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarHemodialisis),
                                    Titulos.TITULO_BUSCAR_HEMODIALISIS,
                                    true,
                                    listaParametroOculto());
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.CANCELAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                hemodialisis.codigo = null;
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
                        crearNuevaHemodialisis();
                        HemodialisisDAL.guardarHemodialisis(hemodialisis);
                        GeneralC.habilitarBotones(ref tstMenuPatron);
                        GeneralC.deshabilitarControles(this);
                        btnSalir.Enabled = true;
                        tsbGuardar.Enabled = false;
                        tsbCancelar.Enabled = false;
                        MessageBox.Show(Mensajes.CONFIRMACION_GUARDADO, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.Modificar_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.habilitarControles(this);
                GeneralC.deshabilitarControles(pnlInformacion);
                dtFecha.Enabled = true;
                tsbGuardar.Enabled = true;
                tsbCancelar.Enabled = true;
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.habilitarControles(this);
            GeneralC.deshabilitarControles(pnlInformacion);
            GeneralC.limpiarControles(this);
            hemodialisis.codigo=null;
            dtFecha.Enabled = true;
            tsbBuscarNit.Enabled = true;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
        }

        private void tsbBuscarNit_Click(object sender, EventArgs e)
        {
            List<string> parametro = new List<string>();
            parametro.Add(string.Empty);

            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_PACIENTE_HEMODIALISIS,
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
            txtCodigoAdministradora.Text= dRows.Field<int>("codigoAdministracion").ToString();
            txtAdministradora.Text= dRows.Field<string>("administracion").ToString();
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
                hemodialisis.codigo = dRows.Field<int>("idHemodialisis").ToString();
                dtFecha.Value = dRows.Field<DateTime>("fecha");
                txtNota.Text = dRows.Field<string>("Nota").ToString();
                txtNotaSigno.Text = dRows.Field<string>("notaSigno").ToString();
               cargarInformacionAtencion(dRows);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GeneralC.posBuscar(this, tstMenuPatron, tsbNuevo, tstModificar, tsbBuscar, tsbAnular);
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

    }
}
