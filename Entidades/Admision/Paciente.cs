using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Galactus.Modelo.Admision;
using System.Data;
using System.Data.SqlClient;

namespace Galactus.Entidades.Admision
{
    class Paciente
    {
#region propiedades

        
        public int idPaciente { get; set; }
        public string tipoIdentificacion { get; set; }
        public string documentoIndentidad { get; set; }
        public string idMunicipioExpedicion { get; set; }
        public string idMunicipioNacimiento { get; set; }
        public string primeroNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string idGenero { get; set; }
        public string idestrato { get; set; }
        public string idEstadoCivil { get; set; }
        public string idMunicipioResidencia { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string correo { get; set;}
        public string idRegimen { get; set; }
        public string idZonaUrbana { get; set; }
        public string idTipoAfiliacion { get; set; }
        public int idUsuario { get; set;}
        public int idEps { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string direccionResidencia { get; set; }
        public int edad { get; set; }
        public DataTable dtDatos = new DataTable();
        public DataTable dtUbicacion = new DataTable();
        public DataTable dtParametro = new DataTable();
        public DataTable dtResultado = new DataTable();
        #endregion

        public void establecerColumnas()
        {
            dtParametro.Columns.Add("idParametro", typeof(Int32));
        }
        public void cargarParametros()
        {
            SqlParameter sqlParam = new SqlParameter();
            List<SqlParameter> param = new List<SqlParameter>();
            sqlParam = new SqlParameter("@tblParametro", SqlDbType.Structured);
            sqlParam.Value = dtParametro;
            param.Add(sqlParam);
            GeneralC.llenarTablaParameter(Sentencias.PACIENTE_PARAMETROS_CARGAR, param, dtResultado);
        }
        public void cargarDatos()
        {
            List<string> paramas = new List<string>();
            paramas.Add(Convert.ToString(idPaciente));
            dtDatos = GeneralC.cargarResultadosSQL(Sentencias.PACIENTE_CARGAR, paramas);
            if (dtDatos.Rows.Count > 0)
            {
                tipoIdentificacion = Convert.ToString(dtDatos.Rows[0].Field<int>("IdTipoIdentificacion"));
                documentoIndentidad = dtDatos.Rows[0].Field<string>("documento");
                idEps =  dtDatos.Rows[0].Field<int>("IdEps");
                idMunicipioExpedicion = Convert.ToString( dtDatos.Rows[0].Field<int>("IdMunicipioExpedicion"));
                idMunicipioNacimiento =Convert.ToString( dtDatos.Rows[0].Field<int>("IdMunicipioNacimiento"));
                idMunicipioResidencia = Convert.ToString( dtDatos.Rows[0].Field<int>("IdMunicipioResidencia"));
                idRegimen = Convert.ToString(dtDatos.Rows[0].Field<int>("idregimen"));
                idTipoAfiliacion = Convert.ToString(dtDatos.Rows[0].Field<int>("idtipoafiliacion"));
                idZonaUrbana = Convert.ToString(dtDatos.Rows[0].Field<int>("idzona"));
                idestrato = Convert.ToString(dtDatos.Rows[0].Field<int>("idestratosocial"));
                idEstadoCivil= Convert.ToString(dtDatos.Rows[0].Field<int>("idestadocivil"));
                primeroNombre = dtDatos.Rows[0].Field<string>("PrimerNombre");
                segundoNombre = dtDatos.Rows[0].Field<string>("SegundoNombre");
                primerApellido = dtDatos.Rows[0].Field<string>("primerapellido");
                segundoApellido = dtDatos.Rows[0].Field<string>("segundoapellido");
                idGenero = Convert.ToString(dtDatos.Rows[0].Field<int>("idgenero"));
                fechaNacimiento = dtDatos.Rows[0].Field<DateTime>("FechaNacimiento");

                direccionResidencia = dtDatos.Rows[0].Field<string>("Direccion");
                telefono = dtDatos.Rows[0].Field<string>("Telefono");
                celular = dtDatos.Rows[0].Field<string>("Celular");
                correo = dtDatos.Rows[0].Field<string>("Correo");
              
            }

        }

        public void eliminar()
        {
            PacienteDAL.eliminarPaciente(this);
        }
        public void cargarUbicaciones()
        {
            List<String> paramas = new List<string>();
            dtUbicacion = GeneralC.cargarResultadosSQL(Sentencias.UBICACION_GEOGRAFICA, paramas);
        }
    }

}
