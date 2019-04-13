using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.Util
{
    class ControlSignos
    {
        public void cargarPrametroSabana(string nombre,int codigo,Panel panelControl) {
            if (panelControl.Controls.Count == 0) {
                panelControl.Controls.Add(crearDatagridViewSignos(nombre));
            }
        }
        private DataGridView crearDatagridViewSignos(string nombre) {
            DataGridView dtw = new DataGridView();
            dtw.Columns.Add("dgCodigo","Codigo");
            dtw.Columns.Add("dgDescripcion", "Descripción");
            dtw.Columns.Add("dg00", "00");
            dtw.Columns.Add("dg01", "01");
            dtw.Columns.Add("dg02", "02");
            dtw.Columns.Add("dg03", "03");
            dtw.Columns.Add("dg04", "04");
            dtw.Columns.Add("dg05", "05");
            dtw.Columns.Add("dg06", "06");
            dtw.Columns.Add("dg07", "07");
            dtw.Columns.Add("dg08", "08");
            dtw.Columns.Add("dg09", "09");
            dtw.Columns.Add("dg10", "10");
            dtw.Columns.Add("dg11", "11");
            dtw.Columns.Add("dg12", "12");
            dtw.Columns.Add("dg13", "13");
            dtw.Columns.Add("dg14", "14");
            dtw.Columns.Add("dg15", "15");
            dtw.Columns.Add("dg16", "16");
            dtw.Columns.Add("dg17", "17");
            dtw.Columns.Add("dg18", "18");
            dtw.Columns.Add("dg19", "19");
            dtw.Columns.Add("dg20", "20");
            dtw.Columns.Add("dg21", "21");
            dtw.Columns.Add("dg22", "22");
            dtw.Columns.Add("dg23", "23");
            dtw.Dock = DockStyle.Fill;
            styloDatagridview(dtw);
            return dtw;
        }
        private void styloDatagridview(DataGridView dtw) {
           
        }
    }
}
