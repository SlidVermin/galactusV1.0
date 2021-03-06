﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Util.Mensajes;
using Galactus.Entidades.HistoriaClinica.Enfermeria;
using Galactus.Util.Constantes;

namespace Galactus.VistaControlador.HistoriaClinica.Enfermeria
{
    public partial class InsumosUI : Form
    {
      public  EnfermeriaClinica enfermeria = new EnfermeriaClinica();
        public InsumosUI()
        {
            InitializeComponent();
        }

        private void InsumosUI_Load(object sender, EventArgs e)
        {
            establecerGridview();
        }
        public void establecerGridview()
        {
            enfermeria.establecerDT();
            dgvInsumos.Columns["dgId"].DataPropertyName = "Id";
            dgvInsumos.Columns["dgCodigo"].DataPropertyName = "Código";
            dgvInsumos.Columns["dgDescripcion"].DataPropertyName = "Descripcion";
            dgvInsumos.Columns["dgCantidad"].DataPropertyName = "Cantidad";
            dgvInsumos.Columns["dgAgregar"].DataPropertyName = "Agregar";
            dgvInsumos.Columns["dgQuitar"].DataPropertyName = "Quitar";

            dgvInsumos.DataSource = enfermeria.dtInsumos;
        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInsumos.Rows[dgvInsumos.CurrentCell.RowIndex].Cells["dgAgregar"].Selected == true ||
              dgvInsumos.Rows[dgvInsumos.CurrentCell.RowIndex].Cells["dgQuitar"].Selected == true)
            {
                try
                {
                    GeneralC.agregarRegistroDatagridView(buscarInsumos, verificarFila, quitarFila, dgvInsumos, dgvInsumos.Columns["dgcodigo"].Index);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void quitarFila()
        {
            dgvInsumos.Rows.RemoveAt(dgvInsumos.CurrentCell.RowIndex);
        }
        public void verificarFila()
        {
            if (string.IsNullOrEmpty(dgvInsumos.Rows[dgvInsumos.CurrentCell.RowIndex].Cells["dgcodigo"].Value.ToString()))
            {
                dgvInsumos.Rows.RemoveAt(dgvInsumos.CurrentCell.RowIndex);
            }
        }
        public void buscarInsumos()
        {
            List<string> parametros = new List<string>();

            DataTable tablaParametros = new DataTable();
            DataTable tablasSeleccionado = new DataTable();

            tablaParametros.Columns.Add("Parametro", Type.GetType("System.Object"));
            tablaParametros.Columns.Add("Valor", Type.GetType("System.Object"));

            //object[] myObjArray = { "@pIdAtencion", idAtencion };
            //object[] myObjArray1 = { "@pFiltro", "" };

            DataView view = new DataView(enfermeria.dtInsumos);

            tablasSeleccionado = view.ToTable(true, new string[] { "id" }).Copy();
            tablasSeleccionado.Rows.RemoveAt(tablasSeleccionado.Rows.Count - 1);
            object[] myObjArray2 = { "@pTblSeleccionados", tablasSeleccionado };

            //tablaParametros.Rows.Add(myObjArray);
            //tablaParametros.Rows.Add(myObjArray1);
            tablaParametros.Rows.Add(myObjArray2);

            GeneralC.buscarDevuelveFila(Sentencias.BUSCAR_INSUMOS_ENFERMERIA,
                                               parametros,
                                               new GeneralC.cargarInfoFila(cargarInsumos),
                                               Mensajes.BUQEDA_INSUMOS, true,null, tablasSeleccionado,tablaParametros);
        }
        public void cargarInsumos(DataRow filas)
        {
            dgvInsumos.Rows[dgvInsumos.CurrentCell.RowIndex].Cells["dgId"].Value = filas.Field<int>("Id");
            dgvInsumos.Rows[dgvInsumos.CurrentCell.RowIndex].Cells["dgCodigo"].Value = filas.Field<String>("Código");
            dgvInsumos.Rows[dgvInsumos.CurrentCell.RowIndex].Cells["dgDescripcion"].Value = filas.Field<String>("Descripción");

        }
    }
}
