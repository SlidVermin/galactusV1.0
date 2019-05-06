namespace Galactus.VistaControlador.Admision.Configuracion
{
    partial class ConfiguracionManualServicioUI
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
            this.label15 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tstModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tabPestañas = new Galactus.Util.Controles.TabControlGalactus();
            this.tabCups = new System.Windows.Forms.TabPage();
            this.dgvCups = new System.Windows.Forms.DataGridView();
            this.tabSoat = new System.Windows.Forms.TabPage();
            this.dgvSoat = new System.Windows.Forms.DataGridView();
            this.tabIss = new System.Windows.Forms.TabPage();
            this.dgvIss = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkActiva = new System.Windows.Forms.CheckBox();
            this.btBuscarCodigo = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tstMenuPatron.SuspendLayout();
            this.tabPestañas.SuspendLayout();
            this.tabCups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCups)).BeginInit();
            this.tabSoat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoat)).BeginInit();
            this.tabIss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F);
            this.label15.Location = new System.Drawing.Point(60, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 18);
            this.label15.TabIndex = 7;
            this.label15.Text = "Manuales de Servicio";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(327, 35);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(388, 21);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
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
            this.tstMenuPatron.TabIndex = 48;
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
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click_1);
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
            // tabPestañas
            // 
            this.tabPestañas.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabPestañas.Controls.Add(this.tabCups);
            this.tabPestañas.Controls.Add(this.tabSoat);
            this.tabPestañas.Controls.Add(this.tabIss);
            this.tabPestañas.ItemSize = new System.Drawing.Size(30, 120);
            this.tabPestañas.Location = new System.Drawing.Point(23, 139);
            this.tabPestañas.Multiline = true;
            this.tabPestañas.Name = "tabPestañas";
            this.tabPestañas.SelectedIndex = 0;
            this.tabPestañas.Size = new System.Drawing.Size(1009, 390);
            this.tabPestañas.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPestañas.TabIndex = 49;
            // 
            // tabCups
            // 
            this.tabCups.Controls.Add(this.dgvCups);
            this.tabCups.Location = new System.Drawing.Point(124, 4);
            this.tabCups.Name = "tabCups";
            this.tabCups.Padding = new System.Windows.Forms.Padding(3);
            this.tabCups.Size = new System.Drawing.Size(881, 382);
            this.tabCups.TabIndex = 0;
            this.tabCups.Text = "CUPS";
            this.tabCups.UseVisualStyleBackColor = true;
            // 
            // dgvCups
            // 
            this.dgvCups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCups.Location = new System.Drawing.Point(3, 3);
            this.dgvCups.Name = "dgvCups";
            this.dgvCups.Size = new System.Drawing.Size(875, 376);
            this.dgvCups.TabIndex = 0;
            // 
            // tabSoat
            // 
            this.tabSoat.Controls.Add(this.dgvSoat);
            this.tabSoat.Location = new System.Drawing.Point(124, 4);
            this.tabSoat.Name = "tabSoat";
            this.tabSoat.Padding = new System.Windows.Forms.Padding(3);
            this.tabSoat.Size = new System.Drawing.Size(881, 382);
            this.tabSoat.TabIndex = 1;
            this.tabSoat.Text = "SOAT";
            this.tabSoat.UseVisualStyleBackColor = true;
            // 
            // dgvSoat
            // 
            this.dgvSoat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoat.Location = new System.Drawing.Point(3, 3);
            this.dgvSoat.Name = "dgvSoat";
            this.dgvSoat.Size = new System.Drawing.Size(875, 376);
            this.dgvSoat.TabIndex = 1;
            // 
            // tabIss
            // 
            this.tabIss.Controls.Add(this.dgvIss);
            this.tabIss.Location = new System.Drawing.Point(124, 4);
            this.tabIss.Name = "tabIss";
            this.tabIss.Size = new System.Drawing.Size(881, 382);
            this.tabIss.TabIndex = 2;
            this.tabIss.Text = "ISS";
            this.tabIss.UseVisualStyleBackColor = true;
            // 
            // dgvIss
            // 
            this.dgvIss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIss.Location = new System.Drawing.Point(0, 0);
            this.dgvIss.Name = "dgvIss";
            this.dgvIss.Size = new System.Drawing.Size(881, 382);
            this.dgvIss.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1027, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 56;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(23, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 98);
            this.panel2.TabIndex = 57;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(7, 8);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(201, 20);
            this.label33.TabIndex = 48;
            this.label33.Text = "Información del manual.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkActiva);
            this.panel1.Controls.Add(this.btBuscarCodigo);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFiltro);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Location = new System.Drawing.Point(13, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 61);
            this.panel1.TabIndex = 32;
            // 
            // chkActiva
            // 
            this.chkActiva.AutoSize = true;
            this.chkActiva.Font = new System.Drawing.Font("Arial", 9.75F);
            this.chkActiva.Location = new System.Drawing.Point(79, 33);
            this.chkActiva.Name = "chkActiva";
            this.chkActiva.Size = new System.Drawing.Size(62, 20);
            this.chkActiva.TabIndex = 73;
            this.chkActiva.Text = "Activo";
            this.chkActiva.UseVisualStyleBackColor = true;
            // 
            // btBuscarCodigo
            // 
            this.btBuscarCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarCodigo.Image = global::Galactus.Properties.Resources.btn_lupa;
            this.btBuscarCodigo.Location = new System.Drawing.Point(721, 33);
            this.btBuscarCodigo.Name = "btBuscarCodigo";
            this.btBuscarCodigo.Size = new System.Drawing.Size(26, 24);
            this.btBuscarCodigo.TabIndex = 32;
            this.btBuscarCodigo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(327, 6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(513, 21);
            this.txtDescripcion.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Filtro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(79, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(140, 21);
            this.txtCodigo.TabIndex = 25;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(250, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 15);
            this.label30.TabIndex = 29;
            this.label30.Text = "Descipción:";
            // 
            // ConfiguracionManualServicioUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabPestañas);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.label15);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1059, 580);
            this.MinimumSize = new System.Drawing.Size(1059, 580);
            this.Name = "ConfiguracionManualServicioUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConfiguracionManualServicioUI_Load);
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.tabPestañas.ResumeLayout(false);
            this.tabCups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCups)).EndInit();
            this.tabSoat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoat)).EndInit();
            this.tabIss.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tstModificar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private Util.Controles.TabControlGalactus tabPestañas;
        private System.Windows.Forms.TabPage tabCups;
        private System.Windows.Forms.TabPage tabSoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvCups;
        private System.Windows.Forms.DataGridView dgvSoat;
        private System.Windows.Forms.TabPage tabIss;
        private System.Windows.Forms.DataGridView dgvIss;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btBuscarCodigo;
        private System.Windows.Forms.CheckBox chkActiva;
        private System.Windows.Forms.Label label33;
    }
}