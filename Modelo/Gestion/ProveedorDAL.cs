using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galactus.Entidades.Inventario;
using System.Data.SqlClient;
using System.Data;

namespace Galactus.Modelo.Gestion
{
    class ProveedorDAL
    {
        public static Proveedor guardarproveedor(Proveedor proveedor) {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = Query.CREAR_PROVEEDOR;
                    sentencia.Parameters.Add(new SqlParameter("@codigo", SqlDbType.NVarChar)).Value = proveedor.codigo;
                    sentencia.Parameters.Add(new SqlParameter("@codigoTercero", SqlDbType.Int)).Value = proveedor.codigoTercero;
                    sentencia.Parameters.Add(new SqlParameter("@codigoRegimen", SqlDbType.Int)).Value = proveedor.codigoRegimen;
                    sentencia.Parameters.Add(new SqlParameter("@codigoUbicacion", SqlDbType.Int)).Value = proveedor.codigoUbicacion;
                    sentencia.Parameters.Add(new SqlParameter("@codigoFormaPago", SqlDbType.Int)).Value = proveedor.codigoFormaPago;
                    sentencia.Parameters.Add(new SqlParameter("@diaEntrega", SqlDbType.Int)).Value = proveedor.diaEntrega;
                    sentencia.Parameters.Add(new SqlParameter("@diaDevolucion", SqlDbType.Int)).Value = proveedor.diaDevolucion;
                    sentencia.Parameters.Add(new SqlParameter("@diaPlazo", SqlDbType.Int)).Value = proveedor.diaPlazo;
                    sentencia.Parameters.Add(new SqlParameter("@cuentaPuc", SqlDbType.Int)).Value = proveedor.cuentaPuc;
                    sentencia.Parameters.Add(new SqlParameter("@cuentaCIIU", SqlDbType.Int)).Value = proveedor.cuentaCIIU;
                    sentencia.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@diaVencimiento", SqlDbType.Int)).Value = proveedor.diaVencimiento;
                    sentencia.Parameters.Add(new SqlParameter("@codigoBanco", SqlDbType.Int)).Value = proveedor.codigoBanco;
                    sentencia.Parameters.Add(new SqlParameter("@codigoTipoCuenta", SqlDbType.Int)).Value = proveedor.codigoTipoCuenta;
                    sentencia.Parameters.Add(new SqlParameter("@Identificacion", SqlDbType.NVarChar)).Value = proveedor.identidicacion;
                    sentencia.Parameters.Add(new SqlParameter("@cuenta", SqlDbType.NVarChar)).Value = proveedor.cuenta;
                    proveedor.codigo = (string)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return proveedor;
        }

        public static Boolean anularproveedor(string codigo) {
            Boolean resultado=false;
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Query.ANULAR_PROVEEDOR;
                    sentencia.Parameters.Add(new SqlParameter("@Idproveedor", SqlDbType.Int)).Value = codigo;
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
    }
}
