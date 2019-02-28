namespace Galactus.VistaControlador.Admision
{
    partial class IngresoUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tBtEditar = new System.Windows.Forms.ToolStripButton();
            this.tBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tBtAnular = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvDiagnostico = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCama = new System.Windows.Forms.ComboBox();
            this.cbEntorno = new System.Windows.Forms.ComboBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Textautorizacion = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.cbInstitucion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCausaExterna = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbVia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbPrefacturado = new System.Windows.Forms.RadioButton();
            this.rbAuditoria = new System.Windows.Forms.RadioButton();
            this.rbCerrado = new System.Windows.Forms.RadioButton();
            this.rbFacturado = new System.Windows.Forms.RadioButton();
            this.rbReabrir = new System.Windows.Forms.RadioButton();
            this.rbIniciado = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaAdmision = new System.Windows.Forms.TextBox();
            this.btPacienteAdmision = new System.Windows.Forms.Button();
            this.txtnombrePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdAdmision = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pacientePB = new System.Windows.Forms.PictureBox();
            this.txtobservacion = new System.Windows.Forms.RichTextBox();
            this.fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dgDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tstMenuPatron.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnostico)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientePB)).BeginInit();
            this.SuspendLayout();
            // 
            // tstMenuPatron
            // 
            this.tstMenuPatron.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuPatron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tBtNuevo,
            this.tBtEditar,
            this.tBtCancelar,
            this.tBtGuardar,
            this.tBtBuscar,
            this.tBtAnular});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 570);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(906, 25);
            this.tstMenuPatron.TabIndex = 38;
            this.tstMenuPatron.Text = "toolStrip1";
            // 
            // tBtNuevo
            // 
            this.tBtNuevo.Image = global::Galactus.Properties.Resources.btn_nuevo;
            this.tBtNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtNuevo.Name = "tBtNuevo";
            this.tBtNuevo.Size = new System.Drawing.Size(62, 22);
            this.tBtNuevo.Text = "Nuevo";
            this.tBtNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tBtNuevo.Click += new System.EventHandler(this.tBtNuevo_Click);
            // 
            // tBtEditar
            // 
            this.tBtEditar.Image = global::Galactus.Properties.Resources.bt_editar;
            this.tBtEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtEditar.Name = "tBtEditar";
            this.tBtEditar.Size = new System.Drawing.Size(57, 22);
            this.tBtEditar.Text = "Editar";
            this.tBtEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tBtEditar.Click += new System.EventHandler(this.tBtEditar_Click);
            // 
            // tBtCancelar
            // 
            this.tBtCancelar.Image = global::Galactus.Properties.Resources.btn_cancelar;
            this.tBtCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtCancelar.Name = "tBtCancelar";
            this.tBtCancelar.Size = new System.Drawing.Size(73, 22);
            this.tBtCancelar.Text = "Cancelar";
            this.tBtCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tBtCancelar.Click += new System.EventHandler(this.tBtCancelar_Click);
            // 
            // tBtGuardar
            // 
            this.tBtGuardar.Image = global::Galactus.Properties.Resources.btn_guardar;
            this.tBtGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtGuardar.Name = "tBtGuardar";
            this.tBtGuardar.Size = new System.Drawing.Size(69, 22);
            this.tBtGuardar.Text = "Guardar";
            this.tBtGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tBtGuardar.Click += new System.EventHandler(this.tBtGuardar_Click);
            // 
            // tBtBuscar
            // 
            this.tBtBuscar.Image = global::Galactus.Properties.Resources.btn_buscar;
            this.tBtBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtBuscar.Name = "tBtBuscar";
            this.tBtBuscar.Size = new System.Drawing.Size(62, 22);
            this.tBtBuscar.Text = "Buscar";
            this.tBtBuscar.Click += new System.EventHandler(this.tBtBuscar_Click);
            // 
            // tBtAnular
            // 
            this.tBtAnular.Image = global::Galactus.Properties.Resources.btn_anular;
            this.tBtAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtAnular.Name = "tBtAnular";
            this.tBtAnular.Size = new System.Drawing.Size(62, 22);
            this.tBtAnular.Text = "Anular";
            this.tBtAnular.Click += new System.EventHandler(this.tBtAnular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 513);
            this.panel1.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Observación";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtobservacion);
            this.panel6.Location = new System.Drawing.Point(10, 433);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(859, 75);
            this.panel6.TabIndex = 56;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgvDiagnostico);
            this.panel5.Location = new System.Drawing.Point(10, 278);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(859, 127);
            this.panel5.TabIndex = 55;
            // 
            // dgvDiagnostico
            // 
            this.dgvDiagnostico.AllowUserToAddRows = false;
            this.dgvDiagnostico.AllowUserToDeleteRows = false;
            this.dgvDiagnostico.AllowUserToResizeColumns = false;
            this.dgvDiagnostico.AllowUserToResizeRows = false;
            this.dgvDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnostico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgQuitar,
            this.dgCodigo,
            this.dgDescripcion});
            this.dgvDiagnostico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiagnostico.Location = new System.Drawing.Point(0, 0);
            this.dgvDiagnostico.Name = "dgvDiagnostico";
            this.dgvDiagnostico.ReadOnly = true;
            this.dgvDiagnostico.RowHeadersVisible = false;
            this.dgvDiagnostico.ShowCellErrors = false;
            this.dgvDiagnostico.ShowCellToolTips = false;
            this.dgvDiagnostico.ShowEditingIcon = false;
            this.dgvDiagnostico.ShowRowErrors = false;
            this.dgvDiagnostico.Size = new System.Drawing.Size(857, 125);
            this.dgvDiagnostico.TabIndex = 0;
            this.dgvDiagnostico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnostico_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Diagnóstico de remision";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.fechaIngreso);
            this.panel4.Controls.Add(this.cbArea);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cbCama);
            this.panel4.Controls.Add(this.cbEntorno);
            this.panel4.Controls.Add(this.Label20);
            this.panel4.Controls.Add(this.Textautorizacion);
            this.panel4.Controls.Add(this.Label15);
            this.panel4.Controls.Add(this.Label16);
            this.panel4.Controls.Add(this.cbInstitucion);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cbCausaExterna);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.cbVia);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(10, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(859, 90);
            this.panel4.TabIndex = 53;
            // 
            // cbArea
            // 
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(607, 60);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(244, 21);
            this.cbArea.TabIndex = 60025;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(558, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 60024;
            this.label9.Text = "Area:";
            // 
            // cbCama
            // 
            this.cbCama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCama.FormattingEnabled = true;
            this.cbCama.Location = new System.Drawing.Point(607, 34);
            this.cbCama.Name = "cbCama";
            this.cbCama.Size = new System.Drawing.Size(244, 21);
            this.cbCama.TabIndex = 60023;
            // 
            // cbEntorno
            // 
            this.cbEntorno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntorno.FormattingEnabled = true;
            this.cbEntorno.Location = new System.Drawing.Point(607, 8);
            this.cbEntorno.Name = "cbEntorno";
            this.cbEntorno.Size = new System.Drawing.Size(244, 21);
            this.cbEntorno.TabIndex = 60022;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.Color.Black;
            this.Label20.Location = new System.Drawing.Point(318, 62);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(97, 15);
            this.Label20.TabIndex = 60021;
            this.Label20.Text = "N°. Autorización:";
            // 
            // Textautorizacion
            // 
            this.Textautorizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textautorizacion.Location = new System.Drawing.Point(418, 60);
            this.Textautorizacion.Name = "Textautorizacion";
            this.Textautorizacion.ReadOnly = true;
            this.Textautorizacion.Size = new System.Drawing.Size(134, 21);
            this.Textautorizacion.TabIndex = 60018;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.Black;
            this.Label15.Location = new System.Drawing.Point(558, 35);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(43, 15);
            this.Label15.TabIndex = 60020;
            this.Label15.Text = "Cama:";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.Color.Black;
            this.Label16.Location = new System.Drawing.Point(548, 11);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(53, 15);
            this.Label16.TabIndex = 60019;
            this.Label16.Text = "Entorno:";
            // 
            // cbInstitucion
            // 
            this.cbInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstitucion.FormattingEnabled = true;
            this.cbInstitucion.Location = new System.Drawing.Point(103, 59);
            this.cbInstitucion.Name = "cbInstitucion";
            this.cbInstitucion.Size = new System.Drawing.Size(200, 21);
            this.cbInstitucion.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.Location = new System.Drawing.Point(6, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Institución:";
            // 
            // cbCausaExterna
            // 
            this.cbCausaExterna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCausaExterna.FormattingEnabled = true;
            this.cbCausaExterna.Location = new System.Drawing.Point(103, 32);
            this.cbCausaExterna.Name = "cbCausaExterna";
            this.cbCausaExterna.Size = new System.Drawing.Size(241, 21);
            this.cbCausaExterna.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Causa externa:";
            // 
            // cbVia
            // 
            this.cbVia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVia.FormattingEnabled = true;
            this.cbVia.Location = new System.Drawing.Point(103, 5);
            this.cbVia.Name = "cbVia";
            this.cbVia.Size = new System.Drawing.Size(241, 21);
            this.cbVia.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Via de ingreso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Datos de ingreso";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbPrefacturado);
            this.panel3.Controls.Add(this.rbAuditoria);
            this.panel3.Controls.Add(this.rbCerrado);
            this.panel3.Controls.Add(this.rbFacturado);
            this.panel3.Controls.Add(this.rbReabrir);
            this.panel3.Controls.Add(this.rbIniciado);
            this.panel3.Location = new System.Drawing.Point(10, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 37);
            this.panel3.TabIndex = 51;
            // 
            // rbPrefacturado
            // 
            this.rbPrefacturado.AutoSize = true;
            this.rbPrefacturado.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrefacturado.Image = global::Galactus.Properties.Resources.User_Green_icon__1_;
            this.rbPrefacturado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbPrefacturado.Location = new System.Drawing.Point(726, 6);
            this.rbPrefacturado.Name = "rbPrefacturado";
            this.rbPrefacturado.Size = new System.Drawing.Size(125, 24);
            this.rbPrefacturado.TabIndex = 10;
            this.rbPrefacturado.Tag = "6";
            this.rbPrefacturado.Text = "    Pre-Facturado";
            this.rbPrefacturado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPrefacturado.UseVisualStyleBackColor = true;
            // 
            // rbAuditoria
            // 
            this.rbAuditoria.AutoSize = true;
            this.rbAuditoria.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAuditoria.Image = global::Galactus.Properties.Resources.User_Orange_icon;
            this.rbAuditoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbAuditoria.Location = new System.Drawing.Point(591, 6);
            this.rbAuditoria.Name = "rbAuditoria";
            this.rbAuditoria.Size = new System.Drawing.Size(96, 24);
            this.rbAuditoria.TabIndex = 9;
            this.rbAuditoria.Tag = "5";
            this.rbAuditoria.Text = "    Auditoria";
            this.rbAuditoria.UseVisualStyleBackColor = true;
            // 
            // rbCerrado
            // 
            this.rbCerrado.AutoSize = true;
            this.rbCerrado.Enabled = false;
            this.rbCerrado.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCerrado.Image = global::Galactus.Properties.Resources.User_Red_icon__1_;
            this.rbCerrado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbCerrado.Location = new System.Drawing.Point(138, 6);
            this.rbCerrado.Name = "rbCerrado";
            this.rbCerrado.Size = new System.Drawing.Size(88, 24);
            this.rbCerrado.TabIndex = 6;
            this.rbCerrado.Tag = "2";
            this.rbCerrado.Text = "    Cerrado";
            this.rbCerrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbCerrado.UseVisualStyleBackColor = true;
            // 
            // rbFacturado
            // 
            this.rbFacturado.AutoSize = true;
            this.rbFacturado.Enabled = false;
            this.rbFacturado.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFacturado.Image = global::Galactus.Properties.Resources.User_Blue_icon__1_;
            this.rbFacturado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbFacturado.Location = new System.Drawing.Point(451, 6);
            this.rbFacturado.Name = "rbFacturado";
            this.rbFacturado.Size = new System.Drawing.Size(101, 24);
            this.rbFacturado.TabIndex = 8;
            this.rbFacturado.Tag = "4";
            this.rbFacturado.Text = "    Facturado";
            this.rbFacturado.UseVisualStyleBackColor = true;
            // 
            // rbReabrir
            // 
            this.rbReabrir.AutoSize = true;
            this.rbReabrir.Enabled = false;
            this.rbReabrir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReabrir.Image = global::Galactus.Properties.Resources.User_Yellow_icon__1_;
            this.rbReabrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbReabrir.Location = new System.Drawing.Point(265, 6);
            this.rbReabrir.Name = "rbReabrir";
            this.rbReabrir.Size = new System.Drawing.Size(147, 24);
            this.rbReabrir.TabIndex = 7;
            this.rbReabrir.Tag = "3";
            this.rbReabrir.Text = "     Re-abrir atención";
            this.rbReabrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbReabrir.UseVisualStyleBackColor = true;
            // 
            // rbIniciado
            // 
            this.rbIniciado.AutoSize = true;
            this.rbIniciado.Checked = true;
            this.rbIniciado.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIniciado.Image = global::Galactus.Properties.Resources.User_Green_icon__1_;
            this.rbIniciado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbIniciado.Location = new System.Drawing.Point(10, 6);
            this.rbIniciado.Name = "rbIniciado";
            this.rbIniciado.Size = new System.Drawing.Size(89, 24);
            this.rbIniciado.TabIndex = 1;
            this.rbIniciado.TabStop = true;
            this.rbIniciado.Tag = "1";
            this.rbIniciado.Text = "    Iniciado";
            this.rbIniciado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbIniciado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Estado de atención";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFechaAdmision);
            this.panel2.Controls.Add(this.btPacienteAdmision);
            this.panel2.Controls.Add(this.txtnombrePaciente);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtIdAdmision);
            this.panel2.Location = new System.Drawing.Point(10, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 33);
            this.panel2.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(629, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fecha admision:";
            // 
            // txtFechaAdmision
            // 
            this.txtFechaAdmision.Location = new System.Drawing.Point(739, 4);
            this.txtFechaAdmision.Name = "txtFechaAdmision";
            this.txtFechaAdmision.ReadOnly = true;
            this.txtFechaAdmision.Size = new System.Drawing.Size(115, 20);
            this.txtFechaAdmision.TabIndex = 34;
            // 
            // btPacienteAdmision
            // 
            this.btPacienteAdmision.Image = global::Galactus.Properties.Resources.btn_lupa;
            this.btPacienteAdmision.Location = new System.Drawing.Point(193, 3);
            this.btPacienteAdmision.Name = "btPacienteAdmision";
            this.btPacienteAdmision.Size = new System.Drawing.Size(26, 24);
            this.btPacienteAdmision.TabIndex = 33;
            this.btPacienteAdmision.UseVisualStyleBackColor = true;
            this.btPacienteAdmision.Click += new System.EventHandler(this.btPacienteAdmision_Click);
            // 
            // txtnombrePaciente
            // 
            this.txtnombrePaciente.Location = new System.Drawing.Point(289, 4);
            this.txtnombrePaciente.Name = "txtnombrePaciente";
            this.txtnombrePaciente.ReadOnly = true;
            this.txtnombrePaciente.Size = new System.Drawing.Size(333, 20);
            this.txtnombrePaciente.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(232, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Admision:";
            // 
            // txtIdAdmision
            // 
            this.txtIdAdmision.Location = new System.Drawing.Point(86, 4);
            this.txtIdAdmision.Name = "txtIdAdmision";
            this.txtIdAdmision.ReadOnly = true;
            this.txtIdAdmision.Size = new System.Drawing.Size(100, 20);
            this.txtIdAdmision.TabIndex = 0;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(6, 7);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(176, 20);
            this.label33.TabIndex = 48;
            this.label33.Text = "Información principal";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 12F);
            this.label30.Location = new System.Drawing.Point(53, 21);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(145, 18);
            this.label30.TabIndex = 40;
            this.label30.Text = "Ingreso de paciente";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(868, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseHover += new System.EventHandler(this.btnSalir_MouseHover);
            // 
            // pacientePB
            // 
            this.pacientePB.Image = global::Galactus.Properties.Resources.user__1_;
            this.pacientePB.Location = new System.Drawing.Point(12, 13);
            this.pacientePB.Name = "pacientePB";
            this.pacientePB.Size = new System.Drawing.Size(35, 31);
            this.pacientePB.TabIndex = 41;
            this.pacientePB.TabStop = false;
            // 
            // txtobservacion
            // 
            this.txtobservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtobservacion.Location = new System.Drawing.Point(0, 0);
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(857, 73);
            this.txtobservacion.TabIndex = 0;
            this.txtobservacion.Text = "";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIngreso.Location = new System.Drawing.Point(440, 8);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(102, 20);
            this.fechaIngreso.TabIndex = 60026;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(350, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 15);
            this.label12.TabIndex = 60027;
            this.label12.Text = "Fecha ingreso:";
            // 
            // dgDescripcion
            // 
            this.dgDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescripcion.HeaderText = "Descripcion";
            this.dgDescripcion.Name = "dgDescripcion";
            this.dgDescripcion.ReadOnly = true;
            // 
            // dgCodigo
            // 
            this.dgCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgCodigo.HeaderText = "Código cie";
            this.dgCodigo.Name = "dgCodigo";
            this.dgCodigo.ReadOnly = true;
            this.dgCodigo.Width = 82;
            // 
            // dgQuitar
            // 
            this.dgQuitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "System.Drawing.Image";
            this.dgQuitar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgQuitar.HeaderText = "Quitar";
            this.dgQuitar.Image = global::Galactus.Properties.Resources.btn_anular;
            this.dgQuitar.Name = "dgQuitar";
            this.dgQuitar.ReadOnly = true;
            this.dgQuitar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgQuitar.Width = 41;
            // 
            // IngresoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 595);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.pacientePB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tstMenuPatron);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.IngresoUI_Load);
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnostico)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tBtNuevo;
        private System.Windows.Forms.ToolStripButton tBtEditar;
        private System.Windows.Forms.ToolStripButton tBtCancelar;
        private System.Windows.Forms.ToolStripButton tBtGuardar;
        private System.Windows.Forms.ToolStripButton tBtBuscar;
        private System.Windows.Forms.ToolStripButton tBtAnular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PictureBox pacientePB;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdAdmision;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtnombrePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaAdmision;
        private System.Windows.Forms.Button btPacienteAdmision;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.RadioButton rbPrefacturado;
        public System.Windows.Forms.RadioButton rbAuditoria;
        public System.Windows.Forms.RadioButton rbCerrado;
        public System.Windows.Forms.RadioButton rbFacturado;
        public System.Windows.Forms.RadioButton rbReabrir;
        public System.Windows.Forms.RadioButton rbIniciado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvDiagnostico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbArea;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCama;
        private System.Windows.Forms.ComboBox cbEntorno;
        public System.Windows.Forms.Label Label20;
        public System.Windows.Forms.TextBox Textautorizacion;
        public System.Windows.Forms.Label Label15;
        public System.Windows.Forms.Label Label16;
        private System.Windows.Forms.ComboBox cbInstitucion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCausaExterna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbVia;
        private System.Windows.Forms.RichTextBox txtobservacion;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker fechaIngreso;
        private System.Windows.Forms.DataGridViewImageColumn dgQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcion;
    }
}