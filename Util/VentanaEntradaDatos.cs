﻿using Galactus.VistaControlador.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.Util
{
    class VentanaEntradaDatos
    {
        public static void modificarTexto(string nombreColumnaDT, 
                                          ref DataGridView dgv,
                                          bool puedeRepetirse,
                                          bool aceptaVacio,
                                          bool permitirCambios)
        {
            string valorNuevo, valorAnterior;
            int indiceFila, indiceColumna;
            indiceFila = dgv.CurrentCell.RowIndex;
            indiceColumna = dgv.CurrentCell.ColumnIndex;

            valorAnterior = dgv.Rows[indiceFila].Cells[indiceColumna].Value.ToString();
            dgv.Rows[indiceFila].Cells[indiceColumna].Value = "";
            ((DataTable)dgv.DataSource).AcceptChanges();

            VentanaEntradaDatosUI ventanaEntrada = new VentanaEntradaDatosUI();
            ventanaEntrada.obtenerTexto(valorAnterior);
            ventanaEntrada.obtenerEstado(permitirCambios);
            ventanaEntrada.ShowDialog();
            valorNuevo = ventanaEntrada.mostrarTexto();
            if ((string.IsNullOrEmpty(valorNuevo) && ! aceptaVacio) ||
                !puedeRepetirse && GeneralC.valorExiste(nombreColumnaDT, valorNuevo, (DataTable)dgv.DataSource))
            {
                dgv.Rows[indiceFila].Cells[indiceColumna].Value = valorAnterior.ToUpper();
            }else if (!string.IsNullOrEmpty(valorNuevo))
            {
                dgv.Rows[indiceFila].Cells[indiceColumna].Value = valorNuevo.ToUpper();
            }
        }
    }
}
