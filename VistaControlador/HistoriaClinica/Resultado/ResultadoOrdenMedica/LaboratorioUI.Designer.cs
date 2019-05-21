namespace Galactus.VistaControlador.HistoriaClinica.OrdenMedica
{
    partial class LaboratorioUI
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
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.dgvOrdenOxigeno = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgIdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcionOrdenOxigeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLectura = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenOxigeno)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvOrdenOxigeno);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(12, 3);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(962, 154);
            this.GroupBox17.TabIndex = 10093;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Laboratorio";
            // 
            // dgvOrdenOxigeno
            // 
            this.dgvOrdenOxigeno.AllowUserToAddRows = false;
            this.dgvOrdenOxigeno.AllowUserToDeleteRows = false;
            this.dgvOrdenOxigeno.AllowUserToResizeColumns = false;
            this.dgvOrdenOxigeno.AllowUserToResizeRows = false;
            this.dgvOrdenOxigeno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenOxigeno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenOxigeno.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrdenOxigeno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenOxigeno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdenOxigeno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenOxigeno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdSolicitud,
            this.dgIdProcedimiento,
            this.dgDescripcionOrdenOxigeno,
            this.dgLectura});
            this.dgvOrdenOxigeno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvOrdenOxigeno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdenOxigeno.Location = new System.Drawing.Point(3, 17);
            this.dgvOrdenOxigeno.MultiSelect = false;
            this.dgvOrdenOxigeno.Name = "dgvOrdenOxigeno";
            this.dgvOrdenOxigeno.ReadOnly = true;
            this.dgvOrdenOxigeno.RowHeadersVisible = false;
            this.dgvOrdenOxigeno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrdenOxigeno.Size = new System.Drawing.Size(956, 134);
            this.dgvOrdenOxigeno.TabIndex = 15;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Mezcla";
            this.dataGridViewImageColumn1.Image = global::Galactus.Properties.Resources.infusion16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Agregar";
            this.dataGridViewImageColumn2.Image = global::Galactus.Properties.Resources.farmacia_ico;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "Quitar";
            this.dataGridViewImageColumn3.Image = global::Galactus.Properties.Resources.btn_anular;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // dgIdSolicitud
            // 
            this.dgIdSolicitud.HeaderText = "idSolicitud";
            this.dgIdSolicitud.Name = "dgIdSolicitud";
            this.dgIdSolicitud.ReadOnly = true;
            this.dgIdSolicitud.Visible = false;
            this.dgIdSolicitud.Width = 70;
            // 
            // dgIdProcedimiento
            // 
            this.dgIdProcedimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgIdProcedimiento.DataPropertyName = "idOxigeno";
            this.dgIdProcedimiento.HeaderText = "idProcedimiento";
            this.dgIdProcedimiento.Name = "dgIdProcedimiento";
            this.dgIdProcedimiento.ReadOnly = true;
            this.dgIdProcedimiento.Visible = false;
            this.dgIdProcedimiento.Width = 609;
            // 
            // dgDescripcionOrdenOxigeno
            // 
            this.dgDescripcionOrdenOxigeno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescripcionOrdenOxigeno.DataPropertyName = "Descripción";
            this.dgDescripcionOrdenOxigeno.HeaderText = "Descripción";
            this.dgDescripcionOrdenOxigeno.Name = "dgDescripcionOrdenOxigeno";
            this.dgDescripcionOrdenOxigeno.ReadOnly = true;
            this.dgDescripcionOrdenOxigeno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgLectura
            // 
            this.dgLectura.HeaderText = "Lectura";
            this.dgLectura.Name = "dgLectura";
            this.dgLectura.ReadOnly = true;
            this.dgLectura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLectura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgLectura.Width = 73;
            // 
            // LaboratorioUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 291);
            this.Controls.Add(this.GroupBox17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(986, 291);
            this.MinimumSize = new System.Drawing.Size(986, 291);
            this.Name = "LaboratorioUI";
            this.Text = "LaboratorioUI";
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenOxigeno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox17;
        public System.Windows.Forms.DataGridView dgvOrdenOxigeno;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcionOrdenOxigeno;
        private System.Windows.Forms.DataGridViewImageColumn dgLectura;
    }
}