namespace Galactus.VistaControlador.Admision
{
    partial class Anexo2UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inconsistenciasGridView = new System.Windows.Forms.DataGridView();
            this.codigoCIECOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDiagCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDiagCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitarAnularCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.observacionText = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.infoInconsRB = new System.Windows.Forms.RadioButton();
            this.usuarioInexistenteRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.registroText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ordenText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoInformeAnexoText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.epsText = new System.Windows.Forms.TextBox();
            this.pacienteText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nSolicitudCodText = new System.Windows.Forms.TextBox();
            this.NSolicitudText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NRegistroText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tBtEditar = new System.Windows.Forms.ToolStripButton();
            this.tBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tbtAnular = new System.Windows.Forms.ToolStripButton();
            this.tbtImprimir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inconsistenciasGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tstMenuPatron.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "INFORME DE ATENCIÓN INICIAL DE URGENCIA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.observacionText);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 448);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.inconsistenciasGridView);
            this.groupBox3.Location = new System.Drawing.Point(6, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 145);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de posibles inconsistencias";
            // 
            // inconsistenciasGridView
            // 
            this.inconsistenciasGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inconsistenciasGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inconsistenciasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inconsistenciasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCIECOL,
            this.descripcionDiagCol,
            this.observacionDiagCol,
            this.quitarAnularCol});
            this.inconsistenciasGridView.GridColor = System.Drawing.Color.DarkGray;
            this.inconsistenciasGridView.Location = new System.Drawing.Point(9, 19);
            this.inconsistenciasGridView.MultiSelect = false;
            this.inconsistenciasGridView.Name = "inconsistenciasGridView";
            this.inconsistenciasGridView.ReadOnly = true;
            this.inconsistenciasGridView.Size = new System.Drawing.Size(790, 120);
            this.inconsistenciasGridView.TabIndex = 1;
            // 
            // codigoCIECOL
            // 
            this.codigoCIECOL.HeaderText = "Descripción";
            this.codigoCIECOL.Name = "codigoCIECOL";
            this.codigoCIECOL.ReadOnly = true;
            this.codigoCIECOL.Width = 170;
            // 
            // descripcionDiagCol
            // 
            this.descripcionDiagCol.HeaderText = "Seleccionar";
            this.descripcionDiagCol.Name = "descripcionDiagCol";
            this.descripcionDiagCol.ReadOnly = true;
            this.descripcionDiagCol.Width = 170;
            // 
            // observacionDiagCol
            // 
            this.observacionDiagCol.HeaderText = "Datos según documentos";
            this.observacionDiagCol.Name = "observacionDiagCol";
            this.observacionDiagCol.ReadOnly = true;
            this.observacionDiagCol.Width = 230;
            // 
            // quitarAnularCol
            // 
            this.quitarAnularCol.HeaderText = "Datos base de datos";
            this.quitarAnularCol.Name = "quitarAnularCol";
            this.quitarAnularCol.ReadOnly = true;
            this.quitarAnularCol.Width = 170;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Observación";
            // 
            // observacionText
            // 
            this.observacionText.Location = new System.Drawing.Point(7, 383);
            this.observacionText.Multiline = true;
            this.observacionText.Name = "observacionText";
            this.observacionText.Size = new System.Drawing.Size(817, 59);
            this.observacionText.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.infoInconsRB);
            this.groupBox4.Controls.Add(this.usuarioInexistenteRB);
            this.groupBox4.Location = new System.Drawing.Point(6, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(805, 60);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo servicio solicitado";
            // 
            // infoInconsRB
            // 
            this.infoInconsRB.AutoSize = true;
            this.infoInconsRB.Location = new System.Drawing.Point(154, 28);
            this.infoInconsRB.Name = "infoInconsRB";
            this.infoInconsRB.Size = new System.Drawing.Size(145, 17);
            this.infoInconsRB.TabIndex = 4;
            this.infoInconsRB.TabStop = true;
            this.infoInconsRB.Text = "Información inconsistente";
            this.infoInconsRB.UseVisualStyleBackColor = true;
            // 
            // usuarioInexistenteRB
            // 
            this.usuarioInexistenteRB.AutoSize = true;
            this.usuarioInexistenteRB.Location = new System.Drawing.Point(9, 28);
            this.usuarioInexistenteRB.Name = "usuarioInexistenteRB";
            this.usuarioInexistenteRB.Size = new System.Drawing.Size(114, 17);
            this.usuarioInexistenteRB.TabIndex = 3;
            this.usuarioInexistenteRB.TabStop = true;
            this.usuarioInexistenteRB.Text = "Usuario inexistente";
            this.usuarioInexistenteRB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.registroText);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.ordenText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tipoInformeAnexoText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.epsText);
            this.groupBox2.Controls.Add(this.pacienteText);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nSolicitudCodText);
            this.groupBox2.Controls.Add(this.NSolicitudText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NRegistroText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 125);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Básicos";
            // 
            // registroText
            // 
            this.registroText.Location = new System.Drawing.Point(545, 88);
            this.registroText.Name = "registroText";
            this.registroText.Size = new System.Drawing.Size(74, 20);
            this.registroText.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(490, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Registro:";
            // 
            // ordenText
            // 
            this.ordenText.Location = new System.Drawing.Point(396, 88);
            this.ordenText.Name = "ordenText";
            this.ordenText.Size = new System.Drawing.Size(74, 20);
            this.ordenText.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Orden:";
            // 
            // tipoInformeAnexoText
            // 
            this.tipoInformeAnexoText.Location = new System.Drawing.Point(112, 88);
            this.tipoInformeAnexoText.Name = "tipoInformeAnexoText";
            this.tipoInformeAnexoText.Size = new System.Drawing.Size(177, 20);
            this.tipoInformeAnexoText.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo informe anexo:";
            // 
            // epsText
            // 
            this.epsText.Location = new System.Drawing.Point(396, 56);
            this.epsText.Name = "epsText";
            this.epsText.Size = new System.Drawing.Size(335, 20);
            this.epsText.TabIndex = 11;
            // 
            // pacienteText
            // 
            this.pacienteText.Location = new System.Drawing.Point(396, 27);
            this.pacienteText.Name = "pacienteText";
            this.pacienteText.Size = new System.Drawing.Size(335, 20);
            this.pacienteText.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Contrato:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Paciente:";
            // 
            // nSolicitudCodText
            // 
            this.nSolicitudCodText.Location = new System.Drawing.Point(260, 56);
            this.nSolicitudCodText.Name = "nSolicitudCodText";
            this.nSolicitudCodText.Size = new System.Drawing.Size(29, 20);
            this.nSolicitudCodText.TabIndex = 7;
            // 
            // NSolicitudText
            // 
            this.NSolicitudText.Location = new System.Drawing.Point(112, 56);
            this.NSolicitudText.Name = "NSolicitudText";
            this.NSolicitudText.Size = new System.Drawing.Size(138, 20);
            this.NSolicitudText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "N° Solicitud";
            // 
            // NRegistroText
            // 
            this.NRegistroText.Location = new System.Drawing.Point(112, 27);
            this.NRegistroText.Name = "NRegistroText";
            this.NRegistroText.Size = new System.Drawing.Size(138, 20);
            this.NRegistroText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identificación:";
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
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 530);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(848, 25);
            this.tstMenuPatron.TabIndex = 29;
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
            // Anexo2UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 555);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Anexo2UI";
            this.Text = "Anexo2UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inconsistenciasGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton infoInconsRB;
        private System.Windows.Forms.RadioButton usuarioInexistenteRB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox epsText;
        private System.Windows.Forms.TextBox pacienteText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nSolicitudCodText;
        private System.Windows.Forms.TextBox NSolicitudText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NRegistroText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox registroText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ordenText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tipoInformeAnexoText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox observacionText;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tBtNuevo;
        private System.Windows.Forms.ToolStripButton tBtEditar;
        private System.Windows.Forms.ToolStripButton tBtCancelar;
        private System.Windows.Forms.ToolStripButton tBtGuardar;
        private System.Windows.Forms.ToolStripButton tBtBuscar;
        private System.Windows.Forms.ToolStripButton tbtAnular;
        private System.Windows.Forms.ToolStripButton tbtImprimir;
        private System.Windows.Forms.DataGridView inconsistenciasGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCIECOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDiagCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDiagCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn quitarAnularCol;
    }
}