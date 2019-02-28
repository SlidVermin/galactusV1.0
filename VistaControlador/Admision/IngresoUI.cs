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
using Galactus.Entidades.Admision;

namespace Galactus.VistaControlador.Admision
{
    public partial class IngresoUI : Form
    {
        Atencion atencion = new Atencion();
        public IngresoUI()
        {
            InitializeComponent();
        }

        private void IngresoUI_Load(object sender, EventArgs e)
        {
            GeneralC.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            establecerGridview();
            btnSalir.Enabled = true;
            GeneralC.llenarCombo(Query.ATENCION_CAUSA_EXTERNA + " " + Util.Constantes.ConstanteGeneral.CAUSA_EXTERNA + "",
                               Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                               Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                               cbCausaExterna);
            GeneralC.llenarCombo(Query.ATENCION_INSTITUCION + " " + Util.Constantes.ConstanteGeneral.INSTITUCIÓN + "",
                               Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                               Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                               cbInstitucion);
            GeneralC.llenarCombo(Query.ATENCION_CAMA + " " + Util.Constantes.ConstanteGeneral.CAMA + "",
                               Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                               Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                               cbCama);
            GeneralC.llenarCombo(Query.GENERAL_ENTORNO_ATENCION,
                              Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                              Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                              cbEntorno);
            GeneralC.llenarCombo(Query.GENERAL_AREA_ATENCION,
                             Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                             Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                             cbArea);
            GeneralC.llenarCombo(Query.ATENCION_VIA_INGRESO + " " + Util.Constantes.ConstanteGeneral.VIA_INGRESO + "",
                             Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                             Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                             cbVia);
        }

        public void establecerGridview()
        {
            atencion.establecerDt();
            dgvDiagnostico.Columns["dgQuitar"].DataPropertyName = "Quitar";
            dgvDiagnostico.Columns["dgCodigo"].DataPropertyName = "Código cie";
            dgvDiagnostico.Columns["dgDescripcion"].DataPropertyName = "Descripcion";

            dgvDiagnostico.DataSource = atencion.dtDiagnostico;
        }

        private void btPacienteAdmision_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();

                GeneralC.buscarDevuelveFila(Query.ATENCION_BUSCAR_PACIENTE_ADMISIONADO,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarPaciente),
                                                   Mensajes.BUSQUEDA_PACIENTE, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cargarPaciente(DataRow filas)
        {
            txtIdAdmision.Text = Convert.ToString(filas.Field<int>("admision"));
            txtnombrePaciente.Text = filas.Field<String>("paciente");
            txtFechaAdmision.Text = Convert.ToString(filas.Field<DateTime>("fecha admision"));
            atencion.idAdmision = filas.Field<int>("admision");
            habilitarControles();
        }

        public void habilitarControles()
        {
            rbIniciado.Enabled = true;
            rbAuditoria.Enabled = true;
            rbPrefacturado.Enabled = true;
            cbVia.Enabled = true;
            cbCausaExterna.Enabled = true;
            cbInstitucion.Enabled = true;
            cbEntorno.Enabled = true;
            cbCama.Enabled = true;
            cbArea.Enabled = true;
            Textautorizacion.Enabled = true;
            Textautorizacion.ReadOnly = false;
            txtobservacion.Enabled = true;
            txtIdAdmision.Enabled = true;
            txtnombrePaciente.Enabled = true;
            txtFechaAdmision.Enabled = true;
            txtIdAdmision.ReadOnly = true;
            txtFechaAdmision.ReadOnly = true;
            txtnombrePaciente.ReadOnly = true;
            fechaIngreso.Enabled = true;
        }

        private void dgvDiagnostico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgCodigo"].Selected == true)
            {
                try
                {
                    List<string> parametros = new List<string>();

                    GeneralC.buscarDevuelveFila(Query.GENERAL_BUSCAR_DIAGNOSTICO,
                                                       parametros,
                                                       new GeneralC.cargarInfoFila(cargarDiagnostico),
                                                       Mensajes.BUSQUEDA_PACIENTE, true);
                    atencion.dtDiagnostico.Rows.Add();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgQuitar"].Selected == true
                 && GeneralC.castFromDbItemVacio( dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgcodigo"].Value.ToString()) != "")
            {
                atencion.dtDiagnostico.Rows.RemoveAt(e.RowIndex);

            }
        }
        public void cargarDiagnostico(DataRow filas)
        {
            dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgCodigo"].Value = filas.Field<String>("Código cie");
            dgvDiagnostico.Rows[dgvDiagnostico.CurrentCell.RowIndex].Cells["dgDescripcion"].Value = filas.Field<String>("Descripcion");
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            habilitarNuevo();
        }

        public void habilitarNuevo()
        {
            btPacienteAdmision.Enabled = true;
            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbBuscar.Enabled = false;
            dgvDiagnostico.Enabled = true;
            GeneralC.limpiarControles(this);
            atencion.dtDiagnostico.Rows.Add();
            rbIniciado.Checked = true;
        }

        private void tstEditar_Click(object sender, EventArgs e)
        {
          if ( GeneralC.fnEditarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar))
            {
                atencion.dtDiagnostico.Rows.Add();
                btPacienteAdmision.Enabled = false;
                fechaIngreso.Enabled = false;
            }      
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            btnSalir.Enabled = true;
            rbIniciado.Checked = true;
        }

        public void limpiarContrles()
        {
            txtIdAdmision.Clear();
        }

        public bool validarForm()
        {
            return true;
        }

        public void asignarAtencion()
        {
            if (rbIniciado.Checked)
            {
                atencion.idEstadoAtencion = Convert.ToInt16( rbIniciado.Tag);
            }else if (rbCerrado.Checked)
            {
                atencion.idEstadoAtencion = Convert.ToInt16(rbCerrado.Tag);
            }else if (rbReabrir.Checked)
            {
                atencion.idEstadoAtencion = Convert.ToInt16(rbReabrir.Tag);
            }else if (rbAuditoria.Checked)
            {
                atencion.idEstadoAtencion = Convert.ToInt16(rbAuditoria.Tag);
            }else if (rbFacturado.Checked)
            {
                atencion.idEstadoAtencion = Convert.ToInt16(rbFacturado.Tag);
            }else if(rbPrefacturado.Checked)
            {
                atencion.idEstadoAtencion = Convert.ToInt16(rbPrefacturado.Tag);
            }
        }
        public void asignarDatos()
        {
            asignarAtencion();
            atencion.idAdmision = Convert.ToInt16( txtIdAdmision.Text);
            atencion.idArea = (String) cbArea.SelectedValue;
            atencion.idCama = (String)cbCama.SelectedValue;
            atencion.idCausaExterna = (String)cbCausaExterna.SelectedValue;
            atencion.idEntorno = (String)cbEntorno.SelectedValue;
            atencion.idInstitucion = (String)cbInstitucion.SelectedValue;
            atencion.idViaIngreso = (String)cbVia.SelectedValue;
            atencion.observacion = txtobservacion.Text;
            atencion.fechaIngreso = fechaIngreso.Value;
            atencion.numeroAutorizacion = Textautorizacion.Text.Equals(string.Empty) ? 0 : Convert.ToInt16( Textautorizacion.Text);
        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    asignarDatos();
                    atencion.guardar();
                    GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstEditar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    atencion.dtDiagnostico.Rows.RemoveAt(atencion.dtDiagnostico.Rows.Count - 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();

                GeneralC.buscarDevuelveFila(Query.ATENCION_BUSCAR,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarDatos),
                                                   Mensajes.BUSQUEDA_PACIENTE, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cargarDatos(DataRow filas)
        {
           
            atencion.idAtencion = filas.Field<int>("atencion");
            atencion.cargarDatos();
            cbVia.SelectedValue = atencion.idViaIngreso;
            cbCausaExterna.SelectedValue = atencion.idCausaExterna;
            cbInstitucion.SelectedValue = atencion.idInstitucion;
            cbCama.SelectedValue = atencion.idCama;
            cbEntorno.SelectedValue = atencion.idEntorno;
            cbArea.SelectedValue = atencion.idArea;
            fechaIngreso.Value = atencion.fechaIngreso;
            Textautorizacion.Text = (Convert.ToString( atencion.numeroAutorizacion));
            txtobservacion.Text = atencion.observacion;
            txtIdAdmision.Text = Convert.ToString( atencion.idAdmision);
            txtnombrePaciente.Text = atencion.nombrePaciente;
            txtFechaAdmision.Text = Convert.ToString( atencion.fechaAdmision);
            dgvDiagnostico.DataSource = atencion.dtDiagnostico;
            establecerAtencion();
            tstEditar.Enabled = true;
            tsbAnular.Enabled = true;
        }
        public void establecerAtencion()
        {
            if (atencion.idEstadoAtencion == 1)
            {
                rbIniciado.Checked = true;
            }else if (atencion.idEstadoAtencion == 2)
            {
                rbCerrado.Checked = true;
            }else if (atencion.idEstadoAtencion == 3)
            {
                rbReabrir.Checked = true;
            }else if (atencion.idEstadoAtencion == 4)
            {
                rbFacturado.Checked = true;
            }else if (atencion.idEstadoAtencion == 5)
            {
                rbAuditoria.Checked = true;
            }else if (atencion.idEstadoAtencion == 6)
            {
                rbPrefacturado.Checked = true;
            }
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightCoral;

        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Control.DefaultBackColor;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    atencion.anular();
                    GeneralC.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
                    btnSalir.Enabled = true;
                    rbIniciado.Checked = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
