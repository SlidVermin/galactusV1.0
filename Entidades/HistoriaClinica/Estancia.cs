using Galactus.Modelo.HistoriaClinica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.HistoriaClinica
{
    class Estancia
    {
        public DataTable dtEstancia { get; set; }

        public DataTable dtCambiosEstancia = new DataTable(); 
        public bool auditoria { get; set; }
        public int idAtencion { get; set; }
        public void listarEstancia()
        {
            try
            {
                dtEstancia = new DataTable();
                List<string> lista = new List<string>();
                lista.Add(Convert.ToString(auditoria));
                lista.Add(Convert.ToString(idAtencion));
                dtEstancia = GeneralC.cargarResultadosSQL(Sentencias.CARGAR_ESTANCIA, lista);
            }catch (Exception ex)
            {
                throw ex;
            }
        }
        public void guardar()
        {
            preparar();
            EstanciaDAL.guardar(this);
        }
       private void preparar()
        {
            dtCambiosEstancia = dtEstancia.Copy();
            for (int i = 0; i< dtCambiosEstancia.Rows.Count ;i++){
                dtCambiosEstancia.Rows[i]["idUsuarioOrigen"] = (string.IsNullOrEmpty(dtCambiosEstancia.Rows[i]["idUsuarioOrigen"].ToString())) ? 
                                                           Sesion.IdUsuario.ToString():
                                                           dtCambiosEstancia.Rows[i]["idUsuarioOrigen"].ToString();
            }
            dtCambiosEstancia.AcceptChanges();
            dtCambiosEstancia.Columns.Remove("Código");
            dtCambiosEstancia.Columns.Remove("Asignar");
            dtCambiosEstancia.Columns.Remove("Descripción");
        }


    }
}
