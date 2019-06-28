using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.ConfiguracionGeneral
{
    class ListaPrecioEquivalencia
    {
        public int idLista { get; set; }
        public string nombre { get; set; }
        public DataTable tablaEquivalencia { get; set; }
        public bool activo { get; set; }
        public ListaPrecioEquivalencia() {
            idLista = 0;
            nombre = string.Empty;
            tablaEquivalencia = new DataTable();
        }
    }
}
