using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galactus.Modelo.HistoriaClinica;
using Galactus.Entidades.HistoriaClinica;

namespace Galactus.VistaControlador.HistoriaClinica
{
    public partial class ValoracionIngresoUI : Form
    {

        
        private IngresoClinico ingreso = new IngresoClinico();
        private int idAtencion;
        
        public ValoracionIngresoUI()
        {
            InitializeComponent();
        }

        public ValoracionIngresoUI(int idAtencion)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
        }
        private void ValoracionIngresoUI_Load(object sender, EventArgs e)
        {

            cargarDatos();
        }

        public void obtenerIdAtencion(int idAtencion)
        {
            this.idAtencion = idAtencion;
        }

        private void cargarDatos()
        {
            ingreso.IdAtencion = idAtencion;
            ingreso.cargarDatosAtencion();
            txtAutorizacion.Text = ingreso.numeroAutorizacion;
            txtcama.Text = ingreso.cama;
            txtcausaexterna.Text = ingreso.causaExterna;
            txtviaingreso.Text = ingreso.viaIngreso;
            txtinstitucion.Text = ingreso.institucion;
            ingreso.cargarDiagnostico();
            dgvRemision.DataSource = ingreso.dtDiagnostico;
        }
        
    }
}
