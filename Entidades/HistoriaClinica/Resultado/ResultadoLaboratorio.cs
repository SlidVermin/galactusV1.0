﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Galactus.Entidades.HistoriaClinica.Resultado
{
    class ResultadoLaboratorio
    {
      public int codigoSolicitud { get; set; }
      public string codigoResultado { get; set; }
      public  int codigoAtencion {get; set; }
      public DateTime fechaResultado { get; set; }
      public DateTime fechaMuestra { get; set; }
      public DataTable dtResultado { get; set; }

        public ResultadoLaboratorio() {
            dtResultado = new DataTable();
            dtResultado.Columns.Add("Codigo", Type.GetType("System.String"));
            dtResultado.Columns.Add("Descripcion", Type.GetType("System.String"));
            dtResultado.Columns.Add("Resultado", Type.GetType("System.String"));
            dtResultado.Columns.Add("Referencia", Type.GetType("System.String"));
        }
    }
}
