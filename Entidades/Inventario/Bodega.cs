using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.Inventario
{
    class Bodega
    {
        public Bodega() {

        }
        public Bodega(int codigo,string nombre)
        {
            this.idBodega = idBodega;
            this.descripcion = descripcion;
        }
        public int idBodega { get; set; }
        public string descripcion { get; set; }
    }
}
