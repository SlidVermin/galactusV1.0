namespace Galactus.VistaControlador.Farmacia
{
    partial class DevolucionMedicamentoUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConsolidados = new System.Windows.Forms.DataGridView();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.btBuscarEntrega = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPestañas = new Galactus.Util.Controles.TabControlGalactus();
            this.tpPreparacion = new System.Windows.Forms.TabPage();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.tpInsumos = new System.Windows.Forms.TabPage();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tstModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.label15 = new System.Windows.Forms.Label();
            this.dgCodigoConsolidado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.Label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsolidados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPestañas.SuspendLayout();
            this.tpPreparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.tpInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.tstMenuPatron.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(23, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 203);
            this.panel2.TabIndex = 75;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(7, 8);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(220, 20);
            this.label33.TabIndex = 48;
            this.label33.Text = "Información de la entrega.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpEntrega);
            this.panel1.Controls.Add(this.Label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvConsolidados);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.txtEntrega);
            this.panel1.Controls.Add(this.btBuscarEntrega);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Location = new System.Drawing.Point(13, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 165);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 10026;
            this.label1.Text = "Pedidos:";
            // 
            // dgvConsolidados
            // 
            this.dgvConsolidados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsolidados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCodigoConsolidado,
            this.dgPaciente,
            this.dgFecha});
            this.dgvConsolidados.Location = new System.Drawing.Point(107, 34);
            this.dgvConsolidados.Name = "dgvConsolidados";
            this.dgvConsolidados.RowHeadersVisible = false;
            this.dgvConsolidados.Size = new System.Drawing.Size(871, 126);
            this.dgvConsolidados.TabIndex = 10025;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(267, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(53, 15);
            this.Label5.TabIndex = 10024;
            this.Label5.Text = "Entrega:";
            // 
            // txtEntrega
            // 
            this.txtEntrega.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrega.Location = new System.Drawing.Point(327, 6);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.ReadOnly = true;
            this.txtEntrega.Size = new System.Drawing.Size(310, 21);
            this.txtEntrega.TabIndex = 10022;
            this.txtEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btBuscarEntrega
            // 
            this.btBuscarEntrega.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarEntrega.Image = global::Galactus.Properties.Resources.btn_lupa;
            this.btBuscarEntrega.Location = new System.Drawing.Point(643, 4);
            this.btBuscarEntrega.Name = "btBuscarEntrega";
            this.btBuscarEntrega.Size = new System.Drawing.Size(26, 24);
            this.btBuscarEntrega.TabIndex = 32;
            this.btBuscarEntrega.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(107, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(140, 21);
            this.txtCodigo.TabIndex = 25;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1027, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 74;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // tabPestañas
            // 
            this.tabPestañas.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabPestañas.Controls.Add(this.tpPreparacion);
            this.tabPestañas.Controls.Add(this.tpInsumos);
            this.tabPestañas.ItemSize = new System.Drawing.Size(30, 120);
            this.tabPestañas.Location = new System.Drawing.Point(23, 245);
            this.tabPestañas.Multiline = true;
            this.tabPestañas.Name = "tabPestañas";
            this.tabPestañas.SelectedIndex = 0;
            this.tabPestañas.Size = new System.Drawing.Size(1009, 282);
            this.tabPestañas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPestañas.TabIndex = 72;
            // 
            // tpPreparacion
            // 
            this.tpPreparacion.Controls.Add(this.dgvMedicamentos);
            this.tpPreparacion.Location = new System.Drawing.Point(124, 4);
            this.tpPreparacion.Name = "tpPreparacion";
            this.tpPreparacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreparacion.Size = new System.Drawing.Size(881, 274);
            this.tpPreparacion.TabIndex = 0;
            this.tpPreparacion.Text = "Medicamentos";
            this.tpPreparacion.UseVisualStyleBackColor = true;
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicamentos.Location = new System.Drawing.Point(3, 3);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.RowHeadersVisible = false;
            this.dgvMedicamentos.Size = new System.Drawing.Size(875, 268);
            this.dgvMedicamentos.TabIndex = 0;
            // 
            // tpInsumos
            // 
            this.tpInsumos.Controls.Add(this.dgvInsumos);
            this.tpInsumos.Location = new System.Drawing.Point(124, 4);
            this.tpInsumos.Name = "tpInsumos";
            this.tpInsumos.Size = new System.Drawing.Size(881, 274);
            this.tpInsumos.TabIndex = 2;
            this.tpInsumos.Text = "Insumos";
            this.tpInsumos.UseVisualStyleBackColor = true;
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInsumos.Location = new System.Drawing.Point(0, 0);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.RowHeadersVisible = false;
            this.dgvInsumos.Size = new System.Drawing.Size(881, 274);
            this.dgvInsumos.TabIndex = 1;
            // 
            // tstMenuPatron
            // 
            this.tstMenuPatron.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuPatron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tstModificar,
            this.tsbCancelar,
            this.tsbGuardar,
            this.tsbBuscar,
            this.tsbAnular});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 555);
            this.tstMenuPatron.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.TabIndex = 71;
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
            // tstModificar
            // 
            this.tstModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstModificar.Image = global::Galactus.Properties.Resources.bt_Editar;
            this.tstModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstModificar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tstModificar.Name = "tstModificar";
            this.tstModificar.Size = new System.Drawing.Size(78, 22);
            this.tstModificar.Text = "Modificar";
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F);
            this.label15.Location = new System.Drawing.Point(60, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(214, 18);
            this.label15.TabIndex = 70;
            this.label15.Text = "Devolución de medicamentos";
            // 
            // dgCodigoConsolidado
            // 
            this.dgCodigoConsolidado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgCodigoConsolidado.HeaderText = "Código";
            this.dgCodigoConsolidado.Name = "dgCodigoConsolidado";
            this.dgCodigoConsolidado.Width = 110;
            // 
            // dgPaciente
            // 
            this.dgPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgPaciente.HeaderText = "Paciente";
            this.dgPaciente.Name = "dgPaciente";
            // 
            // dgFecha
            // 
            this.dgFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgFecha.HeaderText = "Fecha";
            this.dgFecha.Name = "dgFecha";
            this.dgFecha.Width = 120;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.CustomFormat = "dd/MM/yyyy HH.mm:ss";
            this.dtpEntrega.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntrega.Location = new System.Drawing.Point(741, 6);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(154, 21);
            this.dtpEntrega.TabIndex = 10028;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(691, 9);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(44, 15);
            this.Label7.TabIndex = 10027;
            this.Label7.Text = "Fecha:";
            // 
            // DevolucionMedicamentoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabPestañas);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1059, 580);
            this.MinimumSize = new System.Drawing.Size(1059, 580);
            this.Name = "DevolucionMedicamentoUI";
            this.Text = "DevolucionMedicamentoUI";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsolidados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPestañas.ResumeLayout(false);
            this.tpPreparacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.tpInsumos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConsolidados;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtEntrega;
        private System.Windows.Forms.Button btBuscarEntrega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Util.Controles.TabControlGalactus tabPestañas;
        private System.Windows.Forms.TabPage tpPreparacion;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.TabPage tpInsumos;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tstModificar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigoConsolidado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFecha;
        internal System.Windows.Forms.DateTimePicker dtpEntrega;
        internal System.Windows.Forms.Label Label7;
    }
}