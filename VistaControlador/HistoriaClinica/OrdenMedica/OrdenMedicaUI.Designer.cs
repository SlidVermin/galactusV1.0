namespace Galactus.VistaControlador.HistoriaClinica.OrdenMedica
{
    partial class OrdenMedicaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenMedicaUI));
            this.tstMenuOrdenMedica = new System.Windows.Forms.ToolStrip();
            this.tsBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsBtModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsBtAnular = new System.Windows.Forms.ToolStripButton();
            this.tsBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tstPropiedadesOrdenMedica = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBCodigoOrden = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.mtxtFechaOrden = new System.Windows.Forms.MaskedTextBox();
            this.tcOrdenMedica = new Galactus.Util.Controles.TabControlGalactus();
            this.tpIndicaciones = new System.Windows.Forms.TabPage();
            this.tbProcedimientos = new System.Windows.Forms.TabPage();
            this.tpMedicamentos = new System.Windows.Forms.TabPage();
            this.tpAnalisisOrden = new System.Windows.Forms.TabPage();
            this.tstMenuOrdenMedica.SuspendLayout();
            this.tstPropiedadesOrdenMedica.SuspendLayout();
            this.tcOrdenMedica.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstMenuOrdenMedica
            // 
            this.tstMenuOrdenMedica.BackColor = System.Drawing.Color.White;
            this.tstMenuOrdenMedica.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuOrdenMedica.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtNuevo,
            this.tsBtModificar,
            this.tsBtGuardar,
            this.tsBtBuscar,
            this.tsBtAnular,
            this.tsBtCancelar});
            this.tstMenuOrdenMedica.Location = new System.Drawing.Point(0, 321);
            this.tstMenuOrdenMedica.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuOrdenMedica.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuOrdenMedica.Name = "tstMenuOrdenMedica";
            this.tstMenuOrdenMedica.Size = new System.Drawing.Size(1040, 25);
            this.tstMenuOrdenMedica.TabIndex = 57;
            this.tstMenuOrdenMedica.Text = "toolStrip1";
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
            this.tsBtNuevo.Click += new System.EventHandler(this.tsBtNuevo_Click);
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
            this.tsBtModificar.Click += new System.EventHandler(this.tsBtModificar_Click);
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
            this.tsBtGuardar.Click += new System.EventHandler(this.tsBtGuardar_Click);
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
            this.tsBtBuscar.Click += new System.EventHandler(this.tsBtBuscar_Click);
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
            this.tsBtAnular.Click += new System.EventHandler(this.tsBtAnular_Click);
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
            this.tsBtCancelar.Click += new System.EventHandler(this.tsBtCancelar_Click);
            // 
            // tstPropiedadesOrdenMedica
            // 
            this.tstPropiedadesOrdenMedica.BackColor = System.Drawing.Color.White;
            this.tstPropiedadesOrdenMedica.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtBCodigoOrden,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.tstPropiedadesOrdenMedica.Location = new System.Drawing.Point(0, 0);
            this.tstPropiedadesOrdenMedica.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstPropiedadesOrdenMedica.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstPropiedadesOrdenMedica.Name = "tstPropiedadesOrdenMedica";
            this.tstPropiedadesOrdenMedica.Size = new System.Drawing.Size(1040, 25);
            this.tstPropiedadesOrdenMedica.TabIndex = 58;
            this.tstPropiedadesOrdenMedica.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabel1.Text = "Código Orden:";
            // 
            // txtBCodigoOrden
            // 
            this.txtBCodigoOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBCodigoOrden.Name = "txtBCodigoOrden";
            this.txtBCodigoOrden.Size = new System.Drawing.Size(100, 25);
            this.txtBCodigoOrden.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel2.Text = "Fecha Orden:";
            // 
            // mtxtFechaOrden
            // 
            this.mtxtFechaOrden.Location = new System.Drawing.Point(282, 2);
            this.mtxtFechaOrden.Mask = "00/00/0000 00:00";
            this.mtxtFechaOrden.Name = "mtxtFechaOrden";
            this.mtxtFechaOrden.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaOrden.TabIndex = 59;
            this.mtxtFechaOrden.ValidatingType = typeof(System.DateTime);
            // 
            // tcOrdenMedica
            // 
            this.tcOrdenMedica.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcOrdenMedica.Controls.Add(this.tpIndicaciones);
            this.tcOrdenMedica.Controls.Add(this.tbProcedimientos);
            this.tcOrdenMedica.Controls.Add(this.tpMedicamentos);
            this.tcOrdenMedica.Controls.Add(this.tpAnalisisOrden);
            this.tcOrdenMedica.ItemSize = new System.Drawing.Size(30, 120);
            this.tcOrdenMedica.Location = new System.Drawing.Point(2, 28);
            this.tcOrdenMedica.Multiline = true;
            this.tcOrdenMedica.Name = "tcOrdenMedica";
            this.tcOrdenMedica.SelectedIndex = 0;
            this.tcOrdenMedica.Size = new System.Drawing.Size(1096, 283);
            this.tcOrdenMedica.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOrdenMedica.TabIndex = 56;
            // 
            // tpIndicaciones
            // 
            this.tpIndicaciones.Location = new System.Drawing.Point(124, 4);
            this.tpIndicaciones.Name = "tpIndicaciones";
            this.tpIndicaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tpIndicaciones.Size = new System.Drawing.Size(968, 275);
            this.tpIndicaciones.TabIndex = 0;
            this.tpIndicaciones.Text = "Indicaciones";
            this.tpIndicaciones.UseVisualStyleBackColor = true;
            // 
            // tbProcedimientos
            // 
            this.tbProcedimientos.Location = new System.Drawing.Point(124, 4);
            this.tbProcedimientos.Name = "tbProcedimientos";
            this.tbProcedimientos.Padding = new System.Windows.Forms.Padding(3);
            this.tbProcedimientos.Size = new System.Drawing.Size(968, 275);
            this.tbProcedimientos.TabIndex = 1;
            this.tbProcedimientos.Text = "Procedimientos";
            this.tbProcedimientos.UseVisualStyleBackColor = true;
            // 
            // tpMedicamentos
            // 
            this.tpMedicamentos.Location = new System.Drawing.Point(124, 4);
            this.tpMedicamentos.Name = "tpMedicamentos";
            this.tpMedicamentos.Size = new System.Drawing.Size(968, 275);
            this.tpMedicamentos.TabIndex = 2;
            this.tpMedicamentos.Text = "Medicamentos";
            this.tpMedicamentos.UseVisualStyleBackColor = true;
            // 
            // tpAnalisisOrden
            // 
            this.tpAnalisisOrden.Location = new System.Drawing.Point(124, 4);
            this.tpAnalisisOrden.Name = "tpAnalisisOrden";
            this.tpAnalisisOrden.Size = new System.Drawing.Size(968, 275);
            this.tpAnalisisOrden.TabIndex = 3;
            this.tpAnalisisOrden.Text = "Analisis";
            this.tpAnalisisOrden.UseVisualStyleBackColor = true;
            // 
            // OrdenMedicaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 346);
            this.Controls.Add(this.mtxtFechaOrden);
            this.Controls.Add(this.tstPropiedadesOrdenMedica);
            this.Controls.Add(this.tstMenuOrdenMedica);
            this.Controls.Add(this.tcOrdenMedica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdenMedicaUI";
            this.Text = "OrdenMedicaUI";
            this.Load += new System.EventHandler(this.OrdenMedicaUI_Load);
            this.tstMenuOrdenMedica.ResumeLayout(false);
            this.tstMenuOrdenMedica.PerformLayout();
            this.tstPropiedadesOrdenMedica.ResumeLayout(false);
            this.tstPropiedadesOrdenMedica.PerformLayout();
            this.tcOrdenMedica.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Util.Controles.TabControlGalactus tcOrdenMedica;
        private System.Windows.Forms.TabPage tpIndicaciones;
        private System.Windows.Forms.TabPage tbProcedimientos;
        private System.Windows.Forms.TabPage tpMedicamentos;
        private System.Windows.Forms.TabPage tpAnalisisOrden;
        private System.Windows.Forms.ToolStrip tstMenuOrdenMedica;
        private System.Windows.Forms.ToolStripButton tsBtNuevo;
        private System.Windows.Forms.ToolStripButton tsBtModificar;
        private System.Windows.Forms.ToolStripButton tsBtGuardar;
        private System.Windows.Forms.ToolStripButton tsBtBuscar;
        private System.Windows.Forms.ToolStripButton tsBtAnular;
        private System.Windows.Forms.ToolStripButton tsBtCancelar;
        private System.Windows.Forms.ToolStrip tstPropiedadesOrdenMedica;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtBCodigoOrden;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.MaskedTextBox mtxtFechaOrden;
    }
}