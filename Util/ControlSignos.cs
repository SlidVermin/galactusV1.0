using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Galactus.Util;

namespace Galactus.Util
{
    class ControlSignos
    {
        public static void cargarPrametroSabana(string nombre,int codigo,Panel panelControl) {
            if (panelControl.Controls.Count == 0) {
                panelControl.Controls.Add(crearDatagridViewSignos(nombre,codigo));
            }
        }
        private static DataGridView crearDatagridViewSignos(string nombre,int codigo) {
            DataGridView dtw = new DataGridView();
            dtw.Dock = DockStyle.Fill;
            dtw.DataSource = cargarParametrosBD(codigo);
            styloDatagridview(ref dtw);
            return dtw;
        }
        private static void styloDatagridview(ref DataGridView dtw) {
            dtw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtw.AllowUserToOrderColumns = false;
            dtw.AllowUserToAddRows = false;
            dtw.AllowUserToDeleteRows = false;
            dtw.BackgroundColor = System.Drawing.Color.White;
            dtw.AllowUserToResizeRows = false;
            dtw.AllowUserToResizeColumns = false;
            if (dtw.Columns.Count > 0) {
                dtw.Columns[0].Visible = false;
                dtw.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private static DataTable cargarParametrosBD(int codigo) {
            List<string> parametro = new List<string>();
            DataTable dt = new DataTable();
            parametro.Add(codigo.ToString());
            dt = GeneralC.cargarResultadosSQL(Sentencias.PARAMETROS_CONSULTAR_DESCRIPCION_SABANA, parametro);
            return dt;
        }
    }
}
