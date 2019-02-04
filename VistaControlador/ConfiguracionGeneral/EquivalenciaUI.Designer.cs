namespace Galactus.VistaControlador.ConfiguracionGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquivalenciaUI));
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tBtEditar = new System.Windows.Forms.ToolStripButton();
            this.tBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tBtAnular = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboatc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbcEquivalencia = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpCarcacteristicas = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvVias = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvLineas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarUnidades = new System.Windows.Forms.Button();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chkPos = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Numconce = new System.Windows.Forms.NumericUpDown();
            this.tstMenuPatron.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbcEquivalencia.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpCarcacteristicas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVias)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numconce)).BeginInit();
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
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 435);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(925, 25);
            this.tstMenuPatron.TabIndex = 47;
            this.tstMenuPatron.Text = "toolStrip1";
            // 
            // tBtNuevo
            // 
            this.tBtNuevo.Image = global::Galactus.Properties.Resources.add;
            this.tBtNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtNuevo.Name = "tBtNuevo";
            this.tBtNuevo.Size = new System.Drawing.Size(62, 22);
            this.tBtNuevo.Text = "Nuevo";
            this.tBtNuevo.Click += new System.EventHandler(this.tBtNuevo_Click);
            // 
            // tBtEditar
            // 
            this.tBtEditar.Image = global::Galactus.Properties.Resources.edit;
            this.tBtEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtEditar.Name = "tBtEditar";
            this.tBtEditar.Size = new System.Drawing.Size(57, 22);
            this.tBtEditar.Text = "Editar";
            this.tBtEditar.Click += new System.EventHandler(this.tBtEditar_Click);
            // 
            // tBtCancelar
            // 
            this.tBtCancelar.Image = global::Galactus.Properties.Resources.back_arrow;
            this.tBtCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtCancelar.Name = "tBtCancelar";
            this.tBtCancelar.Size = new System.Drawing.Size(73, 22);
            this.tBtCancelar.Text = "Cancelar";
            this.tBtCancelar.Click += new System.EventHandler(this.tBtCancelar_Click);
            // 
            // tBtGuardar
            // 
            this.tBtGuardar.Image = global::Galactus.Properties.Resources.guardar16;
            this.tBtGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtGuardar.Name = "tBtGuardar";
            this.tBtGuardar.Size = new System.Drawing.Size(69, 22);
            this.tBtGuardar.Text = "Guardar";
            this.tBtGuardar.Click += new System.EventHandler(this.tBtGuardar_Click);
            // 
            // tBtBuscar
            // 
            this.tBtBuscar.Image = global::Galactus.Properties.Resources.search__1_;
            this.tBtBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtBuscar.Name = "tBtBuscar";
            this.tBtBuscar.Size = new System.Drawing.Size(62, 22);
            this.tBtBuscar.Text = "Buscar";
            this.tBtBuscar.Click += new System.EventHandler(this.tBtBuscar_Click);
            // 
            // tBtAnular
            // 
            this.tBtAnular.Image = global::Galactus.Properties.Resources.anular24;
            this.tBtAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtAnular.Name = "tBtAnular";
            this.tBtAnular.Size = new System.Drawing.Size(62, 22);
            this.tBtAnular.Text = "Anular";
            this.tBtAnular.Click += new System.EventHandler(this.tBtAnular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descripción: ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(95, 45);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(353, 20);
            this.txtDescripcion.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código: ";
            // 
            // txtBCodigo
            // 
            this.txtBCodigo.Location = new System.Drawing.Point(95, 19);
            this.txtBCodigo.Name = "txtBCodigo";
            this.txtBCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBCodigo.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboatc);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(457, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 110);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información ATC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Descripción: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 20);
            this.textBox2.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Código: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 32;
            // 
            // comboatc
            // 
            this.comboatc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboatc.FormattingEnabled = true;
            this.comboatc.Items.AddRange(new object[] {
            "---Seleccionar---",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "#N/A"});
            this.comboatc.Location = new System.Drawing.Point(86, 71);
            this.comboatc.Name = "comboatc";
            this.comboatc.Size = new System.Drawing.Size(100, 21);
            this.comboatc.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Grupo:";
            // 
            // tbcEquivalencia
            // 
            this.tbcEquivalencia.Controls.Add(this.tpCarcacteristicas);
            this.tbcEquivalencia.Controls.Add(this.tabPage2);
            this.tbcEquivalencia.Location = new System.Drawing.Point(6, 129);
            this.tbcEquivalencia.Name = "tbcEquivalencia";
            this.tbcEquivalencia.SelectedIndex = 0;
            this.tbcEquivalencia.Size = new System.Drawing.Size(892, 291);
            this.tbcEquivalencia.TabIndex = 48;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(884, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Prductos Dependientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // tpCarcacteristicas
            // 
            this.tpCarcacteristicas.Controls.Add(this.groupBox5);
            this.tpCarcacteristicas.Controls.Add(this.groupBox3);
            this.tpCarcacteristicas.Location = new System.Drawing.Point(4, 22);
            this.tpCarcacteristicas.Name = "tpCarcacteristicas";
            this.tpCarcacteristicas.Padding = new System.Windows.Forms.Padding(3);
            this.tpCarcacteristicas.Size = new System.Drawing.Size(884, 265);
            this.tpCarcacteristicas.TabIndex = 0;
            this.tpCarcacteristicas.Text = "Caracteristicas";
            this.tpCarcacteristicas.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvVias);
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
            this.dgvVias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVias.Location = new System.Drawing.Point(3, 16);
            this.dgvVias.Name = "dgvVias";
            this.dgvVias.RowHeadersVisible = false;
            this.dgvVias.Size = new System.Drawing.Size(426, 231);
            this.dgvVias.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvLineas);
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
            this.dgvLineas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLineas.Location = new System.Drawing.Point(3, 16);
            this.dgvLineas.Name = "dgvLineas";
            this.dgvLineas.RowHeadersVisible = false;
            this.dgvLineas.Size = new System.Drawing.Size(426, 231);
            this.dgvLineas.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Unidad:";
            // 
            // btnBuscarUnidades
            // 
            this.btnBuscarUnidades.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUnidades.Image")));
            this.btnBuscarUnidades.Location = new System.Drawing.Point(264, 69);
            this.btnBuscarUnidades.Name = "btnBuscarUnidades";
            this.btnBuscarUnidades.Size = new System.Drawing.Size(34, 23);
            this.btnBuscarUnidades.TabIndex = 56;
            this.btnBuscarUnidades.UseVisualStyleBackColor = true;
            this.btnBuscarUnidades.Click += new System.EventHandler(this.btnBuscarUnidades_Click);
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(95, 71);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(163, 20);
            this.txtUnidadMedida.TabIndex = 54;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(282, 97);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown1.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Osmolalidad:";
            // 
            // chkPos
            // 
            this.chkPos.AutoSize = true;
            this.chkPos.Location = new System.Drawing.Point(254, 21);
            this.chkPos.Name = "chkPos";
            this.chkPos.Size = new System.Drawing.Size(48, 17);
            this.chkPos.TabIndex = 59;
            this.chkPos.Text = "POS";
            this.chkPos.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(308, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 17);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.Text = "Medicamento de control";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Numconce);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.chkPos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.txtUnidadMedida);
            this.groupBox1.Controls.Add(this.btnBuscarUnidades);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbcEquivalencia);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtBCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 426);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Principal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Concentración:";
            // 
            // Numconce
            // 
            this.Numconce.DecimalPlaces = 2;
            this.Numconce.Location = new System.Drawing.Point(95, 97);
            this.Numconce.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Numconce.Name = "Numconce";
            this.Numconce.Size = new System.Drawing.Size(90, 20);
            this.Numconce.TabIndex = 61;
            // 
            // EquivalenciaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tstMenuPatron);
            this.Name = "EquivalenciaUI";
            this.Text = "EquivalenciaUI";
            this.Load += new System.EventHandler(this.EquivalenciaUI_Load);
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbcEquivalencia.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpCarcacteristicas.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVias)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numconce)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox comboatc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tbcEquivalencia;
        private System.Windows.Forms.TabPage tpCarcacteristicas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvLineas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvVias;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarUnidades;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkPos;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown Numconce;
    }
}