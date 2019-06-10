using Galactus.Entidades.Facturacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Modelo.Facturacion
{
    class FacturaPacienteDAL
    {
        public static void guardar(FacturaPaciente factura)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = PrincipalUI.Cnxion;
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = Sentencias.FACTURA_PACIENTE_CREAR;
                    comando.Parameters.Add(new SqlParameter("@IdAdmision", System.Data.SqlDbType.Int)).Value = factura.idAdmision;
                    comando.Parameters.Add(new SqlParameter("@IdContrato", System.Data.SqlDbType.Int)).Value = factura.idContrato;
                    comando.Parameters.Add(new SqlParameter("@idUsuario", System.Data.SqlDbType.Int)).Value = Sesion.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@fechaCreacion", System.Data.SqlDbType.Date)).Value = factura.fechaCreacion;
                    comando.Parameters.Add(new SqlParameter("@fechaVencimiento", System.Data.SqlDbType.Date)).Value = factura.fechaVencimiento;
                    //comando.Parameters.Add(new SqlParameter("@pTblOxigeno", System.Data.SqlDbType.Structured)).Value = factura.dtCambiosOxigeno;
                    //comando.Parameters.Add(new SqlParameter("@pTblMedicamento", System.Data.SqlDbType.Structured)).Value = factura.dtCambiosEquivalencia;
                    //comando.Parameters.Add(new SqlParameter("@pTblCUPS", System.Data.SqlDbType.Structured)).Value = factura.dtCambiosCUPS;
                    factura.codigoFactura = Convert.ToString(comando.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void eliminar(FacturaPaciente factura)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = PrincipalUI.Cnxion;
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = Sentencias.FACTURA_PACIENTE_ANULAR;
                    comando.Parameters.Add(new SqlParameter("@CodigoFactura", System.Data.SqlDbType.Int)).Value = factura.codigoFactura;
                    comando.Parameters.Add(new SqlParameter("@idUsuario", System.Data.SqlDbType.Int)).Value = Sesion.IdUsuario;
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
