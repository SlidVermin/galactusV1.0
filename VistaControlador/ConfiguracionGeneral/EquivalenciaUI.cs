using Galactus.Entidades.ConfiguracionGeneral;
using Galactus.Modelo;
using Galactus.Util.Constantes;
using Galactus.Util.Mensajes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.VistaControlador.ConfiguracionGeneral
{
    public partial class EquivalenciaUI : Form
    {
        Equivalencia equivalencia = new Equivalencia();
        public EquivalenciaUI()
        {
            InitializeComponent();
        }
        private void EquivalenciaUI_Load(object sender, EventArgs e)
        {
            List<ToolStripButton> listaBotonesHab = new List<ToolStripButton>();
            listaBotonesHab.Add(tBtNuevo);
            listaBotonesHab.Add(tBtBuscar);
            GeneralC.posCargadoForm(this, ref tstMenuPatron, ref listaBotonesHab);
        }
        #region Botones
        private void tBtNuevo_Click(object sender, EventArgs e)
        {
            List<ToolStripButton> listaBotones = new List<ToolStripButton>();
            listaBotones.Add(tBtGuardar);
            listaBotones.Add(tBtCancelar);
            GeneralC.formNuevo(this,ref tstMenuPatron,ref listaBotones);
            cargarLineas();
            cargarVias();
            dgvLineas.DataSource = equivalencia.tablaLineas;
            dgvVias.DataSource = equivalencia.tablaVias;
            colocarColumnaChk(ref dgvLineas, "verificarLineas");
            colocarColumnaChk(ref dgvVias, "verificarVias");
        }


        private void tBtEditar_Click(object sender, EventArgs e)
        {
            List<ToolStripButton> listaBotones = new List<ToolStripButton>();
            listaBotones.Add(tBtGuardar);
            listaBotones.Add(tBtCancelar);
            GeneralC.fnEditarForm(this,ref tstMenuPatron,ref listaBotones);
        }
        private void tBtCancelar_Click(object sender, EventArgs e)
        {
            List<ToolStripButton> listaBotones = new List<ToolStripButton>();
            listaBotones.Add(tBtNuevo);
            listaBotones.Add(tBtBuscar);
            GeneralC.fnCancelarForm(this, ref tstMenuPatron, ref listaBotones);
        }
        private void tBtGuardar_Click(object sender, EventArgs e)
        {

        }
        private void tBtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralC.buscarDevuelveFila("",
                                            parametros,
                                            new GeneralC.cargarInfoFila(cargarEquivalencia),
                                            Mensajes.BUSQUEDA_EQUIVALENCIA,
                                            true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tBtAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EquivalenciaDAL.anular(equivalencia);
                    List<ToolStripButton> listaBotones = new List<ToolStripButton>();
                    listaBotones.Add(tBtNuevo);
                    listaBotones.Add(tBtBuscar);
                    GeneralC.posAnular(this, ref tstMenuPatron, ref listaBotones, Mensajes.CONFIRMACION_ANULADO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        #endregion
        private void cargarEquivalencia(DataRow fila)
        {

        }
        private void colocarColumnaChk(ref DataGridView dgv,string nombreColumna )
        {
            if (!dgv.Columns.Contains("Chk"))
            {
                DataGridViewCheckBoxColumn columna = new DataGridViewCheckBoxColumn();
                columna.HeaderText = "";
                columna.Name = nombreColumna;
                dgv.Columns.Add(columna);
            }
        }
        private void cargarLineas()
        {
            List<string> listaParametros = new List<string>();
            listaParametros.Add(Util.Constantes.ConstanteGeneral.LINEA.ToString());
            listaParametros.Add("");
            GeneralC.llenarTabla(Query.PARAMETROS_LISTAR_DOCUMENTOS, listaParametros, equivalencia.tablaLineas);
        }
        private void cargarVias()
        {
            List<string> listaParametros = new List<string>();
            listaParametros.Add(Util.Constantes.ConstanteGeneral.VIAS_ADMINISTRACION.ToString());
            listaParametros.Add("");
            GeneralC.llenarTabla(Query.PARAMETROS_LISTAR_DOCUMENTOS, listaParametros, equivalencia.tablaVias);
        }
        void cargarUnidad(DataRow fila)
        {
            equivalencia.idUnidadMedida = fila.Field<int>("Código");
           txtUnidadMedida.Text = fila.Field<string>("Descripción");
        }
        private void btnBuscarUnidades_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(ConstanteGeneral.UNIDADES_DE_MEDIDA.ToString());
                parametros.Add("");
                GeneralC.listarDocumentosGenerales(Query.PARAMETROS_LISTAR_DOCUMENTOS,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarUnidad),
                                                   Mensajes.BUSQUEDA_UNIDAD_MEDIDA);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
