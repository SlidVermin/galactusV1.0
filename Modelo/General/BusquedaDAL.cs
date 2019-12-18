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
            DataTable tblTemp;
            tblTemp = GeneralC.cargarResultadosSQL(query, parametros);
            return tblTemp;
        }
        public static DataTable llenarResultadoConParametros(string query,
                                                             DataTable listado)
        {
            DataTable tblTemp;
            tblTemp = GeneralC.llenarTablaConParametros(query, listado);
            return tblTemp;
        }
    }
}
