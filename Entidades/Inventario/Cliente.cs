using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Galactus.Entidades.Inventario
{
    class Cliente
    {
        private DataTable dt = new DataTable();
        public int codigo {get;set;}
        public int codigoTercero { get; set; }
        public int codigoRegimen { get; set; }
        public int codigoUbicacion { get; set; }
        public int codigoFormaPago { get; set; }
        public string cuentaPuc { get; set; }
        public string cuentaCIIU { get; set; }
        public int diaPlazo { get; set; }
        public int diaEntrega { get; set; }
        public int diaDevolucion { get; set; }

        public Cliente () {
                dt.Columns.Add("Codigo", Type.GetType("System.Int32"));
                dt.Columns.Add("Descripcion", Type.GetType("System.String"));
            }
            
        public DataTable llenarComboUbicacion() {
            DataRow dRows;   
            dt.Clear();

            dRows = dt.NewRow();
            dRows[0] = 1;
            dRows[1] = "Nacional";
            dt.Rows.Add(dRows);

            dRows = dt.NewRow();
            dRows[0] = 2;
            dRows[1] = "Intenacional";
            dt.Rows.Add(dRows);

            return dt;
        }

        public DataTable llenarComboFormaPago()
        {
            DataRow dRows;
            dt.Clear();

            dRows = dt.NewRow();
            dRows[0] = 1;
            dRows[1] = "Credito";
            dt.Rows.Add(dRows);

            dRows = dt.NewRow();
            dRows[0] = 2;
            dRows[1] = "Contado";
            dt.Rows.Add(dRows);

            return dt;
        }

    }
}
