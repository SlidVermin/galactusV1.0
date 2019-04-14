using Galactus.Entidades.HistoriaClinica.OrdenMedica.Procedimientos;
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
    public partial class ProcedimientosUI : Form
    {
        public bool edicion = false;
        public int idAtencion { get; set; }
        public OrdenClinicaProcedimiento procedimientos { get; set; }
        public ProcedimientosUI()
        {
            InitializeComponent();
        }
        private void ProcedimientosUI_Load(object sender, EventArgs e)
        {
            inicializarForm();
        }
        void inicializarForm()
        {
        }
        public void enlazarDgv()
        {
            if (procedimientos != null)
            {
                dgvProcedimientos.AutoGenerateColumns = false;
                dgvProcedimientos.Columns["descripcion"].DataPropertyName = "descripcion";
                dgvProcedimientos.Columns["cantidad"].DataPropertyName = "cantidad";
                dgvProcedimientos.DataSource = procedimientos.tblProcedimientos;
            }
          
        }
        void cargarProcedimiento(DataRow filaResultado)
        {
            DataRowCollection filas = procedimientos.tblProcedimientos.Rows;
            int cantidad = filas.Count - 1;
            filas[cantidad]["idProcedimiento"] = filaResultado.Field<int>("IdProcedimiento");
            filas[cantidad]["cups"] = filaResultado.Field<string>("Cups");
            filas[cantidad]["descripcion"] = filaResultado.Field<string>("Descripción");
            filas.Add();
        }
        private void dgvProcedimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProcedimientos.Columns["agregar"].Index == e.ColumnIndex & edicion)
            {
                try
                {
                   List<string> parametros = new List<string>();

                    DataTable tablaParametros = new DataTable();
                    DataTable tablasSeleccionado = new DataTable();

                    tablaParametros.Columns.Add("Parametro",Type.GetType("System.Object"));
                    tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

                    object[] myObjArray = { "@idAtencion", idAtencion  };
                    object[] myObjArray1 = { "@filtro", "" };

                    DataView view = new DataView(procedimientos.tblProcedimientos);

                    tablasSeleccionado = view.ToTable(true, new string[] { "idProcedimiento" }).Copy();
                    tablasSeleccionado.Columns.Add("valor");
                    object[] myObjArray2 = { "@tabla", tablasSeleccionado };

                    tablaParametros.Rows.Add(myObjArray);
                    tablaParametros.Rows.Add(myObjArray1);
                    tablaParametros.Rows.Add(myObjArray2);

                    GeneralC.buscarDevuelveFila(Sentencias.ORDEN_CLINICA_BUSCAR_PROCEDIMIENTOS,
                                                parametros,
                                                new GeneralC.cargarInfoFila(cargarProcedimiento),
                                                Mensajes.BUSQUEDA_PROCEDIMIENTOS,
                                                true,
                                                null,
                                                tablasSeleccionado,
                                                tablaParametros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
