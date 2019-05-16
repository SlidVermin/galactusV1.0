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
        private ResultadoLaboratorio resultadoLab;
        public ResultadoLaboratorioUI()
        {
            InitializeComponent();
        }

        private void ResultadoLaboratorioUI_Load(object sender, EventArgs e)
        {
            resultadoLab = new ResultadoLaboratorio();
            validarGrilla();
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.deshabilitarControles(this);
            tsbNuevo.Enabled = true;
            tsbBuscar.Enabled = true;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref tstMenuPatron);
            GeneralC.limpiarControles(this);
            habilitarControles();
            tsbBuscarNit.Enabled = true;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
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
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                tsbBuscar.Enabled = true;
                tsbNuevo.Enabled = true;
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

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            List<string> parametro = new List<string>();
            parametro.Add(string.Empty);
            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_RESULTADO_LAB,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarInformacion),
                                    Titulos.TITULO_BUSCAR_RESULTADO_LAB,
                                    true);
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (Mensajes.preguntaAnular() == true) {
                ResultadoLaboratorioDAL.anularResulatdoLab(resultadoLab.codigoResultado);
                GeneralC.limpiarControles(this);
                GeneralC.deshabilitarBotones(ref tstMenuPatron);
                GeneralC.deshabilitarControles(this);
                tsbNuevo.Enabled = true;
                tsbBuscar.Enabled = true;
            }
        }

        private void tstImprimir_Click(object sender, EventArgs e)
        {

        }
        private void tsbBuscarNit_Click(object sender, EventArgs e)
        {
            List<string> parametro = new List<string>();
            parametro.Add(string.Empty);
            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_PACIENTE_RESULTADO_LAB,
                                    parametro,
                                    new GeneralC.cargarInfoFila(cargarInformacionAtencion),
                                    Titulos.TITULO_BUSCAR_PACIENTE,
                                    true);
        }
        private void habilitarControles() {
            dtpMuestra.Enabled = true;
            dtpResultado.Enabled = true;
            dgvResultados.ReadOnly = false;
            dgvResultados.Columns[0].Visible = false;
            dgvResultados.Columns[1].ReadOnly = true;
            dgvResultados.Columns[2].ReadOnly = false;
            dgvResultados.Columns[3].ReadOnly = true;
        }

        private void validarGrilla() { 
            dgvResultados.Columns[0].DataPropertyName="Codigo";
            dgvResultados.Columns[1].DataPropertyName="Descripcion";
            dgvResultados.Columns[2].DataPropertyName="Resultado";
            dgvResultados.Columns[3].DataPropertyName="Referencia";
            dgvResultados.DataSource = resultadoLab.dtResultado;
        }
        private void cargarInformacionAtencion(DataRow dRows)
        {
            txtAtencion.Text = dRows.Field<int>("idAtencion").ToString();
            txtPaciente.Text = dRows.Field<string>("paciente").ToString();
            txtIdentificacion.Text = dRows.Field<string>("identificacion").ToString();
            txtServicio.Text = dRows.Field<string>("servicio").ToString();
            txtOrdenMedica.Text = dRows.Field<string>("ordenMedica").ToString();
            txtProcedimiento.Text = dRows.Field<string>("Descripcion").ToString();
            txtCodigoAdministradora.Text = dRows.Field<int>("codigoAdministracion").ToString();
            txtAdministradora.Text = dRows.Field<string>("administracion").ToString();
        }

        private void cargarInformacion(DataRow dRows) {

        }
    }
}
