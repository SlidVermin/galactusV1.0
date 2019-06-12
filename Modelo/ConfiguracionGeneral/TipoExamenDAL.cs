using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Galactus.Entidades.ConfiguracionGeneral;

namespace Galactus.Modelo.ConfiguracionGeneral
{
    class TipoExamenDAL
    {
        public static TipoExamen guardarTipoExamen(TipoExamen tipoExamen)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = "";
                    sentencia.Parameters.Add(new SqlParameter("@pIdTipoExamen", SqlDbType.Int)).Value = tipoExamen.idTipoExamen;
                    sentencia.Parameters.Add(new SqlParameter("@pDescripcion", SqlDbType.NVarChar)).Value = tipoExamen.descripcion;
                    sentencia.Parameters.Add(new SqlParameter("@pAgrupable", SqlDbType.Bit)).Value = tipoExamen.ckAgrupable;
                    sentencia.Parameters.Add(new SqlParameter("@pTipo", SqlDbType.Int)).Value = tipoExamen.tipo;
                    tipoExamen.idTipoExamen = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return tipoExamen;
        }

        public static Boolean anularTipoExamen(int codigo)
        {
            Boolean resultado = false;

            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = "";
                    sentencia.Parameters.Add(new SqlParameter("@idTipoExamen", SqlDbType.Int)).Value = codigo;
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
