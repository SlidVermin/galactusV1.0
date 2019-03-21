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
using System.IO;
using System.Text;

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
            GeneralC.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
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
                if (txtNit.Text.Equals(string.Empty))
                {
                    txtBDv.Text = string.Empty;
                }
                else
                {
                    DigitoVerificacion digitoVerificacion = new DigitoVerificacion();
                    txtBDv.Text = digitoVerificacion.calculaNit(txtNit.Text).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
            }



        }
        #endregion
        #region Botones
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            limpiarObjetoEmpresa();
            GeneralC.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
        }
        private void tstModificar_Click(object sender, EventArgs e)
        {
            GeneralC.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar);
        }
        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                asignarDatosEmpresa();
                try
                {
                    EmpresaDAL.guardar(empresa);
                    GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
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
                parametros.Add(string.Empty);
                GeneralC.buscarDevuelveFila(Query.EMPRESA_BUSCAR,
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
        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EmpresaDAL.anular(empresa);
                    GeneralC.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void tsbBuscarTercero_Click(object sender, EventArgs e)
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
            GeneralC.seleccionarImagen(picLogo);
        }
        #endregion
        #region Metodos
        public void cargarTercero(DataRow fila)
        {
            empresa.idResponsable = fila.Field<int>("Código");
            txtIdentificacionRepresentante.Text = fila.Field<string>("Nit");
            txtNombreResponsable.Text = fila.Field<string>("RazonSocial");
        }
        public void cargarEmpresa(DataRow fila)
        {
            empresa.idEmpresa = fila.Field<int>("Código");
            List<string> parametros = new List<string>();
            parametros.Add(empresa.idEmpresa.ToString());
            DataRow filaResultado = GeneralC.devuelveUnaFila(Query.EMPRESA_CARGAR, parametros);
            if (filaResultado != null)
            {
                empresa.nit = filaResultado.Field<string>("Nit");
                empresa.razonSocial = filaResultado.Field<string>("RazonSocial");
                empresa.codigoHabilitacion = filaResultado.Field<string>("CodigoHabilitacion");
                empresa.ubicacion = filaResultado.Field<int>("IdMunicipio");
                empresa.direccion = filaResultado.Field<string>("Direccion");
                empresa.telefono = filaResultado.Field<string>("Telefono");
                empresa.celular = filaResultado.Field<string>("Celular");
                empresa.email = filaResultado.Field<string>("Email");
                empresa.sigla = filaResultado.Field<string>("Sigla");
                empresa.encabezado = filaResultado.Field<string>("EncabezadoFactura");
                empresa.pie = filaResultado.Field<string>("PieFactura");
                empresa.logo = filaResultado.Field<byte[]>("Logo");
                empresa.idResponsable = filaResultado.Field<int>("IdTercero");

                txtNit.Text = empresa.nit;
                txtNombre.Text = empresa.razonSocial;
                txtCodigoHabilitacion.Text = empresa.codigoHabilitacion;
                txtDireccion.Text = empresa.direccion;
                txtTelefono.Text = empresa.telefono;
                txtCelular.Text = empresa.celular;
                txtMail.Text = empresa.email;
                txtSigla.Text = empresa.sigla;
                txtEncabezado.Text = empresa.encabezado;
                txtPie.Text = empresa.pie;
                picLogo.Image = null;
                if (empresa.logo != null)
                {
                    using (MemoryStream memSt = new MemoryStream(empresa.logo))
                    {
                        picLogo.Image = Image.FromStream(memSt);
                    }
                }

                txtIdentificacionRepresentante.Text = filaResultado.Field<string>("identificacion");
                txtNombreResponsable.Text = filaResultado.Field<string>("nombreTercero");
                cbPais.SelectedValue = filaResultado.Field<int>("IdPais");
                cbDepartamento.SelectedValue = filaResultado.Field<int>("IdDepartamento");
                cbCiudad.SelectedValue = empresa.ubicacion;
                GeneralC.posBuscar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular);
            }
        }
        void iniciarlizarForm()
        {
            GeneralC.llenarCombo(Query.CARGARPAIS,
                                 Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                 Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                 cbPais);
        }
        bool validarForm()
        {
            if (txtNit.Text.Equals(""))
            {
                GeneralC.mostrarMensajeInformacio("Debe ingresar el nit !", txtNit);
                return false;
            }
            else if (txtCodigoHabilitacion.Text.Equals(""))
            {
                GeneralC.mostrarMensajeInformacio("Debe ingresar el codigo de habilitación !", txtCodigoHabilitacion);
                return false;
            }
            else if (txtNombre.Text.Equals(""))
            {
                GeneralC.mostrarMensajeInformacio("Debe ingresar la razon social de la empresa !", txtNombre);
                return false;
            }
            else if (txtDireccion.Text.Equals(""))
            {
                GeneralC.mostrarMensajeInformacio("Debe ingresar la dirección de la empresa !", txtDireccion);
                return false;
            }
            else if (txtTelefono.Text.Equals("") && txtCelular.Text.Equals(""))
            {
                GeneralC.mostrarMensajeInformacio("Debe ingresar algún contacto para la empresa !", txtTelefono);
                return false;
            }
            else if (cbPais.SelectedValue.Equals(Util.Constantes.ConstanteGeneral.PREDETERMINADA) || cbPais.SelectedValue == null)
            {
                GeneralC.mostrarMensajeInformacio("Debe escojer el pais !", cbPais);
                return false;
            }
            else if (cbDepartamento.SelectedValue.Equals(Util.Constantes.ConstanteGeneral.PREDETERMINADA) || cbDepartamento.SelectedValue == null)
            {
                GeneralC.mostrarMensajeInformacio("Debe escojer el departamento !", cbDepartamento);
                return false;
            }
            else if (cbCiudad.SelectedValue.Equals(Util.Constantes.ConstanteGeneral.PREDETERMINADA) || cbCiudad.SelectedValue == null)
            {
                GeneralC.mostrarMensajeInformacio("Debe escojer la municipio !", cbCiudad);
                return false;
            }
            else if (txtIdentificacionRepresentante.Text.Equals(""))
            {
                GeneralC.mostrarMensajeInformacio("Debe escojer el representante de la empresa !", tsbBuscarTercero);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void asignarDatosEmpresa()
        {
            empresa.nit = txtNit.Text;
            empresa.razonSocial = txtNombre.Text;
            empresa.codigoHabilitacion = txtCodigoHabilitacion.Text;
            empresa.ubicacion = int.Parse(cbCiudad.SelectedValue.ToString());
            empresa.direccion = txtDireccion.Text;
            empresa.telefono = txtTelefono.Text;
            empresa.celular = txtCelular.Text;
            empresa.email = txtMail.Text;
            empresa.sigla = txtSigla.Text;
            empresa.encabezado = txtEncabezado.Text;
            empresa.pie = txtPie.Text;
            if (picLogo.Image != null)
            {
                using (Bitmap bmp = new Bitmap(picLogo.Image))
                {
                    using (MemoryStream memStream = new MemoryStream())
                    {
                        bmp.Save(memStream, picLogo.Image.RawFormat);
                        empresa.logo = memStream.GetBuffer();
                    }
                }
            }

        }
        void limpiarObjetoEmpresa()
        {
            empresa.idEmpresa = 0;
            empresa.nit = string.Empty;
            empresa.razonSocial = string.Empty;
            empresa.codigoHabilitacion = string.Empty;
            empresa.ubicacion = 0;
            empresa.direccion = string.Empty;
            empresa.telefono = string.Empty;
            empresa.celular = string.Empty;
            empresa.email = string.Empty;
            empresa.sigla = string.Empty;
            empresa.encabezado = string.Empty;
            empresa.pie = string.Empty;
            empresa.logo = null;
            empresa.idResponsable = 0;
        }
        #endregion

    }
}
