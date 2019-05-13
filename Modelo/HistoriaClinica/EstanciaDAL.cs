using Galactus.Entidades.HistoriaClinica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Modelo.HistoriaClinica
{
    class EstanciaDAL
    {
        public static void guardar(Estancia estancia)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = PrincipalUI.Cnxion;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = Sentencias.CREAR_ESTANCIA;
                    comando.Parameters.Add(new SqlParameter("@pAuditoria", SqlDbType.Int)).Value = estancia.auditoria;
                    comando.Parameters.Add(new SqlParameter("@pIdAtencion", SqlDbType.Int)).Value = estancia.idAtencion;
                    comando.Parameters.Add(new SqlParameter("@pIdUsuarioOrigen", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@pTblEstancia", SqlDbType.Structured)).Value = estancia.dtCambiosEstancia;
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
