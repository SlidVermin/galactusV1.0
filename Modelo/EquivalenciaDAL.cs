using Galactus.Entidades.ConfiguracionGeneral;
using System;
using System.Collections.Generic;
using System.Data;
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
            DataTable tablaLineas = new DataTable();
            DataTable tablaVias = new DataTable();
            tablaLineas = equivalencia.tablaLineas.Copy();
            tablaVias = equivalencia.tablaVias.Copy();
            GeneralC.quitarColumnaDatatable("Descripción", tablaLineas);
            GeneralC.quitarColumnaDatatable("Descripción", tablaVias);
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Util.Constantes.ConstanteGeneral.ESQUEMA_ALMACEN + "[uspEquivalenciaCrear]";
                    sentencia.Parameters.Add(new SqlParameter("@pIdEquivalencia", SqlDbType.Int)).Value = equivalencia.idEquivalencia;
                    sentencia.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar)).Value = equivalencia.descripcion;
                    sentencia.Parameters.Add(new SqlParameter("@DescripcionATC", SqlDbType.NVarChar)).Value = equivalencia.descripcionATC;
                    sentencia.Parameters.Add(new SqlParameter("@CodigoATC", SqlDbType.NVarChar)).Value = equivalencia.codigoATC;
                    sentencia.Parameters.Add(new SqlParameter("@GrupoATC", SqlDbType.NVarChar)).Value = equivalencia.grupoATC;
                    sentencia.Parameters.Add(new SqlParameter("@Concentracion", SqlDbType.Float)).Value = equivalencia.concentracion;
                    sentencia.Parameters.Add(new SqlParameter("@Osmolalidad", SqlDbType.Float)).Value = equivalencia.osmolalidad;
                    sentencia.Parameters.Add(new SqlParameter("@IdUnidad", SqlDbType.Int)).Value = equivalencia.idUnidadMedida;
                    sentencia.Parameters.Add(new SqlParameter("@Pos", SqlDbType.Bit)).Value = equivalencia.pos;
                    sentencia.Parameters.Add(new SqlParameter("@MedicamentoEspecial", SqlDbType.Bit)).Value = equivalencia.pos;
                    sentencia.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@tablaLineas", SqlDbType.Structured)).Value = tablaLineas;
                    sentencia.Parameters.Add(new SqlParameter("@tablaVias", SqlDbType.Structured)).Value = tablaVias;
                    equivalencia.idEquivalencia = (int)sentencia.ExecuteScalar();
                }
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
                    sentencia.Connection = PrincipalUI.Cnxion;
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
