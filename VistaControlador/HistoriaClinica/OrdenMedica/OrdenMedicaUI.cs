﻿using Galactus.Entidades.HistoriaClinica;
using Galactus.Entidades.HistoriaClinica.OrdenMedica;
using Galactus.Modelo.HistoriaClinica;
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
    public partial class OrdenMedicaUI : Form
    {

        private int idAtencion;
        private OrdenClinica ordenClinica = new OrdenClinica();
        private IndicacionesUI indicaciones = new IndicacionesUI();
        private ProcedimientosUI procedimientos = new ProcedimientosUI();
        private MedicamentosUI medicamentos = new MedicamentosUI();
        #region "Conctrutores"
        public OrdenMedicaUI()
        {
            InitializeComponent();
        }
        public OrdenMedicaUI(int idAtencion)
        {
            InitializeComponent();
            this.idAtencion = idAtencion;
            ordenClinica.idAtencion = idAtencion;
            indicaciones.indicacion = ordenClinica.indicacion;
        }
        #endregion

        private void OrdenMedicaUI_Load(object sender, EventArgs e)
        {
            GeneralC.cargarFormularioEnPestana(tpIndicaciones, indicaciones);
            GeneralC.cargarFormularioEnPestana(tbProcedimientos, procedimientos);
            GeneralC.cargarFormularioEnPestana(tpMedicamentos, medicamentos);
            GeneralC.posCargadoForm(this, tstMenuOrdenMedica, tsBtNuevo, tsBtBuscar);
        }
        #region "Botones"
        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
            ordenClinica.nuevaOrden();
            GeneralC.formNuevo(this, tstMenuOrdenMedica, tsBtGuardar, tsBtCancelar);
        }
        private void tsBtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> parametros = new List<string>();
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
        }
        private void tsBtGuardar_Click(object sender, EventArgs e)
        {
            if (validarDatos() && Mensajes.preguntaGuardar())
            {
                try
                {
                    crearOrden(ordenClinica);
                    OrdenClinicaDAL.guardarOrdenMedica(ordenClinica);
                    GeneralC.posGuardar(this, tstMenuOrdenMedica, tsBtNuevo, tsBtModificar, tsBtBuscar, tsBtAnular, null, Mensajes.CONFIRMACION_GUARDADO);

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
            ordenClinica.fechaOrden = DateTime.Now;
        }
        bool validarDatos()
        {
            if (String.IsNullOrWhiteSpace(ordenClinica.indicacion.indicacion))
            {
                Mensajes.mensajeFaltaInformacion("Debe colocar Una indicacion!");
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
                tstTxtCodigoOrden.Text = filaResultado.Field<int>("Código Orden").ToString();
                maskedTextBox1.Text = filaResultado.Field<DateTime>("Fecha").ToString();
            }
        }


        #endregion


    }
}
