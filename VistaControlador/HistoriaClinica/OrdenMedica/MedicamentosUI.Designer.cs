namespace Galactus.VistaControlador.HistoriaClinica.OrdenMedica
{
    partial class MedicamentosUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicamentosUI));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.PanelJustificacionN = new System.Windows.Forms.Panel();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.anulardiagevoN = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.PanelJustificacionN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "Quitar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.GroupBox17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 308);
            this.panel1.TabIndex = 2;
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.PanelJustificacionN);
            this.GroupBox17.Controls.Add(this.dgvMedicamentos);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(12, 3);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(883, 293);
            this.GroupBox17.TabIndex = 10092;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Medicamentos";
            // 
            // PanelJustificacionN
            // 
            this.PanelJustificacionN.BackColor = System.Drawing.Color.OldLace;
            this.PanelJustificacionN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelJustificacionN.Controls.Add(this.txtJustificacion);
            this.PanelJustificacionN.Location = new System.Drawing.Point(346, 21);
            this.PanelJustificacionN.Name = "PanelJustificacionN";
            this.PanelJustificacionN.Size = new System.Drawing.Size(464, 204);
            this.PanelJustificacionN.TabIndex = 10085;
            this.PanelJustificacionN.Visible = false;
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtJustificacion.Location = new System.Drawing.Point(4, 3);
            this.txtJustificacion.Multiline = true;
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJustificacion.Size = new System.Drawing.Size(455, 196);
            this.txtJustificacion.TabIndex = 10065;
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.AllowUserToDeleteRows = false;
            this.dgvMedicamentos.AllowUserToResizeColumns = false;
            this.dgvMedicamentos.AllowUserToResizeRows = false;
            this.dgvMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedicamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicamentos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anulardiagevoN});
            this.dgvMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicamentos.Location = new System.Drawing.Point(3, 18);
            this.dgvMedicamentos.MultiSelect = false;
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.ReadOnly = true;
            this.dgvMedicamentos.RowHeadersVisible = false;
            this.dgvMedicamentos.Size = new System.Drawing.Size(877, 272);
            this.dgvMedicamentos.TabIndex = 2;
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
            // MedicamentosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 308);
            this.Controls.Add(this.panel1);
            this.Name = "MedicamentosUI";
            this.Text = "MedicamentosUI";
            this.panel1.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.PanelJustificacionN.ResumeLayout(false);
            this.PanelJustificacionN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.GroupBox GroupBox17;
        internal System.Windows.Forms.Panel PanelJustificacionN;
        internal System.Windows.Forms.TextBox txtJustificacion;
        internal System.Windows.Forms.DataGridView dgvMedicamentos;
        internal System.Windows.Forms.DataGridViewImageColumn anulardiagevoN;
    }
}