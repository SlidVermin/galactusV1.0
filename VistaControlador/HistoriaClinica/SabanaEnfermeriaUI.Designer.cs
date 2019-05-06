namespace Galactus.VistaControlador.HistoriaClinica
{
    partial class SabanaEnfermeriaUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tstModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tpMedicamentos = new System.Windows.Forms.TabPage();
            this.tpSignos = new System.Windows.Forms.TabPage();
            this.dgvSabanaSignos = new System.Windows.Forms.DataGridView();
            this.dgSabanaIdSigno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSabanaDescripcionSigno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno04 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno05 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno06 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno07 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno08 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno09 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSigno23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlGalactus1 = new Galactus.Util.Controles.TabControlGalactus();
            this.pnlInformacion.SuspendLayout();
            this.tstMenuPatron.SuspendLayout();
            this.tpSignos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabanaSignos)).BeginInit();
            this.tabControlGalactus1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.dateTimePicker1);
            this.pnlInformacion.Controls.Add(this.label1);
            this.pnlInformacion.Location = new System.Drawing.Point(5, 5);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(1244, 38);
            this.pnlInformacion.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 21);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Fecha:";
            // 
            // tstMenuPatron
            // 
            this.tstMenuPatron.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuPatron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tstModificar,
            this.tsbCancelar,
            this.tsbGuardar,
            this.tsbBuscar,
            this.tsbAnular});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 426);
            this.tstMenuPatron.MaximumSize = new System.Drawing.Size(1213, 29);
            this.tstMenuPatron.MinimumSize = new System.Drawing.Size(1213, 29);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(1213, 29);
            this.tstMenuPatron.TabIndex = 49;
            this.tstMenuPatron.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNuevo.Image = global::Galactus.Properties.Resources.btn_nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbNuevo.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 26);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // tstModificar
            // 
            this.tstModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstModificar.Image = global::Galactus.Properties.Resources.bt_Editar;
            this.tstModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstModificar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tstModificar.Name = "tstModificar";
            this.tstModificar.Size = new System.Drawing.Size(78, 26);
            this.tstModificar.Text = "Modificar";
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCancelar.Image = global::Galactus.Properties.Resources.btn_cancelar;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(73, 26);
            this.tsbCancelar.Text = "Cancelar";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbGuardar.Image = global::Galactus.Properties.Resources.btn_guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 26);
            this.tsbGuardar.Text = "Guardar";
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbBuscar.Image = global::Galactus.Properties.Resources.btn_buscar;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(62, 26);
            this.tsbBuscar.Text = "Buscar";
            // 
            // tsbAnular
            // 
            this.tsbAnular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAnular.Image = global::Galactus.Properties.Resources.btn_anular;
            this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnular.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbAnular.Name = "tsbAnular";
            this.tsbAnular.Size = new System.Drawing.Size(62, 26);
            this.tsbAnular.Text = "Anular";
            // 
            // tpMedicamentos
            // 
            this.tpMedicamentos.Location = new System.Drawing.Point(124, 4);
            this.tpMedicamentos.Name = "tpMedicamentos";
            this.tpMedicamentos.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedicamentos.Size = new System.Drawing.Size(1130, 369);
            this.tpMedicamentos.TabIndex = 1;
            this.tpMedicamentos.Text = "Aplicación de medicamentos";
            this.tpMedicamentos.UseVisualStyleBackColor = true;
            // 
            // tpSignos
            // 
            this.tpSignos.Controls.Add(this.dgvSabanaSignos);
            this.tpSignos.Location = new System.Drawing.Point(124, 4);
            this.tpSignos.Name = "tpSignos";
            this.tpSignos.Padding = new System.Windows.Forms.Padding(3);
            this.tpSignos.Size = new System.Drawing.Size(1135, 369);
            this.tpSignos.TabIndex = 0;
            this.tpSignos.Text = "Signos vitales";
            this.tpSignos.UseVisualStyleBackColor = true;
            // 
            // dgvSabanaSignos
            // 
            this.dgvSabanaSignos.AllowUserToAddRows = false;
            this.dgvSabanaSignos.AllowUserToDeleteRows = false;
            this.dgvSabanaSignos.AllowUserToResizeColumns = false;
            this.dgvSabanaSignos.AllowUserToResizeRows = false;
            this.dgvSabanaSignos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSabanaSignos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSabanaSignos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSabanaSignos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSabanaSignos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSabanaIdSigno,
            this.dgSabanaDescripcionSigno,
            this.dgSigno00,
            this.dgSigno01,
            this.dgSigno02,
            this.dgSigno03,
            this.dgSigno04,
            this.dgSigno05,
            this.dgSigno06,
            this.dgSigno07,
            this.dgSigno08,
            this.dgSigno09,
            this.dgSigno10,
            this.dgSigno11,
            this.dgSigno12,
            this.dgSigno13,
            this.dgSigno14,
            this.dgSigno15,
            this.dgSigno16,
            this.dgSigno17,
            this.dgSigno18,
            this.dgSigno19,
            this.dgSigno20,
            this.dgSigno21,
            this.dgSigno22,
            this.dgSigno23});
            this.dgvSabanaSignos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSabanaSignos.Location = new System.Drawing.Point(3, 3);
            this.dgvSabanaSignos.Name = "dgvSabanaSignos";
            this.dgvSabanaSignos.RowHeadersVisible = false;
            this.dgvSabanaSignos.Size = new System.Drawing.Size(1129, 363);
            this.dgvSabanaSignos.TabIndex = 6;
            // 
            // dgSabanaIdSigno
            // 
            this.dgSabanaIdSigno.DataPropertyName = "idSigno";
            this.dgSabanaIdSigno.HeaderText = "idSigno";
            this.dgSabanaIdSigno.Name = "dgSabanaIdSigno";
            this.dgSabanaIdSigno.Visible = false;
            this.dgSabanaIdSigno.Width = 48;
            // 
            // dgSabanaDescripcionSigno
            // 
            this.dgSabanaDescripcionSigno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSabanaDescripcionSigno.DataPropertyName = "descripcion";
            this.dgSabanaDescripcionSigno.HeaderText = "Descripción";
            this.dgSabanaDescripcionSigno.Name = "dgSabanaDescripcionSigno";
            this.dgSabanaDescripcionSigno.Width = 142;
            // 
            // dgSigno00
            // 
            this.dgSigno00.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno00.DataPropertyName = "0";
            this.dgSigno00.HeaderText = "0";
            this.dgSigno00.MaxInputLength = 5;
            this.dgSigno00.Name = "dgSigno00";
            this.dgSigno00.Width = 40;
            // 
            // dgSigno01
            // 
            this.dgSigno01.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno01.DataPropertyName = "1";
            this.dgSigno01.HeaderText = "1";
            this.dgSigno01.MaxInputLength = 5;
            this.dgSigno01.Name = "dgSigno01";
            this.dgSigno01.Width = 40;
            // 
            // dgSigno02
            // 
            this.dgSigno02.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno02.DataPropertyName = "2";
            this.dgSigno02.HeaderText = "2";
            this.dgSigno02.MaxInputLength = 5;
            this.dgSigno02.Name = "dgSigno02";
            this.dgSigno02.Width = 40;
            // 
            // dgSigno03
            // 
            this.dgSigno03.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno03.DataPropertyName = "3";
            this.dgSigno03.HeaderText = "3";
            this.dgSigno03.MaxInputLength = 5;
            this.dgSigno03.Name = "dgSigno03";
            this.dgSigno03.Width = 40;
            // 
            // dgSigno04
            // 
            this.dgSigno04.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno04.DataPropertyName = "4";
            this.dgSigno04.HeaderText = "4";
            this.dgSigno04.MaxInputLength = 5;
            this.dgSigno04.Name = "dgSigno04";
            this.dgSigno04.Width = 40;
            // 
            // dgSigno05
            // 
            this.dgSigno05.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno05.DataPropertyName = "5";
            this.dgSigno05.HeaderText = "5";
            this.dgSigno05.MaxInputLength = 5;
            this.dgSigno05.Name = "dgSigno05";
            this.dgSigno05.Width = 40;
            // 
            // dgSigno06
            // 
            this.dgSigno06.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno06.DataPropertyName = "6";
            this.dgSigno06.HeaderText = "6";
            this.dgSigno06.MaxInputLength = 5;
            this.dgSigno06.Name = "dgSigno06";
            this.dgSigno06.Width = 40;
            // 
            // dgSigno07
            // 
            this.dgSigno07.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno07.DataPropertyName = "7";
            this.dgSigno07.HeaderText = "7";
            this.dgSigno07.MaxInputLength = 5;
            this.dgSigno07.Name = "dgSigno07";
            this.dgSigno07.Width = 40;
            // 
            // dgSigno08
            // 
            this.dgSigno08.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno08.DataPropertyName = "8";
            this.dgSigno08.HeaderText = "8";
            this.dgSigno08.MaxInputLength = 5;
            this.dgSigno08.Name = "dgSigno08";
            this.dgSigno08.Width = 40;
            // 
            // dgSigno09
            // 
            this.dgSigno09.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno09.DataPropertyName = "9";
            this.dgSigno09.HeaderText = "9";
            this.dgSigno09.MaxInputLength = 5;
            this.dgSigno09.Name = "dgSigno09";
            this.dgSigno09.Width = 40;
            // 
            // dgSigno10
            // 
            this.dgSigno10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno10.DataPropertyName = "10";
            this.dgSigno10.HeaderText = "10";
            this.dgSigno10.MaxInputLength = 5;
            this.dgSigno10.Name = "dgSigno10";
            this.dgSigno10.Width = 41;
            // 
            // dgSigno11
            // 
            this.dgSigno11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno11.DataPropertyName = "11";
            this.dgSigno11.HeaderText = "11";
            this.dgSigno11.MaxInputLength = 5;
            this.dgSigno11.Name = "dgSigno11";
            this.dgSigno11.Width = 40;
            // 
            // dgSigno12
            // 
            this.dgSigno12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno12.DataPropertyName = "12";
            this.dgSigno12.HeaderText = "12";
            this.dgSigno12.MaxInputLength = 5;
            this.dgSigno12.Name = "dgSigno12";
            this.dgSigno12.Width = 41;
            // 
            // dgSigno13
            // 
            this.dgSigno13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno13.DataPropertyName = "13";
            this.dgSigno13.HeaderText = "13";
            this.dgSigno13.MaxInputLength = 5;
            this.dgSigno13.Name = "dgSigno13";
            this.dgSigno13.Width = 41;
            // 
            // dgSigno14
            // 
            this.dgSigno14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno14.DataPropertyName = "14";
            this.dgSigno14.HeaderText = "14";
            this.dgSigno14.MaxInputLength = 5;
            this.dgSigno14.Name = "dgSigno14";
            this.dgSigno14.Width = 40;
            // 
            // dgSigno15
            // 
            this.dgSigno15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno15.DataPropertyName = "15";
            this.dgSigno15.HeaderText = "15";
            this.dgSigno15.MaxInputLength = 5;
            this.dgSigno15.Name = "dgSigno15";
            this.dgSigno15.Width = 40;
            // 
            // dgSigno16
            // 
            this.dgSigno16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno16.DataPropertyName = "16";
            this.dgSigno16.HeaderText = "16";
            this.dgSigno16.MaxInputLength = 5;
            this.dgSigno16.Name = "dgSigno16";
            this.dgSigno16.Width = 40;
            // 
            // dgSigno17
            // 
            this.dgSigno17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno17.DataPropertyName = "17";
            this.dgSigno17.HeaderText = "17";
            this.dgSigno17.MaxInputLength = 5;
            this.dgSigno17.Name = "dgSigno17";
            this.dgSigno17.Width = 40;
            // 
            // dgSigno18
            // 
            this.dgSigno18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno18.DataPropertyName = "18";
            this.dgSigno18.HeaderText = "18";
            this.dgSigno18.MaxInputLength = 5;
            this.dgSigno18.Name = "dgSigno18";
            this.dgSigno18.Width = 40;
            // 
            // dgSigno19
            // 
            this.dgSigno19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno19.DataPropertyName = "19";
            this.dgSigno19.HeaderText = "19";
            this.dgSigno19.MaxInputLength = 5;
            this.dgSigno19.Name = "dgSigno19";
            this.dgSigno19.Width = 40;
            // 
            // dgSigno20
            // 
            this.dgSigno20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno20.DataPropertyName = "20";
            this.dgSigno20.HeaderText = "20";
            this.dgSigno20.MaxInputLength = 5;
            this.dgSigno20.Name = "dgSigno20";
            this.dgSigno20.Width = 40;
            // 
            // dgSigno21
            // 
            this.dgSigno21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno21.DataPropertyName = "21";
            this.dgSigno21.HeaderText = "21";
            this.dgSigno21.MaxInputLength = 5;
            this.dgSigno21.Name = "dgSigno21";
            this.dgSigno21.Width = 40;
            // 
            // dgSigno22
            // 
            this.dgSigno22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno22.DataPropertyName = "22";
            this.dgSigno22.HeaderText = "22";
            this.dgSigno22.MaxInputLength = 5;
            this.dgSigno22.Name = "dgSigno22";
            this.dgSigno22.Width = 40;
            // 
            // dgSigno23
            // 
            this.dgSigno23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgSigno23.DataPropertyName = "23";
            this.dgSigno23.HeaderText = "23";
            this.dgSigno23.MaxInputLength = 5;
            this.dgSigno23.Name = "dgSigno23";
            this.dgSigno23.Width = 40;
            // 
            // tabControlGalactus1
            // 
            this.tabControlGalactus1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlGalactus1.Controls.Add(this.tpSignos);
            this.tabControlGalactus1.Controls.Add(this.tpMedicamentos);
            this.tabControlGalactus1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlGalactus1.ItemSize = new System.Drawing.Size(30, 120);
            this.tabControlGalactus1.Location = new System.Drawing.Point(3, 46);
            this.tabControlGalactus1.Multiline = true;
            this.tabControlGalactus1.Name = "tabControlGalactus1";
            this.tabControlGalactus1.SelectedIndex = 0;
            this.tabControlGalactus1.Size = new System.Drawing.Size(1263, 377);
            this.tabControlGalactus1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlGalactus1.TabIndex = 11;
            // 
            // SabanaEnfermeriaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 455);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.tabControlGalactus1);
            this.Controls.Add(this.pnlInformacion);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SabanaEnfermeriaUI";
            this.Text = "SabanaEnfermeriaUI";
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.tpSignos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabanaSignos)).EndInit();
            this.tabControlGalactus1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tstModificar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpMedicamentos;
        private System.Windows.Forms.TabPage tpSignos;
        public System.Windows.Forms.DataGridView dgvSabanaSignos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSabanaIdSigno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSabanaDescripcionSigno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno00;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno01;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno02;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno03;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno04;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno05;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno06;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno07;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno08;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno09;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSigno23;
        private Util.Controles.TabControlGalactus tabControlGalactus1;
    }
}