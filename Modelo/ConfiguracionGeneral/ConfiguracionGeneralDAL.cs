using Galactus.Entidades.ConfiguracionGeneral;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Modelo.ConfiguracionGeneral
{
    class ConfiguracionGeneralDAL
    {
        public static void guardar(Entidades.ConfiguracionGeneral.ConfiguracionGeneral objConfiguracionGeneral)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Util.Constantes.ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametroGeneralCrear]";
                    sentencia.Parameters.Add(new SqlParameter("@IdDescripcionValor", System.Data.SqlDbType.Int)).Value = objConfiguracionGeneral.idDocumento;
                    sentencia.Parameters.Add(new SqlParameter("@IdDescripcion", System.Data.SqlDbType.Int)).Value = objConfiguracionGeneral.idParametro;
                    sentencia.Parameters.Add(new SqlParameter("@Valor", System.Data.SqlDbType.NVarChar)).Value = objConfiguracionGeneral.descripcionDocumento;
                    sentencia.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void anular(Entidades.ConfiguracionGeneral.ConfiguracionGeneral objConfiguracionGeneral)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Util.Constantes.ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametroGeneralAnular]";
                    sentencia.Parameters.Add(new SqlParameter("@idParametro", System.Data.SqlDbType.Int)).Value = objConfiguracionGeneral.idParametro;
                    sentencia.Parameters.Add(new SqlParameter("@idDocumento", System.Data.SqlDbType.Int)).Value = objConfiguracionGeneral.idDocumento;
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
