namespace Galactus.VistaControlador.HistoriaClinica
{
    partial class AtencionIngresoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtencionIngresoUI));
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tstEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.PanelJustificacionN = new System.Windows.Forms.Panel();
            this.txtJustificacionN = new System.Windows.Forms.TextBox();
            this.dgvImpresionN = new System.Windows.Forms.DataGridView();
            this.anulardiagevoN = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResumenClinico = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tstMenuPatron.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.PanelJustificacionN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpresionN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstMenuPatron
            // 
            this.tstMenuPatron.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuPatron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstEditar,
            this.tsbCancelar,
            this.tsbAnular,
            this.tsbGuardar});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 361);
            this.tstMenuPatron.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.TabIndex = 49;
            this.tstMenuPatron.Text = "toolStrip1";
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.GroupBox17);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 356);
            this.panel1.TabIndex = 0;
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.PanelJustificacionN);
            this.GroupBox17.Controls.Add(this.dgvImpresionN);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(6, 152);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(931, 153);
            this.GroupBox17.TabIndex = 10092;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Impresión Diagnóstica:";
            // 
            // PanelJustificacionN
            // 
            this.PanelJustificacionN.BackColor = System.Drawing.Color.OldLace;
            this.PanelJustificacionN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelJustificacionN.Controls.Add(this.txtJustificacionN);
            this.PanelJustificacionN.Location = new System.Drawing.Point(263, 26);
            this.PanelJustificacionN.Name = "PanelJustificacionN";
            this.PanelJustificacionN.Size = new System.Drawing.Size(389, 119);
            this.PanelJustificacionN.TabIndex = 10085;
            this.PanelJustificacionN.Visible = false;
            // 
            // txtJustificacionN
            // 
            this.txtJustificacionN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtJustificacionN.Location = new System.Drawing.Point(4, 7);
            this.txtJustificacionN.Multiline = true;
            this.txtJustificacionN.Name = "txtJustificacionN";
            this.txtJustificacionN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJustificacionN.Size = new System.Drawing.Size(381, 107);
            this.txtJustificacionN.TabIndex = 10065;
            // 
            // dgvImpresionN
            // 
            this.dgvImpresionN.AllowUserToAddRows = false;
            this.dgvImpresionN.AllowUserToDeleteRows = false;
            this.dgvImpresionN.AllowUserToResizeColumns = false;
            this.dgvImpresionN.AllowUserToResizeRows = false;
            this.dgvImpresionN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvImpresionN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvImpresionN.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvImpresionN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpresionN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anulardiagevoN});
            this.dgvImpresionN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImpresionN.Location = new System.Drawing.Point(3, 18);
            this.dgvImpresionN.MultiSelect = false;
            this.dgvImpresionN.Name = "dgvImpresionN";
            this.dgvImpresionN.ReadOnly = true;
            this.dgvImpresionN.RowHeadersVisible = false;
            this.dgvImpresionN.Size = new System.Drawing.Size(925, 132);
            this.dgvImpresionN.TabIndex = 2;
            // 
            // anulardiagevoN
            // 
            this.anulardiagevoN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.anulardiagevoN.HeaderText = "Quitar";
            this.anulardiagevoN.Image = ((System.Drawing.Image)(resources.GetObject("anulardiagevoN.Image")));
            this.anulardiagevoN.Name = "anulardiagevoN";
            this.anulardiagevoN.ReadOnly = true;
            this.anulardiagevoN.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResumenClinico);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 142);
            this.groupBox1.TabIndex = 10091;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen Clinico.";
            // 
            // txtResumenClinico
            // 
            this.txtResumenClinico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResumenClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumenClinico.Location = new System.Drawing.Point(3, 18);
            this.txtResumenClinico.Multiline = true;
            this.txtResumenClinico.Name = "txtResumenClinico";
            this.txtResumenClinico.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResumenClinico.Size = new System.Drawing.Size(928, 121);
            this.txtResumenClinico.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "Quitar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // AtencionIngresoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 386);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AtencionIngresoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AtencionIngresoUI";
            this.Load += new System.EventHandler(this.AtencionIngresoUI_Load);
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.PanelJustificacionN.ResumeLayout(false);
            this.PanelJustificacionN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpresionN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tstEditar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.GroupBox GroupBox17;
        internal System.Windows.Forms.Panel PanelJustificacionN;
        internal System.Windows.Forms.TextBox txtJustificacionN;
        internal System.Windows.Forms.DataGridView dgvImpresionN;
        internal System.Windows.Forms.DataGridViewImageColumn anulardiagevoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResumenClinico;
    }
}