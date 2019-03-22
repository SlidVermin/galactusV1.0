using Galactus.Entidades.HistoriaClinica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Modelo.HistoriaClinica
{
    class HistoriaClinicaDAL
    {

        public static void guardarIngreso(IngresoClinico ingreso)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = PrincipalUI.Cnxion;
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = Sentencias.PACIENTE_CREAR;
                    comando.Parameters.Add(new SqlParameter("@IdAtencion", System.Data.SqlDbType.Int)).Value = ingreso.IdAtencion;
                    comando.Parameters.Add(new SqlParameter("@Peso", System.Data.SqlDbType.NVarChar)).Value = ingreso.Peso;
                    comando.Parameters.Add(new SqlParameter("@MotivoIngreso", System.Data.SqlDbType.NVarChar)).Value = ingreso.MotivoIngreso;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesMedicos", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesMedicos;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesQuirurgicos", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesQuirurgicos;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesTransfusionales", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesTransfusionales;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesAlergicos", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesAlergicos;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesTraumaticos", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesTraumaticos;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesToxicos", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesToxicos;
                    comando.Parameters.Add(new SqlParameter("@AntecedentesFamiliares", System.Data.SqlDbType.NVarChar)).Value = ingreso.AntecedentesFamiliares;
                    comando.Parameters.Add(new SqlParameter("@RevisionSistema", System.Data.SqlDbType.NVarChar)).Value = ingreso.RevisionSistema;
                    comando.Parameters.Add(new SqlParameter("@SignosVitales", System.Data.SqlDbType.NVarChar)).Value = ingreso.SignosVitales;
                    comando.Parameters.Add(new SqlParameter("@CabezaCuello", System.Data.SqlDbType.NVarChar)).Value = ingreso.CabezaCuello;
                    comando.Parameters.Add(new SqlParameter("@Torax", System.Data.SqlDbType.NVarChar)).Value = ingreso.Torax;
                    comando.Parameters.Add(new SqlParameter("@CardioPulmonar", System.Data.SqlDbType.NVarChar)).Value = ingreso.CardioPulmonar;
                    comando.Parameters.Add(new SqlParameter("@Abdomen", System.Data.SqlDbType.NVarChar)).Value = ingreso.Abdomen;
                    comando.Parameters.Add(new SqlParameter("@GenitalUrinario", System.Data.SqlDbType.NVarChar)).Value = ingreso.GenitalUrinario;
                    comando.Parameters.Add(new SqlParameter("@Extremidades", System.Data.SqlDbType.NVarChar)).Value = ingreso.Extremidades;
                    comando.Parameters.Add(new SqlParameter("@SistemaNervioso", System.Data.SqlDbType.NVarChar)).Value = ingreso.SistemaNervioso;
                    comando.Parameters.Add(new SqlParameter("@Paraclinicos", System.Data.SqlDbType.NVarChar)).Value = ingreso.Paraclinicos;
                    comando.Parameters.Add(new SqlParameter("@Analisis", System.Data.SqlDbType.NVarChar)).Value = ingreso.Analisis;
                    comando.Parameters.Add(new SqlParameter("@Pronosticos", System.Data.SqlDbType.NVarChar)).Value = ingreso.Pronosticos;
                    comando.Parameters.Add(new SqlParameter("@IdUsuario", System.Data.SqlDbType.NVarChar)).Value = ingreso.IdUsuario;
                    comando.Parameters.Add(new SqlParameter("@IdUsuarioOrigen", System.Data.SqlDbType.NVarChar)).Value = ingreso.IdUsuarioOrigen;
                    comando.Parameters.Add(new SqlParameter("@FechaOrigen", System.Data.SqlDbType.NVarChar)).Value = ingreso.FechaOrigen;

                    comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }



    }
}
