using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.ConfiguracionGeneral
{
    class Equivalencia
    {
        public int idEquivalencia { set; get; }
        public string descripcion { get; set; }
        public string codigoATC { get; set; }
        public string descripcionATC { get; set; }
        public string grupoATC { get; set; }
        public int idUnidadMedida { set; get; }
        public double concentracion { get; set; }
        public DataTable tablaVias = new DataTable();
        public DataTable tablaLineas = new DataTable();

    }
}
