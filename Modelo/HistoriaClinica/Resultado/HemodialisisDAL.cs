using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Galactus.Entidades.HistoriaClinica.Resultado;
using System.Data;

namespace Galactus.Modelo.HistoriaClinica.Resultado
{
    class HemodialisisDAL
    {
        public static Hemodialisis guardarHemodialisis(Hemodialisis hemodialisis)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = Sentencias.CREAR_HEMODIALISIS;
                    sentencia.Parameters.Add(new SqlParameter("@pIdHemodialisis", SqlDbType.Int)).Value = hemodialisis.idHemodialisis;
                    sentencia.Parameters.Add(new SqlParameter("@pIdOrdenMedica", SqlDbType.Int)).Value = hemodialisis.idOrdenMedica;
                    sentencia.Parameters.Add(new SqlParameter("@pIdProcedimiento", SqlDbType.Int)).Value = hemodialisis.idProcedimiento;
                    sentencia.Parameters.Add(new SqlParameter("@pNota", SqlDbType.NVarChar)).Value = hemodialisis.nota;
                    sentencia.Parameters.Add(new SqlParameter("@pNotaSigno", SqlDbType.NVarChar)).Value = hemodialisis.notaSigno;
                    sentencia.Parameters.Add(new SqlParameter("@pFecha", SqlDbType.DateTime)).Value = hemodialisis.fecha;
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@pAuditoria", SqlDbType.Int)).Value = hemodialisis.auditoria;
                    hemodialisis.idHemodialisis = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return hemodialisis;
        }

        public static Boolean anularHemodialisis(int codigo,int auditoria)
        {
            Boolean resultado = false;
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Sentencias.ANULAR_HEMODIALISIS;

                    sentencia.Parameters.Add(new SqlParameter("@pIdHemodialisis", SqlDbType.Int)).Value = codigo;
                    sentencia.Parameters.Add(new SqlParameter("@pAuditoria", SqlDbType.Int)).Value = auditoria;
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
