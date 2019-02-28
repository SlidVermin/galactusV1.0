using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Entidades.Admision;
using Galactus.Util.Mensajes;
using Galactus.Modelo.Admision;

namespace Galactus.VistaControlador
{
    public partial class PacienteUI : Form
    {
        String edad;
        Paciente paciente = new Paciente();
        public PacienteUI()
        {
            InitializeComponent();
        }

        private void buscarEpsBtn_Click(object sender, EventArgs e)
        {

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

        private void PacienteUI_Load(object sender, EventArgs e)
        {
            GeneralC.posCargadoForm(this, tstMenuPatron, tBtNuevo, tBtBuscar);
            GeneralC.llenarCombo(Query.CARGARPAIS,
                                Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                paisBox);
            GeneralC.llenarCombo(Query.CARGARPAIS,
                               Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                               Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                               paisNacBox);
            GeneralC.llenarCombo(Query.CARGARPAIS,
                               Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                               Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                               paisResBox);
            GeneralC.llenarCombo(Query.CARGAR_TIPO_DOCUMENTOS, Util.Constantes.ConstanteGeneral.VALUE_VALOR,
                               Util.Constantes.ConstanteGeneral.DISPLAY_VALOR,
                               tipoDocBox);
            GeneralC.llenarCombo(Query.CARGAR_GENERO, Util.Constantes.ConstanteGeneral.VALUE_VALOR,
                               Util.Constantes.ConstanteGeneral.DISPLAY_VALOR,
                               sexoBox);
            GeneralC.llenarCombo(Query.CARGAR_ESTADO_CIVIL, Util.Constantes.ConstanteGeneral.VALUE_VALOR,
                               Util.Constantes.ConstanteGeneral.DISPLAY_VALOR,
                               estadoCivilBox);
            GeneralC.llenarCombo(Query.CARGAR_AFILIACION, Util.Constantes.ConstanteGeneral.VALUE_VALOR,
                              Util.Constantes.ConstanteGeneral.DISPLAY_VALOR,
                              tipoAfiliacionBox);
            GeneralC.llenarCombo(Query.CARGAR_ESTRATO_SOCIAL, Util.Constantes.ConstanteGeneral.VALUE_VALOR,
                              Util.Constantes.ConstanteGeneral.DISPLAY_VALOR,
                              estratoBox);
            GeneralC.llenarCombo(Query.CARGAR_REGIMEN, Util.Constantes.ConstanteGeneral.VALUE_VALOR,
                              Util.Constantes.ConstanteGeneral.DISPLAY_VALOR,
                              regimenBox);
            GeneralC.llenarCombo(Query.CARGAR_ZONA, Util.Constantes.ConstanteGeneral.VALUE_VALOR,
                              Util.Constantes.ConstanteGeneral.DISPLAY_VALOR,
                              zonaBox);
            btnSalir.Enabled = true;
        }

        public void deshabilitarControles()
        {
            departBox.Enabled = false;
            muniBox.Enabled = false;
            departNacBox.Enabled = false;
            MuniNacBox.Enabled = false;
            departResBox.Enabled = false;
            ciudadResBox.Enabled = false;
        }




        private void departBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void paisNacBox_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void departNacBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (departNacBox.SelectedIndex > 0)
            {
                GeneralC.llenarCombo(Query.CARGAR_MUNICIPIO + " " + departNacBox.SelectedValue + "",
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 MuniNacBox);
                GeneralC.validarComboUbicacion(departNacBox, MuniNacBox);
            }
            else
            {
                GeneralC.llenarCombo(Query.CARGAR_MUNICIPIO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 MuniNacBox);
                GeneralC.validarComboUbicacion(departNacBox, MuniNacBox);
            }
        }

        private void paisResBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void departResBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void tBtNuevo_Click(object sender, EventArgs e)
        {

        }

        private void tBtEditar_Click(object sender, EventArgs e)
        {

        }

        private void tBtCancelar_Click(object sender, EventArgs e)
        {

        }

        public bool validarForm()
        {
            if(tipoDocBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione un tipo de documento !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tipoDocBox.Focus();
                return false;
            }else if (idText.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor digite el numero del documento identidad !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                idText.Focus();
                return false;
            }else if (paisBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el pais de expedición !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                paisBox.Focus();
                return false;
            }else if (departBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el departamento de expedición !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                departBox.Focus();
                return false;
            }else if (muniBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el municipio de expedición !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                muniBox.Focus();
                return false;
            }else if (pNombreText.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor digite el primer nombre !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pNombreText.Focus();
                return false;
            }else if (pApellidoText.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor digite el primer apellido !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pApellidoText.Focus();
                return false;
            }else if (sApellidoText.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor digite el segundo apellido !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sApellidoText.Focus();
                return false;
            }else if (sexoBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el genero !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sexoBox.Focus();
                return false;
            }else if (epsText.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor seleccione la EPS !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                epsText.Focus();
                return false;
            }else if (paisNacBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el pais de nacimiento !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                paisNacBox.Focus();
                return false;
            }else if (departNacBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el departamento de nacimiento !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                departNacBox.Focus();
                return false;
            }else if (MuniNacBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el municipio de nacimiento !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MuniNacBox.Focus();
                return false;
            }else if (regimenBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el regimen !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                regimenBox.Focus();
                return false;
            }else if (tipoAfiliacionBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el tipo de afiliación !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tipoAfiliacionBox.Focus();
                return false;
            }else if (estratoBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el estrato social !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                estratoBox.Focus();
                return false;
            }else if (zonaBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione la zona !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                zonaBox.Focus();
                return false;
            }else if (estadoCivilBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el estado civil !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                estadoCivilBox.Focus();
                return false;
            }else if (paisResBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el pais de residencia !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                paisResBox.Focus();
                return false;
            }else if (departResBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el departamento de residencia !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                departResBox.Focus();
                return false;
            }else if (ciudadResBox.SelectedIndex == 0)
            {
                MessageBox.Show("¡ Favor seleccione el municipio de residencia !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ciudadResBox.Focus();
                return false;
            }else if (direccionResText.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor digite la direccion de residencia !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                direccionResText.Focus();
                return false;
            }else if (telResText.Equals(string.Empty))
            {
                MessageBox.Show("¡ Favor digite el numero de telefono !", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                telResText.Focus();
                return false;
            }
            else
            {
                return true;
            }        
        }

        void asignarDatos()
        {
            paciente.primeroNombre = pNombreText.Text;
            paciente.segundoNombre = sNombreText.Text;
            paciente.primerApellido = pApellidoText.Text;
            paciente.segundoApellido = sApellidoText.Text;
            paciente.tipoIdentificacion = (string)tipoDocBox.SelectedValue;
            paciente.documentoIndentidad = idText.Text;
            paciente.idMunicipioExpedicion = (string)muniBox.SelectedValue;
            paciente.idMunicipioNacimiento = (string)MuniNacBox.SelectedValue;
            paciente.idMunicipioResidencia = (string)ciudadResBox.SelectedValue;
            paciente.correo = emailText.Text;
            paciente.idGenero = (string)sexoBox.SelectedValue;
            paciente.direccionResidencia = direccionResText.Text;
            paciente.telefono = telResText.Text;
            paciente.celular = celResText.Text;
            paciente.fechaNacimiento = fechaNPicker.Value;
            paciente.idRegimen = (string)regimenBox.SelectedValue;
            paciente.idTipoAfiliacion = (string)tipoAfiliacionBox.SelectedValue;
            paciente.idZonaUrbana = (string)zonaBox.SelectedValue;
            paciente.idEstadoCivil = (string)estadoCivilBox.SelectedValue;
            paciente.idestrato = (string)estratoBox.SelectedValue;
        }
        private void tBtGuardar_Click(object sender, EventArgs e)
        {

        }

        private void buscarEpsBtn_Click_1(object sender, EventArgs e)
        {

        }

        public void cargarRegistro(DataRow fila)
        {
            paciente.idEps = fila.Field<int>("idEps");
            epsText.Text = fila.Field<string>("Descripcion");
        }

        private void tBtBuscar_Click(object sender, EventArgs e)
        {

        }
        public void cargarPaciente(DataRow fila)
        {
            paciente.idPaciente = fila.Field<int>("idPaciente");
            epsText.Text = fila.Field<string>("eps");
            paciente.cargarUbicaciones();
            paciente.cargarDatos();
            tipoDocBox.SelectedValue = paciente.tipoIdentificacion;
            idText.Text = Convert.ToString(paciente.documentoIndentidad);
            GeneralC.cargarUbicacionGeografica(paciente.dtUbicacion, paciente.idMunicipioExpedicion, ref paisBox, ref departBox, ref muniBox);
            GeneralC.cargarUbicacionGeografica(paciente.dtUbicacion, paciente.idMunicipioNacimiento, ref paisNacBox, ref departNacBox, ref MuniNacBox);
            GeneralC.cargarUbicacionGeografica(paciente.dtUbicacion, paciente.idMunicipioResidencia, ref paisResBox, ref departResBox, ref ciudadResBox);
            pNombreText.Text = paciente.primeroNombre;
            sNombreText.Text = paciente.segundoNombre;
            pApellidoText.Text = paciente.primerApellido;
            sApellidoText.Text = paciente.segundoApellido;
            sexoBox.SelectedValue = paciente.idGenero;
            estratoBox.SelectedValue = paciente.idestrato;
            zonaBox.SelectedValue = paciente.idZonaUrbana;
            regimenBox.SelectedValue = paciente.idRegimen;
            tipoAfiliacionBox.SelectedValue = paciente.idTipoAfiliacion;
            estadoCivilBox.SelectedValue = paciente.idEstadoCivil;
            direccionResText.Text = paciente.direccionResidencia;
            telResText.Text = paciente.telefono;
            celResText.Text = paciente.celular;
            emailText.Text = paciente.correo;
            fechaNPicker.Value = paciente.fechaNacimiento;
            GeneralC.calcularEdad(fechaNPicker.Value, ref edad);
            edadText.Text = edad;
            tBtEditar.Enabled = true;
            tBtAnular.Enabled = true;
            deshabilitarCombo();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sApellidoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBtGuardar_Click_1(object sender, EventArgs e)
        {
            if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    asignarDatos();
                    PacienteDAL.guardar(paciente);
                    GeneralC.posGuardar(this, tstMenuPatron, tBtNuevo, tBtBuscar, tBtEditar, tBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tBtBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();

                GeneralC.buscarDevuelveFila(Query.PACIENTE_BUSCAR,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarPaciente),
                                                   Mensajes.BUSQUEDA_PACIENTE, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tBtCancelar_Click_1(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenuPatron, tBtNuevo, tBtBuscar);
            paciente.idPaciente = 0;
            btnSalir.Enabled = true;
            fechaNPicker.ResetText();
        }

        private void tBtEditar_Click_1(object sender, EventArgs e)
        {
            GeneralC.fnEditarForm(this, tstMenuPatron, tBtGuardar, tBtCancelar);
        }

        private void tBtNuevo_Click_1(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenuPatron, tBtGuardar, tBtCancelar);
            deshabilitarControles();
            paciente.idPaciente = 0;
            fechaNPicker.ResetText();
        }

        private void paisBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (paisBox.SelectedIndex > 0)
            {

                GeneralC.llenarCombo(Query.CARGAR_DEPARTAMENTO + " " + paisBox.SelectedValue + "",
                                    Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                    Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                    departBox);
                GeneralC.validarComboUbicacion(paisBox, departBox);
            }
            else
            {

                GeneralC.llenarCombo(Query.CARGAR_DEPARTAMENTO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                   Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                   Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                   departBox);
                GeneralC.validarComboUbicacion(paisBox, departBox);
            }
        }

        private void departBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (departBox.SelectedIndex > 0)
            {

                GeneralC.llenarCombo(Query.CARGAR_MUNICIPIO + " " + departBox.SelectedValue + "",
                                    Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                    Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                    muniBox);
                GeneralC.validarComboUbicacion(departBox, muniBox);
            }
            else
            {
                GeneralC.llenarCombo(Query.CARGAR_MUNICIPIO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                   Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                   Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                   muniBox);
                GeneralC.validarComboUbicacion(departBox, muniBox);
            }
        }

        private void paisNacBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (paisNacBox.SelectedIndex > 0)
            {
                GeneralC.llenarCombo(Query.CARGAR_DEPARTAMENTO + " " + paisNacBox.SelectedValue + "",
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 departNacBox);
                GeneralC.validarComboUbicacion(paisNacBox, departNacBox);
            }
            else
            {
                GeneralC.llenarCombo(Query.CARGAR_DEPARTAMENTO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 departNacBox);
                GeneralC.validarComboUbicacion(paisNacBox, departNacBox);
            }
        }

        private void departNacBox_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void departNacBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (departNacBox.SelectedIndex > 0)
            {
                GeneralC.llenarCombo(Query.CARGAR_MUNICIPIO + " " + departNacBox.SelectedValue + "",
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 MuniNacBox);
                GeneralC.validarComboUbicacion(departNacBox, MuniNacBox);
            }
            else
            {
                GeneralC.llenarCombo(Query.CARGAR_MUNICIPIO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 MuniNacBox);
                GeneralC.validarComboUbicacion(departNacBox, MuniNacBox);
            }
        }

        private void paisResBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (paisResBox.SelectedIndex > 0)
            {
                GeneralC.llenarCombo(Query.CARGAR_DEPARTAMENTO + " " + paisResBox.SelectedValue + "",
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 departResBox);
                GeneralC.validarComboUbicacion(paisResBox, departResBox);
            }
            else
            {
                GeneralC.llenarCombo(Query.CARGAR_DEPARTAMENTO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 departResBox);
                GeneralC.validarComboUbicacion(paisResBox, departResBox);
            }
        }
        public void deshabilitarCombo()
        {
            departBox.Enabled = false;
            departNacBox.Enabled = false;
            departResBox.Enabled = false;
            muniBox.Enabled = false;
            MuniNacBox.Enabled = false;
            ciudadResBox.Enabled = false;
        }
        private void departResBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (departResBox.SelectedIndex > 0)
            {
                GeneralC.llenarCombo(Query.CARGAR_MUNICIPIO + " " + departResBox.SelectedValue + "",
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 ciudadResBox);
                GeneralC.validarComboUbicacion(departResBox, ciudadResBox);
            }
            else
            {
                GeneralC.llenarCombo(Query.CARGAR_MUNICIPIO + " " + Util.Constantes.ConstanteGeneral.PREDETERMINADA + "",
                                Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                ciudadResBox);
                GeneralC.validarComboUbicacion(departResBox, ciudadResBox);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
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

        private void tBtAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    paciente.eliminar();
                    GeneralC.posAnular(this, tstMenuPatron, tBtNuevo, tBtBuscar, Mensajes.CONFIRMACION_ANULADO);
                    btnSalir.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void buscarEpsBtn_Click_2(object sender, EventArgs e)
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

        private void fechaNPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fechaNPicker_Validating(object sender, CancelEventArgs e)
        {

            GeneralC.calcularEdad(fechaNPicker.Value, ref edad);
            edadText.Text = edad;
        }

    }
}
