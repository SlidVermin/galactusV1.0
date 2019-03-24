using Galactus.Entidades.HistoriaClinica.OrdenMedica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Modelo.HistoriaClinica
{
    class OrdenClinicaDAL
    {
        public static void guardarOrdenMedica(OrdenClinica OrdenClinica)
        {
            try
            {
                using (System.Data.SqlClient.SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = PrincipalUI.Cnxion;
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = Sentencias.ORDEN_CLINICA_CREAR;
                    comando.Parameters.Add(new SqlParameter("@idOrdenMedica", System.Data.SqlDbType.Int)).Value = OrdenClinica.idOrden;
                    comando.Parameters.Add(new SqlParameter("@idAtencion", System.Data.SqlDbType.Int)).Value = OrdenClinica.idAtencion;
                    comando.Parameters.Add(new SqlParameter("@FechaOrden", System.Data.SqlDbType.DateTime)).Value = OrdenClinica.fechaOrden;
                    comando.Parameters.Add(new SqlParameter("@observacion", System.Data.SqlDbType.NVarChar)).Value = OrdenClinica.indicacion.indicacion;
                    comando.Parameters.Add(new SqlParameter("@IdUsuarioOrigen", System.Data.SqlDbType.Int)).Value = Sesion.IdUsuario;
                    OrdenClinica.idOrden =(int) comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
