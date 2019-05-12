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
          
            GeneralC.cargarFormularioEnPestana(tpInsumos, insumos);
            GeneralC.cargarFormularioEnPestana(tpNotas, notas);
            GeneralC.cargarFormularioEnPestana(tpParaclinicos, paraclinicos);
            GeneralC.cargarFormularioEnPestana(tpProcedimientos, procedimientos);
            GeneralC.cargarFormularioEnPestana(tpGlucometria, glucometrias);
            GeneralC.posCargadoForm(this, tstMenu, tsBtNuevo, tsBtBuscar);
            enfermeria.idInsumo = ConstanteGeneral.PREDETERMINADO;
            enfermeria.idNota = ConstanteGeneral.PREDETERMINADO;
        }

        private void opciones()
        {
            insumos.enfermeria.dtInsumos.Rows.Add();
            insumos.dgvInsumos.ReadOnly = false;
        }
        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenu, tsBtGuardar, tsBtCancelar);
            opciones();
            dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
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
                    buscarNotas();
                    break;
                case 2:

                    break;
                case 3:
                    buscarOrdenMedicaGeneral();
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
        public void buscarNotas()
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(enfermeria.Auditoria));
                parametros.Add(Convert.ToString(idAtencion));
                GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_NOTA_ENFERMERIA,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarNotas),
                                                   Mensajes.BUSCAR_ORDEN, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cargarNotas(DataRow resultados)
        {
            enfermeria.idNota = resultados.Field<int>("Código nota");
            enfermeria.cargarNotas();
            notas.txtNotas.Text = enfermeria.nota;
            dtpFecha.Value = enfermeria.fechaNota;
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
                    tsBtModificar.Enabled = true;
                    procedimientos.dgvProcedimientos.DataSource = enfermeria.dtProcedimientos;
                    txtCodigo.Text =Convert.ToString(resultados.Field<int>("Código orden"));
                    break;
                case 4:
                    enfermeria.cargarGlucometria();
                    tsBtModificar.Enabled = true;
                    glucometrias.dgvGlucometria.DataSource = enfermeria.dtGlucometria;
                    txtCodigo.Text = Convert.ToString(resultados.Field<int>("Código orden"));
                    habilitarCamposDatagridview();
                    break;
            }
           
        }

        public void cargarInsumos(DataRow resultados)
        {
            enfermeria.establecerDT();
            txtCodigo.Text =Convert.ToString(resultados.Field<int>("Código insumo"));
            enfermeria.idInsumo = resultados.Field<int>("Código insumo");
            enfermeria.cargarInsumos();
            dtpFecha.Value = enfermeria.fechaInsumo;
            insumos.dgvInsumos.DataSource = enfermeria.dtInsumos;
            insumos.enfermeria = enfermeria;
            tsBtModificar.Enabled = true;
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
            enfermeria.Auditoria = false;
            enfermeria.idAtencion = idAtencion;
            enfermeria.idInsumo = (txtCodigo.Text.Equals(string.Empty) ? ConstanteGeneral.PREDETERMINADO : Convert.ToInt32(txtCodigo.Text));
            enfermeria.fecha = Convert.ToDateTime(dtpFecha.Text);
        }
        public void guardarInsumos()
        {
            if (validarInsumos() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    obtenerDatos();
                    enfermeria.guardarInsumos();
                    GeneralC.posGuardar(this, tstMenu, tsBtNuevo, tsBtBuscar, tsBtModificar, tsBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);
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
        public void obtenerDatosNotas()
        {
            enfermeria.Auditoria = false;
            enfermeria.nota = notas.txtNotas.Text;
            enfermeria.idAtencion = idAtencion;
            enfermeria.fechaNota = dtpFecha.Value;
        }
        public void guardarNotas()
        {
            if (validarGlucometria() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    obtenerDatosNotas();
                    enfermeria.guardarNota();
                    GeneralC.posGuardar(this, tstMenu, tsBtNuevo, tsBtBuscar, tsBtModificar, tsBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    txtCodigo.Text = Convert.ToString(enfermeria.idNota);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        public void guardarGlucometria()
        {
            if (validarGlucometria() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    enfermeria.Auditoria = false;
                    enfermeria.guardarGlucometria();
                    GeneralC.posGuardar(this, tstMenu, tsBtNuevo, tsBtBuscar, tsBtModificar, tsBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);
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
                    guardarNotas();
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
                    tsBtNuevo.Visible = true;
                    if (enfermeria.insumoAprovado)
                    {
                        txtCodigo.Text = Convert.ToString(enfermeria.idInsumo);
                        dtpFecha.Value = enfermeria.fechaInsumo;
                    }else
                    {
                        txtCodigo.Clear();
                        enfermeria.idInsumo = ConstanteGeneral.PREDETERMINADO;
                    }
                    break;
                case 1:
                    tsBtNuevo.Visible = true;
                    if (enfermeria.notaAprobado)
                    {
                        txtCodigo.Text = Convert.ToString(enfermeria.idNota);
                        dtpFecha.Value = enfermeria.fechaNota;
                    }
                    else
                    {
                        txtCodigo.Clear();
                        enfermeria.idNota = ConstanteGeneral.PREDETERMINADO;
                    }
                    break;
                case 2:
                    tsBtNuevo.Visible = false;
                    tsBtAnular.Enabled = false;
                    break;
                case 3:
                    tsBtNuevo.Visible = false;
                    if (enfermeria.procedimientoAprobado)
                    {
                        txtCodigo.Text = Convert.ToString(enfermeria.idOrdenMedica);
                        tsBtModificar.Enabled = true;
                        tsBtAnular.Enabled = false;
                    }
                    else
                    {
                        txtCodigo.Clear();
                        tsBtAnular.Enabled = false;
                    }
                    break;
                case 4:
                    tsBtNuevo.Visible = false;
                    if (enfermeria.glucometriaAprobado)
                    {
                        txtCodigo.Text = Convert.ToString(enfermeria.idOrdenMedica);
                        tsBtModificar.Enabled = true;
                        tsBtAnular.Enabled = false;
                    }
                    else
                    {                 
                        txtCodigo.Clear();
                        tsBtAnular.Enabled = false;
                    }
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

        public void restablecerAprobados()
        {
            enfermeria.procedimientoAprobado = false;
            enfermeria.insumoAprovado = false;
            enfermeria.glucometriaAprobado = false;
            enfermeria.notaAprobado = false;
        }
        private void tsBtCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenu, tsBtNuevo, tsBtBuscar);
            enfermeria.idInsumo = ConstanteGeneral.PREDETERMINADO;
            enfermeria.idNota = ConstanteGeneral.PREDETERMINADO;
            txtCodigo.Clear();
            restablecerAprobados();
            dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
        }
    }
}
