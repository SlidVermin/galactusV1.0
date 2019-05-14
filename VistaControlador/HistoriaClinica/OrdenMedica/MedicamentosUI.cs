using Galactus.Entidades.HistoriaClinica.OrdenMedica.Medicamentos;
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

namespace Galactus.VistaControlador.HistoriaClinica.OrdenMedica
{
    public partial class MedicamentosUI : Form
    {
        public bool edicion = false;
        public bool auditoria { get; set; }
        public int idAtencion { get; set; }
        public DateTime fecha { get; set; }
        public OrdenClinicaMedicamento medicamentos { get; set; }
        public MedicamentosUI()
        {
            InitializeComponent();
        }

        private void MedicamentosUI_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }
        void inicializarForm()
        {
            enlazarDgv();
        }
        public void enlazarDgv()
        {
            if (medicamentos != null)
            {
                dgvOrdenMedicamentos.AutoGenerateColumns = false;
                dgvOrdenMedicamentos.DataSource = medicamentos.tblMedicamentos;
            }
        }
        void cargarMedicamento(DataRow filaResultado)
        {
            DataRowCollection filas = medicamentos.tblMedicamentos.Rows;
            int cantidad = filas.Count - 1;
            filas[cantidad]["idEquivalencia"] = filaResultado.Field<int>("ID");
            filas[cantidad]["Descripción"] = filaResultado.Field<string>("Descripción");
            filas[cantidad]["Unidad"] = filaResultado.Field<string>("Unidad");
            filas[cantidad]["TipoMedicamento"] = ConstanteGeneral.MEDICAMENTO;
            filas[cantidad]["Dosis"] = 0;
            filas[cantidad]["Horario"] = ConstanteGeneral.POR_DEFINIR;
            filas[cantidad]["Hora Inicial"] = ConstanteGeneral.POR_DEFINIR;
            filas[cantidad]["Via admin."] = ConstanteGeneral.POR_DEFINIR;
            filas[cantidad]["idMedicamento"] = medicamentos.obtenerConsecutivo();
            filas.Add();
            
        }
        private void dgvOrdenMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                dgvOrdenMedicamentos.ReadOnly = true;
                if (GeneralC.verificarUbicacionCelda(e, dgvOrdenMedicamentos, "Dosis"))
                {
                    GeneralC.habilitarCeldas(e, dgvOrdenMedicamentos, "Dosis", edicion);
                }
                else if (GeneralC.verificarUbicacionCelda(e, dgvOrdenMedicamentos, "Horario"))
                {
                    GeneralC.habilitarCeldas(e, dgvOrdenMedicamentos, "Horario", edicion);
                }
                else if (GeneralC.verificarUbicacionCelda(e, dgvOrdenMedicamentos, "HoraInicial"))
                {
                    GeneralC.habilitarCeldas(e, dgvOrdenMedicamentos, "HoraInicial", edicion);
                }
                else if (GeneralC.verificarUbicacionCelda(e, dgvOrdenMedicamentos, "Suspender"))
                {
                    GeneralC.habilitarCeldas(e, dgvOrdenMedicamentos, "Suspender", edicion);
                }
                else if (edicion)
                {
                    if (GeneralC.verificarUbicacionCelda(e, dgvOrdenMedicamentos, "quitar") & e.RowIndex < dgvOrdenMedicamentos.Rows.Count - 1)
                    {
                        if (Mensajes.preguntaAnular())
                        {
                            dgvOrdenMedicamentos.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                    else if (GeneralC.verificarUbicacionCelda(e, dgvOrdenMedicamentos, "agregar") & e.RowIndex == dgvOrdenMedicamentos.Rows.Count - 1)
                    {
                        try
                        {
                            List<string> parametros = new List<string>();

                            DataTable tablaParametros = new DataTable();
                            DataTable tablasSeleccionado = new DataTable();

                            tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
                            tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

                            object[] myObjArray = { "@pAuditoria", auditoria };
                            object[] myObjArray1 = { "@pIdAtencion", idAtencion };
                            object[] myObjArray2 = { "@pFechaOrden", fecha };
                            object[] myObjArray3 = { "@pFiltro", "" };

                            DataView view = new DataView(medicamentos.tblMedicamentos);

                            tablasSeleccionado = view.ToTable(true, new string[] { "idMedicamento" }).Copy();
                            tablasSeleccionado.Rows.RemoveAt(tablasSeleccionado.Rows.Count - 1);
                            object[] myObjArray4 = { "@pTblSeleccionados", tablasSeleccionado };

                            tablaParametros.Rows.Add(myObjArray);
                            tablaParametros.Rows.Add(myObjArray1);
                            tablaParametros.Rows.Add(myObjArray2);
                            tablaParametros.Rows.Add(myObjArray3);
                            tablaParametros.Rows.Add(myObjArray4);

                            GeneralC.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR_MEDICAMENTOS,
                                                        parametros,
                                                        new GeneralC.cargarInfoFila(cargarMedicamento),
                                                        Mensajes.BUSQUEDA_EQUIVALENCIA,
                                                        true,
                                                        null,
                                                        tablasSeleccionado,
                                                        tablaParametros);
                        }
                        catch (Exception ex)
                        {
                            Mensajes.mensajeError(ex);
                        }
                    }
                }
            }
        }

        private void dgvOrdenMedicamentos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgvOrdenMedicamentos.CancelEdit();
            Mensajes.mensajeInformacion(Mensajes.CANTIDAD_INVALIDA);
        }
    }
}
