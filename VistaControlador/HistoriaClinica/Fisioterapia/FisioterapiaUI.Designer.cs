namespace Galactus.VistaControlador.HistoriaClinica.Enfermeria
{
    partial class FisioterapiaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FisioterapiaUI));
            this.tstPropiedadesOrdenMedica = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtcodigoOrdenMedica = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstMenuEvolucion = new System.Windows.Forms.ToolStrip();
            this.tsBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsBtModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsBtAnular = new System.Windows.Forms.ToolStripButton();
            this.tsBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tcEnfermeria = new Galactus.Util.Controles.TabControlGalactus();
            this.tpInsumos = new System.Windows.Forms.TabPage();
            this.tpNotas = new System.Windows.Forms.TabPage();
            this.tpOxigeno = new System.Windows.Forms.TabPage();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tstPropiedadesOrdenMedica.SuspendLayout();
            this.tstMenuEvolucion.SuspendLayout();
            this.tcEnfermeria.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstPropiedadesOrdenMedica
            // 
            this.tstPropiedadesOrdenMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tstPropiedadesOrdenMedica.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtcodigoOrdenMedica,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.tstPropiedadesOrdenMedica.Location = new System.Drawing.Point(0, 0);
            this.tstPropiedadesOrdenMedica.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.Name = "tstPropiedadesOrdenMedica";
            this.tstPropiedadesOrdenMedica.Size = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.TabIndex = 68;
            this.tstPropiedadesOrdenMedica.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Código:";
            // 
            // txtcodigoOrdenMedica
            // 
            this.txtcodigoOrdenMedica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigoOrdenMedica.Name = "txtcodigoOrdenMedica";
            this.txtcodigoOrdenMedica.ReadOnly = true;
            this.txtcodigoOrdenMedica.Size = new System.Drawing.Size(100, 25);
            this.txtcodigoOrdenMedica.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel2.Text = "Fecha:";
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
            this.tstMenuEvolucion.Location = new System.Drawing.Point(0, 320);
            this.tstMenuEvolucion.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstMenuEvolucion.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstMenuEvolucion.Name = "tstMenuEvolucion";
            this.tstMenuEvolucion.Size = new System.Drawing.Size(1095, 25);
            this.tstMenuEvolucion.TabIndex = 67;
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
            // tcEnfermeria
            // 
            this.tcEnfermeria.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcEnfermeria.Controls.Add(this.tpInsumos);
            this.tcEnfermeria.Controls.Add(this.tpNotas);
            this.tcEnfermeria.Controls.Add(this.tpOxigeno);
            this.tcEnfermeria.ItemSize = new System.Drawing.Size(30, 120);
            this.tcEnfermeria.Location = new System.Drawing.Point(4, 28);
            this.tcEnfermeria.Multiline = true;
            this.tcEnfermeria.Name = "tcEnfermeria";
            this.tcEnfermeria.SelectedIndex = 0;
            this.tcEnfermeria.Size = new System.Drawing.Size(1082, 289);
            this.tcEnfermeria.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcEnfermeria.TabIndex = 69;
            // 
            // tpInsumos
            // 
            this.tpInsumos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpInsumos.Location = new System.Drawing.Point(124, 4);
            this.tpInsumos.Name = "tpInsumos";
            this.tpInsumos.Padding = new System.Windows.Forms.Padding(3);
            this.tpInsumos.Size = new System.Drawing.Size(954, 281);
            this.tpInsumos.TabIndex = 0;
            this.tpInsumos.Text = "Insumos";
            // 
            // tpNotas
            // 
            this.tpNotas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpNotas.Location = new System.Drawing.Point(124, 4);
            this.tpNotas.Name = "tpNotas";
            this.tpNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tpNotas.Size = new System.Drawing.Size(954, 281);
            this.tpNotas.TabIndex = 1;
            this.tpNotas.Text = "Notas";
            // 
            // tpOxigeno
            // 
            this.tpOxigeno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpOxigeno.Location = new System.Drawing.Point(124, 4);
            this.tpOxigeno.Name = "tpOxigeno";
            this.tpOxigeno.Size = new System.Drawing.Size(954, 281);
            this.tpOxigeno.TabIndex = 3;
            this.tpOxigeno.Text = "Hoja de oxigeno";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(210, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(90, 20);
            this.dtpFecha.TabIndex = 70;
            // 
            // FisioterapiaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 345);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.tcEnfermeria);
            this.Controls.Add(this.tstPropiedadesOrdenMedica);
            this.Controls.Add(this.tstMenuEvolucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1090, 345);
            this.MinimumSize = new System.Drawing.Size(1090, 345);
            this.Name = "FisioterapiaUI";
            this.Text = "FisioterapiaUI";
            this.Load += new System.EventHandler(this.FisioterapiaUI_Load);
            this.tstPropiedadesOrdenMedica.ResumeLayout(false);
            this.tstPropiedadesOrdenMedica.PerformLayout();
            this.tstMenuEvolucion.ResumeLayout(false);
            this.tstMenuEvolucion.PerformLayout();
            this.tcEnfermeria.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstPropiedadesOrdenMedica;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtcodigoOrdenMedica;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip tstMenuEvolucion;
        private System.Windows.Forms.ToolStripButton tsBtNuevo;
        private System.Windows.Forms.ToolStripButton tsBtModificar;
        private System.Windows.Forms.ToolStripButton tsBtGuardar;
        private System.Windows.Forms.ToolStripButton tsBtBuscar;
        private System.Windows.Forms.ToolStripButton tsBtAnular;
        private System.Windows.Forms.ToolStripButton tsBtCancelar;
        private Util.Controles.TabControlGalactus tcEnfermeria;
        private System.Windows.Forms.TabPage tpInsumos;
        private System.Windows.Forms.TabPage tpNotas;
        private System.Windows.Forms.TabPage tpOxigeno;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}