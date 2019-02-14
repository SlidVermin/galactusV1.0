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
using Galactus.Util.Constantes;
using Galactus.Entidades.Inventario;

namespace Galactus.VistaControlador.Gestion
{
    public partial class ClienteUI : Form
    {
        private Cliente cliente;
        public ClienteUI()
        {
            InitializeComponent();
        }

        private void ClienteUI_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();
            GeneralC.deshabilitarBotones(ref TostMenu);
            GeneralC.deshabilitarControles(this);
            iniciarCombos();
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            GeneralC.deshabilitarBotones(ref TostMenu);
            GeneralC.habilitarControles(this);
            GeneralC.deshabilitarControles(pnlInformacion);
            desHabilitadoPermanentemente();
            GeneralC.limpiarControles(this);
            btnBuscarNit.Enabled = true;
            btGuardar.Enabled = true;
            btCancelar.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.EDITAR_FORM,Mensajes.NOMBRE_SOFT,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) {
                GeneralC.deshabilitarBotones(ref TostMenu);
                GeneralC.habilitarControles(this);
                GeneralC.deshabilitarControles(pnlInformacion);
                desHabilitadoPermanentemente();
                btGuardar.Enabled = true;
                btCancelar.Enabled = true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.CANCELAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneralC.deshabilitarBotones(ref TostMenu);
                GeneralC.deshabilitarControles(this);
                GeneralC.limpiarControles(this);
                btNuevo.Enabled = true;
                btBuscar.Enabled = true;
                btnSalir.Enabled = true;
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btAnular_Click(object sender, EventArgs e)
        {

        }

        #region btnSalir

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightCoral;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Control.DefaultBackColor;
        }
        #endregion

        private void desHabilitadoPermanentemente() {
            txtCuentaCIIU.ReadOnly = true;
            txtCIIU.ReadOnly = true;
            txtPUC.ReadOnly = true;
            txtCuentaPUC.ReadOnly = true;
        }
        private void iniciarCombos() {
           // GeneralC.llenarCombo("", "", "", cbRegimen);
            GeneralC.llenarComboDatosDefinidor(cliente.llenarComboFormaPago(),"Codigo", "Descripcion", cbFormaPago);
            GeneralC.llenarComboDatosDefinidor(cliente.llenarComboUbicacion(),"Codigo", "Descripcion", cbUbicacion);
        }

        private void btnBuscarNit_Click(object sender, EventArgs e)
        {

        }
    }
}
