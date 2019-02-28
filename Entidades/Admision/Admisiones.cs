﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Galactus.Modelo.Admision;
namespace Galactus.Entidades.Admision
{
    class Admisiones
    {
        public int idAdmision { get; set; }
        public int idPaciente { get; set; }
        public DataTable dtPaciente = new DataTable();
        public string identificacion { get; set; }
        public string nombrePaciente { get; set; }
        public string regimen { get; set; }
        public string estratoSocial { get; set; }
        public string tipoAfiliacion { get; set; }
        public string nombreEPS { get; set; }
        public int idEps { get; set; }
        public int idEspecialidad { get; set; }
        public int idContrato { get; set; }
        public int idContacto { get; set; }
        public string idTriage { get; set; }
        public string identificacionAcompañante { get; set; }
        public string identificacionResponsable { get; set; }
        public string tipoDocumentoAcompañante { get; set; }
        public string tipoDocumentoResponsable { get; set; }
        public string nombreAcompañante { get; set; }
        public string nombreResponsable { get; set; }
        public string direccionAcompañante { get; set; }
        public string direccionResponsable { get; set; }
        public string idMunicipioAcompañante { get; set; }
        public string idMunicipioResponsable { get; set; }
        public string telefonoAcompañante { get; set; }
        public string telefonoResponsable { get; set; }
        public DateTime fecha { get; set; }
        public Boolean acompanante { get; set; }
        public Boolean responsable { get; set; }
        public DataSet dsDatos = new DataSet();
        public string cliente { get; set; }
        public string contacto { get; set; }
        public string especialidad { get; set; }
        public DataTable dtUbicacion = new DataTable();

        public void guardar()
        {
            AdmisionDAL.guardar(this);
        }

        public void anular()
        {
            AdmisionDAL.eliminar(this);
        }
        public void cargarPaciente()
        {
            List<string> param = new List<string>();
            param.Add(Convert.ToString(idPaciente));
            GeneralC.llenarTabla(Query.ADMISION_PACIENTE_CARGAR, param, dtPaciente);

            if (dtPaciente.Rows.Count > 0)
            {
                identificacion = dtPaciente.Rows[0].Field<string>("identificacion");
                nombrePaciente = dtPaciente.Rows[0].Field<string>("Paciente");
                regimen = dtPaciente.Rows[0].Field<string>("regimen");
                estratoSocial = dtPaciente.Rows[0].Field<string>("estratoSocial");
                tipoAfiliacion = dtPaciente.Rows[0].Field<string>("tipoAfiliacion");
                nombreEPS = dtPaciente.Rows[0].Field<string>("nombre");
                idEps = dtPaciente.Rows[0].Field<int>("idEps");
            }
        }
        public void cargarDatos()
        {
            List<string> param = new List<string>();
            param.Add(Convert.ToString(idAdmision));
            dsDatos = GeneralC.llenarDataset(Query.ADMISION_CARGAR, param);

            DataTableCollection dt = dsDatos.Tables;
            if (dt["table"].Rows.Count > 0)
            {
                idAdmision = dt["table"].Rows[0].Field<int>("idAdmision");
                idPaciente = dt["table"].Rows[0].Field<int>("idpaciente");
                idEspecialidad= dt["table"].Rows[0].Field<int>("idEspecialidad");
                idTriage =Convert.ToString(dt["table"].Rows[0].Field<int>("idtriage"));
                idContacto = dt["table"].Rows[0].Field<int>("idContacto");
                idContrato = dt["table"].Rows[0].Field<int>("idContrato");
                cliente = dt["table"].Rows[0].Field<String>("cliente");
                contacto = dt["table"].Rows[0].Field<String>("contacto");
                especialidad = dt["table"].Rows[0].Field<String>("especialidad");

            }
             if (dt["table1"].Rows.Count > 0)
            {
                tipoDocumentoAcompañante =Convert.ToString( dt["table1"].Rows[0].Field<int>("idtipodocumento"));
                identificacionAcompañante =Convert.ToString( dt["table1"].Rows[0].Field<int>("documentoIdentificacion"));
                idMunicipioAcompañante = Convert.ToString( dt["table1"].Rows[0].Field<int>("idMunicipio"));
                nombreAcompañante = dt["table1"].Rows[0].Field<String>("nombreAcompanante");
                direccionAcompañante = dt["table1"].Rows[0].Field<String>("direccion");
                telefonoAcompañante = Convert.ToString( dt["table1"].Rows[0].Field<int>("telefono"));
                acompanante = true;
            }

            if (dt["table2"].Rows.Count > 0)
            {
                tipoDocumentoResponsable =Convert.ToString( dt["table2"].Rows[0].Field<int>("idtipodocumento"));
                identificacionResponsable =Convert.ToString( dt["table2"].Rows[0].Field<int>("documentoIdentificacion"));
                idMunicipioResponsable = Convert.ToString(dt["table2"].Rows[0].Field<int>("idMunicipio"));
                nombreResponsable = dt["table2"].Rows[0].Field<String>("nombreResponsable");
                direccionResponsable = dt["table2"].Rows[0].Field<String>("direccion");
                telefonoResponsable =Convert.ToString( dt["table2"].Rows[0].Field<int>("telefono"));
                responsable = true;
            }
        }
        public void cargarUbicaciones()
        {
            List<String> paramas = new List<string>();
            GeneralC.llenarTabla(Query.UBICACION_GEOGRAFICA, paramas, dtUbicacion);
        }
    }
}
