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
using Galactus.Entidades.HistoriaClinica.Enfermeria;
using Galactus.Util.Constantes;

namespace Galactus.VistaControlador.HistoriaClinica.Enfermeria
{
    public partial class EnfermeriaUI : Form
    {
        private int idAtencion;
        private bool auditoria;
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
        public EnfermeriaUI(int idAtencion, bool auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            this.auditoria = auditoria;
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
            switch (tcEnfermeria.SelectedIndex)
            {
                case 0:
                    nuevo();               
                    enfermeria.idInsumo = ConstanteGeneral.PREDETERMINADO;
                    GeneralC.formNuevo(tpInsumos, tstMenu, tsBtGuardar, tsBtCancelar);
                    opciones();
                    break;
                case 1:
                    nuevo();
                    enfermeria.idNota = ConstanteGeneral.PREDETERMINADO;
                    GeneralC.formNuevo(tpNotas, tstMenu, tsBtGuardar, tsBtCancelar);
                    break;
            }
        }
        public void nuevo()
        {
        
            dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
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
                parametros.Add(Convert.ToString(ConstanteGeneral.ENFERMERIA_INSUMOS));
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
                parametros.Add(Convert.ToString(ConstanteGeneral.ENFERMERIA_INSUMOS));
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
            enfermeria.tipo = ConstanteGeneral.ENFERMERIA_INSUMOS;
            enfermeria.cargarNotas();
            notas.txtNotas.Text = enfermeria.nota;
            dtpFecha.Value = enfermeria.fechaNota;
            botonesGuardar();
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
            enfermeria.tipo = ConstanteGeneral.ENFERMERIA_INSUMOS;
            enfermeria.cargarInsumos();
            dtpFecha.Value = enfermeria.fechaInsumo;
            insumos.dgvInsumos.DataSource = enfermeria.dtInsumos;
            insumos.enfermeria = enfermeria;
            botonesGuardar();
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
            enfermeria.tipo = ConstanteGeneral.ENFERMERIA_INSUMOS;
            enfermeria.Auditoria = auditoria;
            enfermeria.idAtencion = idAtencion;
            enfermeria.idInsumo = (txtCodigo.Text.Equals(string.Empty) ? ConstanteGeneral.PREDETERMINADO : Convert.ToInt32(txtCodigo.Text));
            enfermeria.fecha = Convert.ToDateTime(dtpFecha.Text);
        }
        public void botonesGuardar()
        {
            tsBtModificar.Enabled = true;
            tsBtAnular.Enabled = true;
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
                    enfermeria.insumoAprovado = true;
                    botonesGuardar();
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
            enfermeria.tipo = ConstanteGeneral.ENFERMERIA_INSUMOS;
            enfermeria.Auditoria = auditoria;
            enfermeria.nota = notas.txtNotas.Text;
            enfermeria.idAtencion = idAtencion;
            enfermeria.fechaNota = dtpFecha.Value;
        }
        public void guardarNotas()
        {
            if ( MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    obtenerDatosNotas();
                    enfermeria.guardarNota();
                    GeneralC.posGuardar(this, tstMenu, tsBtNuevo, tsBtBuscar, tsBtModificar, tsBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    txtCodigo.Text = Convert.ToString(enfermeria.idNota);
                    enfermeria.notaAprobado = true;
                    botonesGuardar();
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
                    enfermeria.Auditoria = auditoria;
                    enfermeria.guardarGlucometria();
                    GeneralC.posGuardar(this, tstMenu, tsBtNuevo, tsBtBuscar, tsBtModificar, tsBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    cargarGlucometriaGuardar();
                    enfermeria.glucometriaAprobado = true;
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
                        botonesGuardar();
                    }
                    else
                    {
                        txtCodigo.Clear();
                        enfermeria.idInsumo = ConstanteGeneral.PREDETERMINADO;
                        tsBtModificar.Enabled = false;
                        tsBtAnular.Enabled = false;
                    }
                    break;
                case 1:
                    tsBtNuevo.Visible = true;
                    if (enfermeria.notaAprobado)
                    {
                        txtCodigo.Text = Convert.ToString(enfermeria.idNota);
                        dtpFecha.Value = enfermeria.fechaNota;
                        botonesGuardar();
                    }
                    else
                    {
                        txtCodigo.Clear();
                        enfermeria.idNota = ConstanteGeneral.PREDETERMINADO;
                        tsBtModificar.Enabled = false;
                        tsBtAnular.Enabled = false;
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
                        tsBtModificar.Enabled = false;
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
                        tsBtModificar.Enabled = false;
                        tsBtAnular.Enabled = false;
                    }
                    break;
            }
        }
        public void botonesEditar()
        {
            GeneralC.habilitarControlesTabPage(tpInsumos);
            tsBtGuardar.Enabled = true;
            tsBtModificar.Enabled = false;
            tsBtAnular.Enabled = false;
            tsBtNuevo.Enabled = false;
            tsBtBuscar.Enabled = false;
            tsBtCancelar.Enabled = true;
        }
        private void tsBtModificar_Click(object sender, EventArgs e)
        {
            switch (tcEnfermeria.SelectedIndex)
            {
                case 0:
                    botonesEditar();
                    opciones();
                    break;
                case 1:
                    botonesEditar();
                    GeneralC.habilitarControlesTabPage(tpNotas);
                    break;
                case 2:
                    botonesEditar();
                    GeneralC.habilitarControlesTabPage(tpParaclinicos);
                    break;
                case 3:
                    botonesEditar();
                    GeneralC.habilitarControlesTabPage(tpProcedimientos);
                    break;
                case 4:
                    botonesEditar();
                    GeneralC.habilitarControlesTabPage(tpGlucometrias);
                    break;
            }
            
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
            if (MessageBox.Show(Mensajes.CANCELAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                restablecerCancelar();
            }      
        }

        public void cancelar()
        {
            tsBtNuevo.Enabled = true;
            tsBtBuscar.Enabled = true;
            tsBtAnular.Enabled = false;
            tsBtCancelar.Enabled = false;
            tsBtModificar.Enabled = false;
            tsBtGuardar.Enabled = false;
        }
        public void restablecerCancelar()
        {
            switch (tcEnfermeria.SelectedIndex)
            {
                case 0:
                    GeneralC.deshabilitarControlesTabPage(tpInsumos);
                    GeneralC.limpiarControles(tpInsumos);
                    cancelar();
                    enfermeria.idInsumo = ConstanteGeneral.PREDETERMINADO;
                    txtCodigo.Clear();
                    dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
                    enfermeria.insumoAprovado = false;
                    break;
                case 1:
                    GeneralC.deshabilitarControlesTabPage(tpNotas);
                    GeneralC.limpiarControles(tpNotas);
                    enfermeria.idNota = ConstanteGeneral.PREDETERMINADO;
                    cancelar();
                    txtCodigo.Clear();
                    dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
                    enfermeria.notaAprobado = false;
                    break;
                case 2:
                    GeneralC.deshabilitarControlesTabPage(tpParaclinicos);
                    GeneralC.limpiarControles(tpParaclinicos);
                    cancelar();
                    txtCodigo.Clear();
                    dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
                  
                    break;
                case 3:
                    GeneralC.deshabilitarControlesTabPage(tpProcedimientos);
                    GeneralC.limpiarControles(tpProcedimientos);
                    cancelar();
                    txtCodigo.Clear();
                    dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
                    enfermeria.procedimientoAprobado = false;
                    break;
                case 4:
                    GeneralC.deshabilitarControlesTabPage(tpGlucometria);
                    GeneralC.limpiarControles(tpGlucometria);
                    cancelar();
                    txtCodigo.Clear();
                    dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
                    enfermeria.glucometriaAprobado = false;
                    break;

            }
        }
        private void tcEnfermeria_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tpInsumos.Parent != null && tsBtGuardar.Enabled && tcEnfermeria.SelectedTab.Name != tpInsumos.Name)
            {
                e.Cancel = true;
            }
            else if (tcEnfermeria.SelectedTab.Name != tpNotas.Name && tsBtGuardar.Enabled)
            {
                e.Cancel = true;
            }else if (tcEnfermeria.SelectedTab.Name != tpProcedimientos.Name && tsBtGuardar.Enabled)
            {
                e.Cancel = true;
            }else if(tcEnfermeria.SelectedTab.Name != tpGlucometria.Name && tsBtGuardar.Enabled)
            {
                e.Cancel = true;
            }
        }
    }
}
