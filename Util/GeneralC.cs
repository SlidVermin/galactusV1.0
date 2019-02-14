
using Galactus.Util.Constantes;
using Galactus.Util.Mensajes;
using Galactus.VistaControlador.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus
{
    class GeneralC
    {
        public delegate void cargarInfoFila(DataRow fila);
        public delegate void cargarInfoCodigo(string codigo);
        public delegate void subMetodo();
        public static DataRow devuelveUnaFila(string consulta,
                                              List<string> parametros)
        {
            DataTable tablaResultados = new DataTable();
            llenarTabla(consulta, parametros, tablaResultados);
            if (tablaResultados.Rows.Count > 0)
            {
                return tablaResultados.Rows[0];
            }
            return null;
        }
        public static void llenarTabla(string query,
                                       List<string> parametros,
                                       DataTable tablaResultado)
        {
            string listaParametros = obtenerParametros(parametros);
            tablaResultado.Clear();
            try
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(query + listaParametros, PrincipalUI.Cnxion))
                {
                    adaptador.Fill(tablaResultado);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void llenarCombo(string query,
                                       string valueMember,
                                       string displayMember,
                                       ComboBox combo)
        {
            DataTable dt = new DataTable();
            DataRow drFila = dt.NewRow();
            try
            {
                dt.Columns.Add(valueMember);
                dt.Columns.Add(displayMember);
                drFila[0] = "-1";
                drFila[1] = "----Seleccionar----";
                dt.Rows.Add(drFila);
                using (SqlDataAdapter adaptador = new SqlDataAdapter(query, PrincipalUI.Cnxion))
                {
                    adaptador.Fill(dt);
                }
                if (dt.Rows.Count > 0)
                {
                    combo.DataSource = dt;
                    combo.DisplayMember = displayMember;
                    combo.ValueMember = valueMember;

                    combo.AutoCompleteMode = AutoCompleteMode.None;
                    combo.AutoCompleteSource = AutoCompleteSource.None;
                    combo.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static DataRow obtenerRegistroCompleto(string query,
                                                      List<string> parametros)
        {
            string listaParametros = obtenerParametros(parametros);
            try
            {
                using (DataTable tablaResultado = new DataTable())
                {
                    tablaResultado.Clear();
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(query + listaParametros, PrincipalUI.Cnxion))
                    {
                        adaptador.Fill(tablaResultado);
                    }
                    if (tablaResultado.Rows.Count > 0)
                    {
                        return tablaResultado.Rows[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static DataSet llenarDataset(string query,
                                            List<string> parametros)
        {
            string listaParametros = obtenerParametros(parametros);
            try
            {
                using (DataSet dataset = new DataSet())
                {
                    dataset.Clear();
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(query + listaParametros, PrincipalUI.Cnxion))
                    {
                        adaptador.Fill(dataset);
                    }
                    if (dataset.Tables.Count > 0)
                    {
                        return dataset;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        internal static void buscarDevuelveFila(string bODEGA_BUSCAR, List<string> parametros, cargarInfoFila cargarInfoFila, object bUSQUEDA_BODEGA, bool v)
        {
            throw new NotImplementedException();
        }

        public static string obtenerParametros(List<string> parametros)
        {
            string lisatdoParametros;
            if (parametros == null || parametros.Count == 0)
            {
                return "";
            }
            string comillaSimple = Convert.ToChar(39).ToString();
            string coma = Convert.ToChar(44).ToString();
            lisatdoParametros = comillaSimple + parametros.First() + comillaSimple;
            for (int indice = 1; indice <= parametros.Count - 1; indice++)
            {
                lisatdoParametros += coma + comillaSimple + parametros[indice] + comillaSimple;
            }
            return lisatdoParametros;
        }
        public static bool filaValida(int fila)
        {
            return (fila >= 0);
        }
        public static void cargarForm(Form form, Form padre)
        {
            form.MdiParent = padre;
            form.Show();
            form.Focus();
            if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }
        }
        public static void habilitarControles(Control elemento)
        {
            foreach (Control item in elemento.Controls)
            {
                if (((item is TextBox && !item.Name.Contains("txtB")) || (item is RichTextBox) || (item is MaskedTextBox) || (item is DataGridView)) && !(item.Name.ToString().ToLower().Contains(ConstanteGeneral.TEXTBOX_CODIGO)))
                    item.Enabled = true;
                else if ((item is CheckBox) || (item is RadioButton) || (item is ComboBox) || (item is Button) || (item is TreeView) || (item is DateTimePicker) || (item is NumericUpDown))
                    item.Enabled = true;
                else if ((item is GroupBox) || (item.HasChildren))
                    habilitarControles(item);
            }
        }
        public static void deshabilitarControles(Control elemento)
        {
            foreach (Control item in elemento.Controls)
            {
                if ((item is TextBox) & item.Name != "txtFiltro" || (item is RichTextBox) || (item is MaskedTextBox) || (item is DataGridView))
                    item.Enabled = false;
                else if ((item is CheckBox) || (item is RadioButton) || (item is ComboBox) || ((item is Button) & !item.Name.ToString().ToLower().Contains(ConstanteGeneral.BOTON_OPCION)) || (item is TreeView) || (item is DateTimePicker) || (item is NumericUpDown))
                    item.Enabled = false;
                else if ((item is GroupBox) || (item.HasChildren))
                    deshabilitarControles(item);
            }
        }
        public static void deshabilitarBotones(ref ToolStrip menu)
        {
            foreach (var item in menu.Items)
            {
                if (item is ToolStripButton)
                {
                    (item as ToolStripButton).Enabled = false;
                }
                else if (item is ToolStripDropDown)
                {
                    (item as ToolStripDropDown).Enabled = false;
                }

            }
        }
        public static void deshabilitarBotonesPanel(ref Panel menu)
        {
            foreach (var item in menu.Controls)
            {
                (item as Button).Enabled = false;
            }
        }
        public static void habilitarBotonesPanel(ref Panel menu)
        {
            foreach (var item in menu.Controls)
            {
                (item as Button).Enabled = true;
            }
        }
        public static void habilitarBotones(ref ToolStrip menu)
        {
            foreach (var item in menu.Items)
            {
                if (item is ToolStripButton)
                {
                    (item as ToolStripButton).Enabled = true;
                }
                else if (item is ToolStripDropDown)
                {
                    (item as ToolStripDropDown).Enabled = true;
                }

            }
        }
        public static string validarComillas(string text)
        {
            return text.Replace("'", "");
        }
        public static void buscarDevuelveFila(string query,
                                              List<string> parametros,
                                              cargarInfoFila metodo,
                                              string Titulo,
                                              bool buscarConEnter,
                                              List<string> listaColumnasOcultar)
        {
            BusquedaGeneralUI formBusqueda = new BusquedaGeneralUI();
            var objBusqueda = formBusqueda.objBusqueda;
            objBusqueda.BuscarConEnter = buscarConEnter;
            objBusqueda.BusquedaPorCodigo = false;
            formBusqueda.metodoPorFila = metodo;
            objBusqueda.parametros = parametros;
            formBusqueda.Text = Titulo;
            formBusqueda.listaColumnasOcultar = listaColumnasOcultar;
            objBusqueda.Query = query;
            formBusqueda.ShowDialog();
        }
        public static void listarDocumentosGenerales(string query,
                                                     List<string> parametros,
                                                     GeneralC.cargarInfoFila metodo,
                                                     string titulo)
        {
            try
            {
                GeneralC.buscarDevuelveFila(Query.PARAMETROS_LISTAR_DOCUMENTOS,
                                            parametros,
                                            new GeneralC.cargarInfoFila(metodo),
                                            titulo,
                                            true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public static void limpiarControles(object pFormulario)
        {
            foreach (var vControl in (pFormulario as Control).Controls)
            {
                if ((vControl is TextBox) || (vControl is RichTextBox))
                    (vControl as TextBoxBase).Clear();
                //(vControl as Label).ForeColor = Color.LimeGreen;
                else if ((vControl is MaskedTextBox))
                    (vControl as TextBoxBase).ResetText();
                else if ((vControl is ComboBox))
                {
                    if (((vControl as ComboBox).Items.Count > 0))
                        (vControl as ComboBox).SelectedIndex = 0;
                }
                else if ((vControl is NumericUpDown))
                    (vControl as NumericUpDown).Value = (vControl as NumericUpDown).Minimum;
                else if ((vControl is CheckBox))
                    (vControl as CheckBox).Checked = false;
                else if ((vControl is PictureBox) && ((vControl as PictureBox).Name != ConstanteGeneral.FORMULARIO_LOGO))
                    (vControl as PictureBox).Image = null;
                else if ((vControl is CheckedListBox))
                    (vControl as CheckedListBox).Items.Clear();
                else if ((vControl is RadioButton))
                {
                    //var vCurrentRB = (vControl as RadioButton).Location.X + (vControl as RadioButton).Location.Y;
                    //if ((vFrtRB > vCurrentRB))
                    //    vFrtRB = vCurrentRB;
                    //else
                    //    (vControl as RadioButton).Checked = false;
                }
                else if ((vControl is TreeView))
                    (vControl as TreeView).Nodes.Clear();
                else if ((vControl is DataGridView))
                {
                    (vControl as DataGridView).EndEdit();
                    if ((vControl as DataGridView).DataSource is BindingSource)
                        (vControl as DataGridView).DataSource = String.Empty;
                    else if ((vControl as DataGridView).DataSource != null)
                        (vControl as DataGridView).DataSource = String.Empty;
                    //diseñoDGV(ref vControl);
                }
                else
                    // mira a ve si es un contenedor
                    limpiarControles(vControl);
            }
        }
        public static void diseñoDGV(ref DataGridView dgv)
        {
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Empty;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Empty;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Empty;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new Font(ConstanteGeneral.TIPO_LETRA_ELEMENTO, 9);
        }
        public static void formNuevo(object formulario,
                                     ToolStrip menu,
                                     ToolStripButton btn1,
                                     ToolStripButton btn2)
        {
            try
            {
                limpiarControles(formulario);
                habilitarControles((Control)formulario);
                deshabilitarBotones(ref menu);
                habilitarBotones(btn1);
                habilitarBotones(btn2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void posCargadoForm(Form formulario,
                                          ToolStrip menu,
                                          ToolStripButton btn1 = null,
                                          ToolStripButton btn2 = null,
                                          ToolStripButton btn3 = null,
                                          ToolStripButton btn4 = null,
                                          ToolStripButton btn5 = null,
                                          string msm = "")
        {
            accionesGenerales(formulario, menu, btn1, btn2, btn3, btn4, btn5, msm);
        }
        public static void posBuscar(Form formulario,
                                      ToolStrip menu,
                                      ToolStripButton btn1,
                                      ToolStripButton btn2,
                                      ToolStripButton btn3,
                                      ToolStripButton btn4,
                                      ToolStripButton btn5 = null,
                                      string msm = "")
        {
            accionesGenerales(formulario, menu, btn1, btn2, btn3, btn4, btn5, msm);
        }
        public static void posGuardar(Form formulario,
                                      ToolStrip menu,
                                      ToolStripButton btn1,
                                      ToolStripButton btn2,
                                      ToolStripButton btn3,
                                      ToolStripButton btn4,
                                      ToolStripButton btn5 = null,
                                      string msm = "")
        {
            accionesGenerales(formulario, menu, btn1, btn2, btn3, btn4, btn5, msm);
        }
  
        public static void posAnular(Form formulario,
                                      ToolStrip menu,
                                      ToolStripButton btn1,
                                      ToolStripButton btn2,
                                       string msm = "")
        {
            limpiarControles(formulario);
            accionesGenerales(formulario, menu, btn1, btn2, null, null, null, msm);
        }
        public static bool fnEditarForm(Form formulario,
                                        ToolStrip menu,
                                        ToolStripButton btn1,
                                        ToolStripButton btn2)
        {
            if (MessageBox.Show(Mensajes.EDITAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return false;
            }
            habilitarControles((Control)formulario);
            deshabilitarBotones(ref menu);
            habilitarBotones(btn1);
            habilitarBotones(btn2);
            return true;
        }
        public static bool fnCancelarForm(Form formulario,
                                              ToolStrip menu,
                                              ToolStripButton btn1,
                                              ToolStripButton btn2)
        {
            if (MessageBox.Show(Mensajes.CANCELAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return false;
            }
            limpiarControles(formulario);
            deshabilitarBotones(ref menu);
            deshabilitarControles(formulario);
            habilitarBotones(btn1);
            habilitarBotones(btn2);
            return true;
        }
        private static void accionesGenerales(Form formulario,
                                              ToolStrip menu,
                                              ToolStripButton btn1,
                                              ToolStripButton btn2,
                                              ToolStripButton btn3,
                                              ToolStripButton btn4,
                                              ToolStripButton btn5 = null,
                                              string msm = "")
        {

            deshabilitarControles(formulario);
            deshabilitarBotones(ref menu);
            habilitarBotones(btn1);
            habilitarBotones(btn2);
            habilitarBotones(btn3);
            habilitarBotones(btn4);
            habilitarBotones(btn5);
            if (!msm.Equals(""))
            {
                MessageBox.Show(msm, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        static void habilitarBotones(ToolStripButton btn)
        {
            if (btn != null)
            {
                btn.Enabled = true;
            }
        }
       public static void mostrarMensajeInformacio(string mensaje,Control control) {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            control.Focus();
        }
       public static void quitarColumnaDatatable(string nombreColumna,DataTable tabla) {
            if (tabla.Columns.Contains(nombreColumna))
            {
                tabla.Columns.Remove(nombreColumna);
            }
        }
    }
}
