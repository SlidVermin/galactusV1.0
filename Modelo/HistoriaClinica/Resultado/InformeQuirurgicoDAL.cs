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
    class InformeQuirurgicoDAL
    {
        public static InformeQuirurgico guardarInformeQuirurgico(InformeQuirurgico informeQx)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = Sentencias.INFORME_QX_CREAR;
                    sentencia.Parameters.Add(new SqlParameter("@pIdInformeQX", SqlDbType.Int)).Value = informeQx.idInformeQX;
                    sentencia.Parameters.Add(new SqlParameter("@pidAtencion", SqlDbType.Int)).Value = informeQx.idAtencion;
                    sentencia.Parameters.Add(new SqlParameter("@pNota", SqlDbType.NVarChar)).Value = informeQx.notaQuirurgica;
                    sentencia.Parameters.Add(new SqlParameter("@pIdVia", SqlDbType.Int)).Value = informeQx.idVia;
                    sentencia.Parameters.Add(new SqlParameter("@pIdAyudante", SqlDbType.Int)).Value = informeQx.idAyudante;
                    sentencia.Parameters.Add(new SqlParameter("@pIdAnastesia", SqlDbType.Int)).Value = informeQx.idAnastesia;
                    sentencia.Parameters.Add(new SqlParameter("@pIdAnastesiologo", SqlDbType.Int)).Value = informeQx.idAnastesiologo;
                    sentencia.Parameters.Add(new SqlParameter("@pfechaInicio", SqlDbType.DateTime)).Value = informeQx.fechaInicio;
                    sentencia.Parameters.Add(new SqlParameter("@pfechaFin", SqlDbType.DateTime)).Value = informeQx.fechaFin;
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    informeQx.idInformeQX = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return informeQx;
        }

        public static Boolean anularInformeQuirurgico(int codigo)
        {
            Boolean resultado = false;
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Sentencias.INFORME_QX_ANULAR;
                    sentencia.Parameters.Add(new SqlParameter("@IdInfQuirurgico", SqlDbType.Int)).Value = codigo;
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
