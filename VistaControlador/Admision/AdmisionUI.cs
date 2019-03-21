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

        private void ModificarBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {

        }

        private void anularBtn_Click(object sender, EventArgs e)
        {

        }

        public void cargarRegistro(DataRow fila)
        {
            admision.idPaciente = fila.Field<int>("IdPaciente");
            admision.cargarPaciente();
            txttipoafiliacion.Text = admision.tipoAfiliacion;
            hClinicaText.Text = admision.identificacion;
            estratoSocialText.Text = admision.estratoSocial;
            regimenText.Text = admision.regimen;
            nombrePacienteText.Text = admision.nombrePaciente;
            EPSNomText.Text = admision.nombreEPS;
        }

        private void AdmisionUI_Load(object sender, EventArgs e)
        {
            GeneralC.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
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
            GeneralC.llenarCombo(Query.ADMISION_TRIAGE +" "+ Util.Constantes.ConstanteGeneral.TRIAGE + "",
                              Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                              Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                              triageBox);
            btnSalir.Enabled = true;
        }
        #region zonaGeografica

        private void paisAcompañante_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

       

        private void departAcompañanteBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }


        private void paisResponsableBox_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void departRespBox_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
        #endregion

        private void buscarHCPacienteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();

                GeneralC.buscarDevuelveFila(Query.ADMISION_PACIENTE_BUSCAR,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarRegistro),
                                                   Mensajes.BUSQUEDA_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void paisAcompañante_SelectedValueChanged_1(object sender, EventArgs e)
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

        private void departAcompañanteBox_SelectedValueChanged_1(object sender, EventArgs e)
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

        private void paisResponsableBox_SelectedValueChanged_1(object sender, EventArgs e)
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

        private void departRespBox_SelectedValueChanged_1(object sender, EventArgs e)
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

        private void buscarContratoOtrosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(admision.idEps));
                GeneralC.buscarDevuelveFila(Query.ADMISION_CONTRATO_EPS,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarContratoEps),
                                                   Mensajes.BUSQUEDA_CONTRATO_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void cargarContratoEps(DataRow fila)
        {
            contratoCodOtrosText.Text = Convert.ToString(fila.Field<int>("Código"));
            contratoNomOtrosText.Text = fila.Field<String>("Cliente");
            admision.idContrato = fila.Field<int>("Código");
        }

        private void buscarContactoOtrosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                
                GeneralC.buscarDevuelveFila(Query.ADMISION_TERCERO_PACIENTE,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarContacto),
                                                   Mensajes.BUSQUEDA_CONTRATO_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void cargarContacto(DataRow filas)
        {
            contactoCodOtrosText.Text = Convert.ToString(filas.Field<int>("idTercero"));
            contactoNomOtrosText.Text = filas.Field<String>("tercero");
            admision.idContacto = filas.Field<int>("idTercero");
        }

        private void buscarEspOtrosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(Convert.ToString(Util.Constantes.ConstanteGeneral.ESPECIALIDAD));
                GeneralC.buscarDevuelveFila(Query.ADMISION_ESPECIALIDAD,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarEspecialidad),
                                                   Mensajes.BUSQUEDA_CONTRATO_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cargarEspecialidad(DataRow filas)
        {
            especialidadText.Text = filas.Field<String>("descripcion");
            admision.idEspecialidad = filas.Field<int>("Código");
        }

        public bool validarForm()
        {
            if (contratoCodOtrosText.Text.Equals(String.Empty))
            {
                MessageBox.Show("¡ Favor seleccione el contrato  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                buscarContactoOtrosBtn.Focus();
                return false;

            }else if (contactoCodOtrosText.Text.Equals(String.Empty))
            {
                MessageBox.Show("¡ Favor seleccione el contrato  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                buscarContactoOtrosBtn.Focus();
                return false;
            }else if (triageBox.SelectedIndex ==0)
            {
                MessageBox.Show("¡ Favor seleccione el triage  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                triageBox.Focus();
                return false;
            }else if (especialidadText.Text.Equals(String.Empty))
            {
                MessageBox.Show("¡ Favor seleccione la especialidad  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                especialidadText.Focus();
                return false;
            }else if (checkAcompanante.Checked)
            {
                if (tipoDocAcompañanteBox.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el tipo de documento del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tipoDocAcompañanteBox.Focus();
                    return false;
                }else if (idAcompañanteText.Text.Equals(String.Empty))
                {
                    MessageBox.Show("¡ Favor digite el numero de documento del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    idAcompañanteText.Focus();
                    return false;
                }else if (nombreAcompañanteText.Text.Equals(String.Empty))
                {
                    MessageBox.Show("¡ Favor digite el nombre completo del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nombreAcompañanteText.Focus();
                    return false;
                }else if (paisAcompañante.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el pais del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    paisAcompañante.Focus();
                    return false;
                }else if (departAcompañanteBox.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el departamento del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    departAcompañanteBox.Focus();
                    return false;
                }else if (ciudadAcompañanteBox.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el municipio del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ciudadAcompañanteBox.Focus();
                    return false;
                }else if (dirAcompañanteText.Text.Equals(String.Empty))
                {
                    MessageBox.Show("¡ Favor digite la direccion del acompañante  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dirAcompañanteText.Focus();
                    return false;
                }
            }else if (checkResponsable.Checked)
            {
                if (tipoDocResponsableBox.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el tipo de documento del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tipoDocResponsableBox.Focus();
                    return false;
                }
                else if (idResponsableText.Text.Equals(String.Empty))
                {
                    MessageBox.Show("¡ Favor digite el numero de documento del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    idResponsableText.Focus();
                    return false;
                }
                else if (nombreRespText.Text.Equals(String.Empty))
                {
                    MessageBox.Show("¡ Favor digite el nombre completo del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nombreRespText.Focus();
                    return false;
                }
                else if (paisResponsableBox.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el pais del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    paisResponsableBox.Focus();
                    return false;
                }
                else if (departRespBox.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el departamento del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    departRespBox.Focus();
                    return false;
                }
                else if (ciudadResBox.SelectedIndex == 0)
                {
                    MessageBox.Show("¡ Favor seleccione el municipio del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ciudadResBox.Focus();
                    return false;
                }
                else if (dirResponsableBox.Text.Equals(String.Empty))
                {
                    MessageBox.Show("¡ Favor digite la direccion del responsable  !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dirResponsableBox.Focus();
                    return false;
                }
            }
            else
            {
                return true;
            }
            return true;    
        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    asignarDatos();
                    admision.guardar();
                    nRegistroText.Text = Convert.ToString(admision.idAdmision);
                    GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void asignarDatos()
        {
            admision.idAdmision = (nRegistroText.Text.Equals(String.Empty))  ? 0: int.Parse(nRegistroText.Text);
            admision.fecha = fechaPacientePicker.Value;
            admision.tipoDocumentoAcompañante = (string)tipoDocAcompañanteBox.SelectedValue;
            admision.tipoDocumentoResponsable = (string)tipoDocResponsableBox.SelectedValue;
            admision.identificacionAcompañante = idAcompañanteText.Text;
            admision.identificacionResponsable = idResponsableText.Text;
            admision.nombreAcompañante = nombreAcompañanteText.Text;
            admision.nombreResponsable = nombreRespText.Text;
            admision.telefonoAcompañante = telAcompañanteText.Text;
            admision.telefonoResponsable = telRespText.Text;
            admision.idMunicipioAcompañante = (string) ciudadAcompañanteBox.SelectedValue;
            admision.idMunicipioResponsable = (string)ciudadResBox.SelectedValue;
            admision.direccionAcompañante = dirAcompañanteText.Text;
            admision.direccionResponsable = dirResponsableBox.Text;
            admision.idTriage = (string) triageBox.SelectedValue;
            admision.acompanante = checkAcompanante.Checked;
            admision.responsable = checkResponsable.Checked;
        }

        private void checkAcompanante_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAcompanante.Checked)
            {
                pnlacompanante.Enabled = true;
            }else
            {
                pnlacompanante.Enabled = false;
            }
        }

        private void checkResponsable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkResponsable.Checked)
            {
                pnlresponsable.Enabled = true;
            }else
            {
                pnlresponsable.Enabled = false;
            }
        }

        public void deshabilitarCombosUbicacion()
        {
            departAcompañanteBox.Enabled = false;
            departRespBox.Enabled = false;
            ciudadAcompañanteBox.Enabled = false;
            ciudadResBox.Enabled = false;
        }

        private void tstModificar_Click(object sender, EventArgs e)
        {
            GeneralC.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar);
            buscarHCPacienteBtn.Enabled = false;
            fechaPacientePicker.Enabled = false;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
            admision.idAdmision = 0;
            btnSalir.Enabled = true;
            fechaPacientePicker.ResetText();

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
            admision.idAdmision = 0;
            fechaPacientePicker.ResetText();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();

                GeneralC.buscarDevuelveFila(Query.ADMISION_BUSCAR,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarDatos),
                                                   Mensajes.BUSQUEDA_CONTRATO_EPS, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cargarDatos(DataRow filas)
        {
            admision.idAdmision = filas.Field<int>("Admision");
            admision.cargarUbicaciones();
            admision.cargarDatos();
            contratoCodOtrosText.Text = Convert.ToString( admision.idContrato);
            contactoCodOtrosText.Text = Convert.ToString( admision.idContacto);
            contratoNomOtrosText.Text = admision.cliente;
            contactoNomOtrosText.Text = admision.contacto;
            triageBox.SelectedValue = admision.idTriage;
            especialidadText.Text = admision.especialidad;
            nRegistroText.Text = Convert.ToString( admision.idAdmision);
            tstModificar.Enabled = true;
            tsbAnular.Enabled = true;
            if (admision.acompanante)
            {
                tipoDocAcompañanteBox.SelectedValue = admision.tipoDocumentoAcompañante;
                idAcompañanteText.Text = admision.identificacionAcompañante;
                nombreAcompañanteText.Text = admision.nombreAcompañante;
                GeneralC.cargarUbicacionGeografica(admision.dtUbicacion, admision.idMunicipioAcompañante, ref paisAcompañante, ref departAcompañanteBox, ref ciudadAcompañanteBox);
                dirAcompañanteText.Text = admision.direccionAcompañante;
                telAcompañanteText.Text = admision.telefonoAcompañante;
                checkAcompanante.Checked = admision.acompanante;
            }
            if (admision.responsable)
            {
                tipoDocResponsableBox.SelectedValue = admision.tipoDocumentoResponsable;
                idResponsableText.Text = admision.identificacionResponsable;
                nombreRespText.Text = admision.nombreResponsable;
                GeneralC.cargarUbicacionGeografica(admision.dtUbicacion, admision.idMunicipioResponsable, ref paisAcompañante, ref departAcompañanteBox, ref ciudadAcompañanteBox);
                dirResponsableBox.Text = admision.direccionResponsable;
                telRespText.Text = admision.telefonoResponsable;
                checkResponsable.Checked = admision.responsable;
            }
            admision.cargarPaciente();
            txttipoafiliacion.Text = admision.tipoAfiliacion;
            hClinicaText.Text = admision.identificacion;
            estratoSocialText.Text = admision.estratoSocial;
            regimenText.Text = admision.regimen;
            nombrePacienteText.Text = admision.nombrePaciente;
            EPSNomText.Text = admision.nombreEPS;
            deshabilitarCombosUbicacion();
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    admision.anular();
                    GeneralC.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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
    }
}
