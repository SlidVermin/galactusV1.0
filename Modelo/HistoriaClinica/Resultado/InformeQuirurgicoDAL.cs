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

                    sentencia.CommandText = Sentencias.CREAR_INFORME_QX;
                    sentencia.Parameters.Add(new SqlParameter("@codigo", SqlDbType.NVarChar)).Value = informeQx.codigo;
                    sentencia.Parameters.Add(new SqlParameter("@codigoAtencion", SqlDbType.Int)).Value = informeQx.codigoAtencion;
                    sentencia.Parameters.Add(new SqlParameter("@nota", SqlDbType.Int)).Value = informeQx.notaQuirurgica;
                    sentencia.Parameters.Add(new SqlParameter("@codigoVia", SqlDbType.Int)).Value = informeQx.codigoVia;
                    sentencia.Parameters.Add(new SqlParameter("@codigoAyudante", SqlDbType.Int)).Value = informeQx.codigoAyudante;
                    sentencia.Parameters.Add(new SqlParameter("@codigoAnastesia", SqlDbType.Int)).Value = informeQx.codigoAnastesia;
                    sentencia.Parameters.Add(new SqlParameter("@codigoAnastesiologo", SqlDbType.Int)).Value = informeQx.codigoAnastesiologo;
                    sentencia.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Int)).Value = informeQx.fecha;
                    sentencia.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    informeQx.codigo = (string)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return informeQx;
        }

        public static Boolean anularInformeQuirurgico(string codigo)
        {
            Boolean resultado = false;
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Sentencias.ANULAR_HEMODIALISIS;
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
