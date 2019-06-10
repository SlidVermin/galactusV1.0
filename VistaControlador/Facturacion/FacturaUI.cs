using Galactus.Entidades.Facturacion;
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

namespace Galactus.VistaControlador
{
    public partial class FacturaUI : Form
    {
        FacturaPaciente factura = new FacturaPaciente();
        public FacturaUI()
        {
            InitializeComponent();
        }

        private void btBuscarContrato_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                GeneralC.buscarDevuelveFila(Sentencias.FACTURA_PACIENTE_BUSCAR_CONTRATO,
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
            txtCodigoContrato.Text = Convert.ToString(fila.Field<int>("Código"));
            txtDocumento.Text = fila.Field<String>("NIT");
            txtNombre.Text = fila.Field<String>("Cliente");
            txtTarifa.Text = fila.Field<String>("Tarifa");
            txtListaPrecio.Text = fila.Field<String>("ListaPrecio");
            factura.idContrato = fila.Field<int>("Código");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btBuscarAtencion_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                GeneralC.buscarDevuelveFila(Sentencias.FACTURA_PACIENTE_CARGAR_ADMISION,
                                                   parametros,
                                                   new GeneralC.cargarInfoFila(cargarAdmision),
                                                   Mensajes.BUSQUEDA_ADMISIONES, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cargarAdmision(DataRow fila)
        {
            txtCodigoContrato.Text = Convert.ToString(fila.Field<int>("IdAdmision"));
            txtPaciente.Text = fila.Field<String>("Paciente");
            dtpIngreso.Value = Convert.ToDateTime(fila.Field<String>("ingreso"));
            dtpEgreso.Value = Convert.ToDateTime(fila.Field<String>("egreso"));
            txtAfiliacion.Text = fila.Field<String>("afiliacion");
            txtRegimen.Text = fila.Field<String>("regimen");
            factura.idAdmision = fila.Field<int>("IdAdmision");
            factura.cargarDatos(); 
        }
    }
}
