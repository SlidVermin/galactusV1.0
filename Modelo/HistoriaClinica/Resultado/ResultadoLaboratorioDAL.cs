using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galactus.Entidades.HistoriaClinica.Resultado;
using System.Data.SqlClient;
using System.Data;

namespace Galactus.Modelo.HistoriaClinica.Resultado
{
    class ResultadoLaboratorioDAL
    {
        public static ResultadoLaboratorio guardarResultadoLab(ResultadoLaboratorio resultadoLab) {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Sentencias.CREAR_RESULTADO_LAB;
                    sentencia.Parameters.Add(new SqlParameter("@pIdResultado", SqlDbType.Int)).Value = resultadoLab.codigoResultado;
                    sentencia.Parameters.Add(new SqlParameter("@pIdSolicitud", SqlDbType.Int)).Value = resultadoLab.idOrdenMedica;
                    sentencia.Parameters.Add(new SqlParameter("@pFechaMuestra", SqlDbType.DateTime)).Value = resultadoLab.fechaMuestra;
                    sentencia.Parameters.Add(new SqlParameter("@pFechaResultado", SqlDbType.DateTime)).Value = resultadoLab.fechaResultado;
                    sentencia.Parameters.Add(new SqlParameter("@pObervacion", SqlDbType.NVarChar)).Value = resultadoLab.observacion;
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuarioOrigen", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@pAuditoria", SqlDbType.Int)).Value = resultadoLab.auditoria;  
                    sentencia.Parameters.Add(new SqlParameter("@pTblExamen", SqlDbType.Structured)).Value = resultadoLab.dtResultado;
                    resultadoLab.codigoResultado = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultadoLab;
        }


        public static Boolean anularResulatdoLab(int codigo,int auditoria)
        {
            Boolean resultado = false;
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Sentencias.ANULAR_RESULTADO_LAB;
                    sentencia.Parameters.Add(new SqlParameter("@pIdResultado", SqlDbType.Int)).Value = codigo;
                    sentencia.Parameters.Add(new SqlParameter("@Auditoria", SqlDbType.Int)).Value = auditoria;
                    sentencia.ExecuteNonQuery();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultado;
        }
    }
}
