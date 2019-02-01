using Galactus.Entidades.Inventario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Modelo.Inventario
{
    class ProductoDAL
    {
        public static void guardar(Producto objProducto)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PriincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Util.Constantes.ConstanteGeneral.ESQUEMA_INVENTARIO + "[uspProductoCrear]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdProducto", SqlDbType.Int)).Value = objProducto.idProducto;
                    sentencia.Parameters.Add(new SqlParameter("@pDescripcion", SqlDbType.NVarChar)).Value = objProducto.descripcion;
                    sentencia.Parameters.Add(new SqlParameter("@pIdEquivalencia", SqlDbType.Int)).Value = objProducto.idEquivalencia;
                    sentencia.Parameters.Add(new SqlParameter("@pIdMarca", SqlDbType.Int)).Value = objProducto.idMarca;
                    sentencia.Parameters.Add(new SqlParameter("@pIdPresentacion", SqlDbType.Int)).Value = objProducto.idPresentacion;
                    sentencia.Parameters.Add(new SqlParameter("@pRegistroSanitario", SqlDbType.NVarChar)).Value = objProducto.registroSanitario;
                    sentencia.Parameters.Add(new SqlParameter("@pCodigoCUM", SqlDbType.NVarChar)).Value = objProducto.codigoCUM;
                    sentencia.Parameters.Add(new SqlParameter("@pIva",SqlDbType.Float)).Value = objProducto.iva;
                    sentencia.Parameters.Add(new SqlParameter("@pUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    objProducto.idProducto = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void anular(Producto objProducto)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PriincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Util.Constantes.ConstanteGeneral.ESQUEMA_INVENTARIO + "[uspProductoAnular]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdProducto", SqlDbType.Int)).Value = objProducto.idProducto; ;
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
