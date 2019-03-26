using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Modelo.General
{
    class BusquedaDAL
    {
        public static DataTable llenarResultado(string query,
                                                List<string> parametros)
        {
            DataTable tblTemp = new DataTable();
            GeneralC.llenarTabla(query, parametros, tblTemp);
            return tblTemp;
        }
        public static DataTable llenarResultadoConParametros(string query,
                                                             DataTable listado)
        {
            DataTable tblTemp = new DataTable();
            GeneralC.llenarTablaConParametros(query, listado, tblTemp);
            return tblTemp;
        }
    }
}
