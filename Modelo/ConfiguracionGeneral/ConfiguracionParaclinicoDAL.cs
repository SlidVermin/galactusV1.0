using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Galactus.Entidades.ConfiguracionGeneral;
using System.Data.SqlClient;

namespace Galactus.Modelo.ConfiguracionGeneral
{
    class ConfiguracionParaclinicoDAL
    {
        public static void guardarClasificacionParaclinico(ConfiguracionParaclinico clasifParaclinico) {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = Sentencias.CLASIFICACION_PROCEDIMIENTO_CREAR;
                    sentencia.Parameters.Add(new SqlParameter("@pIdGrupo", System.Data.SqlDbType.Int)).Value = clasifParaclinico.idGrupo;
                    sentencia.Parameters.Add(new SqlParameter("@pSesion", System.Data.SqlDbType.Int)).Value = clasifParaclinico.sesion;
                    sentencia.Parameters.Add(new SqlParameter("@pTbConfig", System.Data.SqlDbType.Structured)).Value = clasifParaclinico.dtRegistro;
                    sentencia.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void guardarClasificacionExamen(ConfiguracionParaclinico clasifParaclinico)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = Sentencias.CLASIFICACION_EXAMEN_CREAR;
                    sentencia.Parameters.Add(new SqlParameter("@pIdGrupo", System.Data.SqlDbType.Int)).Value = clasifParaclinico.idTipoLaboratorio;
                    sentencia.Parameters.Add(new SqlParameter("@pSesion", System.Data.SqlDbType.Int)).Value = clasifParaclinico.sesion;
                    sentencia.Parameters.Add(new SqlParameter("@pTbConfig", System.Data.SqlDbType.Structured)).Value = clasifParaclinico.dtRegistro;
                    sentencia.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
