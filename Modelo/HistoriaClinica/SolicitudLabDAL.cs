using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Galactus.Entidades.HistoriaClinica;

namespace Galactus.Modelo.HistoriaClinica
{
    class SolicitudLabDAL
    {
        public static SolicitudLab guardarSolicitudLab(SolicitudLab solicitudLab)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Sentencias.CREAR_SOLICITUD_LAB;
                    sentencia.Parameters.Add(new SqlParameter("@pIdSolicitudLab", SqlDbType.Int)).Value = solicitudLab.idSolicitud;
                    sentencia.Parameters.Add(new SqlParameter("@pIdLaboratorio", SqlDbType.Int)).Value = solicitudLab.idLaboratorio;
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@pFecha", SqlDbType.Date)).Value = solicitudLab.fecha;
                    sentencia.Parameters.Add(new SqlParameter("@pTablaLab", SqlDbType.Structured)).Value = solicitudLab.dtLaboratorio;
                    solicitudLab.idSolicitud = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return solicitudLab;
        }

        public static Boolean anularSolicitudLab(int codigo)
        {
            Boolean resultado = false;
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText =Sentencias.ANULAR_SOLICITUD_LAB;

                    sentencia.Parameters.Add(new SqlParameter("@pIdSolicitudLab", SqlDbType.Int)).Value = codigo;
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
