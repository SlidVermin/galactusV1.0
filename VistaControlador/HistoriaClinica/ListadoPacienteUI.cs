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
using Galactus.VistaControlador.HistoriaClinica;
using Galactus.Entidades.HistoriaClinica;
using Galactus.Util.Constantes;

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class ListadoPacienteUI : Form
    {
        ListadoPaciente listaPaciente = new ListadoPaciente();
        private bool auditoria;
        public ListadoPacienteUI()
        {
            InitializeComponent();
        }

        private void ListadoPaciente_Load(object sender, EventArgs e)
        {
            auditoria = false; //esto está quemado para pruebas, siempre será HC
            listaPaciente.idMenu = Tag.ToString();
            switch (listaPaciente.idMenu)
            {
                case ConstanteGeneral.MENU_ATENCION_MEDICA:
                    lbTitulo.Text = ConstanteGeneral.TITULO_ATENCIÓN_MEDICA;
                    break;
                case ConstanteGeneral.MENU_ATENCION_ENFERMERIA:
                    lbTitulo.Text = ConstanteGeneral.TITULO_ATENCIÓN_ENFERMERIA;
                    break;
            }
            GeneralC.llenarCombo(ConsultasHistoriaClinica.ESTADO_ATENCION + " " + Util.Constantes.ConstanteGeneral.ESTADO_ATENCION + "",
                                  Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                  Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                  cbEstado);
           
            cbEstado.SelectedValue = ConstanteGeneral.ESTADO_INICIADO;
            listaPaciente.idEstadoAtencion = ConstanteGeneral.ESTADO_INICIADO;
            establecerGridview();

            
        }

        public void preCargar()
        {
            listaPaciente.listarPacientes();
            dibujarGridView();
        }

        public void dibujarGridView()
        {
            //for (int i = 0; i < dgvListaPaciente.Rows.Count; i++)
            //{
            //    dgvListaPaciente.Rows[i].Cells["dgAtencion"].Style.BackColor = Color.FromArgb(Convert.ToInt32(dgvListaPaciente.Rows[i].Cells["dgColor"].Value));
            //    dgvListaPaciente.Rows[i].Cells["dgAdmision"].Style.BackColor = Color.FromArgb(Convert.ToInt32(dgvListaPaciente.Rows[i].Cells["dgColor"].Value));

            //    dgvListaPaciente.Rows[i].Cells["dgArea"].Style.BackColor = Color.FromArgb(Convert.ToInt32(dgvListaPaciente.Rows[i].Cells["dgColor"].Value));
            //    dgvListaPaciente.Rows[i].Cells["dgEntorno"].Style.BackColor = Color.FromArgb(Convert.ToInt32(dgvListaPaciente.Rows[i].Cells["dgColor"].Value));
            //}
        }
        public void cargar()
        {           
            listaPaciente.listarPacientes();
            dgvListaPaciente.DataSource = listaPaciente.dtPaciente;
        }

        public void establecerGridview()
        {

            dgvListaPaciente.Columns["dgAtencion"].DataPropertyName = "Atencion";
            dgvListaPaciente.Columns["dgAdmision"].DataPropertyName = "Admision";
            dgvListaPaciente.Columns["dgPaciente"].DataPropertyName = "Paciente";
            dgvListaPaciente.Columns["dgFechaIngreso"].DataPropertyName = "Fecha Ingreso";
            dgvListaPaciente.Columns["dgEntorno"].DataPropertyName = "Entorno";
            dgvListaPaciente.Columns["dgArea"].DataPropertyName = "Area";
            dgvListaPaciente.Columns["dgEstancia"].DataPropertyName = "Estancia";
            dgvListaPaciente.Columns["dgEdad"].DataPropertyName = "Edad";
            dgvListaPaciente.Columns["dgGenero"].DataPropertyName = "Genero";
            dgvListaPaciente.Columns["dgCliente"].DataPropertyName = "Cliente";
            dgvListaPaciente.Columns["dgColor"].DataPropertyName = "Color";
            dgvListaPaciente.Columns["dgEgreso"].DataPropertyName = "Fecha egreso";

            cargar();
            
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dgvListaPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (listaPaciente.idMenu)
            {
                case ConstanteGeneral.MENU_ATENCION_MEDICA:
                    HistoriaClinicaUI formHistoriaClinica = new HistoriaClinicaUI();
                    formHistoriaClinica.obtenerDatosPaciente(listaPaciente,Convert.ToInt32(dgvListaPaciente.Rows[dgvListaPaciente.CurrentCell.RowIndex].Cells["dgAtencion"].Value), auditoria);
                    formHistoriaClinica.ShowDialog();
                    break;
                case ConstanteGeneral.MENU_ATENCION_ENFERMERIA:
                    FichaEnfermeriaUI formHistoriaEnfermeria = new FichaEnfermeriaUI();
                    formHistoriaEnfermeria.obtenerDatosPaciente(listaPaciente, Convert.ToInt32(dgvListaPaciente.Rows[dgvListaPaciente.CurrentCell.RowIndex].Cells["dgAtencion"].Value), auditoria);
                    formHistoriaEnfermeria.ShowDialog();
                    break;               
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();

                GeneralC.buscarDevuelveFila(ConsultasHistoriaClinica.AREA_ATENCION,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarAreas),
                                                   Mensajes.BUSQUEDA_AREA, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cargarAreas(DataRow filas)
        {
            listaPaciente.idArea = filas.Field<int>("IdArea");
            txtArea.Text = filas.Field<String>("Area");
            preCargar();
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            if (txtArea.Text.Equals(String.Empty))
            {
                cbEntorno.Enabled = false;
                btLimpiar.Visible = false;
            }else
            {
                GeneralC.llenarCombo(ConsultasHistoriaClinica.ENTORNO_ATENCION + " " + listaPaciente.idArea + "",
                             Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                             Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                             cbEntorno);
                cbEntorno.Enabled = true;
                btLimpiar.Visible = true;
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if  (cbEstado.SelectedIndex !=0)
            {
                listaPaciente.idEstadoAtencion = Convert.ToInt16( cbEstado.SelectedValue);
                preCargar();
            }
            
        }
       
        private void cbEntorno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEntorno.SelectedIndex !=0)
            {
                listaPaciente.idEntorno = Convert.ToInt16(cbEntorno.SelectedValue);
                preCargar();
            }else
            {
                listaPaciente.idEntorno = 0;
                preCargar();
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtArea.Clear();
            listaPaciente.idArea = 0;
            cbEntorno.SelectedValue = -1;
            preCargar();
        }

        private void ListadoPacienteUI_Shown(object sender, EventArgs e)
        {
            dibujarGridView();
            dgvListaPaciente.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
