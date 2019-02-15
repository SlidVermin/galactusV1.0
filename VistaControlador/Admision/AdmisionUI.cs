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
using Galactus.Modelo.Admision;
using Galactus.Entidades.Admision;

namespace Galactus.VistaControlador.Admision
{
    public partial class AdmisionUI : Form
    {
        Admisiones admision = new Admisiones();
        public AdmisionUI()
        {
            InitializeComponent();
        }

        private void nuevoBtn_Click(object sender, EventArgs e)
        {

        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {

        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {

        }

        private void editarBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {

        }

        private void anularBtn_Click(object sender, EventArgs e)
        {

        }

        private void buscarHCPacienteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();

                GeneralC.buscarDevuelveFila(Query.CARGAR_EPS,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarRegistro),
                                                   Mensajes.BUSQUEDA_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cargarRegistro(DataRow fila)
        {
            admision.idPaciente = fila.Field<int>("IdPaciente");
            admision.cargarPaciente();
        }

        private void AdmisionUI_Load(object sender, EventArgs e)
        {
            GeneralC.llenarCombo(Query.CARGAR_TIPO_DOCUMENTOS, Util.Constantes.ConstanteGeneral.VALUE_VALOR,
                               Util.Constantes.ConstanteGeneral.DISPLAY_VALOR,
                               tipoDocAcompañanteBox);
            GeneralC.llenarCombo(Query.CARGAR_TIPO_DOCUMENTOS, Util.Constantes.ConstanteGeneral.VALUE_VALOR,
                               Util.Constantes.ConstanteGeneral.DISPLAY_VALOR,
                               tipoDocResponsableBox);
            GeneralC.llenarCombo(Query.CARGARPAIS,
                               Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                               Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                               paisResponsableBox);
            GeneralC.llenarCombo(Query.CARGARPAIS,
                               Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                               Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                               paisAcompañante);
        }
        #region zonaGeografica

        private void paisAcompañante_SelectedValueChanged(object sender, EventArgs e)
        {
            if (paisAcompañante.SelectedIndex > 0)
            {

                GeneralC.llenarCombo(Query.CARGAR_DEPARTAMENTO + " " + paisAcompañante.SelectedValue + "",
                                    Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                    Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                    departAcompañanteBox);
                GeneralC.validarComboUbicacion(paisAcompañante, departAcompañanteBox);
            }
            else
            {

                GeneralC.llenarCombo(Query.CARGAR_DEPARTAMENTO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                   Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                   Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                   departAcompañanteBox);
                GeneralC.validarComboUbicacion(paisAcompañante, departAcompañanteBox);
            }
        }

       

        private void departAcompañanteBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (departAcompañanteBox.SelectedIndex > 0)
            {

                GeneralC.llenarCombo(Query.CARGAR_MUNICIPIO + " " + departAcompañanteBox.SelectedValue + "",
                                    Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                    Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                    ciudadAcompañanteBox);
                GeneralC.validarComboUbicacion(departAcompañanteBox, ciudadAcompañanteBox);
            }
            else
            {
                GeneralC.llenarCombo(Query.CARGAR_MUNICIPIO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                   Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                   Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                   ciudadAcompañanteBox);
                GeneralC.validarComboUbicacion(departAcompañanteBox, ciudadAcompañanteBox);
            }
        }


        private void paisResponsableBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (paisResponsableBox.SelectedIndex > 0)
            {

                GeneralC.llenarCombo(Query.CARGAR_DEPARTAMENTO + " " + paisResponsableBox.SelectedValue + "",
                                    Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                    Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                    departRespBox);
                GeneralC.validarComboUbicacion(paisResponsableBox, departRespBox);
            }
            else
            {

                GeneralC.llenarCombo(Query.CARGAR_DEPARTAMENTO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                   Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                   Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                   departRespBox);
                GeneralC.validarComboUbicacion(paisResponsableBox, departRespBox);
            }
        }

        private void departRespBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (departRespBox.SelectedIndex > 0)
            {

                GeneralC.llenarCombo(Query.CARGAR_MUNICIPIO + " " + departRespBox.SelectedValue + "",
                                    Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                    Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                    ciudadResBox);
                GeneralC.validarComboUbicacion(departRespBox, ciudadResBox);
            }
            else
            {
                GeneralC.llenarCombo(Query.CARGAR_MUNICIPIO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                   Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                   Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                   ciudadResBox);
                GeneralC.validarComboUbicacion(departRespBox, ciudadResBox);
            }
        }
        #endregion
    }
}
