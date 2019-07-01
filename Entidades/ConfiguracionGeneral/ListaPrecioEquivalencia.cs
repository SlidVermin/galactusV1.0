using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.Entidades.ConfiguracionGeneral
{
    class ListaPrecioEquivalencia
    {
        public int idLista { get; set; }
        public string nombre { get; set; }
        public DataTable tablaEquivalencia { get; set; }
        public bool activo { get; set; }
        public BindingSource tblFuente { get; set; }
        public ListaPrecioEquivalencia()
        {
            idLista = 0;
            nombre = string.Empty;
            tablaEquivalencia = new DataTable();
            tblFuente = new BindingSource();
           
        }
        public void configuracionFuente() {
            colocarColumnas();
            tblFuente.DataSource = tablaEquivalencia;
        }
        void colocarColumnas()
        {
            if ( tablaEquivalencia.Columns.Count == 0) {
                tablaEquivalencia.Columns.Add("Id");
                tablaEquivalencia.Columns.Add("Nombre");
                tablaEquivalencia.Columns.Add("Precio");
                tablaEquivalencia.Columns.Add("mostrar");
            }
        }
    }
}
