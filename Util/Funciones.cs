using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.Util
{
    class Funciones
    {
        internal static string obtenerFechaServidor(int frmto)
        {
            string fcha;
            if (validarFormatoFecha(frmto))
            {
                fcha = ejecutarConsultaSQL("SELECT CONVERT(varchar,GETDATE()," + frmto.ToString() + ") AS Fecha", "Fecha");
                return fcha;
            }
            else
                return "0";
        }

        private static bool validarFormatoFecha(int formato)
        {
            if ((formato >= 0 && formato < 15) | (formato > 99 && formato < 115))
                return true;
            else
                return false;
        }

        public static string ejecutarConsultaSQL(string consultaSQL, string item)
        {
            string valor = String.Empty;
            try
            {
                using (var consulta = new SqlCommand(consultaSQL, PrincipalUI.Cnxion))
                {
                    using (var resultado = consulta.ExecuteReader())
                    {
                        if (resultado.HasRows)
                        {
                            resultado.Read();
                            valor = resultado[item].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        public static bool fechaValida(string fecha) {
            try
            {
                DateTime fechaEsperada;
                fechaEsperada = DateTime.Parse(fecha);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
        public static void validarValoresNumericos(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 || e.KeyChar == 44)
            {
                e.KeyChar = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


    }
}
