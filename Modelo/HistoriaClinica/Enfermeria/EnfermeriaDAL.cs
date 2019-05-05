using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Galactus.Entidades.HistoriaClinica.Enfermeria;
using Galactus.Util.Constantes;

namespace Galactus.Modelo.HistoriaClinica.Enfermeria
{
    class EnfermeriaDAL
    {
        public static void  guardarInsumos(EnfermeriaClinica enfermeria)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = PrincipalUI.Cnxion;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = Sentencias.CREAR_INSUMOS_ENFERMERIA;
                    comando.Parameters.Add(new SqlParameter("@idOrden", SqlDbType.Int)).Value = enfermeria.idInsumo;
                    comando.Parameters.Add(new SqlParameter("@idAtencion", SqlDbType.Int)).Value = enfermeria.idAtencion;
                    comando.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.NVarChar)).Value = ConstanteGeneral.ENFERMERIA_INSUMOS;
                    comando.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime)).Value = enfermeria.fecha;
                    comando.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@tblInsumos", SqlDbType.Structured)).Value = enfermeria.dtInsumosCopia;
                    comando.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void guardarGlucometria(EnfermeriaClinica enfermeria)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = PrincipalUI.Cnxion;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = Sentencias.CREAR_GLUCOMETRIA_ENFERMERIA;
                    comando.Parameters.Add(new SqlParameter("@idOrdenMedica", SqlDbType.Int)).Value = enfermeria.idOrdenMedica;
                    comando.Parameters.Add(new SqlParameter("@tblGlucometria", SqlDbType.Structured)).Value = enfermeria.dtGlucometriaCopia;
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
