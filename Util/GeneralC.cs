
using Galactus.Util;
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
        public static void habilitarCeldas(DataGridViewCellEventArgs e, DataGridView dgv, string columna, bool edicion)
        {
            int i;
            dgv.ReadOnly = false;
            for (i=0;i< dgv.Rows.Count;i++)
            {
                dgv.Columns[i].ReadOnly = false;
            }
            if (e.RowIndex >= 0){
                if (verificarUbicacionCelda(e, dgv, columna) && edicion && desactvarUltimaFila(dgv, e.RowIndex))
                {
                    dgv.Columns[columna].ReadOnly = false;
                    dgv.Rows[e.RowIndex].Cells[columna].ReadOnly = false;
                }
                else
                {
                    dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                }
            }
            


        }
        public static bool desactvarUltimaFila(DataGridView dgv, int filaActual)
        {
            if (filaActual < dgv.RowCount - 1)
            {
                return true;
            }
            return false;
        }

        public static bool verificarUbicacionCelda(DataGridViewCellEventArgs e, DataGridView dgv, string columna)
        {
            return e.ColumnIndex == dgv.Columns[columna].Index;
        }
        public static void llenarTablaConParametros(string query,
                                                    DataTable listado,
                                                    DataTable tablaResultado)
        {
           tablaResultado.Clear();
            try
            {
                using (SqlCommand comando = new SqlCommand()) {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = query;
                    comando.Connection = PrincipalUI.Cnxion;

                    foreach (DataRow item in listado.Rows)
                    {
                    
                        comando.Parameters.AddWithValue(item.Field<string>("parametro"), item.Field<object>("valor"));
                    }

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tablaResultado);
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void validarComboUbicacion(ComboBox cbUbicacion,
                                                ComboBox cbDeshabilitar)
        {
            if (cbUbicacion.SelectedIndex > 0)
            {
                cbDeshabilitar.Enabled = true;
            }
            else
            {
                cbDeshabilitar.Enabled = false;
            }
        }

        public static object castFromDbItemVacio(Object DbItem)
        {
            if (DbItem is DBNull)
            {
                return DbItem = "";
            }
            else
            {
                return DbItem;
            }
        }

        public static void calcularEdad(DateTime fechaNacimiento,
                                     ref string campoFecha)
        {

            campoFecha = Convert.ToString(DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year);
        }

        public static DataTable copiarNewDatatable(DataTable dtDatos,
                                                   String nombreCampo,
                                                   int codigoCampo)
        {
            DataTable dt = new DataTable();
            dt = dtDatos.Clone();
            DataRow[] filas;
            try

            {
                filas = dtDatos.Select(nombreCampo + "='" + codigoCampo + "'");
                foreach (DataRow dw in filas)
                {
                    dt.ImportRow(dw);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public static DataTable copiarTablaCondicional(DataTable dtOrigen, String condicion)
        {
            DataTable dtResultado = new DataTable();
            try
            {

                dtResultado = dtOrigen.Clone();
                condicion = condicion.Replace("'%", "'<<>>");
                condicion = condicion.Replace("%'", "<<>>'");
                condicion = condicion.Replace("%", "");
                condicion = condicion.Replace("'<<>>", "'%");
                condicion = condicion.Replace("<<>>'", "%'");
                DataRow[] filas = dtOrigen.Select(condicion);
                foreach (DataRow row in filas)
                {
                    dtResultado.ImportRow(row);
                }
            }
            catch (Exception ex)
            {
                Mensajes.mensajeError(ex);
            }
            return dtResultado;
        }
        public static bool valorExiste(string nombreColumnaDT, string valor, DataTable dtOrigen) {
            if (dtOrigen.Select(nombreColumnaDT + "='" + valor + "'").Count() > 0)
            {
                Mensajes.mensajeAdvertencia(Mensajes.VALOR_EXISTENTE);
                return true;
            }
            return false;
    }
        public static void cargarUbicacionGeografica(DataTable dtUbicaciones,
                                                     String idMunicipio,
                                                     ref ComboBox comboPais,
                                                     ref ComboBox comboDepartamento,
                                                     ref ComboBox comboMunicipio)
        {

            try
            {
                DataRow[] filaPais, filaDepartamento, filaMunicipio;
                filaMunicipio = dtUbicaciones.Select("Código=" + idMunicipio + "");


                filaDepartamento = dtUbicaciones.Select("Código=" + filaMunicipio[0]["idPadre"] + "");

                filaPais = dtUbicaciones.Select("Código=" + filaDepartamento[0]["idPadre"] + "");
                comboPais.SelectedValue = Convert.ToString(filaPais[0]["Código"]);
                comboDepartamento.SelectedValue = Convert.ToString(filaDepartamento[0]["Código"]);
                comboMunicipio.SelectedValue = idMunicipio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void llenarComboDatosDefinidor(DataTable dt,
                                                     string valueMember,
                                                     string displayMember,
                                                     ComboBox combo)

        {
            DataTable dtAux = new DataTable();
            dtAux = dt.Clone();
            DataRow drFila = dtAux.NewRow();
            try
            {
                drFila[0] = "-1";
                drFila[1] = "----Seleccionar----";
                dtAux.Rows.Add(drFila);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dRows in dt.Select())
                    {
                        dtAux.ImportRow(dRows);
                    }

                    combo.DataSource = dtAux;
                    combo.DisplayMember = displayMember;
                    combo.ValueMember = valueMember;

                    combo.AutoCompleteMode = AutoCompleteMode.None;
                    combo.AutoCompleteSource = AutoCompleteSource.None;
                    combo.DropDownStyle = ComboBoxStyle.DropDownList;
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void llenarComboDependiente(ComboBox comboPadre, ComboBox comboHijo, string query)
        {
            if (comboPadre.SelectedIndex > 0)
            {
                string filtro = (comboPadre.SelectedIndex == 0) ? Util.Constantes.ConstanteGeneral.PREDETERMINADA : comboPadre.SelectedValue.ToString();
                GeneralC.llenarCombo(query + " " + filtro + "",
                                     Util.Constantes.ConstanteGeneral.VALUEMEMBER,
                                     Util.Constantes.ConstanteGeneral.DISPLAYMEMBER,
                                     comboHijo);
                GeneralC.validarComboUbicacion(comboPadre, comboHijo);
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

        public static DateTime obtenerFechaServidor()
        {
           
            try
            {
                DateTime fechaServidor = new DateTime();
                DataTable dtAlmacenar = new DataTable();

                using (SqlDataAdapter da = new SqlDataAdapter("select getdate()", PrincipalUI.Cnxion))
                {
                    da.Fill(dtAlmacenar);
                }
                if (dtAlmacenar.Rows.Count > 0)
                {
                  fechaServidor = dtAlmacenar.Rows[0].Field<DateTime>(0);             
                }
                return  fechaServidor;
            }
            catch(Exception ex)
            {
                throw ex;
                return DateTime.Now;
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
                if ((((item is TextBox || item is ToolStripTextBox) && !item.Name.Contains("txtB")) || (item is RichTextBox) || (item is MaskedTextBox) || (item is DataGridView)) && !(item.Name.ToString().ToLower().Contains(ConstanteGeneral.TEXTBOX_CODIGO)))
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
        public static bool validarDetalleVacio(DataTable dtOrigen, string nombreColumna, bool quitarUltimaFila)
        {
            string filtro = string.Concat("[", nombreColumna, "]='' or [", nombreColumna, "] is null");
            DataView trasformador = new DataView(dtOrigen, filtro, "", DataViewRowState.CurrentRows);
            DataTable dtDetalle = new DataTable();
            dtDetalle = trasformador.ToTable("tabla", true, nombreColumna);
            if (quitarUltimaFila) {
                dtDetalle.Rows.RemoveAt(dtDetalle.Rows.Count - 1); 
            }
            if (dtDetalle.Select().Count() > 0) {
                Mensajes.mensajePorDefectoFaltaInformacion();
                return false;
            }else
            {
                return true;
            }
        }

        public static void agregarRegistroDatagridView(subMetodo metodo,
                                                       subMetodo verificarFila,
                                                       subMetodo QuitarFila,
                                                       DataGridView dgv,
                                                       int indiceColumna
                                                       )
        {
            
            int columnaActual;
            int filaActual;
            bool filaVacia;
            String nombreColumna;

          
            columnaActual = dgv.CurrentCell.ColumnIndex;
            nombreColumna = dgv.Columns[columnaActual].HeaderText;
            filaActual = dgv.CurrentCell.RowIndex;
            filaVacia = (string.IsNullOrEmpty( dgv.Rows[filaActual].Cells[indiceColumna].Value.ToString())) ? true:false;

            switch (nombreColumna)
            {
                case "Agregar":
                    agregarRow(metodo,
                          verificarFila,
                          dgv,
                          filaActual,
                          columnaActual,
                          filaVacia);
                    break;
                case "Quitar":
                    if (!filaVacia)
                    {
                        QuitarFila.Invoke();
                    }                   
                    break;
            }
           
          
        }
        public static void agregarRow(subMetodo metodo,
                                      subMetodo verificarFila,
                                      DataGridView dgv,
                                      int filaActual,
                                      int columnaActual,
                                      bool filaVacia)
        {
            if (filaVacia == false)
            {
                filaActual += 1;
            }
            DataTable dt = new DataTable();
            dt = dgv.DataSource as DataTable;
            DataRow fila = dt.NewRow();
            ((DataTable)(dgv).DataSource).Rows.InsertAt(fila, filaActual);
            dgv.ClearSelection();
            dgv.Rows[filaActual].Cells[columnaActual].Selected = true;
            metodo.Invoke();
            verificarFila.Invoke();
        }
        public static void buscarDevuelveFila(string query,
                                              List<string> parametros,
                                              cargarInfoFila metodo,
                                              string Titulo,
                                              bool buscarConEnter,
                                              List<string> listaColumnasOcultar = null,
                                              DataTable itemsSeleccionados = null,
                                              DataTable listadoParametros = null)
        {
            BusquedaGeneralUI formBusqueda = new BusquedaGeneralUI();
            var objBusqueda = formBusqueda.objBusqueda;
            objBusqueda.BuscarConEnter = buscarConEnter;
            objBusqueda.BusquedaPorCodigo = false;
            objBusqueda.parametros = parametros;
            objBusqueda.Query = query;
            objBusqueda.itemsSelecionados = itemsSeleccionados;
            objBusqueda.listadoParametros = listadoParametros;
            formBusqueda.listaColumnasOcultar = listaColumnasOcultar;
            formBusqueda.metodoPorFila = metodo;
            formBusqueda.Text = Titulo;
            formBusqueda.ShowDialog();
        }
        public static void abrirVentanaEntradaDatos(ref DataGridView dgv,
                                      string nombreTituloColumna,
                                      string nombreColumnaDescripcion,
                                      bool habilitarEscrito)
        {
            string nombreColumnaDgv;
            nombreColumnaDgv = dgv.Columns[dgv.CurrentCell.ColumnIndex].HeaderText.ToString();
            if (nombreTituloColumna == nombreColumnaDgv &&
                dgv.CurrentCell.RowIndex >= 0 &&
                !string.IsNullOrEmpty(dgv.Rows[dgv.CurrentCell.RowIndex].Cells[nombreColumnaDescripcion].Value.ToString()))
            {
                VentanaEntradaDatos.modificarTexto(nombreTituloColumna,
                                              ref dgv,
                                              true,
                                              true,
                                              habilitarEscrito);
                dgv.EndEdit();
                ((DataTable)dgv.DataSource).AcceptChanges();

            }
        }
        public static void listarDocumentosGenerales(string query,
                                                     List<string> parametros,
                                                     GeneralC.cargarInfoFila metodo,
                                                     string titulo)
        {
            try
            {
                GeneralC.buscarDevuelveFila(Sentencias.PARAMETROS_LISTAR_DOCUMENTOS,
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
                        if ((vControl as DataGridView).DataSource is DataTable)
                        {
                            ((DataTable)(vControl as DataGridView).DataSource).Rows.Clear();
                        }
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

        public static void posAnular(Form formulario, ToolStrip menu, ToolStripButton btn1, ToolStripButton btn2, string msm = "")
        {
            limpiarControles(formulario);
            accionesGenerales(formulario, menu, btn1, btn2, null, null, null, msm);
        }
        public static bool fnModificarForm(Object formulario, ToolStrip menu, ToolStripButton btn1, ToolStripButton btn2)
        {
            if (MessageBox.Show(Mensajes.Modificar_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
        public static void mostrarMensajeInformacio(string mensaje, Control control)
        {
            MessageBox.Show(mensaje, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            control.Focus();
        }
        public static void quitarColumnaDatatable(string nombreColumna, DataTable tabla)
        {
            if (tabla.Columns.Contains(nombreColumna))
            {
                tabla.Columns.Remove(nombreColumna);
            }
        }
        public static void colocarIconosMenu(ToolStrip menu)
        {
            foreach (ToolStripButton item in menu.Items)
            {
                switch (item.Name)
                {
                    case "tsbNuevo":
                        item.Image = Properties.Resources.btn_nuevo;
                        break;
                    case "tstModificar":
                        item.Image = Properties.Resources.bt_Editar;
                        break;
                    case "tsbCancelar":
                        item.Image = Properties.Resources.btn_cancelar;
                        break;
                    case "tsbGuardar":
                        item.Image = Properties.Resources.btn_guardar;
                        break;
                    case "tsbBuscar":
                        item.Image = Properties.Resources.btn_buscar;
                        break;
                    case "tsbAnular":
                        item.Image = Properties.Resources.btn_anular;
                        break;
                    default:
                        item.Image = null;
                        break;
                }
            }

        }
        public static void seleccionarImagen(PictureBox pictu)
        {
            try
            {
                using (OpenFileDialog objetoSeleccion = new OpenFileDialog())
                {
                    objetoSeleccion.InitialDirectory = "";
                    objetoSeleccion.Filter = "Todos los archivos de imagen | *.jpg; *.jpeg; *.png; *.bmp; *.gif; *.pdf; *| PDF | *.pdf | JPEG | *.jpeg; *.jpg | BMP | *.bmp | GIF | *.gif | PNG | *.png";
                    objetoSeleccion.Title = "Seleccionar Archivo";
                    if (objetoSeleccion.ShowDialog() == DialogResult.OK)
                    {
                        pictu.Image = null;
                        pictu.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictu.Image = Image.FromFile(objetoSeleccion.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void cargarFormularioEnPestana(TabPage tabPage, Form formContenido)
        {
            if (tabPage.Controls.Count > 0)
            {
                tabPage.Controls.Clear();
            }

            formContenido.TopLevel = false;
            formContenido.Dock = DockStyle.None;
            formContenido.FormBorderStyle = FormBorderStyle.None;
            tabPage.Controls.Add(formContenido);
            tabPage.Tag = formContenido;
            tabPage.AutoScroll = true;
            formContenido.Show();
        }
    }
}
