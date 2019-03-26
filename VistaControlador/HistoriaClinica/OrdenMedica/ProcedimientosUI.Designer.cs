namespace Galactus.VistaControlador.HistoriaClinica.OrdenMedica
{
    partial class ProcedimientosUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcedimientosUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.PanelJustificacionN = new System.Windows.Forms.Panel();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.dgvProcedimientos = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.justificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.anulardiagevoN = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.PanelJustificacionN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.GroupBox17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 256);
            this.panel1.TabIndex = 1;
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.PanelJustificacionN);
            this.GroupBox17.Controls.Add(this.dgvProcedimientos);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(12, 3);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(883, 248);
            this.GroupBox17.TabIndex = 10092;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Procedimientos";
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
            // dgvProcedimientos
            // 
            this.dgvProcedimientos.AllowUserToAddRows = false;
            this.dgvProcedimientos.AllowUserToDeleteRows = false;
            this.dgvProcedimientos.AllowUserToResizeColumns = false;
            this.dgvProcedimientos.AllowUserToResizeRows = false;
            this.dgvProcedimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProcedimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProcedimientos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.cantidad,
            this.justificacion,
            this.Agregar,
            this.anulardiagevoN});
            this.dgvProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcedimientos.Location = new System.Drawing.Point(3, 18);
            this.dgvProcedimientos.MultiSelect = false;
            this.dgvProcedimientos.Name = "dgvProcedimientos";
            this.dgvProcedimientos.ReadOnly = true;
            this.dgvProcedimientos.RowHeadersVisible = false;
            this.dgvProcedimientos.Size = new System.Drawing.Size(877, 227);
            this.dgvProcedimientos.TabIndex = 2;
            this.dgvProcedimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedimientos_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "Quitar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 90;
            // 
            // justificacion
            // 
            this.justificacion.HeaderText = "Justificación";
            this.justificacion.Name = "justificacion";
            this.justificacion.ReadOnly = true;
            this.justificacion.Width = 112;
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "Agregar";
            this.Agregar.Image = global::Galactus.Properties.Resources.search__1_;
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            this.Agregar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Agregar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Agregar.Width = 84;
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
            // ProcedimientosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 256);
            this.Controls.Add(this.panel1);
            this.Name = "ProcedimientosUI";
            this.Text = "ProcedimientosUI";
            this.Load += new System.EventHandler(this.ProcedimientosUI_Load);
            this.panel1.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.PanelJustificacionN.ResumeLayout(false);
            this.PanelJustificacionN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.GroupBox GroupBox17;
        internal System.Windows.Forms.DataGridView dgvProcedimientos;
        internal System.Windows.Forms.Panel PanelJustificacionN;
        internal System.Windows.Forms.TextBox txtJustificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn justificacion;
        private System.Windows.Forms.DataGridViewImageColumn Agregar;
        private System.Windows.Forms.DataGridViewImageColumn anulardiagevoN;
    }
}