using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Entidades.ConfiguracionGeneral;
using Galactus.Util.Constantes;
using Galactus.Util.Mensajes;
using Galactus.Util;
using Galactus.Modelo.ConfiguracionGeneral;

namespace Galactus.VistaControlador.ConfiguracionGeneral
{
    public partial class ConfiguracionExamenLaboratorioUI : Form
    {
        ConfiguracionParaclinico clasificacionParaclinico = new ConfiguracionParaclinico();
        BindingSource bindNavegador= new BindingSource();
        public ConfiguracionExamenLaboratorioUI()
        {
            InitializeComponent();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvClasificacionParaclinico.EndEdit();
                clasificacioParaclinicoCrear();
                clasificacionParaclinicoGuardar();
                Mensajes.mensajeInformacion(Mensajes.CONFIRMACION_GUARDADO);
            }
            catch (Exception ex) {
                Mensajes.mensajeError(ex);
            }
        }

        private void tsbBuscarGrupos_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralC.buscarDevuelveFila(Sentencias.GRUPO_PARACLINICO_LISTAR,
                                        null,
                                        new GeneralC.cargarInfoFila(cargarGrupo),
                                        Titulos.TITULO_BUSCAR_GRUPO,
                                        true);
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }
      }
        private void cargarGrupo(DataRow dRows)
        {
            clasificacionParaclinico.idGrupo = dRows.Field<int>("codigo");
            txtGrupo.Text = dRows.Field<string>("Descripcion");
            cargarListaProcedimiento(ConstanteGeneral.SIN_VALOR_NUMERICO.ToString());
        }
        private void ConfiguracionExamenLaboratorioUI_Load(object sender, EventArgs e)
        {
            validarGrilla(dgvClasificacionParaclinico);
        }

        private void dgvClasificacionParaclinico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) {
               clasificacionParaclinico.editable = true;
            }     
        }
        private void txtBuscarItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter) {
                filtrarRegistro();
            }
        }

        private void btBuscarSinGrupoCUPS_Click(object sender, EventArgs e)
        {
            filtrarRegistro();
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

        #region ClasificacionParaclinico

        private void cargarListaProcedimiento(string valor)
        {
            List<string> paramtro = new List<string>();
            paramtro.Add(valor);
            paramtro.Add(clasificacionParaclinico.idGrupo.ToString());
            GeneralC.llenarTabla(Sentencias.CLASIFICACION_PROCEDIMIENTO_PAGINACION, paramtro, clasificacionParaclinico.dtProcedimiento);
            bindNavegador.DataSource = clasificacionParaclinico.dtProcedimiento;
            dgvClasificacionParaclinico.DataSource = bindNavegador.DataSource;
            clasificacionParaclinico.numPaginacion = clasificacionParaclinico.dtProcedimiento.Rows[0].Field<int>("Fila");
            numeroPaginas(clasificacionParaclinico.numPaginacion);
            lbRegistros.Text = "N° Registro: " + (clasificacionParaclinico.dtProcedimiento.Rows.Count).ToString();
        }

        private void paginacion(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (clasificacionParaclinico.editable == false)
            {
                remarcarLinkLaber();
                cargarListaProcedimiento(((LinkLabel)sender).Tag.ToString());
                ((LinkLabel)sender).LinkVisited = true;
                clasificacionParaclinico.sesion = Convert.ToInt32(((LinkLabel)sender).Name);
            }
            else
            {
                Mensajes.mensajeAdvertencia("el sistema ah detectado una modificacion Favor Guardar el registro");
            }
        }
        private void remarcarLinkLaber()
        {
            foreach (LinkLabel linklabel in pnPaginador.Controls)
            {
                linklabel.LinkVisited = false;
            }
        }
        private void numeroPaginas(int tope)
        {
            int posicionInicial = 3;
            int aumentoPosicion = 17;
            int aumentoContendor = 1000;
            int contenedorTag = 0;

            LinkLabel link;

            for (int posicion = 0; posicion < tope; posicion++)
            {
                link = new LinkLabel();
                link.Location = new Point(posicionInicial, 10);
                link.Size = new Size(13,13);
                link.Tag = contenedorTag;
                link.Text = posicion.ToString();
                link.Name= posicion.ToString();
                link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.paginacion);
                pnPaginador.Controls.Add(link);
                link.Show();
                contenedorTag = contenedorTag + aumentoContendor;
                posicionInicial = posicionInicial + aumentoPosicion;

                if (link.Name==ConstanteGeneral.SIN_VALOR_NUMERICO.ToString()) {
                    link.LinkVisited = true;
                }
            }
        }

        #endregion

        private void validarGrilla(DataGridView  grilla) {
            grilla.ReadOnly = false;
            grilla.Columns[0].DataPropertyName = "idProcedimiento";
            grilla.Columns[0].ReadOnly = true;
            grilla.Columns[1].DataPropertyName = "cups";
            grilla.Columns[1].ReadOnly = true;
            grilla.Columns[2].DataPropertyName = "Descripcion";
            grilla.Columns[2].ReadOnly = true;
            grilla.Columns[3].DataPropertyName = "Estado";
            grilla.Columns[3].ReadOnly = false;
            grilla.AutoGenerateColumns = false;
        }

        private void clasificacionParaclinicoGuardar() {
            ConfiguracionParaclinicoDAL.guardarClasificacionParaclinico(clasificacionParaclinico);
            clasificacionParaclinico.editable = false;
        }

        private void clasificacioParaclinicoCrear() {
            clasificacionParaclinico.dtRegistro.Clear();
            foreach (DataRow dRows in clasificacionParaclinico.dtProcedimiento.Select("Estado = True")) {
                   clasificacionParaclinico.dtRegistro.ImportRow(dRows);
            }         
        }
        private void filtrarRegistro() {
            if (clasificacionParaclinico.dtProcedimiento.Rows.Count > 0) {
                bindNavegador.Filter = "Cups Like '%" + txtBuscarItems.Text + "%' Or Descripcion Like '%" + txtBuscarItems.Text + "%'";
            }
        }
    }
}
