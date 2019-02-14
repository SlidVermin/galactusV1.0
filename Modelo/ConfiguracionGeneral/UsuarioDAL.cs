using Galactus.Entidades.ConfiguracionGeneral;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Modelo.ConfiguracionGeneral
{
    class UsuarioDAL
    {
        public static void guardar(Usuario usuario)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Util.Constantes.ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspUsuarioCrear]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = usuario.idUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@pNombre", SqlDbType.NVarChar)).Value = usuario.nombre;
                    sentencia.Parameters.Add(new SqlParameter("@pNombreLogin", SqlDbType.NVarChar)).Value = usuario.usuario;
                    sentencia.Parameters.Add(new SqlParameter("@pClave", SqlDbType.NVarChar)).Value = usuario.pass;
                    sentencia.Parameters.Add(new SqlParameter("@pIdRol", SqlDbType.Int)).Value = usuario.idRol;
                    sentencia.Parameters.Add(new SqlParameter("@pUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    usuario.idUsuario = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void anular(Usuario usuario)
        {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Util.Constantes.ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspUsuarioAnular]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = usuario.idUsuario; ;
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
