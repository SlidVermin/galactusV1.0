using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galactus.Util.Constantes;
using Galactus.Util.Mensajes;
using System.Windows.Forms;
using Galactus.Entidades.HistoriaClinica.Configuracion;
namespace Galactus.VistaControlador.HistoriaClinica.Configuracion
{



    public partial class ConfiguracionProcedimientoMedicoUI : Form
    {
        ConfiguracionProcedimientoMedico configuracionProcedimientoMedico = new ConfiguracionProcedimientoMedico();
         public Boolean unicaVez { get; set; }
        public ConfiguracionProcedimientoMedicoUI()
        {
            InitializeComponent();
        }

        private void ConfiguracionProcedimientoMedicoUI_Load(object sender, EventArgs e)
        {
            GeneralC.deshabilitarControles(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            List<ToolStripButton> listaBotones = new List<ToolStripButton>();
            listaBotones.Add(btnGuardar);
            listaBotones.Add(btnCancelar);
            GeneralC.formNuevo(this,tstMenuPatron, btnGuardar, btnCancelar);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            GeneralC.fnEditarForm(this,  tstMenuPatron, btnGuardar, btnCancelar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GeneralC.fnCancelarForm(this,tstMenuPatron, btnNuevo, btnBuscar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralC.buscarDevuelveFila(Query.PRODUCTO_BUSCAR,
                                            parametros,
                                            new GeneralC.cargarInfoFila(cargarConfiguracionMedica),
                                            Mensajes.BUSQUEDA_PRODUCTO,
                                            true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void cargarConfiguracionMedica(DataRow fila)
        {
            configuracionProcedimientoMedico.idConfiguracion = fila.Field<int>("CodigoConfiguracion");
            List<string> listaParametros = new List<string>();
            listaParametros.Add(configuracionProcedimientoMedico.idConfiguracion.ToString());
            DataRow filaResultado = GeneralC.obtenerRegistroCompleto(Query.PRODUCTO_CARGAR, listaParametros);
            if (filaResultado != null)
            {
                configuracionProcedimientoMedico.idItem = filaResultado.Field<string>("idItem");
                configuracionProcedimientoMedico.descripcionItem = filaResultado.Field<string>("descripcionItem");
                configuracionProcedimientoMedico.idCliente = filaResultado.Field<int>("idCliente");
                configuracionProcedimientoMedico.descripcionCliente = filaResultado.Field<string>("descripcionCliente");
                configuracionProcedimientoMedico.moduloHc = filaResultado.Field<bool>("moduloHc");
                configuracionProcedimientoMedico.moduloFc = filaResultado.Field<bool>("moduloFc");
                configuracionProcedimientoMedico.noRepetible = filaResultado.Field<bool>("noRepetible");
                configuracionProcedimientoMedico.paquete = filaResultado.Field<bool>("paquete");               
                configuracionProcedimientoMedico.tipo = filaResultado.Field<string>("tipoItem");

                txtBNombreCliente.Text = filaResultado.Field<string>("nombreCliente");
                txtBCodigo.Text = configuracionProcedimientoMedico.idConfiguracion.ToString();
                txtBNombreProcedimiento.Text = configuracionProcedimientoMedico.descripcionItem;

                GeneralC.posBuscar(this, tstMenuPatron, btnNuevo, btnBuscar, btnEditar, btnAnular);
            }


        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                  
                    GeneralC.posAnular(this, tstMenuPatron, btnNuevo, btnBuscar, Mensajes.CONFIRMACION_ANULADO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
         
}
