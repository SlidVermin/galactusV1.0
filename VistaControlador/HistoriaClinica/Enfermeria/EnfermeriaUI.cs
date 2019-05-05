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
using Galactus.Entidades.HistoriaClinica.Enfermeria;
using Galactus.Util.Constantes;

namespace Galactus.VistaControlador.HistoriaClinica.Enfermeria
{
    public partial class EnfermeriaUI : Form
    {
        private int idAtencion;
        private EnfermeriaClinica enfermeria = new EnfermeriaClinica();
        InsumosUI insumos = new InsumosUI();
        NotasUI notas = new NotasUI();
        ParaclinicosUI paraclinicos = new ParaclinicosUI();
        ProcedimientosUI procedimientos = new ProcedimientosUI();
        GlucometriasUI glucometrias = new GlucometriasUI();
        public EnfermeriaUI()
        {
            InitializeComponent();
        }
        public EnfermeriaUI(int idAtencion)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
        }
        private void EnfermeriaUI_Load(object sender, EventArgs e)
        {
            fecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
            GeneralC.cargarFormularioEnPestana(tpInsumos, insumos);
            GeneralC.cargarFormularioEnPestana(tpNotas, notas);
            GeneralC.cargarFormularioEnPestana(tpParaclinicos, paraclinicos);
            GeneralC.cargarFormularioEnPestana(tpProcedimientos, procedimientos);
            GeneralC.cargarFormularioEnPestana(tpGlucometria, glucometrias);
        }

        private void opciones()
        {
            insumos.enfermeria.dtInsumos.Rows.Add();
            insumos.dgvInsumos.ReadOnly = false;
        }
        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenuEvolucion, tsBtGuardar, tsBtCancelar);
            opciones();
            fecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
            enfermeria.idInsumo = ConstanteGeneral.PREDETERMINADO;
        }

        private void tsBtBuscar_Click(object sender, EventArgs e)
        {
            switch (tcEnfermeria.SelectedIndex)
            {
                case 0:
                    buscarInsumos();
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:
                    buscarOrdenMedica();
                    break;
                case 4:
                    buscarOrdenMedica();
                    break;
            }         
        }
        public void buscarOrdenMedica()
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(idAtencion));
                parametros.Add(ConstanteGeneral.CODIGO_PROCEDIMIENTO_GLUCOMETRIA);
                parametros.Add(ConstanteGeneral.CODIGO_PROCEDIMIENTO_GLUCOMETRIA_2);
                GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_ORDEN_MEDICA_ENFERMERIA,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarDatos),
                                                   Mensajes.BUSCAR_ORDEN, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void buscarInsumos()
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(idAtencion));
                GeneralC.buscarDevuelveFila(Sentencias.ENFERMERIA_INSUMOS_BUSCAR,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarInsumos),
                                                   Mensajes.BUSCAR_ORDEN, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void buscarOrdenMedicaGeneral()
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(idAtencion));
                GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_ORDEN_MEDICA_GENERAL,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarDatos),
                                                   Mensajes.BUSCAR_ORDEN, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void habilitarCamposDatagridview()
        {
            glucometrias.dgvGlucometria.ReadOnly = false;
        }
        public void cargarDatos(DataRow resultados)
        {
            enfermeria.idOrdenMedica = resultados.Field<int>("Código orden");
            switch (tcEnfermeria.SelectedIndex)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:
                    enfermeria.fechaProcedimiento = resultados.Field<DateTime>("Fecha orden");
                    enfermeria.cargarProcedimientos();
                    procedimientos.dgvProcedimientos.DataSource = enfermeria.dtProcedimientos;
                    break;
                case 4:
                    enfermeria.cargarGlucometria();
                    glucometrias.dgvGlucometria.DataSource = enfermeria.dtGlucometria;
                    habilitarCamposDatagridview();
                    break;
            }
           
        }

        public void cargarInsumos(DataRow resultados)
        {
            enfermeria.establecerDT();
            txtcodigoOrdenMedica.Text =Convert.ToString(resultados.Field<int>("Código insumo"));
            enfermeria.idInsumo = resultados.Field<int>("Código insumo");
            enfermeria.cargarInsumos();
            insumos.dgvInsumos.DataSource = enfermeria.dtInsumos;
            insumos.enfermeria = enfermeria;
        }
        public bool validarInsumos()
        {
            enfermeria = insumos.enfermeria;
           
            if (enfermeria.dtInsumos.Select("cantidad = 0").Count() > 1)
            {
                MessageBox.Show("por favor digite una cantidad valida", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

                return true;
        }

        public void obtenerDatos()
        {
            enfermeria.idAtencion = idAtencion;
            enfermeria.idInsumo = (txtcodigoOrdenMedica.Text.Equals(string.Empty) ? ConstanteGeneral.PREDETERMINADO : Convert.ToInt32(txtcodigoOrdenMedica.Text));
            enfermeria.fecha = Convert.ToDateTime(fecha.Text);
        }
        public void guardarInsumos()
        {
            if (validarInsumos() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    obtenerDatos();
                    enfermeria.guardarInsumos();
                    GeneralC.posGuardar(this, tstMenuEvolucion, tsBtNuevo, tsBtBuscar, tsBtModificar, tsBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void cargarGlucometriaGuardar()
        {
            enfermeria.cargarGlucometria();
            glucometrias.dgvGlucometria.DataSource = enfermeria.dtGlucometria;
        }
        public bool validarGlucometria()
        {
            return true;
        }
        public void guardarGlucometria()
        {
            if (validarGlucometria() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    enfermeria.guardarGlucometria();
                    GeneralC.posGuardar(this, tstMenuEvolucion, tsBtNuevo, tsBtBuscar, tsBtModificar, tsBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    cargarGlucometriaGuardar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tsBtGuardar_Click(object sender, EventArgs e)
        {
            switch (tcEnfermeria.SelectedIndex)
            {
                case 0:
                    guardarInsumos();
                    break;
                case 1:
                   
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:
                    guardarGlucometria();
                    break;
            }
        }

        private void tcEnfermeria_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcEnfermeria.SelectedIndex)
            {
                case 0:
                    txtcodigoOrdenMedica.Text = Convert.ToString(enfermeria.idInsumo);
                    tsBtNuevo.Visible = true;
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:
                    fecha.Text = Convert.ToString(enfermeria.fechaProcedimiento);
                    tsBtNuevo.Visible = false;
                    break;
                case 4:
                    txtcodigoOrdenMedica.Text = Convert.ToString(enfermeria.idOrdenMedica);
                    tsBtNuevo.Visible = false;
                    break;
            }
        }

        private void tsBtModificar_Click(object sender, EventArgs e)
        {
            GeneralC.habilitarControles(this);
            tsBtGuardar.Enabled = true;
            tsBtModificar.Enabled = false;
            tsBtAnular.Enabled = false;
            tsBtNuevo.Enabled = false;
            tsBtBuscar.Enabled = false;
            tsBtCancelar.Enabled = true;
            opciones();
        }

        private void tsBtCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenuEvolucion, tsBtNuevo, tsBtBuscar);
            enfermeria.idInsumo = ConstanteGeneral.PREDETERMINADO;
            fecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
        }
    }
}
