using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Galactus.Entidades.HistoriaClinica.Resultado;

namespace Galactus.Modelo.HistoriaClinica.Resultado
{
    class EcocardiogramaDAL
    {
        public static Ecocardiograma guardarEcocardiograma(Ecocardiograma ecocardiograma)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = Sentencias.CREAR_ECOCARDIOGARMA;
                    sentencia.Parameters.Add(new SqlParameter("@pIdEco", SqlDbType.Int)).Value = ecocardiograma.idEco;
                    sentencia.Parameters.Add(new SqlParameter("@pIdOrdenMedica", SqlDbType.Int)).Value = ecocardiograma.idOrdenMedica;
                    sentencia.Parameters.Add(new SqlParameter("@pIdProcedimiento", SqlDbType.Int)).Value = ecocardiograma.idProcedimiento;
                    sentencia.Parameters.Add(new SqlParameter("@pNota", SqlDbType.NVarChar)).Value = ecocardiograma.lectura;
                    sentencia.Parameters.Add(new SqlParameter("@pFecha", SqlDbType.DateTime)).Value = ecocardiograma.fecha;
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@pAuditoria", SqlDbType.Int)).Value = ecocardiograma.auditoria;
                    sentencia.Parameters.Add(new SqlParameter("@ptbParametro", SqlDbType.Structured)).Value = extrarDatatable(ecocardiograma.dtParametro);
                    ecocardiograma.idEco = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ecocardiograma;
        }

        public static Boolean anularEcocardiograma(int codigo, int auditoria)
        {
            Boolean resultado = false;
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Sentencias.ANULAR_ECOCARDIOGRAMA;

                    sentencia.Parameters.Add(new SqlParameter("@pIdEco", SqlDbType.Int)).Value = codigo;
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
        private static DataTable extrarDatatable(DataTable dt)
        {
            DataTable dtExtraido = new DataTable();
            dtExtraido = dt.Copy();
            dtExtraido.Columns.Remove("Descripcion");
            dtExtraido.Rows.RemoveAt(dtExtraido.Rows.Count - 1);
            return dtExtraido;
        }
    }
}
