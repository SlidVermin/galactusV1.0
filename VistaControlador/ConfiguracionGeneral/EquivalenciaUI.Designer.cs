﻿namespace Galactus.VistaControlador.ConfiguracionGeneral
{
    partial class EquivalenciaUI
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
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tstEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.gbInformacionATC = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbGrupoATC = new System.Windows.Forms.ComboBox();
            this.txtCodigoATC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcionATC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.gbDatosBasicos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numConce = new System.Windows.Forms.NumericUpDown();
            this.chkMedicamentoControl = new System.Windows.Forms.CheckBox();
            this.chkPos = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numOsmolalidad = new System.Windows.Forms.NumericUpDown();
            this.txtBUnidadMedida = new System.Windows.Forms.TextBox();
            this.tsbBuscarUnidades = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCaracteristicas = new System.Windows.Forms.GroupBox();
            this.tbcEquivalencia = new System.Windows.Forms.TabControl();
            this.tpCarcacteristicas = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvLineas = new System.Windows.Forms.DataGridView();
            this.CódigoL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripciónL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerificarL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvVias = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verificar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tstMenuPatron.SuspendLayout();
            this.gbInformacionATC.SuspendLayout();
            this.gbPrincipal.SuspendLayout();
            this.gbDatosBasicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOsmolalidad)).BeginInit();
            this.gbCaracteristicas.SuspendLayout();
            this.tbcEquivalencia.SuspendLayout();
            this.tpCarcacteristicas.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVias)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tstMenuPatron
            // 
            this.tstMenuPatron.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuPatron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tstEditar,
            this.tsbGuardar,
            this.tsbBuscar,
            this.tsbAnular,
            this.tsbCancelar});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 520);
            this.tstMenuPatron.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.TabIndex = 47;
            this.tstMenuPatron.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNuevo.Image = global::Galactus.Properties.Resources.btn_nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbNuevo.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tstEditar
            // 
            this.tstEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstEditar.Image = global::Galactus.Properties.Resources.bt_editar;
            this.tstEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstEditar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tstEditar.Name = "tstEditar";
            this.tstEditar.Size = new System.Drawing.Size(57, 22);
            this.tstEditar.Text = "Editar";
            this.tstEditar.Click += new System.EventHandler(this.tstEditar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCancelar.Image = global::Galactus.Properties.Resources.btn_cancelar;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
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
            // tsbBuscar
            // 
            this.tsbBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbBuscar.Image = global::Galactus.Properties.Resources.btn_buscar;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(62, 22);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbAnular
            // 
            this.tsbAnular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAnular.Image = global::Galactus.Properties.Resources.btn_anular;
            this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnular.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbAnular.Name = "tsbAnular";
            this.tsbAnular.Size = new System.Drawing.Size(62, 22);
            this.tsbAnular.Text = "Anular";
            this.tsbAnular.Click += new System.EventHandler(this.tsbAnular_Click);
            // 
            // gbInformacionATC
            // 
            this.gbInformacionATC.Controls.Add(this.label11);
            this.gbInformacionATC.Controls.Add(this.cbGrupoATC);
            this.gbInformacionATC.Controls.Add(this.txtCodigoATC);
            this.gbInformacionATC.Controls.Add(this.label8);
            this.gbInformacionATC.Controls.Add(this.txtDescripcionATC);
            this.gbInformacionATC.Controls.Add(this.label10);
            this.gbInformacionATC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionATC.Location = new System.Drawing.Point(514, 17);
            this.gbInformacionATC.Name = "gbInformacionATC";
            this.gbInformacionATC.Size = new System.Drawing.Size(451, 175);
            this.gbInformacionATC.TabIndex = 47;
            this.gbInformacionATC.TabStop = false;
            this.gbInformacionATC.Text = "Informacion ATC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Grupo:";
            // 
            // cbGrupoATC
            // 
            this.cbGrupoATC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupoATC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupoATC.FormattingEnabled = true;
            this.cbGrupoATC.Items.AddRange(new object[] {
            "---Seleccionar---",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "#N/A"});
            this.cbGrupoATC.Location = new System.Drawing.Point(86, 101);
            this.cbGrupoATC.Name = "cbGrupoATC";
            this.cbGrupoATC.Size = new System.Drawing.Size(100, 21);
            this.cbGrupoATC.TabIndex = 2;
            // 
            // txtCodigoATC
            // 
            this.txtCodigoATC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoATC.Location = new System.Drawing.Point(86, 49);
            this.txtCodigoATC.Name = "txtCodigoATC";
            this.txtCodigoATC.Size = new System.Drawing.Size(145, 20);
            this.txtCodigoATC.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Código: ";
            // 
            // txtDescripcionATC
            // 
            this.txtDescripcionATC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionATC.Location = new System.Drawing.Point(86, 75);
            this.txtDescripcionATC.Name = "txtDescripcionATC";
            this.txtDescripcionATC.Size = new System.Drawing.Size(349, 20);
            this.txtDescripcionATC.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Descripción: ";
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbPrincipal.Controls.Add(this.gbDatosBasicos);
            this.gbPrincipal.Controls.Add(this.gbCaracteristicas);
            this.gbPrincipal.Controls.Add(this.gbInformacionATC);
            this.gbPrincipal.Location = new System.Drawing.Point(12, 6);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(971, 511);
            this.gbPrincipal.TabIndex = 48;
            this.gbPrincipal.TabStop = false;
            // 
            // gbDatosBasicos
            // 
            this.gbDatosBasicos.Controls.Add(this.label3);
            this.gbDatosBasicos.Controls.Add(this.numConce);
            this.gbDatosBasicos.Controls.Add(this.chkMedicamentoControl);
            this.gbDatosBasicos.Controls.Add(this.chkPos);
            this.gbDatosBasicos.Controls.Add(this.label4);
            this.gbDatosBasicos.Controls.Add(this.numOsmolalidad);
            this.gbDatosBasicos.Controls.Add(this.txtBUnidadMedida);
            this.gbDatosBasicos.Controls.Add(this.tsbBuscarUnidades);
            this.gbDatosBasicos.Controls.Add(this.label5);
            this.gbDatosBasicos.Controls.Add(this.txtBCodigo);
            this.gbDatosBasicos.Controls.Add(this.label1);
            this.gbDatosBasicos.Controls.Add(this.txtDescripcion);
            this.gbDatosBasicos.Controls.Add(this.label2);
            this.gbDatosBasicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosBasicos.Location = new System.Drawing.Point(6, 16);
            this.gbDatosBasicos.Name = "gbDatosBasicos";
            this.gbDatosBasicos.Size = new System.Drawing.Size(490, 175);
            this.gbDatosBasicos.TabIndex = 64;
            this.gbDatosBasicos.TabStop = false;
            this.gbDatosBasicos.Text = "Datos Basicos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Concentración:";
            // 
            // numConce
            // 
            this.numConce.DecimalPlaces = 2;
            this.numConce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numConce.Location = new System.Drawing.Point(93, 110);
            this.numConce.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numConce.Name = "numConce";
            this.numConce.Size = new System.Drawing.Size(90, 20);
            this.numConce.TabIndex = 69;
            // 
            // chkMedicamentoControl
            // 
            this.chkMedicamentoControl.AutoSize = true;
            this.chkMedicamentoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMedicamentoControl.Location = new System.Drawing.Point(335, 143);
            this.chkMedicamentoControl.Name = "chkMedicamentoControl";
            this.chkMedicamentoControl.Size = new System.Drawing.Size(140, 17);
            this.chkMedicamentoControl.TabIndex = 65;
            this.chkMedicamentoControl.Text = "Medicamento de control";
            this.chkMedicamentoControl.UseVisualStyleBackColor = true;
            // 
            // chkPos
            // 
            this.chkPos.AutoSize = true;
            this.chkPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPos.Location = new System.Drawing.Point(281, 143);
            this.chkPos.Name = "chkPos";
            this.chkPos.Size = new System.Drawing.Size(48, 17);
            this.chkPos.TabIndex = 64;
            this.chkPos.Text = "POS";
            this.chkPos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Osmolalidad:";
            // 
            // numOsmolalidad
            // 
            this.numOsmolalidad.DecimalPlaces = 2;
            this.numOsmolalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOsmolalidad.Location = new System.Drawing.Point(93, 141);
            this.numOsmolalidad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numOsmolalidad.Name = "numOsmolalidad";
            this.numOsmolalidad.Size = new System.Drawing.Size(166, 20);
            this.numOsmolalidad.TabIndex = 70;
            // 
            // txtBUnidadMedida
            // 
            this.txtBUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBUnidadMedida.Location = new System.Drawing.Point(93, 84);
            this.txtBUnidadMedida.Name = "txtBUnidadMedida";
            this.txtBUnidadMedida.Size = new System.Drawing.Size(163, 20);
            this.txtBUnidadMedida.TabIndex = 67;
            // 
            // tsbBuscarUnidades
            // 
            this.tsbBuscarUnidades.BackColor = System.Drawing.Color.White;
            this.tsbBuscarUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbBuscarUnidades.Image = global::Galactus.Properties.Resources.btn_lupa;
            this.tsbBuscarUnidades.Location = new System.Drawing.Point(262, 82);
            this.tsbBuscarUnidades.Name = "tsbBuscarUnidades";
            this.tsbBuscarUnidades.Size = new System.Drawing.Size(22, 22);
            this.tsbBuscarUnidades.TabIndex = 68;
            this.tsbBuscarUnidades.UseVisualStyleBackColor = false;
            this.tsbBuscarUnidades.Click += new System.EventHandler(this.tsbBuscarUnidades_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Unidad:";
            // 
            // txtBCodigo
            // 
            this.txtBCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBCodigo.Location = new System.Drawing.Point(93, 32);
            this.txtBCodigo.Name = "txtBCodigo";
            this.txtBCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBCodigo.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Código: ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(93, 58);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(353, 20);
            this.txtDescripcion.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Descripción: ";
            // 
            // gbCaracteristicas
            // 
            this.gbCaracteristicas.Controls.Add(this.tbcEquivalencia);
            this.gbCaracteristicas.Location = new System.Drawing.Point(6, 197);
            this.gbCaracteristicas.Name = "gbCaracteristicas";
            this.gbCaracteristicas.Size = new System.Drawing.Size(949, 312);
            this.gbCaracteristicas.TabIndex = 63;
            this.gbCaracteristicas.TabStop = false;
            // 
            // tbcEquivalencia
            // 
            this.tbcEquivalencia.Controls.Add(this.tpCarcacteristicas);
            this.tbcEquivalencia.Controls.Add(this.tabPage2);
            this.tbcEquivalencia.Location = new System.Drawing.Point(10, 18);
            this.tbcEquivalencia.Name = "tbcEquivalencia";
            this.tbcEquivalencia.SelectedIndex = 0;
            this.tbcEquivalencia.Size = new System.Drawing.Size(918, 291);
            this.tbcEquivalencia.TabIndex = 49;
            // 
            // tpCarcacteristicas
            // 
            this.tpCarcacteristicas.Controls.Add(this.groupBox5);
            this.tpCarcacteristicas.Controls.Add(this.groupBox3);
            this.tpCarcacteristicas.Location = new System.Drawing.Point(4, 22);
            this.tpCarcacteristicas.Name = "tpCarcacteristicas";
            this.tpCarcacteristicas.Padding = new System.Windows.Forms.Padding(3);
            this.tpCarcacteristicas.Size = new System.Drawing.Size(910, 265);
            this.tpCarcacteristicas.TabIndex = 0;
            this.tpCarcacteristicas.Text = "Caracteristicas";
            this.tpCarcacteristicas.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvLineas);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(432, 250);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lineas";
            // 
            // dgvLineas
            // 
            this.dgvLineas.AllowUserToAddRows = false;
            this.dgvLineas.AllowUserToDeleteRows = false;
            this.dgvLineas.AllowUserToResizeColumns = false;
            this.dgvLineas.AllowUserToResizeRows = false;
            this.dgvLineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLineas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CódigoL,
            this.DescripciónL,
            this.VerificarL});
            this.dgvLineas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLineas.Location = new System.Drawing.Point(3, 16);
            this.dgvLineas.Name = "dgvLineas";
            this.dgvLineas.RowHeadersVisible = false;
            this.dgvLineas.Size = new System.Drawing.Size(426, 231);
            this.dgvLineas.TabIndex = 0;
            // 
            // CódigoL
            // 
            this.CódigoL.HeaderText = "Código";
            this.CódigoL.Name = "CódigoL";
            this.CódigoL.Visible = false;
            this.CódigoL.Width = 46;
            // 
            // DescripciónL
            // 
            this.DescripciónL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescripciónL.HeaderText = "Descripción";
            this.DescripciónL.Name = "DescripciónL";
            // 
            // VerificarL
            // 
            this.VerificarL.HeaderText = "";
            this.VerificarL.Name = "VerificarL";
            this.VerificarL.Width = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvVias);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(444, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 250);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vias de administración";
            // 
            // dgvVias
            // 
            this.dgvVias.AllowUserToAddRows = false;
            this.dgvVias.AllowUserToDeleteRows = false;
            this.dgvVias.AllowUserToResizeColumns = false;
            this.dgvVias.AllowUserToResizeRows = false;
            this.dgvVias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Descripción,
            this.Verificar});
            this.dgvVias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVias.Location = new System.Drawing.Point(3, 16);
            this.dgvVias.Name = "dgvVias";
            this.dgvVias.RowHeadersVisible = false;
            this.dgvVias.Size = new System.Drawing.Size(426, 231);
            this.dgvVias.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Visible = false;
            this.Código.Width = 46;
            // 
            // Descripción
            // 
            this.Descripción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            // 
            // Verificar
            // 
            this.Verificar.HeaderText = "";
            this.Verificar.Name = "Verificar";
            this.Verificar.Width = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvProductos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(910, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Prductos Dependientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(3, 3);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.Size = new System.Drawing.Size(904, 259);
            this.dgvProductos.TabIndex = 0;
            // 
            // EquivalenciaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 545);
            this.Controls.Add(this.gbPrincipal);
            this.Controls.Add(this.tstMenuPatron);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(1025, 584);
            this.MinimumSize = new System.Drawing.Size(1025, 584);
            this.Name = "EquivalenciaUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equivalencia";
            this.Load += new System.EventHandler(this.EquivalenciaUI_Load);
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.gbInformacionATC.ResumeLayout(false);
            this.gbInformacionATC.PerformLayout();
            this.gbPrincipal.ResumeLayout(false);
            this.gbDatosBasicos.ResumeLayout(false);
            this.gbDatosBasicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOsmolalidad)).EndInit();
            this.gbCaracteristicas.ResumeLayout(false);
            this.tbcEquivalencia.ResumeLayout(false);
            this.tpCarcacteristicas.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVias)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tstEditar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.GroupBox gbInformacionATC;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cbGrupoATC;
        private System.Windows.Forms.TextBox txtCodigoATC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcionATC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.GroupBox gbCaracteristicas;
        private System.Windows.Forms.TabControl tbcEquivalencia;
        private System.Windows.Forms.TabPage tpCarcacteristicas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvLineas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódigoL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripciónL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VerificarL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvVias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Verificar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox gbDatosBasicos;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numConce;
        private System.Windows.Forms.CheckBox chkMedicamentoControl;
        private System.Windows.Forms.CheckBox chkPos;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown numOsmolalidad;
        private System.Windows.Forms.TextBox txtBUnidadMedida;
        private System.Windows.Forms.Button tsbBuscarUnidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
    }
}