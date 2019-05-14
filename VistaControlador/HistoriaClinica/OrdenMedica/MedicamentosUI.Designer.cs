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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvOrdenMedicamentos = new System.Windows.Forms.DataGridView();
            this.DataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewImageColumn8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgIdMedicamentoOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdEquivalenciaOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcionOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTipoOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdObjetoOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgViaOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDosisOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUnidadOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHorarioOrdenMedicamento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgHoraInicialOrdenMedicamento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgDiasTratamientoOrdenMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSuspenderOrdenMedicamento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.GroupBox17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 291);
            this.panel1.TabIndex = 2;
            // 
            // GroupBox17
            // 
            this.GroupBox17.Controls.Add(this.dgvOrdenMedicamentos);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(12, 3);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(962, 285);
            this.GroupBox17.TabIndex = 10092;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Medicamentos";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "Quitar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Agregar";
            this.dataGridViewImageColumn2.Image = global::Galactus.Properties.Resources.add;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "Quitar";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 41;
            // 
            // dgvOrdenMedicamentos
            // 
            this.dgvOrdenMedicamentos.AllowUserToAddRows = false;
            this.dgvOrdenMedicamentos.AllowUserToDeleteRows = false;
            this.dgvOrdenMedicamentos.AllowUserToResizeColumns = false;
            this.dgvOrdenMedicamentos.AllowUserToResizeRows = false;
            this.dgvOrdenMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenMedicamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenMedicamentos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrdenMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenMedicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdenMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewImageColumn7,
            this.DataGridViewImageColumn8,
            this.dgIdMedicamentoOrdenMedicamento,
            this.dgIdEquivalenciaOrdenMedicamento,
            this.dgDescripcionOrdenMedicamento,
            this.dgTipoOrdenMedicamento,
            this.dgIdObjetoOrdenMedicamento,
            this.dgViaOrdenMedicamento,
            this.dgDosisOrdenMedicamento,
            this.dgUnidadOrdenMedicamento,
            this.dgHorarioOrdenMedicamento,
            this.dgHoraInicialOrdenMedicamento,
            this.dgDiasTratamientoOrdenMedicamento,
            this.dgSuspenderOrdenMedicamento});
            this.dgvOrdenMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvOrdenMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdenMedicamentos.Location = new System.Drawing.Point(3, 17);
            this.dgvOrdenMedicamentos.MultiSelect = false;
            this.dgvOrdenMedicamentos.Name = "dgvOrdenMedicamentos";
            this.dgvOrdenMedicamentos.RowHeadersVisible = false;
            this.dgvOrdenMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrdenMedicamentos.Size = new System.Drawing.Size(956, 265);
            this.dgvOrdenMedicamentos.TabIndex = 15;
            // 
            // DataGridViewImageColumn7
            // 
            this.DataGridViewImageColumn7.HeaderText = "Agregar";
            this.DataGridViewImageColumn7.Image = global::Galactus.Properties.Resources.farmacia_ico;
            this.DataGridViewImageColumn7.Name = "DataGridViewImageColumn7";
            this.DataGridViewImageColumn7.Width = 56;
            // 
            // DataGridViewImageColumn8
            // 
            this.DataGridViewImageColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataGridViewImageColumn8.HeaderText = "Quitar";
            this.DataGridViewImageColumn8.Image = global::Galactus.Properties.Resources.btn_anular;
            this.DataGridViewImageColumn8.Name = "DataGridViewImageColumn8";
            this.DataGridViewImageColumn8.Width = 46;
            // 
            // dgIdMedicamentoOrdenMedicamento
            // 
            this.dgIdMedicamentoOrdenMedicamento.DataPropertyName = "idMedicamento";
            this.dgIdMedicamentoOrdenMedicamento.HeaderText = "idMedicamento";
            this.dgIdMedicamentoOrdenMedicamento.Name = "dgIdMedicamentoOrdenMedicamento";
            this.dgIdMedicamentoOrdenMedicamento.Visible = false;
            this.dgIdMedicamentoOrdenMedicamento.Width = 116;
            // 
            // dgIdEquivalenciaOrdenMedicamento
            // 
            this.dgIdEquivalenciaOrdenMedicamento.DataPropertyName = "idEquivalencia";
            this.dgIdEquivalenciaOrdenMedicamento.HeaderText = "idEquivalencia";
            this.dgIdEquivalenciaOrdenMedicamento.Name = "dgIdEquivalenciaOrdenMedicamento";
            this.dgIdEquivalenciaOrdenMedicamento.Visible = false;
            this.dgIdEquivalenciaOrdenMedicamento.Width = 112;
            // 
            // dgDescripcionOrdenMedicamento
            // 
            this.dgDescripcionOrdenMedicamento.DataPropertyName = "Descripción";
            this.dgDescripcionOrdenMedicamento.HeaderText = "Descripción";
            this.dgDescripcionOrdenMedicamento.Name = "dgDescripcionOrdenMedicamento";
            this.dgDescripcionOrdenMedicamento.Width = 98;
            // 
            // dgTipoOrdenMedicamento
            // 
            this.dgTipoOrdenMedicamento.DataPropertyName = "tipoMedicamento";
            this.dgTipoOrdenMedicamento.HeaderText = "Tipo";
            this.dgTipoOrdenMedicamento.Name = "dgTipoOrdenMedicamento";
            this.dgTipoOrdenMedicamento.Visible = false;
            this.dgTipoOrdenMedicamento.Width = 56;
            // 
            // dgIdObjetoOrdenMedicamento
            // 
            this.dgIdObjetoOrdenMedicamento.DataPropertyName = "idObjeto";
            this.dgIdObjetoOrdenMedicamento.HeaderText = "idObjeto";
            this.dgIdObjetoOrdenMedicamento.Name = "dgIdObjetoOrdenMedicamento";
            this.dgIdObjetoOrdenMedicamento.Visible = false;
            this.dgIdObjetoOrdenMedicamento.Width = 78;
            // 
            // dgViaOrdenMedicamento
            // 
            this.dgViaOrdenMedicamento.DataPropertyName = "Via admin.";
            this.dgViaOrdenMedicamento.HeaderText = "Via admin.";
            this.dgViaOrdenMedicamento.Name = "dgViaOrdenMedicamento";
            this.dgViaOrdenMedicamento.Width = 90;
            // 
            // dgDosisOrdenMedicamento
            // 
            this.dgDosisOrdenMedicamento.DataPropertyName = "Dosis";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.dgDosisOrdenMedicamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDosisOrdenMedicamento.HeaderText = "Dosis";
            this.dgDosisOrdenMedicamento.Name = "dgDosisOrdenMedicamento";
            this.dgDosisOrdenMedicamento.Width = 65;
            // 
            // dgUnidadOrdenMedicamento
            // 
            this.dgUnidadOrdenMedicamento.DataPropertyName = "Unidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUnidadOrdenMedicamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgUnidadOrdenMedicamento.HeaderText = "Unidad";
            this.dgUnidadOrdenMedicamento.Name = "dgUnidadOrdenMedicamento";
            this.dgUnidadOrdenMedicamento.Width = 72;
            // 
            // dgHorarioOrdenMedicamento
            // 
            this.dgHorarioOrdenMedicamento.DataPropertyName = "Horario";
            this.dgHorarioOrdenMedicamento.HeaderText = "Horario";
            this.dgHorarioOrdenMedicamento.Items.AddRange(new object[] {
            "Por definir",
            "Cód. Azul",
            "Ahora",
            "Razón nec.",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "36",
            "48",
            "72"});
            this.dgHorarioOrdenMedicamento.Name = "dgHorarioOrdenMedicamento";
            this.dgHorarioOrdenMedicamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHorarioOrdenMedicamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgHorarioOrdenMedicamento.Width = 73;
            // 
            // dgHoraInicialOrdenMedicamento
            // 
            this.dgHoraInicialOrdenMedicamento.DataPropertyName = "Hora inicial";
            this.dgHoraInicialOrdenMedicamento.HeaderText = "Hora inicial";
            this.dgHoraInicialOrdenMedicamento.Items.AddRange(new object[] {
            "Por definir",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.dgHoraInicialOrdenMedicamento.Name = "dgHoraInicialOrdenMedicamento";
            this.dgHoraInicialOrdenMedicamento.Width = 75;
            // 
            // dgDiasTratamientoOrdenMedicamento
            // 
            this.dgDiasTratamientoOrdenMedicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgDiasTratamientoOrdenMedicamento.DataPropertyName = "Dias Tto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgDiasTratamientoOrdenMedicamento.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgDiasTratamientoOrdenMedicamento.HeaderText = "Dias Tto";
            this.dgDiasTratamientoOrdenMedicamento.Name = "dgDiasTratamientoOrdenMedicamento";
            this.dgDiasTratamientoOrdenMedicamento.Width = 70;
            // 
            // dgSuspenderOrdenMedicamento
            // 
            this.dgSuspenderOrdenMedicamento.DataPropertyName = "Suspender";
            this.dgSuspenderOrdenMedicamento.HeaderText = "Suspender";
            this.dgSuspenderOrdenMedicamento.Name = "dgSuspenderOrdenMedicamento";
            this.dgSuspenderOrdenMedicamento.Width = 74;
            // 
            // MedicamentosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 291);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(986, 291);
            this.MinimumSize = new System.Drawing.Size(986, 291);
            this.Name = "MedicamentosUI";
            this.Text = "MedicamentosUI";
            this.Load += new System.EventHandler(this.MedicamentosUI_Load);
            this.panel1.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenMedicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.GroupBox GroupBox17;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        public System.Windows.Forms.DataGridView dgvOrdenMedicamentos;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewImageColumn DataGridViewImageColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdMedicamentoOrdenMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdEquivalenciaOrdenMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcionOrdenMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTipoOrdenMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdObjetoOrdenMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgViaOrdenMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDosisOrdenMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUnidadOrdenMedicamento;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgHorarioOrdenMedicamento;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgHoraInicialOrdenMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDiasTratamientoOrdenMedicamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgSuspenderOrdenMedicamento;
    }
}