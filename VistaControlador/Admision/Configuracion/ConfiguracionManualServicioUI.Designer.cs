namespace Galactus.VistaControlador.Admision.Configuracion
{
    partial class ConfiguracionManualServicioUI
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
            this.tabPestañas = new System.Windows.Forms.TabControl();
            this.tabPagSoat = new System.Windows.Forms.TabPage();
            this.dgvSoat = new System.Windows.Forms.DataGridView();
            this.tabPagIss = new System.Windows.Forms.TabPage();
            this.dgvIss = new System.Windows.Forms.DataGridView();
            this.tabPagCups = new System.Windows.Forms.TabPage();
            this.dgvCups = new System.Windows.Forms.DataGridView();
            this.admisionesPB = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbListaManual = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tstEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tabPestañas.SuspendLayout();
            this.tabPagSoat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoat)).BeginInit();
            this.tabPagIss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIss)).BeginInit();
            this.tabPagCups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admisionesPB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tstMenuPatron.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPestañas
            // 
            this.tabPestañas.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPestañas.Controls.Add(this.tabPagSoat);
            this.tabPestañas.Controls.Add(this.tabPagIss);
            this.tabPestañas.Controls.Add(this.tabPagCups);
            this.tabPestañas.Location = new System.Drawing.Point(1, 99);
            this.tabPestañas.Margin = new System.Windows.Forms.Padding(4);
            this.tabPestañas.Name = "tabPestañas";
            this.tabPestañas.SelectedIndex = 0;
            this.tabPestañas.Size = new System.Drawing.Size(905, 557);
            this.tabPestañas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPestañas.TabIndex = 1;
            this.tabPestañas.SelectedIndexChanged += new System.EventHandler(this.tabPestañas_SelectedIndexChanged);
            // 
            // tabPagSoat
            // 
            this.tabPagSoat.Controls.Add(this.dgvSoat);
            this.tabPagSoat.Location = new System.Drawing.Point(4, 27);
            this.tabPagSoat.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagSoat.Name = "tabPagSoat";
            this.tabPagSoat.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagSoat.Size = new System.Drawing.Size(897, 526);
            this.tabPagSoat.TabIndex = 0;
            this.tabPagSoat.Text = "SOAT";
            this.tabPagSoat.UseVisualStyleBackColor = true;
            // 
            // dgvSoat
            // 
            this.dgvSoat.AllowUserToAddRows = false;
            this.dgvSoat.AllowUserToDeleteRows = false;
            this.dgvSoat.BackgroundColor = System.Drawing.Color.White;
            this.dgvSoat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoat.Location = new System.Drawing.Point(4, 4);
            this.dgvSoat.Name = "dgvSoat";
            this.dgvSoat.ReadOnly = true;
            this.dgvSoat.RowHeadersVisible = false;
            this.dgvSoat.Size = new System.Drawing.Size(889, 518);
            this.dgvSoat.TabIndex = 0;
            // 
            // tabPagIss
            // 
            this.tabPagIss.Controls.Add(this.dgvIss);
            this.tabPagIss.Location = new System.Drawing.Point(4, 27);
            this.tabPagIss.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagIss.Name = "tabPagIss";
            this.tabPagIss.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagIss.Size = new System.Drawing.Size(897, 526);
            this.tabPagIss.TabIndex = 1;
            this.tabPagIss.Text = "ISS";
            this.tabPagIss.UseVisualStyleBackColor = true;
            // 
            // dgvIss
            // 
            this.dgvIss.AllowUserToAddRows = false;
            this.dgvIss.AllowUserToDeleteRows = false;
            this.dgvIss.BackgroundColor = System.Drawing.Color.White;
            this.dgvIss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIss.Location = new System.Drawing.Point(4, 4);
            this.dgvIss.Name = "dgvIss";
            this.dgvIss.ReadOnly = true;
            this.dgvIss.RowHeadersVisible = false;
            this.dgvIss.Size = new System.Drawing.Size(889, 518);
            this.dgvIss.TabIndex = 1;
            // 
            // tabPagCups
            // 
            this.tabPagCups.Controls.Add(this.dgvCups);
            this.tabPagCups.Location = new System.Drawing.Point(4, 27);
            this.tabPagCups.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagCups.Name = "tabPagCups";
            this.tabPagCups.Size = new System.Drawing.Size(897, 526);
            this.tabPagCups.TabIndex = 2;
            this.tabPagCups.Text = "CUPS";
            this.tabPagCups.UseVisualStyleBackColor = true;
            // 
            // dgvCups
            // 
            this.dgvCups.AllowUserToAddRows = false;
            this.dgvCups.AllowUserToDeleteRows = false;
            this.dgvCups.BackgroundColor = System.Drawing.Color.White;
            this.dgvCups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCups.Location = new System.Drawing.Point(0, 0);
            this.dgvCups.Name = "dgvCups";
            this.dgvCups.ReadOnly = true;
            this.dgvCups.RowHeadersVisible = false;
            this.dgvCups.Size = new System.Drawing.Size(897, 526);
            this.dgvCups.TabIndex = 1;
            // 
            // admisionesPB
            // 
            this.admisionesPB.Image = global::Galactus.Properties.Resources.hospital_reception;
            this.admisionesPB.Location = new System.Drawing.Point(7, 3);
            this.admisionesPB.Name = "admisionesPB";
            this.admisionesPB.Size = new System.Drawing.Size(40, 40);
            this.admisionesPB.TabIndex = 8;
            this.admisionesPB.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(53, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Manuales de Servicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbListaManual);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 51);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cbListaManual
            // 
            this.cbListaManual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaManual.FormattingEnabled = true;
            this.cbListaManual.Location = new System.Drawing.Point(678, 17);
            this.cbListaManual.Name = "cbListaManual";
            this.cbListaManual.Size = new System.Drawing.Size(213, 24);
            this.cbListaManual.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista segun el manual:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(65, 19);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(455, 22);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro:";
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
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 660);
            this.tstMenuPatron.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.TabIndex = 48;
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
            // 
            // tsbAnular
            // 
            this.tsbAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbAnular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAnular.Image = global::Galactus.Properties.Resources.btn_anular;
            this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnular.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbAnular.Name = "tsbAnular";
            this.tsbAnular.Size = new System.Drawing.Size(62, 22);
            this.tsbAnular.Text = "Anular";
            // 
            // ConfiguracionManualServicioUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 685);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.admisionesPB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tabPestañas);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(923, 724);
            this.MinimumSize = new System.Drawing.Size(923, 724);
            this.Name = "ConfiguracionManualServicioUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConfiguracionManualServicioUI_Load);
            this.tabPestañas.ResumeLayout(false);
            this.tabPagSoat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoat)).EndInit();
            this.tabPagIss.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIss)).EndInit();
            this.tabPagCups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admisionesPB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabPestañas;
        private System.Windows.Forms.TabPage tabPagSoat;
        private System.Windows.Forms.DataGridView dgvSoat;
        private System.Windows.Forms.TabPage tabPagIss;
        private System.Windows.Forms.DataGridView dgvIss;
        private System.Windows.Forms.TabPage tabPagCups;
        private System.Windows.Forms.DataGridView dgvCups;
        private System.Windows.Forms.PictureBox admisionesPB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbListaManual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tstEditar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
    }
}