namespace Galactus.VistaControlador.HistoriaClinica.Enfermeria
{
    partial class EnfermeriaUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnfermeriaUI));
            this.tstPropiedadesOrdenMedica = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtIdEvolucion = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstMenuEvolucion = new System.Windows.Forms.ToolStrip();
            this.tsBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsBtModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsBtAnular = new System.Windows.Forms.ToolStripButton();
            this.tsBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.mtxtFechaEvolucion = new System.Windows.Forms.MaskedTextBox();
            this.tpGlucometrias = new System.Windows.Forms.TabPage();
            this.fecha = new System.Windows.Forms.MaskedTextBox();
            this.tcOrdenMedica = new Galactus.Util.Controles.TabControlGalactus();
            this.tpInsumos = new System.Windows.Forms.TabPage();
            this.tpNotas = new System.Windows.Forms.TabPage();
            this.tpParaclinicos = new System.Windows.Forms.TabPage();
            this.tpHemoderivados = new System.Windows.Forms.TabPage();
            this.tpGlucometria = new System.Windows.Forms.TabPage();
            this.tstPropiedadesOrdenMedica.SuspendLayout();
            this.tstMenuEvolucion.SuspendLayout();
            this.tcOrdenMedica.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstPropiedadesOrdenMedica
            // 
            this.tstPropiedadesOrdenMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tstPropiedadesOrdenMedica.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtIdEvolucion,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.tstPropiedadesOrdenMedica.Location = new System.Drawing.Point(0, 0);
            this.tstPropiedadesOrdenMedica.MaximumSize = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.MinimumSize = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.Name = "tstPropiedadesOrdenMedica";
            this.tstPropiedadesOrdenMedica.Size = new System.Drawing.Size(1095, 25);
            this.tstPropiedadesOrdenMedica.TabIndex = 66;
            this.tstPropiedadesOrdenMedica.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Código:";
            // 
            // txtIdEvolucion
            // 
            this.txtIdEvolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdEvolucion.Name = "txtIdEvolucion";
            this.txtIdEvolucion.ReadOnly = true;
            this.txtIdEvolucion.Size = new System.Drawing.Size(100, 25);
            this.txtIdEvolucion.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // mtxtFechaEvolucion
            // 
            this.mtxtFechaEvolucion.Location = new System.Drawing.Point(308, 2);
            this.mtxtFechaEvolucion.Mask = "00/00/0000 00:00";
            this.mtxtFechaEvolucion.Name = "mtxtFechaEvolucion";
            this.mtxtFechaEvolucion.ReadOnly = true;
            this.mtxtFechaEvolucion.Size = new System.Drawing.Size(100, 20);
            this.mtxtFechaEvolucion.TabIndex = 67;
            this.mtxtFechaEvolucion.ValidatingType = typeof(System.DateTime);
            // 
            // tpGlucometrias
            // 
            this.tpGlucometrias.Location = new System.Drawing.Point(124, 4);
            this.tpGlucometrias.Name = "tpGlucometrias";
            this.tpGlucometrias.Size = new System.Drawing.Size(968, 297);
            this.tpGlucometrias.TabIndex = 4;
            this.tpGlucometrias.Text = "Glucometrias";
            this.tpGlucometrias.UseVisualStyleBackColor = true;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(207, 2);
            this.fecha.Mask = "00/00/0000 00:00";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Size = new System.Drawing.Size(100, 20);
            this.fecha.TabIndex = 68;
            this.fecha.ValidatingType = typeof(System.DateTime);
            // 
            // tcOrdenMedica
            // 
            this.tcOrdenMedica.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcOrdenMedica.Controls.Add(this.tpInsumos);
            this.tcOrdenMedica.Controls.Add(this.tpNotas);
            this.tcOrdenMedica.Controls.Add(this.tpParaclinicos);
            this.tcOrdenMedica.Controls.Add(this.tpHemoderivados);
            this.tcOrdenMedica.Controls.Add(this.tpGlucometria);
            this.tcOrdenMedica.ItemSize = new System.Drawing.Size(30, 120);
            this.tcOrdenMedica.Location = new System.Drawing.Point(4, 28);
            this.tcOrdenMedica.Multiline = true;
            this.tcOrdenMedica.Name = "tcOrdenMedica";
            this.tcOrdenMedica.SelectedIndex = 0;
            this.tcOrdenMedica.Size = new System.Drawing.Size(1096, 305);
            this.tcOrdenMedica.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOrdenMedica.TabIndex = 64;
            // 
            // tpInsumos
            // 
            this.tpInsumos.BackColor = System.Drawing.Color.Silver;
            this.tpInsumos.Location = new System.Drawing.Point(124, 4);
            this.tpInsumos.Name = "tpInsumos";
            this.tpInsumos.Padding = new System.Windows.Forms.Padding(3);
            this.tpInsumos.Size = new System.Drawing.Size(968, 297);
            this.tpInsumos.TabIndex = 0;
            this.tpInsumos.Text = "Insumos";
            // 
            // tpNotas
            // 
            this.tpNotas.Location = new System.Drawing.Point(124, 4);
            this.tpNotas.Name = "tpNotas";
            this.tpNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tpNotas.Size = new System.Drawing.Size(968, 297);
            this.tpNotas.TabIndex = 1;
            this.tpNotas.Text = "Notas";
            this.tpNotas.UseVisualStyleBackColor = true;
            // 
            // tpParaclinicos
            // 
            this.tpParaclinicos.Location = new System.Drawing.Point(124, 4);
            this.tpParaclinicos.Name = "tpParaclinicos";
            this.tpParaclinicos.Size = new System.Drawing.Size(968, 297);
            this.tpParaclinicos.TabIndex = 2;
            this.tpParaclinicos.Text = "Paraclinicos";
            this.tpParaclinicos.UseVisualStyleBackColor = true;
            // 
            // tpHemoderivados
            // 
            this.tpHemoderivados.Location = new System.Drawing.Point(124, 4);
            this.tpHemoderivados.Name = "tpHemoderivados";
            this.tpHemoderivados.Size = new System.Drawing.Size(968, 297);
            this.tpHemoderivados.TabIndex = 3;
            this.tpHemoderivados.Text = "Hemoderivados";
            this.tpHemoderivados.UseVisualStyleBackColor = true;
            // 
            // tpGlucometria
            // 
            this.tpGlucometria.Location = new System.Drawing.Point(124, 4);
            this.tpGlucometria.Name = "tpGlucometria";
            this.tpGlucometria.Size = new System.Drawing.Size(968, 297);
            this.tpGlucometria.TabIndex = 4;
            this.tpGlucometria.Text = "Glucometrias";
            this.tpGlucometria.UseVisualStyleBackColor = true;
            // 
            // EnfermeriaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1100, 357);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.tstPropiedadesOrdenMedica);
            this.Controls.Add(this.tstMenuEvolucion);
            this.Controls.Add(this.mtxtFechaEvolucion);
            this.Controls.Add(this.tcOrdenMedica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1100, 357);
            this.MinimumSize = new System.Drawing.Size(1100, 357);
            this.Name = "EnfermeriaUI";
            this.Text = "EnfermeriaUI";
            this.Load += new System.EventHandler(this.EnfermeriaUI_Load);
            this.tstPropiedadesOrdenMedica.ResumeLayout(false);
            this.tstPropiedadesOrdenMedica.PerformLayout();
            this.tstMenuEvolucion.ResumeLayout(false);
            this.tstMenuEvolucion.PerformLayout();
            this.tcOrdenMedica.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tpInsumos;
        private System.Windows.Forms.TabPage tpNotas;
        private System.Windows.Forms.TabPage tpHemoderivados;
        private System.Windows.Forms.ToolStripButton tsBtCancelar;
        private System.Windows.Forms.ToolStripButton tsBtAnular;
        private System.Windows.Forms.ToolStripButton tsBtBuscar;
        private System.Windows.Forms.ToolStripButton tsBtGuardar;
        private System.Windows.Forms.ToolStripButton tsBtModificar;
        private System.Windows.Forms.ToolStripButton tsBtNuevo;
        private System.Windows.Forms.ToolStrip tstPropiedadesOrdenMedica;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtIdEvolucion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip tstMenuEvolucion;
        private System.Windows.Forms.MaskedTextBox mtxtFechaEvolucion;
        private System.Windows.Forms.TabPage tpParaclinicos;
        private Util.Controles.TabControlGalactus tcOrdenMedica;
        private System.Windows.Forms.TabPage tpGlucometrias;
        private System.Windows.Forms.TabPage tpGlucometria;
        private System.Windows.Forms.MaskedTextBox fecha;
    }
}