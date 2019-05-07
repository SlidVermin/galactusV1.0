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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvDiagnostico = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.fechaIngreso = new System.Windows.Forms.DateTimePicker();
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
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tstModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ndValor = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.dgCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnostico)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientePB)).BeginInit();
            this.tstMenuPatron.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndValor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 455);
            this.panel1.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgvDiagnostico);
            this.panel5.Location = new System.Drawing.Point(10, 267);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(923, 169);
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
            this.dgCodigo,
            this.dgDescripcion,
            this.dgQuitar,
            this.dgAgregar});
            this.dgvDiagnostico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiagnostico.Location = new System.Drawing.Point(0, 0);
            this.dgvDiagnostico.Name = "dgvDiagnostico";
            this.dgvDiagnostico.ReadOnly = true;
            this.dgvDiagnostico.RowHeadersVisible = false;
            this.dgvDiagnostico.ShowCellErrors = false;
            this.dgvDiagnostico.ShowCellToolTips = false;
            this.dgvDiagnostico.ShowEditingIcon = false;
            this.dgvDiagnostico.ShowRowErrors = false;
            this.dgvDiagnostico.Size = new System.Drawing.Size(921, 167);
            this.dgvDiagnostico.TabIndex = 0;
            this.dgvDiagnostico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnostico_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Diagnóstico de remision";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label4);
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
            this.panel4.Location = new System.Drawing.Point(10, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(923, 148);
            this.panel4.TabIndex = 53;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(722, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 15);
            this.label12.TabIndex = 60027;
            this.label12.Text = "Fecha ingreso:";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIngreso.Location = new System.Drawing.Point(812, 6);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(102, 20);
            this.fechaIngreso.TabIndex = 60026;
            // 
            // cbArea
            // 
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(103, 59);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(320, 21);
            this.cbArea.TabIndex = 60025;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(61, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 60024;
            this.label9.Text = "Area:";
            // 
            // cbCama
            // 
            this.cbCama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCama.FormattingEnabled = true;
            this.cbCama.Location = new System.Drawing.Point(103, 113);
            this.cbCama.Name = "cbCama";
            this.cbCama.Size = new System.Drawing.Size(320, 21);
            this.cbCama.TabIndex = 60023;
            // 
            // cbEntorno
            // 
            this.cbEntorno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntorno.FormattingEnabled = true;
            this.cbEntorno.Location = new System.Drawing.Point(103, 86);
            this.cbEntorno.Name = "cbEntorno";
            this.cbEntorno.Size = new System.Drawing.Size(320, 21);
            this.cbEntorno.TabIndex = 60022;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Arial", 9F);
            this.Label20.ForeColor = System.Drawing.Color.Black;
            this.Label20.Location = new System.Drawing.Point(494, 32);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(95, 15);
            this.Label20.TabIndex = 60021;
            this.Label20.Text = "N°. Autorización:";
            // 
            // Textautorizacion
            // 
            this.Textautorizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textautorizacion.Location = new System.Drawing.Point(596, 30);
            this.Textautorizacion.Name = "Textautorizacion";
            this.Textautorizacion.ReadOnly = true;
            this.Textautorizacion.Size = new System.Drawing.Size(320, 21);
            this.Textautorizacion.TabIndex = 60018;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.Black;
            this.Label15.Location = new System.Drawing.Point(54, 114);
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
            this.Label16.Location = new System.Drawing.Point(45, 88);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(53, 15);
            this.Label16.TabIndex = 60019;
            this.Label16.Text = "Entorno:";
            // 
            // cbInstitucion
            // 
            this.cbInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstitucion.FormattingEnabled = true;
            this.cbInstitucion.Location = new System.Drawing.Point(596, 6);
            this.cbInstitucion.Name = "cbInstitucion";
            this.cbInstitucion.Size = new System.Drawing.Size(320, 21);
            this.cbInstitucion.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.Location = new System.Drawing.Point(521, 9);
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
            this.cbCausaExterna.Size = new System.Drawing.Size(320, 21);
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
            this.cbVia.Size = new System.Drawing.Size(320, 21);
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
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Datos de ingreso";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.fechaIngreso);
            this.panel2.Controls.Add(this.txtFechaAdmision);
            this.panel2.Controls.Add(this.btPacienteAdmision);
            this.panel2.Controls.Add(this.txtnombrePaciente);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtIdAdmision);
            this.panel2.Location = new System.Drawing.Point(12, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 33);
            this.panel2.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(514, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fecha admision:";
            // 
            // txtFechaAdmision
            // 
            this.txtFechaAdmision.Location = new System.Drawing.Point(619, 4);
            this.txtFechaAdmision.Name = "txtFechaAdmision";
            this.txtFechaAdmision.ReadOnly = true;
            this.txtFechaAdmision.Size = new System.Drawing.Size(98, 20);
            this.txtFechaAdmision.TabIndex = 34;
            // 
            // btPacienteAdmision
            // 
            this.btPacienteAdmision.Image = global::Galactus.Properties.Resources.btn_lupa;
            this.btPacienteAdmision.Location = new System.Drawing.Point(162, 2);
            this.btPacienteAdmision.Name = "btPacienteAdmision";
            this.btPacienteAdmision.Size = new System.Drawing.Size(26, 24);
            this.btPacienteAdmision.TabIndex = 33;
            this.btPacienteAdmision.UseVisualStyleBackColor = true;
            this.btPacienteAdmision.Click += new System.EventHandler(this.btPacienteAdmision_Click);
            // 
            // txtnombrePaciente
            // 
            this.txtnombrePaciente.Location = new System.Drawing.Point(252, 4);
            this.txtnombrePaciente.Name = "txtnombrePaciente";
            this.txtnombrePaciente.ReadOnly = true;
            this.txtnombrePaciente.Size = new System.Drawing.Size(258, 20);
            this.txtnombrePaciente.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(191, 6);
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
            this.txtIdAdmision.Size = new System.Drawing.Size(73, 20);
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
            this.label30.Location = new System.Drawing.Point(53, 13);
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
            this.btnSalir.Location = new System.Drawing.Point(937, 5);
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
            this.pacientePB.Location = new System.Drawing.Point(12, 5);
            this.pacientePB.Name = "pacientePB";
            this.pacientePB.Size = new System.Drawing.Size(35, 31);
            this.pacientePB.TabIndex = 41;
            this.pacientePB.TabStop = false;
            // 
            // tstMenuPatron
            // 
            this.tstMenuPatron.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuPatron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tstModificar,
            this.tsbGuardar,
            this.tsbCancelar,
            this.tsbBuscar,
            this.tsbAnular});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 501);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(969, 25);
            this.tstMenuPatron.TabIndex = 46;
            this.tstMenuPatron.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::Galactus.Properties.Resources.btn_nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click_2);
            // 
            // tstModificar
            // 
            this.tstModificar.Image = global::Galactus.Properties.Resources.bt_Editar;
            this.tstModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstModificar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tstModificar.Name = "tstModificar";
            this.tstModificar.Size = new System.Drawing.Size(78, 22);
            this.tstModificar.Text = "Modificar";
            this.tstModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tstModificar.Click += new System.EventHandler(this.tstModificar_Click_2);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = global::Galactus.Properties.Resources.btn_cancelar;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click_1);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::Galactus.Properties.Resources.btn_guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = global::Galactus.Properties.Resources.btn_buscar;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(62, 22);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click_1);
            // 
            // tsbAnular
            // 
            this.tsbAnular.Image = global::Galactus.Properties.Resources.btn_anular;
            this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnular.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbAnular.Name = "tsbAnular";
            this.tsbAnular.Size = new System.Drawing.Size(62, 22);
            this.tsbAnular.Text = "Anular";
            this.tsbAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbAnular.Click += new System.EventHandler(this.tsbAnular_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 60026;
            this.label4.Text = "Atención furips";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ndValor);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Location = new System.Drawing.Point(497, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 29);
            this.panel3.TabIndex = 60027;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.checkBox1.Location = new System.Drawing.Point(4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Atencion FURIPS";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ndValor
            // 
            this.ndValor.Location = new System.Drawing.Point(229, 4);
            this.ndValor.Name = "ndValor";
            this.ndValor.Size = new System.Drawing.Size(185, 20);
            this.ndValor.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(153, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 15);
            this.label14.TabIndex = 75;
            this.label14.Text = "Valor saldo:";
            // 
            // dgCodigo
            // 
            this.dgCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgCodigo.HeaderText = "Código";
            this.dgCodigo.Name = "dgCodigo";
            this.dgCodigo.ReadOnly = true;
            this.dgCodigo.Width = 65;
            // 
            // dgDescripcion
            // 
            this.dgDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescripcion.HeaderText = "Descripcion";
            this.dgDescripcion.Name = "dgDescripcion";
            this.dgDescripcion.ReadOnly = true;
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
            // dgAgregar
            // 
            this.dgAgregar.HeaderText = "Agregar";
            this.dgAgregar.Image = global::Galactus.Properties.Resources.farmacia_ico;
            this.dgAgregar.Name = "dgAgregar";
            this.dgAgregar.ReadOnly = true;
            this.dgAgregar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAgregar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IngresoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 526);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.pacientePB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(969, 526);
            this.MinimumSize = new System.Drawing.Size(969, 526);
            this.Name = "IngresoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.IngresoUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnostico)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientePB)).EndInit();
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
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
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker fechaIngreso;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tstModificar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ndValor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcion;
        private System.Windows.Forms.DataGridViewImageColumn dgQuitar;
        private System.Windows.Forms.DataGridViewImageColumn dgAgregar;
    }
}