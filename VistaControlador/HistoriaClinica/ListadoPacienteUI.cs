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
        public ListadoPacienteUI()
        {
            InitializeComponent();
        }

        private void ListadoPaciente_Load(object sender, EventArgs e)
        {
            listaPaciente.idMenu = Tag.ToString();
            GeneralC.llenarCombo(ConsultasHistoriaClinica.ESTADO_ATENCION + " " + Util.Constantes.ConstanteGeneral.ESTADO_ATENCION + "",
                                  Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                  Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                  cbEstado);
           
            cbEstado.SelectedValue = ConstanteGeneral.ESTADO_INICIADO;
           
            establecerGridview();
            
        }

        public void preCargar()
        {
            listaPaciente.listarPacientes();
            for (int i = 0; i < dgvListaPaciente.Rows.Count; i++)
            {
                dgvListaPaciente.Rows[i].Cells["dgAtencion"].Style.BackColor = Color.FromArgb(Convert.ToInt32(dgvListaPaciente.Rows[i].Cells["dgColor"].Value));
                dgvListaPaciente.Rows[i].Cells["dgAdmision"].Style.BackColor = Color.FromArgb(Convert.ToInt32(dgvListaPaciente.Rows[i].Cells["dgColor"].Value));
            }
        }
        public void cargar()
        {
            listaPaciente.idEstadoAtencion = ConstanteGeneral.ESTADO_INICIADO;
           
            listaPaciente.listarPacientes();
            dgvListaPaciente.DataSource = listaPaciente.dtPaciente;

            for (int i = 0; i < dgvListaPaciente.Rows.Count ; i++)
            {
                dgvListaPaciente.Rows[i].Cells["dgAtencion"].Style.BackColor = Color.FromArgb(Convert.ToInt32( dgvListaPaciente.Rows[i].Cells["dgColor"].Value));
                dgvListaPaciente.Rows[i].Cells["dgAdmision"].Style.BackColor = Color.FromArgb(Convert.ToInt32(dgvListaPaciente.Rows[i].Cells["dgColor"].Value));
            }
        }
        public void establecerGridview()
        {
           
            dgvListaPaciente.Columns["dgAtencion"].DataPropertyName = "Atencion";
            dgvListaPaciente.Columns["dgAdmision"].DataPropertyName = "Admision";
            dgvListaPaciente.Columns["dgPaciente"].DataPropertyName = "Paciente";
            dgvListaPaciente.Columns["dgFechaIngreso"].DataPropertyName = "FechaIngreso";
            dgvListaPaciente.Columns["dgEntorno"].DataPropertyName = "Entorno";
            dgvListaPaciente.Columns["dgArea"].DataPropertyName = "Area";
            dgvListaPaciente.Columns["dgEstancia"].DataPropertyName = "Estancia";
            dgvListaPaciente.Columns["dgEdad"].DataPropertyName = "Edad";
            dgvListaPaciente.Columns["dgGenero"].DataPropertyName = "Genero";
            dgvListaPaciente.Columns["dgEps"].DataPropertyName = "EPS";
            dgvListaPaciente.Columns["dgColor"].DataPropertyName = "Color";
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
            HistoriaClinicaUI formHistoriaClinica = new HistoriaClinicaUI();
            formHistoriaClinica.ShowDialog();
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
            }else
            {
                GeneralC.llenarCombo(ConsultasHistoriaClinica.ENTORNO_ATENCION + " " + listaPaciente.idArea + "",
                             Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                             Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                             cbEntorno);
                cbEntorno.Enabled = true;
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if  (! cbEstado.ValueMember.ToString().Equals(String.Empty))
            {
                listaPaciente.idEstadoAtencion = Convert.ToInt16( cbEstado.SelectedValue);
                preCargar();
            }
            
        }
       
        private void cbEntorno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbEntorno.ValueMember.ToString().Equals(String.Empty))
            {
                listaPaciente.idEntorno = Convert.ToInt16(cbEntorno.SelectedValue);
                preCargar();
            }
        }
    }
}
