using Galactus.Entidades.ConfiguracionGeneral;
using Galactus.Modelo.ConfiguracionGeneral;
using Galactus.Util;
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
    public partial class EmpresaUI : Form
    {
        Empresa empresa = new Empresa();
        #region Eventos de otros controles
        public EmpresaUI()
        {
            InitializeComponent();
        }
        private void EmpresaUI_Load(object sender, EventArgs e)
        {
            GeneralC.posCargadoForm(this, tstMenuPatron, tBtNuevo, tBtBuscar);
            iniciarlizarForm();
        }
        private void cbPais_SelectedValueChanged(object sender, EventArgs e)
        {
            GeneralC.llenarComboDependiente(cbPais, cbDepartamento, Query.CARGAR_DEPARTAMENTO);
        }
        private void cbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            GeneralC.llenarComboDependiente(cbDepartamento, cbCiudad, Query.CARGAR_MUNICIPIO);
        }
        private void Textnit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Textnit.Text.Equals(string.Empty))
                {
                    Textdv.Text = string.Empty;
                }
                else
                {
                    DigitoVerificacion digitoVerificacion = new DigitoVerificacion();
                    Textdv.Text = digitoVerificacion.calculaNit(Textnit.Text).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
            }



        }
        #endregion
        #region Botones
        private void tBtNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenuPatron, tBtGuardar, tBtCancelar);
        }
        private void tBtEditar_Click(object sender, EventArgs e)
        {
            GeneralC.fnEditarForm(this, tstMenuPatron, tBtGuardar, tBtCancelar);
        }
        private void tBtCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenuPatron, tBtNuevo, tBtBuscar);
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
                GeneralC.buscarDevuelveFila(Query.EQUIVALENCIA_BUSCAR,
                                            parametros,
                                            new GeneralC.cargarInfoFila(cargarEmpresa),
                                            Mensajes.BUSQUEDA_EMPRESA,
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
                    EmpresaDAL.anular(empresa);
                    GeneralC.posAnular(this, tstMenuPatron, tBtNuevo, tBtBuscar, Mensajes.CONFIRMACION_ANULADO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void btBuscarTercero_Click(object sender, EventArgs e)
        {
            List<string> parametro = new List<string>();
            parametro.Add(string.Empty);
            GeneralC.buscarDevuelveFila(Query.BUSCAR_TERCERO,
                                        parametro,
                                        new GeneralC.cargarInfoFila(cargarTercero),
                                        Util.Titulos.TITULO_BUSCAR_TERCERO,
                                        true);
        }
        private void btlogo_Click(object sender, EventArgs e)
        {
            GeneralC.seleccionarImagen(pictLogo);
        }
        #endregion
        #region Metodos
        public void cargarTercero(DataRow fila)
        {
            empresa.idEmpresa = fila.Field<int>("Código");
            txtIdRepresentante.Text = fila.Field<string>("Nit");
            txtNombreTercero.Text = fila.Field<string>("RazonSocial");
        }
        public void cargarEmpresa(DataRow fila)
        {
            empresa.idEmpresa = fila.Field<int>("Código");
            txtIdRepresentante.Text = fila.Field<string>("Nit");
            txtNombreTercero.Text = fila.Field<string>("RazonSocial");
        }
        void iniciarlizarForm()
        {
            GeneralC.llenarCombo(Query.CARGARPAIS,
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 cbPais);
        }
        private void armarEmpresa()
        {
            empresa.razonSocial = txtNombre.Text;
        }
        #endregion
   
    }
}
