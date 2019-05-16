using Galactus.Entidades.HistoriaClinica.Enfermeria;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Modelo.HistoriaClinica
{
    class SabanaDAL
    {
        public static void guardar(ref Sabana sabana)
        {
           try
            {
                using (System.Data.SqlClient.SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = PrincipalUI.Cnxion;
                    using (SqlTransaction trans = comando.Connection.BeginTransaction())
                    {

                        comando.Transaction = trans;
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.CommandText = Sentencias.SABANA_CREAR;
                        comando.Parameters.Add(new SqlParameter("@pAuditoria", System.Data.SqlDbType.Bit)).Value = sabana.auditoria;
                        comando.Parameters.Add(new SqlParameter("@pIdSabana", System.Data.SqlDbType.Int)).Value = sabana.idSabana;
                        comando.Parameters.Add(new SqlParameter("@pIdAtencion", System.Data.SqlDbType.Int)).Value = sabana.idAtencion;
                        comando.Parameters.Add(new SqlParameter("@pFecha", System.Data.SqlDbType.DateTime)).Value = sabana.fecha;
                        comando.Parameters.Add(new SqlParameter("@pIdUsuarioOrigen", System.Data.SqlDbType.Int)).Value = Sesion.IdUsuario;
                        comando.Parameters.Add(new SqlParameter("@pTblMedicamento", System.Data.SqlDbType.Structured)).Value = sabana.dtCambiosMedicamento;
                        comando.Parameters.Add(new SqlParameter("@pTblGoteo", System.Data.SqlDbType.Structured)).Value = sabana.dtCambiosGoteo;
                        sabana.idSabana = (int)comando.ExecuteScalar();
                        try
                        {
                            trans.Commit();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
