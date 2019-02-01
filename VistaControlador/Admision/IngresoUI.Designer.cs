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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.observacionText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.estadoAtencionBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.diagnosticosGridView = new System.Windows.Forms.DataGridView();
            this.codigoCIECOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDiagCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDiagCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitarAnularCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nAutorizacionText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.institucionText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.camaBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.areaServicioBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.causaExternaBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viaIngresoBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarEspOtrosBtn = new System.Windows.Forms.Button();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tBtEditar = new System.Windows.Forms.ToolStripButton();
            this.tBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tbtAnular = new System.Windows.Forms.ToolStripButton();
            this.tbtImprimir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tstMenuPatron.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 546);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.observacionText);
            this.groupBox5.Location = new System.Drawing.Point(16, 444);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(859, 89);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Observación";
            // 
            // observacionText
            // 
            this.observacionText.Location = new System.Drawing.Point(6, 19);
            this.observacionText.Multiline = true;
            this.observacionText.Name = "observacionText";
            this.observacionText.Size = new System.Drawing.Size(838, 50);
            this.observacionText.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.estadoAtencionBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 81);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado de atención";
            // 
            // estadoAtencionBox
            // 
            this.estadoAtencionBox.FormattingEnabled = true;
            this.estadoAtencionBox.Location = new System.Drawing.Point(6, 28);
            this.estadoAtencionBox.Name = "estadoAtencionBox";
            this.estadoAtencionBox.Size = new System.Drawing.Size(186, 21);
            this.estadoAtencionBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.diagnosticosGridView);
            this.groupBox4.Location = new System.Drawing.Point(7, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(868, 192);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Diagnósticos de Remisión";
            // 
            // diagnosticosGridView
            // 
            this.diagnosticosGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.diagnosticosGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.diagnosticosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosticosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCIECOL,
            this.descripcionDiagCol,
            this.observacionDiagCol,
            this.quitarAnularCol});
            this.diagnosticosGridView.GridColor = System.Drawing.Color.DarkGray;
            this.diagnosticosGridView.Location = new System.Drawing.Point(9, 19);
            this.diagnosticosGridView.MultiSelect = false;
            this.diagnosticosGridView.Name = "diagnosticosGridView";
            this.diagnosticosGridView.ReadOnly = true;
            this.diagnosticosGridView.Size = new System.Drawing.Size(844, 167);
            this.diagnosticosGridView.TabIndex = 0;
            // 
            // codigoCIECOL
            // 
            this.codigoCIECOL.HeaderText = "Código CIE";
            this.codigoCIECOL.Name = "codigoCIECOL";
            this.codigoCIECOL.ReadOnly = true;
            // 
            // descripcionDiagCol
            // 
            this.descripcionDiagCol.HeaderText = "Descripción del diagnóstico ";
            this.descripcionDiagCol.Name = "descripcionDiagCol";
            this.descripcionDiagCol.ReadOnly = true;
            this.descripcionDiagCol.Width = 400;
            // 
            // observacionDiagCol
            // 
            this.observacionDiagCol.HeaderText = "Observación del diagnóstico";
            this.observacionDiagCol.Name = "observacionDiagCol";
            this.observacionDiagCol.ReadOnly = true;
            this.observacionDiagCol.Width = 200;
            // 
            // quitarAnularCol
            // 
            this.quitarAnularCol.HeaderText = "Quitar/Anular";
            this.quitarAnularCol.Name = "quitarAnularCol";
            this.quitarAnularCol.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nAutorizacionText);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buscarEspOtrosBtn);
            this.groupBox3.Controls.Add(this.institucionText);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.camaBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.areaServicioBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.causaExternaBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.viaIngresoBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(868, 123);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de ingreso";
            // 
            // nAutorizacionText
            // 
            this.nAutorizacionText.Location = new System.Drawing.Point(403, 85);
            this.nAutorizacionText.Name = "nAutorizacionText";
            this.nAutorizacionText.Size = new System.Drawing.Size(161, 20);
            this.nAutorizacionText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "N°. Autorización";
            // 
            // institucionText
            // 
            this.institucionText.Location = new System.Drawing.Point(91, 86);
            this.institucionText.Name = "institucionText";
            this.institucionText.Size = new System.Drawing.Size(168, 20);
            this.institucionText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Institución:";
            // 
            // camaBox
            // 
            this.camaBox.FormattingEnabled = true;
            this.camaBox.Location = new System.Drawing.Point(403, 53);
            this.camaBox.Name = "camaBox";
            this.camaBox.Size = new System.Drawing.Size(161, 21);
            this.camaBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cama:";
            // 
            // areaServicioBox
            // 
            this.areaServicioBox.FormattingEnabled = true;
            this.areaServicioBox.Location = new System.Drawing.Point(403, 26);
            this.areaServicioBox.Name = "areaServicioBox";
            this.areaServicioBox.Size = new System.Drawing.Size(161, 21);
            this.areaServicioBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Área de servicio:";
            // 
            // causaExternaBox
            // 
            this.causaExternaBox.FormattingEnabled = true;
            this.causaExternaBox.Location = new System.Drawing.Point(91, 53);
            this.causaExternaBox.Name = "causaExternaBox";
            this.causaExternaBox.Size = new System.Drawing.Size(168, 21);
            this.causaExternaBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Causa externa:";
            // 
            // viaIngresoBox
            // 
            this.viaIngresoBox.FormattingEnabled = true;
            this.viaIngresoBox.Location = new System.Drawing.Point(91, 26);
            this.viaIngresoBox.Name = "viaIngresoBox";
            this.viaIngresoBox.Size = new System.Drawing.Size(168, 21);
            this.viaIngresoBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vía de ingreso:";
            // 
            // buscarEspOtrosBtn
            // 
            this.buscarEspOtrosBtn.Image = global::Galactus.Properties.Resources.search__1_;
            this.buscarEspOtrosBtn.Location = new System.Drawing.Point(265, 83);
            this.buscarEspOtrosBtn.Name = "buscarEspOtrosBtn";
            this.buscarEspOtrosBtn.Size = new System.Drawing.Size(26, 24);
            this.buscarEspOtrosBtn.TabIndex = 6;
            this.buscarEspOtrosBtn.UseVisualStyleBackColor = true;
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
            this.tbtAnular,
            this.tbtImprimir});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 570);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(906, 25);
            this.tstMenuPatron.TabIndex = 28;
            this.tstMenuPatron.Text = "toolStrip1";
            // 
            // tBtNuevo
            // 
            this.tBtNuevo.Image = global::Galactus.Properties.Resources.add;
            this.tBtNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtNuevo.Name = "tBtNuevo";
            this.tBtNuevo.Size = new System.Drawing.Size(62, 22);
            this.tBtNuevo.Text = "Nuevo";
            // 
            // tBtEditar
            // 
            this.tBtEditar.Image = global::Galactus.Properties.Resources.edit;
            this.tBtEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtEditar.Name = "tBtEditar";
            this.tBtEditar.Size = new System.Drawing.Size(57, 22);
            this.tBtEditar.Text = "Editar";
            // 
            // tBtCancelar
            // 
            this.tBtCancelar.Image = global::Galactus.Properties.Resources.back_arrow;
            this.tBtCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtCancelar.Name = "tBtCancelar";
            this.tBtCancelar.Size = new System.Drawing.Size(73, 22);
            this.tBtCancelar.Text = "Cancelar";
            // 
            // tBtGuardar
            // 
            this.tBtGuardar.Image = global::Galactus.Properties.Resources.guardar16;
            this.tBtGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtGuardar.Name = "tBtGuardar";
            this.tBtGuardar.Size = new System.Drawing.Size(69, 22);
            this.tBtGuardar.Text = "Guardar";
            // 
            // tBtBuscar
            // 
            this.tBtBuscar.Image = global::Galactus.Properties.Resources.search__1_;
            this.tBtBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtBuscar.Name = "tBtBuscar";
            this.tBtBuscar.Size = new System.Drawing.Size(62, 22);
            this.tBtBuscar.Text = "Buscar";
            // 
            // tbtAnular
            // 
            this.tbtAnular.Image = global::Galactus.Properties.Resources.anular24;
            this.tbtAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtAnular.Name = "tbtAnular";
            this.tbtAnular.Size = new System.Drawing.Size(62, 22);
            this.tbtAnular.Text = "Anular";
            // 
            // tbtImprimir
            // 
            this.tbtImprimir.Image = global::Galactus.Properties.Resources.print__2_;
            this.tbtImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtImprimir.Name = "tbtImprimir";
            this.tbtImprimir.Size = new System.Drawing.Size(73, 22);
            this.tbtImprimir.Text = "Imprimir";
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 595);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox institucionText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox camaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox areaServicioBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox causaExternaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox viaIngresoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox estadoAtencionBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView diagnosticosGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCIECOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDiagCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDiagCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn quitarAnularCol;
        private System.Windows.Forms.TextBox nAutorizacionText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buscarEspOtrosBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox observacionText;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tBtNuevo;
        private System.Windows.Forms.ToolStripButton tBtEditar;
        private System.Windows.Forms.ToolStripButton tBtCancelar;
        private System.Windows.Forms.ToolStripButton tBtGuardar;
        private System.Windows.Forms.ToolStripButton tBtBuscar;
        private System.Windows.Forms.ToolStripButton tbtAnular;
        private System.Windows.Forms.ToolStripButton tbtImprimir;
    }
}