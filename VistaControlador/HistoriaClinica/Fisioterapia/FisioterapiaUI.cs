using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Entidades.HistoriaClinica.Fisioterapeuta;
using Galactus.Entidades.HistoriaClinica.Enfermeria;
using Galactus.Util.Constantes;
using Galactus.Util.Mensajes;

namespace Galactus.VistaControlador.HistoriaClinica.Enfermeria
{
    public partial class FisioterapiaUI : Form
    {
        EnfermeriaClinica enfermeria = new EnfermeriaClinica();
        private int idAtencion;
        Fisioterapeutas fisio = new Fisioterapeutas();
        InsumosUI insumos = new InsumosUI();
        NotasUI notas = new NotasUI();
        public FisioterapiaUI()
        {
            InitializeComponent();
        }
        public FisioterapiaUI(int idAtencion)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
        }

        private void FisioterapiaUI_Load(object sender, EventArgs e)
        {
            dtpFecha.Text = Convert.ToString(GeneralC.obtenerFechaServidor());
            GeneralC.cargarFormularioEnPestana(tpInsumos, insumos);
            GeneralC.cargarFormularioEnPestana(tpNotas, notas);
            GeneralC.posCargadoForm(this, tstMenu, tsBtNuevo, tsBtBuscar);
            enfermeria.idInsumo = ConstanteGeneral.PREDETERMINADO;
            enfermeria.idNota = ConstanteGeneral.PREDETERMINADO;
        }
        private void opciones()
        {
            insumos.enfermeria.dtInsumos.Rows.Add();
            insumos.dgvInsumos.ReadOnly = false;
            insumos.dgvInsumos.Enabled = true;
        }
        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
            switch (tcFisio.SelectedIndex)
            {
                case 0:
                    nuevo();
                    opciones();
                    enfermeria.idInsumo = ConstanteGeneral.PREDETERMINADO;
                    GeneralC.formNuevo(tpInsumos, tstMenu, tsBtGuardar, tsBtCancelar);
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

        public void obtenerDatos()
        {
            enfermeria.idInsumo = (txtCodigo.Text.Equals(String.Empty) ? ConstanteGeneral.PREDETERMINADO : Convert.ToInt32(txtCodigo.Text));
            enfermeria.tipo = ConstanteGeneral.FISOTERAPEUTAS_INSUMOS;
            enfermeria.fecha = dtpFecha.Value;
            enfermeria.idAtencion = idAtencion;
            enfermeria.nota = notas.txtNotas.Text;
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
                    txtCodigo.Text = Convert.ToString(enfermeria.idInsumo);
                    enfermeria.insumoAprovado = true;
                    botonesGuardar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void obtenerDatosNotas()
        {
            enfermeria.tipo = ConstanteGeneral.FISOTERAPEUTAS_INSUMOS;
            enfermeria.Auditoria = false;
            enfermeria.nota = notas.txtNotas.Text;
            enfermeria.idAtencion = idAtencion;
            enfermeria.fechaNota = dtpFecha.Value;
        }
        public void guardarNotas()
        {
            if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        private void tsBtGuardar_Click(object sender, EventArgs e)
        {
            switch (tcFisio.SelectedIndex)
            {
                case 0:
                    guardarInsumos();
                    break;
                case 1:
                    guardarNotas();
                    break;             
            }
        }
        public void buscarInsumos()
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(idAtencion));
                parametros.Add(Convert.ToString(ConstanteGeneral.FISOTERAPEUTAS_INSUMOS));
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
        public void cargarInsumos(DataRow resultados)
        {
            enfermeria.establecerDT();
            txtCodigo.Text = Convert.ToString(resultados.Field<int>("Código insumo"));
            enfermeria.idInsumo = resultados.Field<int>("Código insumo");
            enfermeria.tipo = ConstanteGeneral.FISOTERAPEUTAS_INSUMOS;
            enfermeria.cargarInsumos();
            dtpFecha.Value = enfermeria.fechaInsumo;
            insumos.dgvInsumos.DataSource = enfermeria.dtInsumos;
            insumos.enfermeria = enfermeria;
            botonesGuardar();
        }
        public void buscarNotas()
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(enfermeria.Auditoria));
                parametros.Add(Convert.ToString(idAtencion));
                parametros.Add(Convert.ToString(ConstanteGeneral.FISOTERAPEUTAS_INSUMOS));
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
            enfermeria.tipo = ConstanteGeneral.FISOTERAPEUTAS_INSUMOS;
            enfermeria.cargarNotas();
            notas.txtNotas.Text = enfermeria.nota;
            dtpFecha.Value = enfermeria.fechaNota;
            botonesGuardar();
        }
        private void tsBtBuscar_Click(object sender, EventArgs e)
        {
            switch (tcFisio.SelectedIndex)
            {
                case 0:
                    buscarInsumos();
                    break;
                case 1:
                    buscarNotas();
                    break;
            }
        }
      
        private void tcEnfermeria_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcFisio.SelectedIndex)
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
               
            }
        }
        public void botonesEditar()
        {    
            tsBtGuardar.Enabled = true;
            tsBtModificar.Enabled = false;
            tsBtAnular.Enabled = false;
            tsBtNuevo.Enabled = false;
            tsBtBuscar.Enabled = false;
            tsBtCancelar.Enabled = true;
        }
        private void tsBtModificar_Click(object sender, EventArgs e)
        {
            switch (tcFisio.SelectedIndex)
            {
                case 0:
                    botonesEditar();
                    opciones();
                    break;
                case 1:
                    botonesEditar();
                    GeneralC.habilitarControlesTabPage(tpNotas);
                    break;
            }
        }
        public void restablecerCancelar()
        {
            switch (tcFisio.SelectedIndex)
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
        private void tsBtCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.CANCELAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                restablecerCancelar();
            }
        }

        private void tcFisio_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tpInsumos.Parent != null && tsBtGuardar.Enabled && tcFisio.SelectedTab.Name != tpInsumos.Name)
            {
                e.Cancel = true;
            }else if (tcFisio.SelectedTab.Name != tpNotas.Name && tsBtGuardar.Enabled )
            {
                e.Cancel = true;
            }
        }
    }
}
