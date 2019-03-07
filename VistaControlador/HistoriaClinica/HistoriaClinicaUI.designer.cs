namespace Galactus.VistaControlador.HistoriaClinica
{
    partial class HistoriaClinicaUI
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
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoAdministradora = new System.Windows.Forms.TextBox();
            this.txtAdministradora = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtAtencion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabControlGalactus1 = new Galactus.Util.Controles.TabControlGalactus();
            this.pagIngreso = new System.Windows.Forms.TabPage();
            this.panelIngreso = new System.Windows.Forms.Panel();
            this.pagOrdenMedica = new System.Windows.Forms.TabPage();
            this.pagEvolucion = new System.Windows.Forms.TabPage();
            this.pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlGalactus1.SuspendLayout();
            this.pagIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.dtFecha);
            this.pnlInformacion.Controls.Add(this.label4);
            this.pnlInformacion.Controls.Add(this.txtCodigoAdministradora);
            this.pnlInformacion.Controls.Add(this.txtAdministradora);
            this.pnlInformacion.Controls.Add(this.label10);
            this.pnlInformacion.Controls.Add(this.label9);
            this.pnlInformacion.Controls.Add(this.txtServicio);
            this.pnlInformacion.Controls.Add(this.txtPaciente);
            this.pnlInformacion.Controls.Add(this.txtIdentificacion);
            this.pnlInformacion.Controls.Add(this.txtAtencion);
            this.pnlInformacion.Controls.Add(this.label7);
            this.pnlInformacion.Controls.Add(this.label3);
            this.pnlInformacion.Controls.Add(this.label5);
            this.pnlInformacion.Location = new System.Drawing.Point(4, 38);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(1260, 59);
            this.pnlInformacion.TabIndex = 2;
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFecha.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(897, 6);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(176, 21);
            this.dtFecha.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(792, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Fecha Atención:";
            // 
            // txtCodigoAdministradora
            // 
            this.txtCodigoAdministradora.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtCodigoAdministradora.Location = new System.Drawing.Point(625, 30);
            this.txtCodigoAdministradora.Name = "txtCodigoAdministradora";
            this.txtCodigoAdministradora.Size = new System.Drawing.Size(145, 21);
            this.txtCodigoAdministradora.TabIndex = 27;
            this.txtCodigoAdministradora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdministradora
            // 
            this.txtAdministradora.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtAdministradora.Location = new System.Drawing.Point(776, 30);
            this.txtAdministradora.Name = "txtAdministradora";
            this.txtAdministradora.Size = new System.Drawing.Size(475, 21);
            this.txtAdministradora.TabIndex = 26;
            this.txtAdministradora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label10.Location = new System.Drawing.Point(526, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Administradora:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label9.Location = new System.Drawing.Point(526, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Servicio:";
            // 
            // txtServicio
            // 
            this.txtServicio.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtServicio.Location = new System.Drawing.Point(625, 6);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(145, 21);
            this.txtServicio.TabIndex = 23;
            this.txtServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtPaciente.Location = new System.Drawing.Point(123, 30);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(392, 21);
            this.txtPaciente.TabIndex = 22;
            this.txtPaciente.TextChanged += new System.EventHandler(this.txtPaciente_TextChanged);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtIdentificacion.Location = new System.Drawing.Point(338, 6);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(177, 21);
            this.txtIdentificacion.TabIndex = 20;
            this.txtIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAtencion
            // 
            this.txtAtencion.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtAtencion.Location = new System.Drawing.Point(123, 6);
            this.txtAtencion.Name = "txtAtencion";
            this.txtAtencion.Size = new System.Drawing.Size(109, 21);
            this.txtAtencion.TabIndex = 19;
            this.txtAtencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.Location = new System.Drawing.Point(247, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Identificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(21, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Paciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(21, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nº Atención:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Historia Clinica";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1236, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabControlGalactus1
            // 
            this.tabControlGalactus1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlGalactus1.Controls.Add(this.pagIngreso);
            this.tabControlGalactus1.Controls.Add(this.pagOrdenMedica);
            this.tabControlGalactus1.Controls.Add(this.pagEvolucion);
            this.tabControlGalactus1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlGalactus1.ItemSize = new System.Drawing.Size(30, 120);
            this.tabControlGalactus1.Location = new System.Drawing.Point(4, 101);
            this.tabControlGalactus1.Multiline = true;
            this.tabControlGalactus1.Name = "tabControlGalactus1";
            this.tabControlGalactus1.SelectedIndex = 0;
            this.tabControlGalactus1.Size = new System.Drawing.Size(1260, 548);
            this.tabControlGalactus1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlGalactus1.TabIndex = 0;
            this.tabControlGalactus1.SelectedIndexChanged += new System.EventHandler(this.tabControlGalactus1_SelectedIndexChanged);
            // 
            // pagIngreso
            // 
            this.pagIngreso.Controls.Add(this.panelIngreso);
            this.pagIngreso.Location = new System.Drawing.Point(124, 4);
            this.pagIngreso.Name = "pagIngreso";
            this.pagIngreso.Padding = new System.Windows.Forms.Padding(3);
            this.pagIngreso.Size = new System.Drawing.Size(1132, 540);
            this.pagIngreso.TabIndex = 2;
            this.pagIngreso.Text = "Ingreso";
            this.pagIngreso.UseVisualStyleBackColor = true;
            // 
            // panelIngreso
            // 
            this.panelIngreso.AutoScroll = true;
            this.panelIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIngreso.Location = new System.Drawing.Point(3, 3);
            this.panelIngreso.Name = "panelIngreso";
            this.panelIngreso.Size = new System.Drawing.Size(1126, 534);
            this.panelIngreso.TabIndex = 0;
            // 
            // pagOrdenMedica
            // 
            this.pagOrdenMedica.Location = new System.Drawing.Point(124, 4);
            this.pagOrdenMedica.Name = "pagOrdenMedica";
            this.pagOrdenMedica.Padding = new System.Windows.Forms.Padding(3);
            this.pagOrdenMedica.Size = new System.Drawing.Size(1132, 429);
            this.pagOrdenMedica.TabIndex = 1;
            this.pagOrdenMedica.Text = "Orden Medica";
            this.pagOrdenMedica.UseVisualStyleBackColor = true;
            // 
            // pagEvolucion
            // 
            this.pagEvolucion.Location = new System.Drawing.Point(124, 4);
            this.pagEvolucion.Name = "pagEvolucion";
            this.pagEvolucion.Padding = new System.Windows.Forms.Padding(3);
            this.pagEvolucion.Size = new System.Drawing.Size(1132, 429);
            this.pagEvolucion.TabIndex = 3;
            this.pagEvolucion.Text = "Evolución";
            this.pagEvolucion.UseVisualStyleBackColor = true;
            // 
            // HistoriaClinicaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 650);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlInformacion);
            this.Controls.Add(this.tabControlGalactus1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1269, 650);
            this.MinimumSize = new System.Drawing.Size(1269, 650);
            this.Name = "HistoriaClinicaUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoriaClinicaUI";
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlGalactus1.ResumeLayout(false);
            this.pagIngreso.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Util.Controles.TabControlGalactus tabControlGalactus1;
        private System.Windows.Forms.TabPage pagOrdenMedica;
        private System.Windows.Forms.TabPage pagIngreso;
        private System.Windows.Forms.TabPage pagEvolucion;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoAdministradora;
        private System.Windows.Forms.TextBox txtAdministradora;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtAtencion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelIngreso;
    }
}