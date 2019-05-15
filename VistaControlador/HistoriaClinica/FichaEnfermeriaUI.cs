﻿using System;
using System.Data;
using System.Windows.Forms;
using Galactus.Util.Mensajes;
using Galactus.Entidades.HistoriaClinica;
using Galactus.Entidades.HistoriaClinica.OrdenMedica;
using Galactus.VistaControlador.HistoriaClinica.OrdenMedica;
using Galactus.VistaControlador.HistoriaClinica.Enfermeria;
using System.Collections.Generic;
using Galactus.VistaControlador.HistoriaClinica.Fisioterapia;

namespace Galactus.VistaControlador.HistoriaClinica
{

    public partial class FichaEnfermeriaUI : Form
    {
        private int idAtencion;
        private bool auditoria;
        private EnfermeriaUI enfermeria;
        private FisioterapiaUI fisioterapia;
        private SabanaEnfermeriaUI sabana;
        private HojaOxigenoUI oxigeno;
        public FichaEnfermeriaUI()
        {
            InitializeComponent();
        }

        #region btnSalir      
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion        

        private void HistoriaClinicaUI_Load(object sender, EventArgs e)
        {
            enfermeria = new EnfermeriaUI(idAtencion, auditoria);
            fisioterapia = new FisioterapiaUI(idAtencion, auditoria);
            sabana = new SabanaEnfermeriaUI(idAtencion, auditoria);
            oxigeno = new HojaOxigenoUI(idAtencion,auditoria);
            GeneralC.cargarFormularioEnPestana(tpEnfermeria, enfermeria);
            GeneralC.cargarFormularioEnPestana(tpSabana, sabana);
            GeneralC.cargarFormularioEnPestana(tpFisioterapeutas, fisioterapia);
            GeneralC.cargarFormularioEnPestana(tpOxigeno, oxigeno);
        }
        public void obtenerDatosPaciente(ListadoPaciente listaPaciente, int idIngreso, bool auditoria)
        {
            DataTable dtDatos = new DataTable();
            dtDatos = GeneralC.copiarNewDatatable(listaPaciente.dtPaciente, "Atencion", idIngreso);
            if (dtDatos.Rows.Count > 0)
            {
                txtAtencion.Text = Convert.ToString(dtDatos.Rows[0].Field<int>("Atencion"));
                txtAdmision.Text = Convert.ToString(dtDatos.Rows[0].Field<int>("Admision"));
                txtPaciente.Text = dtDatos.Rows[0].Field<String>("Paciente");
                txtEdad.Text = Convert.ToString(dtDatos.Rows[0].Field<String>("Edad"));
                tcHistoriaClinica.Text = dtDatos.Rows[0].Field<String>("EPS");
                txtEstancia.Text = Convert.ToString(dtDatos.Rows[0].Field<String>("Estancia"));
                txtSexo.Text = dtDatos.Rows[0].Field<String>("Genero");
                txtServicio.Text = dtDatos.Rows[0].Field<String>("Entorno");
                txtfechaIngreso.Text = Convert.ToString(dtDatos.Rows[0].Field<DateTime>("Fecha ingreso"));

                idAtencion = int.Parse(txtAtencion.Text);
                this.auditoria = auditoria;



            }
        }

        private void tsBtNuevo_Click(object sender, EventArgs e)
        {
          
        }

        private void tsbGuardarIngreso_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(Mensajes.SALIR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
