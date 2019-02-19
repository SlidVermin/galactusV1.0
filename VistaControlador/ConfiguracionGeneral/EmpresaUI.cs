using Galactus.Entidades.ConfiguracionGeneral;
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
        public EmpresaUI()
        {
            InitializeComponent();
        }
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

        }

        private void tBtAnular_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void EmpresaUI_Load(object sender, EventArgs e)
        {
            GeneralC.posCargadoForm(this, tstMenuPatron, tBtNuevo, tBtBuscar);
            iniciarlizarForm();
        }
        void iniciarlizarForm()
        {
            GeneralC.llenarCombo(Query.CARGARPAIS,
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 cbPais);
        }
        private void cbPais_SelectedValueChanged(object sender, EventArgs e)
        {
            GeneralC.llenarComboDependiente(cbPais, cbDepartamento, Query.CARGAR_DEPARTAMENTO);
        }
        private void cbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            GeneralC.llenarComboDependiente(cbDepartamento, cbCiudad, Query.CARGAR_MUNICIPIO);
        }
    }
}
