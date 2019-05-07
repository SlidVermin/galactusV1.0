namespace Galactus.VistaControlador.HistoriaClinica
{
    partial class EstanciaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstanciaUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tstMenuEvolucion = new System.Windows.Forms.ToolStrip();
            this.tsBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsBtModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsBtAnular = new System.Windows.Forms.ToolStripButton();
            this.tsBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.gbEstancia = new System.Windows.Forms.GroupBox();
            this.dgvEstancia = new System.Windows.Forms.DataGridView();
            this.dgIdCodigoManualCUPSEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgExcluirEstancia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgFechaEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCodigoCUPSEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcionEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgJustificacionEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdUsuarioCEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tstMenuEvolucion.SuspendLayout();
            this.gbEstancia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstancia)).BeginInit();
            this.SuspendLayout();
            // 
            // tstMenuEvolucion
            // 
            this.tstMenuEvolucion.BackColor = System.Drawing.Color.White;
            this.tstMenuEvolucion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuEvolucion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtNuevo,
            this.tsBtModificar,
            this.tsBtGuardar,
            this.tsBtBuscar,
            this.tsBtAnular,
            this.tsBtCancelar});
            this.tstMenuEvolucion.Location = new System.Drawing.Point(0, 332);
            this.tstMenuEvolucion.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstMenuEvolucion.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstMenuEvolucion.Name = "tstMenuEvolucion";
            this.tstMenuEvolucion.Size = new System.Drawing.Size(1095, 25);
            this.tstMenuEvolucion.TabIndex = 65;
            this.tstMenuEvolucion.Text = "toolStrip1";
            // 
            // tsBtNuevo
            // 
            this.tsBtNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsBtNuevo.Image")));
            this.tsBtNuevo.ImageTransparentColor = System.Drawing.Color.White;
            this.tsBtNuevo.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtNuevo.Name = "tsBtNuevo";
            this.tsBtNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsBtNuevo.Text = "Nuevo";
            // 
            // tsBtModificar
            // 
            this.tsBtModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtModificar.Image")));
            this.tsBtModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtModificar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtModificar.Name = "tsBtModificar";
            this.tsBtModificar.Size = new System.Drawing.Size(78, 22);
            this.tsBtModificar.Text = "Modificar";
            // 
            // tsBtGuardar
            // 
            this.tsBtGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtGuardar.Image")));
            this.tsBtGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtGuardar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtGuardar.Name = "tsBtGuardar";
            this.tsBtGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsBtGuardar.Text = "Guardar";
            // 
            // tsBtBuscar
            // 
            this.tsBtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtBuscar.Image")));
            this.tsBtBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtBuscar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtBuscar.Name = "tsBtBuscar";
            this.tsBtBuscar.Size = new System.Drawing.Size(62, 22);
            this.tsBtBuscar.Text = "Buscar";
            // 
            // tsBtAnular
            // 
            this.tsBtAnular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtAnular.Image = ((System.Drawing.Image)(resources.GetObject("tsBtAnular.Image")));
            this.tsBtAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtAnular.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtAnular.Name = "tsBtAnular";
            this.tsBtAnular.Size = new System.Drawing.Size(62, 22);
            this.tsBtAnular.Text = "Anular";
            // 
            // tsBtCancelar
            // 
            this.tsBtCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtCancelar.Image")));
            this.tsBtCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtCancelar.Name = "tsBtCancelar";
            this.tsBtCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsBtCancelar.Text = "Cancelar";
            // 
            // gbEstancia
            // 
            this.gbEstancia.Controls.Add(this.dgvEstancia);
            this.gbEstancia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstancia.Location = new System.Drawing.Point(12, 12);
            this.gbEstancia.Name = "gbEstancia";
            this.gbEstancia.Size = new System.Drawing.Size(1076, 317);
            this.gbEstancia.TabIndex = 66;
            this.gbEstancia.TabStop = false;
            this.gbEstancia.Text = "Listado de estancia por dia";
            // 
            // dgvEstancia
            // 
            this.dgvEstancia.AllowUserToAddRows = false;
            this.dgvEstancia.AllowUserToDeleteRows = false;
            this.dgvEstancia.AllowUserToResizeColumns = false;
            this.dgvEstancia.AllowUserToResizeRows = false;
            this.dgvEstancia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstancia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstancia.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEstancia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstancia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstancia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdCodigoManualCUPSEstancia,
            this.dgExcluirEstancia,
            this.dgFechaEstancia,
            this.dgCodigoCUPSEstancia,
            this.dgDescripcionEstancia,
            this.dgJustificacionEstancia,
            this.dgIdUsuarioCEstancia});
            this.dgvEstancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvEstancia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstancia.Location = new System.Drawing.Point(3, 17);
            this.dgvEstancia.MultiSelect = false;
            this.dgvEstancia.Name = "dgvEstancia";
            this.dgvEstancia.RowHeadersVisible = false;
            this.dgvEstancia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEstancia.Size = new System.Drawing.Size(1070, 297);
            this.dgvEstancia.TabIndex = 15;
            // 
            // dgIdCodigoManualCUPSEstancia
            // 
            this.dgIdCodigoManualCUPSEstancia.HeaderText = "idCodigoManualCUPS";
            this.dgIdCodigoManualCUPSEstancia.Name = "dgIdCodigoManualCUPSEstancia";
            this.dgIdCodigoManualCUPSEstancia.Visible = false;
            this.dgIdCodigoManualCUPSEstancia.Width = 137;
            // 
            // dgExcluirEstancia
            // 
            this.dgExcluirEstancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgExcluirEstancia.HeaderText = "Excluir";
            this.dgExcluirEstancia.Name = "dgExcluirEstancia";
            this.dgExcluirEstancia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgExcluirEstancia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgExcluirEstancia.Width = 50;
            // 
            // dgFechaEstancia
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dgFechaEstancia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgFechaEstancia.HeaderText = "Fecha";
            this.dgFechaEstancia.Name = "dgFechaEstancia";
            this.dgFechaEstancia.Width = 66;
            // 
            // dgCodigoCUPSEstancia
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCodigoCUPSEstancia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgCodigoCUPSEstancia.HeaderText = "Código";
            this.dgCodigoCUPSEstancia.Name = "dgCodigoCUPSEstancia";
            this.dgCodigoCUPSEstancia.Width = 72;
            // 
            // dgDescripcionEstancia
            // 
            this.dgDescripcionEstancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgDescripcionEstancia.HeaderText = "Descripción";
            this.dgDescripcionEstancia.Name = "dgDescripcionEstancia";
            this.dgDescripcionEstancia.Width = 550;
            // 
            // dgJustificacionEstancia
            // 
            this.dgJustificacionEstancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgJustificacionEstancia.HeaderText = "Justificación";
            this.dgJustificacionEstancia.Name = "dgJustificacionEstancia";
            // 
            // dgIdUsuarioCEstancia
            // 
            this.dgIdUsuarioCEstancia.HeaderText = "idUsuarioC";
            this.dgIdUsuarioCEstancia.Name = "dgIdUsuarioCEstancia";
            this.dgIdUsuarioCEstancia.Visible = false;
            this.dgIdUsuarioCEstancia.Width = 95;
            // 
            // EstanciaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 357);
            this.Controls.Add(this.gbEstancia);
            this.Controls.Add(this.tstMenuEvolucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1100, 357);
            this.MinimumSize = new System.Drawing.Size(1100, 357);
            this.Name = "EstanciaUI";
            this.Text = "EstanciaUI";
            this.tstMenuEvolucion.ResumeLayout(false);
            this.tstMenuEvolucion.PerformLayout();
            this.gbEstancia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstMenuEvolucion;
        private System.Windows.Forms.ToolStripButton tsBtNuevo;
        private System.Windows.Forms.ToolStripButton tsBtModificar;
        private System.Windows.Forms.ToolStripButton tsBtGuardar;
        private System.Windows.Forms.ToolStripButton tsBtBuscar;
        private System.Windows.Forms.ToolStripButton tsBtAnular;
        private System.Windows.Forms.ToolStripButton tsBtCancelar;
        internal System.Windows.Forms.GroupBox gbEstancia;
        public System.Windows.Forms.DataGridView dgvEstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdCodigoManualCUPSEstancia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgExcluirEstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFechaEstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigoCUPSEstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcionEstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgJustificacionEstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdUsuarioCEstancia;
    }
}