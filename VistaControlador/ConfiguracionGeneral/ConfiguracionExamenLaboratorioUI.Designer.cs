namespace Galactus.VistaControlador.ConfiguracionGeneral
{
    partial class ConfiguracionExamenLaboratorioUI
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.pacientePB = new System.Windows.Forms.PictureBox();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.pnPaginador = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btBuscarSinGrupoCUPS = new System.Windows.Forms.Button();
            this.tabControlGalactus1 = new Galactus.Util.Controles.TabControlGalactus();
            this.tpClasificacion = new System.Windows.Forms.TabPage();
            this.dgvClasificacionParaclinico = new System.Windows.Forms.DataGridView();
            this.dgIdProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCups = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tsbBuscarGrupos = new System.Windows.Forms.Button();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpClasificacionExamen = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvClasificacionExamen = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btBuscarTipoExamen = new System.Windows.Forms.Button();
            this.txtTipoExamen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpNoAgrupable = new System.Windows.Forms.TabPage();
            this.txtBuscarItems = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacientePB)).BeginInit();
            this.tstMenuPatron.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlGalactus1.SuspendLayout();
            this.tpClasificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacionParaclinico)).BeginInit();
            this.tpClasificacionExamen.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacionExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1027, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 63;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 12F);
            this.label30.Location = new System.Drawing.Point(60, 15);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(209, 18);
            this.label30.TabIndex = 60;
            this.label30.Text = "Configuración de Paraclinico";
            // 
            // pacientePB
            // 
            this.pacientePB.Image = global::Galactus.Properties.Resources.user__1_;
            this.pacientePB.Location = new System.Drawing.Point(25, 4);
            this.pacientePB.Name = "pacientePB";
            this.pacientePB.Size = new System.Drawing.Size(31, 31);
            this.pacientePB.TabIndex = 61;
            this.pacientePB.TabStop = false;
            // 
            // tstMenuPatron
            // 
            this.tstMenuPatron.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuPatron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 555);
            this.tstMenuPatron.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.TabIndex = 59;
            this.tstMenuPatron.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbGuardar.Image = global::Galactus.Properties.Resources.btn_guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbRegistros);
            this.panel1.Controls.Add(this.pnPaginador);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btBuscarSinGrupoCUPS);
            this.panel1.Controls.Add(this.tabControlGalactus1);
            this.panel1.Controls.Add(this.txtBuscarItems);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Location = new System.Drawing.Point(23, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 509);
            this.panel1.TabIndex = 62;
            // 
            // lbRegistros
            // 
            this.lbRegistros.AutoSize = true;
            this.lbRegistros.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistros.Location = new System.Drawing.Point(876, 479);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Size = new System.Drawing.Size(84, 15);
            this.lbRegistros.TabIndex = 48;
            this.lbRegistros.Text = "N° Registro: 0";
            // 
            // pnPaginador
            // 
            this.pnPaginador.AutoScroll = true;
            this.pnPaginador.Location = new System.Drawing.Point(3, 471);
            this.pnPaginador.Name = "pnPaginador";
            this.pnPaginador.Size = new System.Drawing.Size(854, 35);
            this.pnPaginador.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Filtro:";
            // 
            // btBuscarSinGrupoCUPS
            // 
            this.btBuscarSinGrupoCUPS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarSinGrupoCUPS.Image = global::Galactus.Properties.Resources.btn_lupa;
            this.btBuscarSinGrupoCUPS.Location = new System.Drawing.Point(976, 4);
            this.btBuscarSinGrupoCUPS.Name = "btBuscarSinGrupoCUPS";
            this.btBuscarSinGrupoCUPS.Size = new System.Drawing.Size(26, 24);
            this.btBuscarSinGrupoCUPS.TabIndex = 28;
            this.btBuscarSinGrupoCUPS.UseVisualStyleBackColor = true;
            this.btBuscarSinGrupoCUPS.Click += new System.EventHandler(this.btBuscarSinGrupoCUPS_Click);
            // 
            // tabControlGalactus1
            // 
            this.tabControlGalactus1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlGalactus1.Controls.Add(this.tpClasificacion);
            this.tabControlGalactus1.Controls.Add(this.tpClasificacionExamen);
            this.tabControlGalactus1.Controls.Add(this.tpNoAgrupable);
            this.tabControlGalactus1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlGalactus1.ItemSize = new System.Drawing.Size(30, 120);
            this.tabControlGalactus1.Location = new System.Drawing.Point(3, 32);
            this.tabControlGalactus1.Multiline = true;
            this.tabControlGalactus1.Name = "tabControlGalactus1";
            this.tabControlGalactus1.SelectedIndex = 0;
            this.tabControlGalactus1.Size = new System.Drawing.Size(1003, 439);
            this.tabControlGalactus1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlGalactus1.TabIndex = 41;
            // 
            // tpClasificacion
            // 
            this.tpClasificacion.Controls.Add(this.dgvClasificacionParaclinico);
            this.tpClasificacion.Controls.Add(this.tsbBuscarGrupos);
            this.tpClasificacion.Controls.Add(this.txtGrupo);
            this.tpClasificacion.Controls.Add(this.label1);
            this.tpClasificacion.Location = new System.Drawing.Point(124, 4);
            this.tpClasificacion.Name = "tpClasificacion";
            this.tpClasificacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpClasificacion.Size = new System.Drawing.Size(875, 431);
            this.tpClasificacion.TabIndex = 0;
            this.tpClasificacion.Text = "Clasificación de Procedimientos";
            this.tpClasificacion.UseVisualStyleBackColor = true;
            // 
            // dgvClasificacionParaclinico
            // 
            this.dgvClasificacionParaclinico.AllowUserToAddRows = false;
            this.dgvClasificacionParaclinico.AllowUserToDeleteRows = false;
            this.dgvClasificacionParaclinico.AllowUserToResizeColumns = false;
            this.dgvClasificacionParaclinico.AllowUserToResizeRows = false;
            this.dgvClasificacionParaclinico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClasificacionParaclinico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClasificacionParaclinico.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClasificacionParaclinico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasificacionParaclinico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdProcedimiento,
            this.dgCups,
            this.dgDescripcion,
            this.dgEstado});
            this.dgvClasificacionParaclinico.Location = new System.Drawing.Point(6, 37);
            this.dgvClasificacionParaclinico.MultiSelect = false;
            this.dgvClasificacionParaclinico.Name = "dgvClasificacionParaclinico";
            this.dgvClasificacionParaclinico.ReadOnly = true;
            this.dgvClasificacionParaclinico.RowHeadersVisible = false;
            this.dgvClasificacionParaclinico.Size = new System.Drawing.Size(860, 388);
            this.dgvClasificacionParaclinico.TabIndex = 49;
            this.dgvClasificacionParaclinico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasificacionParaclinico_CellClick);
            // 
            // dgIdProcedimiento
            // 
            this.dgIdProcedimiento.HeaderText = "idProcedimiento";
            this.dgIdProcedimiento.Name = "dgIdProcedimiento";
            this.dgIdProcedimiento.ReadOnly = true;
            this.dgIdProcedimiento.Visible = false;
            this.dgIdProcedimiento.Width = 103;
            // 
            // dgCups
            // 
            this.dgCups.HeaderText = "Cups";
            this.dgCups.Name = "dgCups";
            this.dgCups.ReadOnly = true;
            this.dgCups.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgCups.Width = 43;
            // 
            // dgDescripcion
            // 
            this.dgDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescripcion.HeaderText = "Descripcion";
            this.dgDescripcion.Name = "dgDescripcion";
            this.dgDescripcion.ReadOnly = true;
            this.dgDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgEstado
            // 
            this.dgEstado.HeaderText = "Estado";
            this.dgEstado.Name = "dgEstado";
            this.dgEstado.ReadOnly = true;
            this.dgEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgEstado.Width = 71;
            // 
            // tsbBuscarGrupos
            // 
            this.tsbBuscarGrupos.Image = global::Galactus.Properties.Resources.btn_lupa;
            this.tsbBuscarGrupos.Location = new System.Drawing.Point(317, 7);
            this.tsbBuscarGrupos.Name = "tsbBuscarGrupos";
            this.tsbBuscarGrupos.Size = new System.Drawing.Size(26, 24);
            this.tsbBuscarGrupos.TabIndex = 48;
            this.tsbBuscarGrupos.UseVisualStyleBackColor = true;
            this.tsbBuscarGrupos.Click += new System.EventHandler(this.tsbBuscarGrupos_Click);
            // 
            // txtGrupo
            // 
            this.txtGrupo.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtGrupo.Location = new System.Drawing.Point(60, 9);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.ReadOnly = true;
            this.txtGrupo.Size = new System.Drawing.Size(256, 21);
            this.txtGrupo.TabIndex = 47;
            this.txtGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Grupo:";
            // 
            // tpClasificacionExamen
            // 
            this.tpClasificacionExamen.Controls.Add(this.panel5);
            this.tpClasificacionExamen.Location = new System.Drawing.Point(124, 4);
            this.tpClasificacionExamen.Name = "tpClasificacionExamen";
            this.tpClasificacionExamen.Padding = new System.Windows.Forms.Padding(3);
            this.tpClasificacionExamen.Size = new System.Drawing.Size(875, 431);
            this.tpClasificacionExamen.TabIndex = 1;
            this.tpClasificacionExamen.Text = "Clasificación Examén";
            this.tpClasificacionExamen.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgvClasificacionExamen);
            this.panel5.Controls.Add(this.btBuscarTipoExamen);
            this.panel5.Controls.Add(this.txtTipoExamen);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(8, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(861, 464);
            this.panel5.TabIndex = 53;
            // 
            // dgvClasificacionExamen
            // 
            this.dgvClasificacionExamen.AllowUserToAddRows = false;
            this.dgvClasificacionExamen.AllowUserToDeleteRows = false;
            this.dgvClasificacionExamen.AllowUserToResizeColumns = false;
            this.dgvClasificacionExamen.AllowUserToResizeRows = false;
            this.dgvClasificacionExamen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClasificacionExamen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClasificacionExamen.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClasificacionExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasificacionExamen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.dgvClasificacionExamen.Location = new System.Drawing.Point(-1, 34);
            this.dgvClasificacionExamen.MultiSelect = false;
            this.dgvClasificacionExamen.Name = "dgvClasificacionExamen";
            this.dgvClasificacionExamen.ReadOnly = true;
            this.dgvClasificacionExamen.RowHeadersVisible = false;
            this.dgvClasificacionExamen.Size = new System.Drawing.Size(860, 388);
            this.dgvClasificacionExamen.TabIndex = 53;
            this.dgvClasificacionExamen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasificacionParaclinico_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "idProcedimiento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 103;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cups";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 43;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Estado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 71;
            // 
            // btBuscarTipoExamen
            // 
            this.btBuscarTipoExamen.Image = global::Galactus.Properties.Resources.btn_lupa;
            this.btBuscarTipoExamen.Location = new System.Drawing.Point(351, 4);
            this.btBuscarTipoExamen.Name = "btBuscarTipoExamen";
            this.btBuscarTipoExamen.Size = new System.Drawing.Size(26, 24);
            this.btBuscarTipoExamen.TabIndex = 52;
            this.btBuscarTipoExamen.UseVisualStyleBackColor = true;
            this.btBuscarTipoExamen.Click += new System.EventHandler(this.btBuscarTipoExamen_Click);
            // 
            // txtTipoExamen
            // 
            this.txtTipoExamen.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtTipoExamen.Location = new System.Drawing.Point(90, 6);
            this.txtTipoExamen.Name = "txtTipoExamen";
            this.txtTipoExamen.ReadOnly = true;
            this.txtTipoExamen.Size = new System.Drawing.Size(256, 21);
            this.txtTipoExamen.TabIndex = 51;
            this.txtTipoExamen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tipo Examén:";
            // 
            // tpNoAgrupable
            // 
            this.tpNoAgrupable.Location = new System.Drawing.Point(124, 4);
            this.tpNoAgrupable.Name = "tpNoAgrupable";
            this.tpNoAgrupable.Padding = new System.Windows.Forms.Padding(3);
            this.tpNoAgrupable.Size = new System.Drawing.Size(875, 431);
            this.tpNoAgrupable.TabIndex = 3;
            this.tpNoAgrupable.Text = "Examenes no agrupables";
            this.tpNoAgrupable.UseVisualStyleBackColor = true;
            // 
            // txtBuscarItems
            // 
            this.txtBuscarItems.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarItems.Location = new System.Drawing.Point(127, 5);
            this.txtBuscarItems.Name = "txtBuscarItems";
            this.txtBuscarItems.Size = new System.Drawing.Size(843, 21);
            this.txtBuscarItems.TabIndex = 25;
            this.txtBuscarItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarItems_KeyDown);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(8, 246);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(0, 20);
            this.label43.TabIndex = 40;
            // 
            // ConfiguracionExamenLaboratorioUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 580);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.pacientePB);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1059, 580);
            this.MinimumSize = new System.Drawing.Size(1059, 580);
            this.Name = "ConfiguracionExamenLaboratorioUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfiguracionExamenLaboratorioUI";
            this.Load += new System.EventHandler(this.ConfiguracionExamenLaboratorioUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientePB)).EndInit();
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlGalactus1.ResumeLayout(false);
            this.tpClasificacion.ResumeLayout(false);
            this.tpClasificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacionParaclinico)).EndInit();
            this.tpClasificacionExamen.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacionExamen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PictureBox pacientePB;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.Panel panel1;
        private Util.Controles.TabControlGalactus tabControlGalactus1;
        private System.Windows.Forms.TabPage tpClasificacion;
        private System.Windows.Forms.Button btBuscarSinGrupoCUPS;
        private System.Windows.Forms.TextBox txtBuscarItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpClasificacionExamen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TabPage tpNoAgrupable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPaginador;
        private System.Windows.Forms.Label lbRegistros;
        private System.Windows.Forms.Button tsbBuscarGrupos;
        private System.Windows.Forms.TextBox txtGrupo;
        internal System.Windows.Forms.DataGridView dgvClasificacionParaclinico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCups;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgEstado;
        internal System.Windows.Forms.DataGridView dgvClasificacionExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btBuscarTipoExamen;
        private System.Windows.Forms.TextBox txtTipoExamen;
        private System.Windows.Forms.Label label2;
    }
}