using System;
using Galactus.Entidades.Admision.Configuracion;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Modelo.Admision.Configuracion
{
    class ManualServicioDAL
    {
        public static ManualServicio guardarManual(ManualServicio objManualServicio) {

            return objManualServicio;
        }

        public static Boolean AnularManual(string codigo)
        {
            Boolean respuesta = false;
            return respuesta;
        }
    }
}
