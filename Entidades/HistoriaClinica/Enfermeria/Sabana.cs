using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.HistoriaClinica.Enfermeria
{
    class Sabana
    {
        public int idSabana { get; set; }
        public bool auditoria { get; set; }
        public int idAtencion { get; set; }
        public DateTime fecha { get; set; }

        public DataTable dtMedicamento { get; set; }
        public DataTable dtGoteo { get; set; }
        public DataTable dtCambiosGoteo { get; set; }
        public DataTable dtCambiosMedicamento { get; set; } 
        
        public Sabana()
        {
            dtMedicamento= new DataTable();
            dtGoteo= new DataTable();
            dtCambiosGoteo = new DataTable();
            dtCambiosMedicamento = new DataTable();
        }
        public void prepararDT()
        {
            dtCambiosMedicamento = dtMedicamento.Copy();
            dtCambiosMedicamento.Columns.Remove("tipo");
            dtCambiosMedicamento.Columns.Remove("descripcion");

            dtCambiosGoteo = dtGoteo.Copy();
            dtCambiosGoteo.Columns.Remove("tipo");
            dtCambiosGoteo.Columns.Remove("descripcion");
            calcularMedicamentos();
            calcularGoteo();
        }
        private void calcularMedicamentos()
        {
            int cantidadAplicadas=0;
            int fila;
            int columna;
            for (fila=0;fila< dtCambiosMedicamento.Rows.Count;fila++)
            {
                cantidadAplicadas = 0;
                for (columna = 1; columna < dtCambiosMedicamento.Columns.Count-1; columna++)
                {
                    if (dtCambiosMedicamento.Rows[fila][columna].ToString().Length == 2) {
                        cantidadAplicadas += 1;
                    }
                }
                dtCambiosMedicamento.Rows[fila]["total"] = cantidadAplicadas;
            }
            
        }
        private void calcularGoteo()
        {
            double cantidadAplicadas = 0;
            int fila;
            int columna;
            for (fila = 0; fila < dtCambiosGoteo.Rows.Count; fila++)
            {
                cantidadAplicadas = 0;
                for (columna = 1; columna < dtCambiosGoteo.Columns.Count - 1; columna++)
                {
                    if (GeneralC.IsNumeric(dtCambiosGoteo.Rows[fila][columna].ToString()) &&
                        double.Parse(dtCambiosGoteo.Rows[fila][columna].ToString()) > 0)
                    {
                        cantidadAplicadas += double.Parse(dtCambiosGoteo.Rows[fila][columna].ToString());
                    }
                }
                dtCambiosGoteo.Rows[fila]["total"] = cantidadAplicadas;
            }
            
        }
        
    }
}
