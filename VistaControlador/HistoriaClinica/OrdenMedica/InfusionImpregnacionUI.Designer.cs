namespace Galactus.VistaControlador.HistoriaClinica.OrdenMedica
{
    partial class InfusionImpregnacionUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupBox63 = new System.Windows.Forms.GroupBox();
            this.dgvOrdenInfusionImpregnacion = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgIdMedicamentoOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcionTipoOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdEquivalenciaOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcionOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTipoOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDosisOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUnidadOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVelocidadOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIdEquivalenciaDisolventeOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescripcionDisolventeOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCantidadDisolventeOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHoraInicialOrdenINIM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgMezclaOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDiasTratamientoOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSuspenderOrdenINIM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgAceptaDisolventeOrdenINIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox63.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenInfusionImpregnacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Agregar";
            this.dataGridViewImageColumn1.Image = global::Galactus.Properties.Resources.farmacia_ico;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 56;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "Quitar";
            this.dataGridViewImageColumn2.Image = global::Galactus.Properties.Resources.btn_anular;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 46;
            // 
            // GroupBox63
            // 
            this.GroupBox63.Controls.Add(this.dgvOrdenInfusionImpregnacion);
            this.GroupBox63.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox63.Location = new System.Drawing.Point(12, 3);
            this.GroupBox63.Name = "GroupBox63";
            this.GroupBox63.Size = new System.Drawing.Size(962, 285);
            this.GroupBox63.TabIndex = 8;
            this.GroupBox63.TabStop = false;
            this.GroupBox63.Text = "Infusiones e impregnaciones:";
            // 
            // dgvOrdenInfusionImpregnacion
            // 
            this.dgvOrdenInfusionImpregnacion.AllowUserToAddRows = false;
            this.dgvOrdenInfusionImpregnacion.AllowUserToDeleteRows = false;
            this.dgvOrdenInfusionImpregnacion.AllowUserToResizeColumns = false;
            this.dgvOrdenInfusionImpregnacion.AllowUserToResizeRows = false;
            this.dgvOrdenInfusionImpregnacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenInfusionImpregnacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenInfusionImpregnacion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrdenInfusionImpregnacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenInfusionImpregnacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrdenInfusionImpregnacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenInfusionImpregnacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn3,
            this.dataGridViewImageColumn4,
            this.dgIdMedicamentoOrdenINIM,
            this.dgDescripcionTipoOrdenINIM,
            this.dgIdEquivalenciaOrdenINIM,
            this.dgDescripcionOrdenINIM,
            this.dgTipoOrdenINIM,
            this.dgDosisOrdenINIM,
            this.dgUnidadOrdenINIM,
            this.dgVelocidadOrdenINIM,
            this.dgIdEquivalenciaDisolventeOrdenINIM,
            this.dgDescripcionDisolventeOrdenINIM,
            this.dgCantidadDisolventeOrdenINIM,
            this.dgHoraInicialOrdenINIM,
            this.dgMezclaOrdenINIM,
            this.dgDiasTratamientoOrdenINIM,
            this.dgSuspenderOrdenINIM,
            this.dgAceptaDisolventeOrdenINIM});
            this.dgvOrdenInfusionImpregnacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvOrdenInfusionImpregnacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdenInfusionImpregnacion.Location = new System.Drawing.Point(3, 17);
            this.dgvOrdenInfusionImpregnacion.MultiSelect = false;
            this.dgvOrdenInfusionImpregnacion.Name = "dgvOrdenInfusionImpregnacion";
            this.dgvOrdenInfusionImpregnacion.RowHeadersVisible = false;
            this.dgvOrdenInfusionImpregnacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrdenInfusionImpregnacion.Size = new System.Drawing.Size(956, 265);
            this.dgvOrdenInfusionImpregnacion.TabIndex = 15;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Agregar";
            this.dataGridViewImageColumn3.Image = global::Galactus.Properties.Resources.farmacia_ico;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 56;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn4.HeaderText = "Quitar";
            this.dataGridViewImageColumn4.Image = global::Galactus.Properties.Resources.btn_anular;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Width = 46;
            // 
            // dgIdMedicamentoOrdenINIM
            // 
            this.dgIdMedicamentoOrdenINIM.DataPropertyName = "idMedicamento";
            this.dgIdMedicamentoOrdenINIM.HeaderText = "idMedicamento";
            this.dgIdMedicamentoOrdenINIM.Name = "dgIdMedicamentoOrdenINIM";
            this.dgIdMedicamentoOrdenINIM.Visible = false;
            this.dgIdMedicamentoOrdenINIM.Width = 116;
            // 
            // dgDescripcionTipoOrdenINIM
            // 
            this.dgDescripcionTipoOrdenINIM.DataPropertyName = "Tipo";
            this.dgDescripcionTipoOrdenINIM.HeaderText = "Tipo";
            this.dgDescripcionTipoOrdenINIM.Name = "dgDescripcionTipoOrdenINIM";
            this.dgDescripcionTipoOrdenINIM.Width = 56;
            // 
            // dgIdEquivalenciaOrdenINIM
            // 
            this.dgIdEquivalenciaOrdenINIM.DataPropertyName = "idEquivalencia";
            this.dgIdEquivalenciaOrdenINIM.HeaderText = "idEquivalencia";
            this.dgIdEquivalenciaOrdenINIM.Name = "dgIdEquivalenciaOrdenINIM";
            this.dgIdEquivalenciaOrdenINIM.Visible = false;
            this.dgIdEquivalenciaOrdenINIM.Width = 112;
            // 
            // dgDescripcionOrdenINIM
            // 
            this.dgDescripcionOrdenINIM.DataPropertyName = "Descripción";
            this.dgDescripcionOrdenINIM.HeaderText = "Descripción";
            this.dgDescripcionOrdenINIM.Name = "dgDescripcionOrdenINIM";
            this.dgDescripcionOrdenINIM.Width = 98;
            // 
            // dgTipoOrdenINIM
            // 
            this.dgTipoOrdenINIM.DataPropertyName = "tipoMedicamento";
            this.dgTipoOrdenINIM.HeaderText = "tipoMedicamento";
            this.dgTipoOrdenINIM.Name = "dgTipoOrdenINIM";
            this.dgTipoOrdenINIM.Visible = false;
            this.dgTipoOrdenINIM.Width = 126;
            // 
            // dgDosisOrdenINIM
            // 
            this.dgDosisOrdenINIM.DataPropertyName = "Dosis";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0";
            this.dgDosisOrdenINIM.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgDosisOrdenINIM.HeaderText = "Dosis";
            this.dgDosisOrdenINIM.Name = "dgDosisOrdenINIM";
            this.dgDosisOrdenINIM.Width = 65;
            // 
            // dgUnidadOrdenINIM
            // 
            this.dgUnidadOrdenINIM.DataPropertyName = "Unidad";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUnidadOrdenINIM.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgUnidadOrdenINIM.HeaderText = "Unidad";
            this.dgUnidadOrdenINIM.Name = "dgUnidadOrdenINIM";
            this.dgUnidadOrdenINIM.Width = 72;
            // 
            // dgVelocidadOrdenINIM
            // 
            this.dgVelocidadOrdenINIM.DataPropertyName = "cc/hora";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0";
            this.dgVelocidadOrdenINIM.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgVelocidadOrdenINIM.HeaderText = "cc/hora";
            this.dgVelocidadOrdenINIM.Name = "dgVelocidadOrdenINIM";
            this.dgVelocidadOrdenINIM.Width = 72;
            // 
            // dgIdEquivalenciaDisolventeOrdenINIM
            // 
            this.dgIdEquivalenciaDisolventeOrdenINIM.DataPropertyName = "idEquivalenciaDisolvente";
            this.dgIdEquivalenciaDisolventeOrdenINIM.HeaderText = "idEquivalenciaDosilvente";
            this.dgIdEquivalenciaDisolventeOrdenINIM.Name = "dgIdEquivalenciaDisolventeOrdenINIM";
            this.dgIdEquivalenciaDisolventeOrdenINIM.Visible = false;
            this.dgIdEquivalenciaDisolventeOrdenINIM.Width = 170;
            // 
            // dgDescripcionDisolventeOrdenINIM
            // 
            this.dgDescripcionDisolventeOrdenINIM.DataPropertyName = "Disolvente";
            this.dgDescripcionDisolventeOrdenINIM.HeaderText = "Disolvente";
            this.dgDescripcionDisolventeOrdenINIM.Name = "dgDescripcionDisolventeOrdenINIM";
            this.dgDescripcionDisolventeOrdenINIM.Width = 90;
            // 
            // dgCantidadDisolventeOrdenINIM
            // 
            this.dgCantidadDisolventeOrdenINIM.DataPropertyName = "Cantidad";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = "0";
            this.dgCantidadDisolventeOrdenINIM.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgCantidadDisolventeOrdenINIM.HeaderText = "Cantidad";
            this.dgCantidadDisolventeOrdenINIM.Name = "dgCantidadDisolventeOrdenINIM";
            this.dgCantidadDisolventeOrdenINIM.Width = 82;
            // 
            // dgHoraInicialOrdenINIM
            // 
            this.dgHoraInicialOrdenINIM.DataPropertyName = "Hora inicial";
            this.dgHoraInicialOrdenINIM.HeaderText = "Hora inicial";
            this.dgHoraInicialOrdenINIM.Items.AddRange(new object[] {
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
            this.dgHoraInicialOrdenINIM.Name = "dgHoraInicialOrdenINIM";
            this.dgHoraInicialOrdenINIM.Width = 75;
            // 
            // dgMezclaOrdenINIM
            // 
            this.dgMezclaOrdenINIM.DataPropertyName = "Mezcla";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgMezclaOrdenINIM.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgMezclaOrdenINIM.HeaderText = "Mezcla";
            this.dgMezclaOrdenINIM.Name = "dgMezclaOrdenINIM";
            this.dgMezclaOrdenINIM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMezclaOrdenINIM.Width = 69;
            // 
            // dgDiasTratamientoOrdenINIM
            // 
            this.dgDiasTratamientoOrdenINIM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgDiasTratamientoOrdenINIM.DataPropertyName = "Dias Tto";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgDiasTratamientoOrdenINIM.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgDiasTratamientoOrdenINIM.HeaderText = "Dias Tto";
            this.dgDiasTratamientoOrdenINIM.Name = "dgDiasTratamientoOrdenINIM";
            this.dgDiasTratamientoOrdenINIM.Width = 70;
            // 
            // dgSuspenderOrdenINIM
            // 
            this.dgSuspenderOrdenINIM.DataPropertyName = "Suspender";
            this.dgSuspenderOrdenINIM.HeaderText = "Suspender";
            this.dgSuspenderOrdenINIM.Name = "dgSuspenderOrdenINIM";
            this.dgSuspenderOrdenINIM.Width = 74;
            // 
            // dgAceptaDisolventeOrdenINIM
            // 
            this.dgAceptaDisolventeOrdenINIM.DataPropertyName = "Acepta disolvente";
            this.dgAceptaDisolventeOrdenINIM.HeaderText = "Acepta disolvente";
            this.dgAceptaDisolventeOrdenINIM.Name = "dgAceptaDisolventeOrdenINIM";
            this.dgAceptaDisolventeOrdenINIM.Visible = false;
            this.dgAceptaDisolventeOrdenINIM.Width = 117;
            // 
            // InfusionImpregnacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(986, 291);
            this.Controls.Add(this.GroupBox63);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(986, 291);
            this.MinimumSize = new System.Drawing.Size(986, 291);
            this.Name = "InfusionImpregnacionUI";
            this.Text = "InfusionImpregnacionUI";
            this.Load += new System.EventHandler(this.InfusionImpregnacionUI_Load);
            this.GroupBox63.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenInfusionImpregnacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        internal System.Windows.Forms.GroupBox GroupBox63;
        public System.Windows.Forms.DataGridView dgvOrdenInfusionImpregnacion;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdMedicamentoOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcionTipoOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdEquivalenciaOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcionOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTipoOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDosisOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUnidadOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgVelocidadOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdEquivalenciaDisolventeOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescripcionDisolventeOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCantidadDisolventeOrdenINIM;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgHoraInicialOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMezclaOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDiasTratamientoOrdenINIM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgSuspenderOrdenINIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAceptaDisolventeOrdenINIM;
    }
}