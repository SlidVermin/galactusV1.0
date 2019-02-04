using Galactus.Entidades.ConfiguracionGeneral;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Modelo
{
    class EquivalenciaDAL
    {
        public static void guardar(Equivalencia equivalencia)
        {
            try
            {
                //using (SqlCommand sentencia = new SqlCommand())
                //{
                //    sentencia.Connection = PriincipalUI.Cnxion;
                //    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                //    sentencia.CommandText = Util.Constantes.ConstanteGeneral.ESQUEMA_ALMACEN + "[uspProductoCrear]";
                //    sentencia.Parameters.Add(new SqlParameter("@pIdProducto", SqlDbType.Int)).Value = objProducto.idProducto;
                //    sentencia.Parameters.Add(new SqlParameter("@pDescripcion", SqlDbType.NVarChar)).Value = objProducto.descripcion;
                //    sentencia.Parameters.Add(new SqlParameter("@pIdEquivalencia", SqlDbType.Int)).Value = objProducto.idEquivalencia;
                //    sentencia.Parameters.Add(new SqlParameter("@pIdMarca", SqlDbType.Int)).Value = objProducto.idMarca;
                //    sentencia.Parameters.Add(new SqlParameter("@pIdPresentacion", SqlDbType.Int)).Value = objProducto.idPresentacion;
                //    sentencia.Parameters.Add(new SqlParameter("@pRegistroSanitario", SqlDbType.NVarChar)).Value = objProducto.registroSanitario;
                //    sentencia.Parameters.Add(new SqlParameter("@pCodigoCUM", SqlDbType.NVarChar)).Value = objProducto.codigoCUM;
                //    sentencia.Parameters.Add(new SqlParameter("@pIva", SqlDbType.Float)).Value = objProducto.iva;
                //    sentencia.Parameters.Add(new SqlParameter("@pUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                //    objProducto.idProducto = (int)sentencia.ExecuteScalar();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void anular(Equivalencia equivalencia)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PriincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Util.Constantes.ConstanteGeneral.ESQUEMA_ALMACEN + "[uspEquivalenciaAnular]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdEquivalencia", System.Data.SqlDbType.Int)).Value = equivalencia.idEquivalencia ;
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
