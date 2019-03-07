namespace Galactus.VistaControlador.HistoriaClinica
{
    partial class ListadoPacienteUI
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
            this.label30 = new System.Windows.Forms.Label();
            this.pacientePB = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListaPaciente = new System.Windows.Forms.DataGridView();
            this.dgAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEntorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEstancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.triageBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buscarHCPacienteBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pacientePB)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPaciente)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 12F);
            this.label30.Location = new System.Drawing.Point(52, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(136, 18);
            this.label30.TabIndex = 31;
            this.label30.Text = "Lista de pacientes";
            // 
            // pacientePB
            // 
            this.pacientePB.Image = global::Galactus.Properties.Resources.user__1_;
            this.pacientePB.Location = new System.Drawing.Point(12, 9);
            this.pacientePB.Name = "pacientePB";
            this.pacientePB.Size = new System.Drawing.Size(35, 31);
            this.pacientePB.TabIndex = 32;
            this.pacientePB.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 592);
            this.panel1.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListaPaciente);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(7, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1235, 528);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numero de paciente(200)";
            // 
            // dgvListaPaciente
            // 
            this.dgvListaPaciente.AllowUserToAddRows = false;
            this.dgvListaPaciente.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgAtencion,
            this.dgPaciente,
            this.dgEntorno,
            this.dgArea,
            this.dgEstancia,
            this.dgEdad,
            this.dgGenero,
            this.dgEps});
            this.dgvListaPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaPaciente.Location = new System.Drawing.Point(3, 18);
            this.dgvListaPaciente.Name = "dgvListaPaciente";
            this.dgvListaPaciente.RowHeadersVisible = false;
            this.dgvListaPaciente.ShowCellErrors = false;
            this.dgvListaPaciente.ShowCellToolTips = false;
            this.dgvListaPaciente.ShowEditingIcon = false;
            this.dgvListaPaciente.ShowRowErrors = false;
            this.dgvListaPaciente.Size = new System.Drawing.Size(1229, 507);
            this.dgvListaPaciente.TabIndex = 0;
            this.dgvListaPaciente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPaciente_CellDoubleClick);
            // 
            // dgAtencion
            // 
            this.dgAtencion.HeaderText = "Atencion";
            this.dgAtencion.Name = "dgAtencion";
            // 
            // dgPaciente
            // 
            this.dgPaciente.HeaderText = "Paciente";
            this.dgPaciente.Name = "dgPaciente";
            this.dgPaciente.Width = 200;
            // 
            // dgEntorno
            // 
            this.dgEntorno.HeaderText = "Entorno";
            this.dgEntorno.Name = "dgEntorno";
            // 
            // dgArea
            // 
            this.dgArea.HeaderText = "Area";
            this.dgArea.Name = "dgArea";
            // 
            // dgEstancia
            // 
            this.dgEstancia.HeaderText = "Estancia";
            this.dgEstancia.Name = "dgEstancia";
            // 
            // dgEdad
            // 
            this.dgEdad.HeaderText = "Edad";
            this.dgEdad.Name = "dgEdad";
            // 
            // dgGenero
            // 
            this.dgGenero.HeaderText = "Genero";
            this.dgGenero.Name = "dgGenero";
            // 
            // dgEps
            // 
            this.dgEps.HeaderText = "EPS";
            this.dgEps.Name = "dgEps";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.triageBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buscarHCPacienteBtn);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(7, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 37);
            this.panel2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1029, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(966, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Estados:";
            // 
            // button1
            // 
            this.button1.Image = global::Galactus.Properties.Resources.btn_lupa;
            this.button1.Location = new System.Drawing.Point(932, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(664, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(262, 20);
            this.textBox3.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(621, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Area:";
            // 
            // triageBox
            // 
            this.triageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.triageBox.FormattingEnabled = true;
            this.triageBox.Location = new System.Drawing.Point(388, 5);
            this.triageBox.Name = "triageBox";
            this.triageBox.Size = new System.Drawing.Size(212, 21);
            this.triageBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(325, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Entorno:";
            // 
            // buscarHCPacienteBtn
            // 
            this.buscarHCPacienteBtn.Image = global::Galactus.Properties.Resources.btn_lupa;
            this.buscarHCPacienteBtn.Location = new System.Drawing.Point(291, 3);
            this.buscarHCPacienteBtn.Name = "buscarHCPacienteBtn";
            this.buscarHCPacienteBtn.Size = new System.Drawing.Size(26, 24);
            this.buscarHCPacienteBtn.TabIndex = 28;
            this.buscarHCPacienteBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Busqueda:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1235, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 46;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ListadoPacienteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 650);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.pacientePB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1269, 650);
            this.MinimumSize = new System.Drawing.Size(1269, 650);
            this.Name = "ListadoPacienteUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoPaciente";
            this.Load += new System.EventHandler(this.ListadoPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientePB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPaciente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PictureBox pacientePB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscarHCPacienteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListaPaciente;
        private System.Windows.Forms.ComboBox triageBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEntorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEstancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEps;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}