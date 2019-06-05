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

namespace Galactus.VistaControlador.ConfiguracionGeneral
{
    public partial class ConfiguracionExamenLaboratorioUI : Form
    {
        ConfiguracionParaclinico clasificacionParaclinico = new ConfiguracionParaclinico();
        public ConfiguracionExamenLaboratorioUI()
        {
            InitializeComponent();
        }

        private void cargarListaProcedimiento(string valor)
        {
            List<string> paramtro = new List<string>();
            paramtro.Add(valor);
            paramtro.Add(clasificacionParaclinico.idGrupo.ToString());
            GeneralC.llenarTabla(Sentencias.CLASIFICACION_PROCEDIMIENTO_PAGINACION, paramtro, clasificacionParaclinico.dtProcedimiento);
            ((ListBox)ckListaProcedimiento).DataSource = clasificacionParaclinico.dtProcedimiento;
            ((ListBox)ckListaProcedimiento).ValueMember = "idProcedimiento";
            ((ListBox)ckListaProcedimiento).DisplayMember = "Descripcion";
            clasificacionParaclinico.numPaginacion = clasificacionParaclinico.dtProcedimiento.Rows[0].Field<int>("Fila");
            numeroPaginas(clasificacionParaclinico.numPaginacion);
            lbRegistros.Text = "N° Registro: " + (clasificacionParaclinico.dtProcedimiento.Rows.Count).ToString();
            
        }

        private void paginacion(object sender, LinkLabelLinkClickedEventArgs e)
        {
            remarcarLinkLaber();
            cargarListaProcedimiento(((LinkLabel)sender).Tag.ToString());
            ((LinkLabel)sender).LinkVisited = true;
        }

        private void remarcarLinkLaber()
        {
            foreach (LinkLabel linklabel in pnPaginador.Controls)
            {
                linklabel.LinkVisited = false;
            }
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
    }
}
