﻿using Galactus.Entidades.ConfiguracionGeneral;
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
            GeneralC.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
        }
        #region Botones
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
            cargarLineas();
            cargarVias();
            enlazarGrillas();
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
                asignarDatosEquivalencia();
                try
                {
                    EquivalenciaDAL.guardar(equivalencia);
                    GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    txtBCodigo.Text = equivalencia.idEquivalencia.ToString();
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
                parametros.Add("");
                GeneralC.buscarDevuelveFila(Sentencias.EQUIVALENCIA_BUSCAR,
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
        private void tsbAnular_Click(object sender, EventArgs e)
        {
            if (verificarExistenciaProductosenlazados() && MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EquivalenciaDAL.anular(equivalencia);
                    GeneralC.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        #endregion
        #region Metodos y funciones
        private bool verificarExistenciaProductosenlazados()
        {
            if (dgvProductos.RowCount == 0)
            {
                return true;
            }
            MessageBox.Show("La equivalencia no se puede anular por que tiene productos asociados !", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        private void cargarLineas()
        {
            List<string> listaParametros =new List<string>();
            listaParametros.Add(Util.Constantes.ConstanteGeneral.LINEA.ToString());
            listaParametros.Add("");
            equivalencia.tablaLineas = GeneralC.cargarResultadosSQL(Sentencias.PARAMETROS_LISTAR_DOCUMENTOS, listaParametros);
        }
        private void cargarVias()
        {
            List<string> listaParametros = new List<string>();
            listaParametros.Add(Util.Constantes.ConstanteGeneral.VIAS_ADMINISTRACION.ToString());
            listaParametros.Add("");
            equivalencia.tablaVias = GeneralC.cargarResultadosSQL(Sentencias.PARAMETROS_LISTAR_DOCUMENTOS, listaParametros);
        }
        void cargarUnidad(DataRow fila)
        {
            equivalencia.idUnidadMedida = fila.Field<int>("Código");
            txtBUnidadMedida.Text = fila.Field<string>("Descripción");
        }
        private void cargarEquivalencia(DataRow fila)
        {
            equivalencia.idEquivalencia = fila.Field<int>("Código");
            List<string> listaParametros = new List<string>();
            listaParametros.Add(equivalencia.idEquivalencia.ToString());

            DataSet tablasResultado = new DataSet();
            try
            {
                tablasResultado = GeneralC.llenarDataset(Sentencias.EQUIVALENCIA_CARGAR, listaParametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            if (tablasResultado != null)
            {
                DataRow filaResultado = tablasResultado.Tables[0].Rows[0];

                equivalencia.descripcion = filaResultado.Field<string>("Nombre");
                equivalencia.osmolalidad = (double)filaResultado.Field<decimal>("Osmolalidad");
                equivalencia.descripcionATC = filaResultado.Field<string>("DescripcionATC");
                equivalencia.codigoATC = filaResultado.Field<string>("CodigoATC");
                equivalencia.grupoATC = filaResultado.Field<string>("GrupoATC");
                equivalencia.concentracion = (double)filaResultado.Field<decimal>("Concentracion");
                equivalencia.idUnidadMedida = filaResultado.Field<Nullable<int>>("idUnidad");
                equivalencia.pos = filaResultado.Field<bool>("pos");
                equivalencia.medicamentoEspecial = filaResultado.Field<bool>("MedicamentoEspecial");
                txtBUnidadMedida.Text = filaResultado.Field<string>("Valor");

                txtBCodigo.Text = equivalencia.idEquivalencia.ToString();
                txtDescripcion.Text = equivalencia.descripcion;
                txtCodigoATC.Text = equivalencia.codigoATC;
                cbGrupoATC.SelectedItem = equivalencia.grupoATC;
                txtDescripcionATC.Text = equivalencia.descripcionATC;
                numConce.Value = (decimal)equivalencia.concentracion;
                chkPos.Checked = equivalencia.pos;
                chkMedicamentoControl.Checked = equivalencia.medicamentoEspecial;

                equivalencia.tablaLineas.Clear();
                equivalencia.tablaVias.Clear();

                equivalencia.tablaLineas = tablasResultado.Tables[1].Copy();
                equivalencia.tablaVias = tablasResultado.Tables[2].Copy();
                equivalencia.tablaProductos = tablasResultado.Tables[3].Copy();
                enlazarGrillas();

                GeneralC.posBuscar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular);
            }
        }
        private void tsbBuscarUnidades_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(ConstanteGeneral.UNIDADES_DE_MEDIDA.ToString());
                parametros.Add("");
                GeneralC.listarDocumentosGenerales(Sentencias.PARAMETROS_LISTAR_DOCUMENTOS,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarUnidad),
                                                   Mensajes.BUSQUEDA_UNIDAD_MEDIDA);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool validarForm()
        {
            dgvLineas.EndEdit();
            dgvLineas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dgvVias.EndEdit();
            dgvVias.CommitEdit(DataGridViewDataErrorContexts.Commit);

            equivalencia.tablaLineas.AcceptChanges();
            equivalencia.tablaVias.AcceptChanges();

            if (txtDescripcion.Text.Equals(""))
            {
                GeneralC.mostrarMensajeInformacio("Debe ingresar la descripción !", txtDescripcion);
                return false;
            }
            else if (txtBUnidadMedida.Text.Equals(""))
            {
                GeneralC.mostrarMensajeInformacio("Debe escoger la unidad !", tsbBuscarUnidades);
                return false;
            }
            else if (cbGrupoATC.SelectedIndex == 0)
            {
                GeneralC.mostrarMensajeInformacio("Debe escoger el grupo ATC !", cbGrupoATC);
                return false;
            }
            else if (equivalencia.tablaLineas.Select("Verificar = True").Count() == 0)
            {
                GeneralC.mostrarMensajeInformacio("Debe seleccionar por lo menos una linea !", dgvLineas);
                return false;
            }
            else
            {
                return true;
            }
        }
        void enlazarGrillas()
        {


            dgvLineas.Columns["CódigoL"].DataPropertyName = "Código";
            dgvLineas.Columns["DescripciónL"].DataPropertyName = "Descripción";
            dgvLineas.Columns["VerificarL"].DataPropertyName = "Verificar";

            dgvVias.Columns["Código"].DataPropertyName = "Código";
            dgvVias.Columns["Descripción"].DataPropertyName = "Descripción";
            dgvVias.Columns["Verificar"].DataPropertyName = "Verificar";


            dgvLineas.AutoGenerateColumns = false;
            dgvVias.AutoGenerateColumns = false;

            dgvLineas.DataSource = equivalencia.tablaLineas;
            dgvVias.DataSource = equivalencia.tablaVias;
            dgvProductos.DataSource = equivalencia.tablaProductos;

        }
        void asignarDatosEquivalencia()
        {
            equivalencia.idEquivalencia = (txtBCodigo.Text.Equals(String.Empty) ? 0 : int.Parse(txtBCodigo.Text));
            equivalencia.descripcion = txtDescripcion.Text;
            equivalencia.concentracion = (double)numConce.Value;
            equivalencia.osmolalidad = (double)numOsmolalidad.Value;
            equivalencia.codigoATC = txtCodigoATC.Text;
            equivalencia.descripcionATC = txtDescripcionATC.Text;
            equivalencia.grupoATC = cbGrupoATC.SelectedItem.ToString();
            equivalencia.pos = chkPos.Checked;
            equivalencia.medicamentoEspecial = chkMedicamentoControl.Checked;
        }
        #endregion

    }
}
