﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.Entidades.ConfiguracionGeneral
{
    class ConfiguracionGeneral
    {
        public int idParametro { get; set; }
        public int idDocumento { get; set; }
        public string descripcionDocumento { get; set; }
        public DataTable tablaDocumentos { get; set; }
        public BindingSource enlace;
        public ConfiguracionGeneral()
        {
            tablaDocumentos = new DataTable();
            tablaDocumentos.Columns.Add("Código", Type.GetType("System.Int32"));
            tablaDocumentos.Columns.Add("Descripción", Type.GetType("System.String"));

            enlace = new BindingSource();
            
        }
        public void llenarDocumentos()
        {
            try
            {
                List<string> listaParametros = new List<string>();
                listaParametros.Add(idParametro.ToString());
                GeneralC.llenarTabla(Query.PARAMETROS_CARGAR_DOCUMENTOS,
                                     listaParametros,
                                     tablaDocumentos);
                enlace.DataSource = tablaDocumentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }

}
