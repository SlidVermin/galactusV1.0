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
    class ListaPrecioEquivalenciaDAL
    {
        public static void guardar(ListaPrecioEquivalencia objLista)
        {
            try
            {
                DataTable tblData = new DataTable();
                tblData = objLista.tablaEquivalencia.DefaultView.ToTable(true,new string[] { "Id", "Precio", "mostrar" }).Copy();

                if (tblData.Columns.Count>0)
                {
                    tblData.Columns.Add("Activo",Type.GetType("System.Boolean"), "IIF(Precio>0,True,False)");
                }
                using (SqlCommand sentencia = new SqlCommand())
                {
                    sentencia.Connection = PrincipalUI.Cnxion;
                    sentencia.CommandType = System.Data.CommandType.StoredProcedure;
                    sentencia.CommandText = Util.Constantes.ConstanteGeneral.ESQUEMA_GENERAL + "[uspListaPrecioCrear]";
                    sentencia.Parameters.Add(new SqlParameter("@pId", SqlDbType.Int)).Value = objLista.idLista;
                    sentencia.Parameters.Add(new SqlParameter("@pNombre", SqlDbType.NVarChar)).Value = objLista.nombre;
                    sentencia.Parameters.Add(new SqlParameter("@pActivo", SqlDbType.Bit)).Value = objLista.activo;
                    sentencia.Parameters.Add(new SqlParameter("@pIdUsuario", SqlDbType.Int)).Value = Sesion.IdUsuario;
                    sentencia.Parameters.Add(new SqlParameter("@pTablaEquivalencia", SqlDbType.Structured)).Value = tblData;
                    objLista.idLista = (int)sentencia.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
