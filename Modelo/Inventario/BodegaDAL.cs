using Galactus.Entidades.Inventario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Modelo.Inventario
{
    class BodegaDAL
    {
        public static void guardar(Bodega objBodega)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PriincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Util.Constantes.ConstanteGeneral.ESQUEMA_INVENTARIO + "[uspBodegaCrear]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdBodega", System.Data.SqlDbType.Int)).Value = objBodega.idBodega;
                    sentencia.Parameters.Add(new SqlParameter("@pIdDescripcion", System.Data.SqlDbType.NVarChar)).Value = objBodega.descripcion;
                    sentencia.Parameters.Add(new SqlParameter("@pUsuario", System.Data.SqlDbType.Int)).Value = Sesion.IdUsuario;
                    objBodega.idBodega = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void anular(Bodega objBodega)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PriincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Util.Constantes.ConstanteGeneral.ESQUEMA_INVENTARIO + "[uspBodegaAnular]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdBodega", System.Data.SqlDbType.Int)).Value = objBodega.idBodega; ;
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
