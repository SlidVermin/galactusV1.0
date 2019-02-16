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
    class ClienteDAL
    {
        public static Cliente guardarCliente(Cliente cliente) {
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                    sentencia.CommandText = Query.CREAR_CLIENTE;
                    sentencia.Parameters.Add(new SqlParameter("@codigo", SqlDbType.NVarChar)).Value = cliente.codigo;
                    sentencia.Parameters.Add(new SqlParameter("@codigoTercero", SqlDbType.Int)).Value = cliente.codigoTercero;
                    sentencia.Parameters.Add(new SqlParameter("@codigoRegimen", SqlDbType.Int)).Value = cliente.codigoRegimen;
                    sentencia.Parameters.Add(new SqlParameter("@codigoUbicacion", SqlDbType.Int)).Value = cliente.codigoUbicacion;
                    sentencia.Parameters.Add(new SqlParameter("@codigoFormaPago", SqlDbType.Int)).Value = cliente.codigoFormaPago;
                    sentencia.Parameters.Add(new SqlParameter("@diaEntrega", SqlDbType.Int)).Value = cliente.diaEntrega;
                    sentencia.Parameters.Add(new SqlParameter("@diaDevolucion", SqlDbType.Int)).Value = cliente.diaDevolucion;
                    sentencia.Parameters.Add(new SqlParameter("@diaPlazo", SqlDbType.Int)).Value = cliente.diaPlazo;
                    sentencia.Parameters.Add(new SqlParameter("@cuentaPuc", SqlDbType.Int)).Value = cliente.cuentaPuc;
                    sentencia.Parameters.Add(new SqlParameter("@cuentaCIIU", SqlDbType.Int)).Value = cliente.cuentaCIIU;
                    sentencia.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    cliente.codigo = (string)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cliente;
        }

        public static Boolean anularCliente(string codigo) {
            Boolean resultado=false;
            try
            {
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Query.ANULAR_CLIENTE;
                    sentencia.Parameters.Add(new SqlParameter("@IdCliente", SqlDbType.Int)).Value = codigo;
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
