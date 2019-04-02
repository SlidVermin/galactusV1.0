using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Galactus.Entidades.HistoriaClinica.Evolucion;

namespace Galactus.Modelo.HistoriaClinica
{
    class EvolucionMedicaDAL
    {
        public static void guardarEvolucion(Evolucion evolucionMedica)
        {
            try
            {
                using (System.Data.SqlClient.SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = PrincipalUI.Cnxion;
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = Sentencias.CREAR_EVOLUCION_MEDICA;
                    comando.Parameters.Add(new SqlParameter("@IdAtencion", System.Data.SqlDbType.Int)).Value = evolucionMedica.IdAtencion;
                    comando.Parameters.Add(new SqlParameter("@IdEvolucion", System.Data.SqlDbType.Int)).Value = evolucionMedica.idEvolucion;
                    comando.Parameters.Add(new SqlParameter("@Fecha", System.Data.SqlDbType.DateTime)).Value = evolucionMedica.fechaEvolucion;
                    comando.Parameters.Add(new SqlParameter("@Subjetivos", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Subjetivos;
                    comando.Parameters.Add(new SqlParameter("@Generales", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Generales;
                    comando.Parameters.Add(new SqlParameter("@SignosVitales", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.SignosVitales;
                    comando.Parameters.Add(new SqlParameter("@GenitoUrinario", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.GenitalUrinario;
                    comando.Parameters.Add(new SqlParameter("@Torax", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Torax;
                    comando.Parameters.Add(new SqlParameter("@SistemaNervioso", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.SistemaNervioso;
                    comando.Parameters.Add(new SqlParameter("@Abdomen", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Abdomen;
                    comando.Parameters.Add(new SqlParameter("@PielFanera", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.PielFanera;
                    comando.Parameters.Add(new SqlParameter("@Extremidades", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Extremidades;
                    comando.Parameters.Add(new SqlParameter("@CabezaCuello", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.CabezaCuello;
                    comando.Parameters.Add(new SqlParameter("@CardioPulmonar", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.CardioPulmonar;
                    comando.Parameters.Add(new SqlParameter("@Analisis", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Analisis;
                    comando.Parameters.Add(new SqlParameter("@Plan", System.Data.SqlDbType.NVarChar)).Value = evolucionMedica.Plan;
                    comando.Parameters.Add(new SqlParameter("@idUsuario", System.Data.SqlDbType.Int)).Value = Sesion.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@tblDiagnostico", System.Data.SqlDbType.Structured)).Value = evolucionMedica.dtAlistar;

                    evolucionMedica.idEvolucion = (int)  comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void borrarEvolucion(Evolucion evolucionMedica)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = PrincipalUI.Cnxion;
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = Sentencias.ANULAR_EVOLUCION_MEDICA;
                    comando.Parameters.Add(new SqlParameter("@idEvolucion", System.Data.SqlDbType.Int)).Value = evolucionMedica.idEvolucion;
                    comando.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void cargarDatos(Evolucion evolucionMedica)
        {
            try
            {
                List<String> list = new List<String>();
                list.Add(Convert.ToString(evolucionMedica.idEvolucion));
                evolucionMedica.dsDatos = GeneralC.llenarDataset(Sentencias.CARGAR_EVOLUCION_MEDICA, list);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
