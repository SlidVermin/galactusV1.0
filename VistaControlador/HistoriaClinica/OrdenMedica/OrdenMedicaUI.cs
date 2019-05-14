using Galactus.Entidades.HistoriaClinica;
using Galactus.Entidades.HistoriaClinica.OrdenMedica;
using Galactus.Modelo.HistoriaClinica;
using Galactus.Util;
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
using System.Configuration;

namespace Galactus.VistaControlador.HistoriaClinica.OrdenMedica
{
    public partial class OrdenMedicaUI : Form
    {

        private int idAtencion;
        private OrdenClinica ordenClinica = new OrdenClinica();
        private IndicacionesUI indicacionesUI = new IndicacionesUI();
        private OxigenoUI oxigenoUI = new OxigenoUI();
        private ProcedimientosUI procedimientosUI = new ProcedimientosUI();
        private MedicamentosUI medicamentosUI = new MedicamentosUI();
        private InfusionImpregnacionUI infusionImpregnacionUI = new InfusionImpregnacionUI();
        public int accionOrden;
        #region "Conctrutores"
        public OrdenMedicaUI()
        {
            InitializeComponent();
        }
        public OrdenMedicaUI(int idAtencion, bool auditoria)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            ordenClinica.idAtencion = idAtencion;
            ordenClinica.auditoria = auditoria;
            indicacionesUI.indicacion = ordenClinica.indicacion;
            procedimientosUI.idAtencion = idAtencion;
            procedimientosUI.procedimientos = ordenClinica.procedimiento;
            medicamentosUI.idAtencion = idAtencion;
            medicamentosUI.auditoria = auditoria;
            medicamentosUI.medicamentos = ordenClinica.medicamento;
            infusionImpregnacionUI.idAtencion = idAtencion;
            infusionImpregnacionUI.auditoria = auditoria;
            infusionImpregnacionUI.medicamentos = ordenClinica.medicamento;
            oxigenoUI.idAtencion = idAtencion;
            oxigenoUI.oxigeno = ordenClinica.oxigeno;
        }
        #endregion

        private void OrdenMedicaUI_Load(object sender, EventArgs e)
        {
            GeneralC.cargarFormularioEnPestana(tpIndicaciones, indicacionesUI);
            GeneralC.cargarFormularioEnPestana(tpOxigeno, oxigenoUI);
            GeneralC.cargarFormularioEnPestana(tbProcedimientos, procedimientosUI);
            GeneralC.cargarFormularioEnPestana(tpMedicamentos, medicamentosUI);
            GeneralC.cargarFormularioEnPestana(tpInfusionImpregnacion, infusionImpregnacionUI);
            GeneralC.posCargadoForm(this, tstMenuOrdenMedica, tsBtNuevo, tsBtBuscar);
        }
        #region "Botones"
        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
       
            GeneralC.formNuevo(this, tstMenuOrdenMedica, tsBtGuardar, tsBtCancelar);
            ordenClinica.nuevaOrden();
            crearOrden(ordenClinica);
            txtBCodigoOrden.ReadOnly = true;
            procedimientosUI.enlazarDgv();
            oxigenoUI.enlazarDgv();
            medicamentosUI.enlazarDgv();
            infusionImpregnacionUI.enlazarDgv();
            activarEdicion();           
        }
        void activarEdicion()
        {
            indicacionesUI.edicion = true;
            procedimientosUI.edicion = true;
            oxigenoUI.edicion = true;
            infusionImpregnacionUI.edicion = true;
            medicamentosUI.edicion = true;
        }
        void desactivarEdicion()
        {
            indicacionesUI.edicion = false;
            procedimientosUI.edicion = false;
            medicamentosUI.edicion = false;
            oxigenoUI.edicion = false;
            infusionImpregnacionUI.edicion = false;
        }

        private void tsBtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add(ordenClinica.auditoria.ToString());
                parametros.Add(ordenClinica.idAtencion.ToString());
                parametros.Add(string.Empty);
                GeneralC.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR,
                                            parametros,
                                            new GeneralC.cargarInfoFila(cargarOrdenClinica),
                                            Mensajes.BUSQUEDA_ORDENES_MEDICAS,
                                            true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tsBtModificar_Click(object sender, EventArgs e)
        {
            GeneralC.fnModificarForm(this, tstMenuOrdenMedica, tsBtGuardar, tsBtCancelar);
            txtBCodigoOrden.ReadOnly = true;
            ordenClinica.agregarFila();
            activarEdicion();
        }
        private void tsBtGuardar_Click(object sender, EventArgs e)
        {
            if (validarDatos() && Mensajes.preguntaGuardar())
            {
                try
                {
                    crearOrden(ordenClinica);
                    ordenClinica.oxigeno.prepararDT();
                    ordenClinica.medicamento.prepararDT();
                    OrdenClinicaDAL.guardarOrdenMedica(ordenClinica);
                    GeneralC.posGuardar(this, tstMenuOrdenMedica, tsBtNuevo, tsBtModificar, tsBtBuscar, tsBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    desactivarEdicion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void tsBtCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this, tstMenuOrdenMedica, tsBtNuevo, tsBtBuscar);
        }
        private void tsBtAnular_Click(object sender, EventArgs e)
        {
            if (Mensajes.preguntaAnular())
            {
                try
                {
                    OrdenClinicaDAL.anularOrdenMedica(ordenClinica);
                    
                    GeneralC.posAnular(this, tstMenuOrdenMedica, tsBtNuevo, tsBtBuscar, Mensajes.CONFIRMACION_ANULADO);
                    ordenClinica.nuevaOrden();
                    desactivarEdicion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
        #region "Metodos y Funciones"
        void crearOrden(OrdenClinica ordenClinica)
        {
            ordenClinica.fechaOrden = DateTime.Parse(dtpFecha.Text);
            medicamentosUI.fecha = ordenClinica.fechaOrden;
            infusionImpregnacionUI.fecha = ordenClinica.fechaOrden;
        }
        bool validarDatos()
        {

            if (ordenClinica.procedimiento.tblProcedimientos.Select("Cantidad = 0").Count() > 1 ||
                ordenClinica.medicamento.tblMedicamentos.Select("Dosis = 0").Count() > 1 ||
                ordenClinica.medicamento.tblInfusionImpregnacion.Select("Dosis = 0").Count() > 1)
            {
                Mensajes.mensajeAdvertencia(Mensajes.CANTIDAD_INVALIDA);
                return false;
            }
            else
            {
                return true;
            }
        }
        void cargarOrdenClinica(DataRow filaResultado)
        {
            if (filaResultado != null)
            {
                ordenClinica.idOrden = filaResultado.Field<int>("Código Orden");
                txtBCodigoOrden.Text = ordenClinica.idOrden.ToString();
                dtpFecha.Text = filaResultado.Field<DateTime>("Fecha").ToString();

                DataSet tablasResultados = new DataSet();
                List<string> Parametros = new List<string>();
                Parametros.Add(ordenClinica.auditoria.ToString());
                Parametros.Add(ordenClinica.idOrden.ToString());
                tablasResultados = GeneralC.llenarDataset(Sentencias.ORDEN_CLINICA_CARGAR, Parametros);
                if (tablasResultados.Tables.Count > 0)
                {
                    ordenClinica.indicacion.indicacion = tablasResultados.Tables[0].Rows[0].Field<string>(0);
                }
                indicacionesUI.indicacion = ordenClinica.indicacion;
                indicacionesUI.visualizarIndicacionCargada();

                oxigenoUI.oxigeno.tblOxigeno.Clear();
                oxigenoUI.oxigeno.tblOxigeno = tablasResultados.Tables["Table1"].Copy();
                oxigenoUI.enlazarDgv();

                medicamentosUI.medicamentos.tblMedicamentos.Clear();
                medicamentosUI.medicamentos.tblMedicamentos = GeneralC.copiarTablaCondicional(tablasResultados.Tables["Table2"].Copy(), "tipoMedicamento='M'");
                medicamentosUI.medicamentos.tblMedicamentos.Columns.Remove("cc/hora");
                medicamentosUI.medicamentos.tblMedicamentos.Columns.Remove("idEquivalenciaDisolvente");
                medicamentosUI.medicamentos.tblMedicamentos.Columns.Remove("Disolvente");
                medicamentosUI.medicamentos.tblMedicamentos.Columns.Remove("Cantidad");
                medicamentosUI.medicamentos.tblMedicamentos.Columns.Remove("Tipo");
                medicamentosUI.medicamentos.tblMedicamentos.Columns.Remove("Acepta disolvente");
                medicamentosUI.medicamentos.homologarHorario();                

                infusionImpregnacionUI.medicamentos.tblInfusionImpregnacion = GeneralC.copiarTablaCondicional(tablasResultados.Tables["Table2"].Copy(), "tipoMedicamento in ('In','Im')");
                infusionImpregnacionUI.medicamentos.tblMezcla = tablasResultados.Tables["Table3"].Copy();
                infusionImpregnacionUI.medicamentos.tblInfusionImpregnacion.Columns.Remove("idViaAdmon");
                infusionImpregnacionUI.medicamentos.tblInfusionImpregnacion.Columns.Remove("Via admin.");
                infusionImpregnacionUI.medicamentos.tblInfusionImpregnacion.Columns.Remove("Horario");
                infusionImpregnacionUI.medicamentos.tblInfusionImpregnacion.Columns.Add("Mezcla");

                medicamentosUI.enlazarDgv();
                infusionImpregnacionUI.enlazarDgv();

                procedimientosUI.procedimientos.tblProcedimientos.Clear();
                procedimientosUI.procedimientos.tblProcedimientos = tablasResultados.Tables["Table4"].Copy();
                procedimientosUI.enlazarDgv();
                GeneralC.posBuscar(this, tstMenuOrdenMedica, tsBtNuevo, tsBtBuscar, tsBtModificar, tsBtAnular);
            }
        }

        #endregion


    }
}
