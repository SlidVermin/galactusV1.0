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
using Galactus.Modelo.HistoriaClinica.Resultado;
using Galactus.Util.Mensajes;
using Galactus.Util;

namespace Galactus.VistaControlador.HistoriaClinica.Resultado
{
    public partial class ResultadoLaboratorioUI : Form
    {
        private ResultadoLaboratorio resultadoLab = new ResultadoLaboratorio();
        private int idProcedimiento;

        public ResultadoLaboratorioUI(int idSolicitud,int idProcedimiento, int auditoria)
        {
            InitializeComponent();
            resultadoLab.codigoSolicitud = idSolicitud;
            this.idProcedimiento = idProcedimiento;
            resultadoLab.auditoria = auditoria;
        }
        private void tstModificar_Click(object sender, EventArgs e)
        {
            if (Mensajes.preguntaSiNo(Mensajes.Modificar_FORM)== true) {
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                habilitarControles();
                tsbGuardar.Enabled = true;
                tsbCancelar.Enabled = true;
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (Mensajes.preguntaSiNo(Mensajes.CANCELAR_FORM) == true) {
                cargarInformacionADatos();
            }
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (dtpMuestra.Value.Date == dtpResultado.Value.Date)
            {
                Mensajes.mensajeAdvertencia("La fecha de muestra, no puede ser igual a la fecha de resultado");
            }
            else
            {
                if (Mensajes.preguntaGuardar() == true)
                {
                    ResultadoLaboratorioDAL.guardarResultadoLab(resultadoLab);
                    GeneralC.habilitarBotones(ref tstMenuPatron);
                    GeneralC.deshabilitarControles(this);
                    tsbGuardar.Enabled = false;
                    Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_GUARDADO);
                }
            }
        }
        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (Mensajes.preguntaAnular() == true) {
                ResultadoLaboratorioDAL.anularResulatdoLab(resultadoLab.codigoResultado);

            }
        }

        private void tstImprimir_Click(object sender, EventArgs e)
        {

        }
        private void habilitarControles() {
            dtpMuestra.Enabled = true;
            dtpResultado.Enabled = true;
            dgvResultados.ReadOnly = false;
            txtObservacion.ReadOnly = false;
            dgvResultados.Columns[2].ReadOnly = true;
            dgvResultados.Columns[3].ReadOnly = false;
            dgvResultados.Columns[4].ReadOnly = true;
        }

        private void validarGrilla() { 
            dgvResultados.Columns["dgCodigo"].DataPropertyName="Codigo";
            dgvResultados.Columns["dgParametro"].DataPropertyName = "Parametro";
            dgvResultados.Columns["dgDescripcion"].DataPropertyName="Descripcion";
            dgvResultados.Columns["dgResultado"].DataPropertyName="Resultado";
            dgvResultados.Columns["dgReferencia"].DataPropertyName="Referencia";
            dgvResultados.DataSource = resultadoLab.dtResultado;
            dgvResultados.AutoGenerateColumns = false;
        }
        public void cargarInformacionADatos()
        {
            List<string> paramtro = new List<string>();
            DataRow dRows;
            DataTable dtDatos = new DataTable();
            paramtro.Add(resultadoLab.auditoria.ToString());
            paramtro.Add(resultadoLab.codigoSolicitud.ToString());
            paramtro.Add(idProcedimiento.ToString());
            GeneralC.llenarTabla(Sentencias.BUSCAR_PACIENTE_RESULTADO_LAB, paramtro, dtDatos);
            dRows = dtDatos.Rows[0];

            txtAtencion.Text = dRows.Field<int>("idAtencion").ToString();
            txtPaciente.Text = dRows.Field<string>("paciente").ToString();
            txtIdentificacion.Text = dRows.Field<string>("Documento").ToString();
            txtServicio.Text = dRows.Field<string>("Entorno").ToString();
            txtOrdenMedica.Text = dRows.Field<int>("IdOrdenMedica").ToString();
            txtProcedimiento.Text = dRows.Field<string>("procedimiento").ToString();
            txtCodigoAdministradora.Text = dRows.Field<int>("IdContrato").ToString();
            txtAdministradora.Text = dRows.Field<string>("Nombre").ToString();
            resultadoLab.codigoGenero = dRows.Field<int>("IdGenero");
            resultadoLab.estadoRegistro = dRows.Field<bool>("EstadoRegistro");
            lbTitulo.Text = dRows.Field<string>("nombreExamen").ToString();
            validarGrilla();
            cargarParametrosLaboratorio();

            GeneralC.deshabilitarControles(this);
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            btnSalir.Enabled = true;

            if (resultadoLab.estadoRegistro == true) {
                tstModificar.Enabled = true;
                tstImprimir.Enabled = true;
                tsbAnular.Enabled = true;               
            }
            else
            {
                habilitarControles();
                tsbGuardar.Enabled = true;
                tsbCancelar.Enabled = true;
            }         
        }
        private void cargarParametrosLaboratorio() {
            List<string> paramtro = new List<string>();
            paramtro.Add(resultadoLab.auditoria.ToString());
            paramtro.Add(resultadoLab.codigoSolicitud.ToString()); 
            paramtro.Add(resultadoLab.codigoGenero.ToString());
            paramtro.Add(idProcedimiento.ToString());
            GeneralC.llenarTabla(Sentencias.CARGAR_RESULTADO_LAB, paramtro, resultadoLab.dtResultado);
            dgvResultados.DataSource = resultadoLab.dtResultado;
        }
        #region btnSalir      
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

    }
}
