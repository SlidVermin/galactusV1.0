namespace Galactus.VistaControlador.HistoriaClinica
{
    partial class IngresoClinicoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoClinicoUI));
            this.tcIngresoClinico = new Galactus.Util.Controles.TabControlGalactus();
            this.tpValoracion = new System.Windows.Forms.TabPage();
            this.tpAntecedentes = new System.Windows.Forms.TabPage();
            this.tpExamenFisico = new System.Windows.Forms.TabPage();
            this.tpAnalisis = new System.Windows.Forms.TabPage();
            this.tsIngreso = new System.Windows.Forms.ToolStrip();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tcIngresoClinico.SuspendLayout();
            this.tsIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcIngresoClinico
            // 
            this.tcIngresoClinico.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcIngresoClinico.Controls.Add(this.tpValoracion);
            this.tcIngresoClinico.Controls.Add(this.tpAntecedentes);
            this.tcIngresoClinico.Controls.Add(this.tpExamenFisico);
            this.tcIngresoClinico.Controls.Add(this.tpAnalisis);
            this.tcIngresoClinico.ItemSize = new System.Drawing.Size(30, 120);
            this.tcIngresoClinico.Location = new System.Drawing.Point(2, 3);
            this.tcIngresoClinico.Multiline = true;
            this.tcIngresoClinico.Name = "tcIngresoClinico";
            this.tcIngresoClinico.SelectedIndex = 0;
            this.tcIngresoClinico.Size = new System.Drawing.Size(1100, 338);
            this.tcIngresoClinico.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcIngresoClinico.TabIndex = 4;
            // 
            // tpValoracion
            // 
            this.tpValoracion.Location = new System.Drawing.Point(124, 4);
            this.tpValoracion.Name = "tpValoracion";
            this.tpValoracion.Padding = new System.Windows.Forms.Padding(3);
            this.tpValoracion.Size = new System.Drawing.Size(972, 330);
            this.tpValoracion.TabIndex = 0;
            this.tpValoracion.Text = "Valoracion";
            this.tpValoracion.UseVisualStyleBackColor = true;
            // 
            // tpAntecedentes
            // 
            this.tpAntecedentes.Location = new System.Drawing.Point(124, 4);
            this.tpAntecedentes.Name = "tpAntecedentes";
            this.tpAntecedentes.Padding = new System.Windows.Forms.Padding(3);
            this.tpAntecedentes.Size = new System.Drawing.Size(972, 330);
            this.tpAntecedentes.TabIndex = 1;
            this.tpAntecedentes.Text = "Antecedentes";
            this.tpAntecedentes.UseVisualStyleBackColor = true;
            // 
            // tpExamenFisico
            // 
            this.tpExamenFisico.Location = new System.Drawing.Point(124, 4);
            this.tpExamenFisico.Name = "tpExamenFisico";
            this.tpExamenFisico.Size = new System.Drawing.Size(972, 330);
            this.tpExamenFisico.TabIndex = 2;
            this.tpExamenFisico.Text = "Examen Fisico";
            this.tpExamenFisico.UseVisualStyleBackColor = true;
            // 
            // tpAnalisis
            // 
            this.tpAnalisis.Location = new System.Drawing.Point(124, 4);
            this.tpAnalisis.Name = "tpAnalisis";
            this.tpAnalisis.Size = new System.Drawing.Size(972, 330);
            this.tpAnalisis.TabIndex = 3;
            this.tpAnalisis.Text = "Analisis";
            this.tpAnalisis.UseVisualStyleBackColor = true;
            // 
            // tsIngreso
            // 
            this.tsIngreso.BackColor = System.Drawing.Color.White;
            this.tsIngreso.Dock = System.Windows.Forms.DockStyle.None;
            this.tsIngreso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbModificar,
            this.tsbGuardar,
            this.tsbCancelar});
            this.tsIngreso.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsIngreso.Location = new System.Drawing.Point(2, 344);
            this.tsIngreso.MaximumSize = new System.Drawing.Size(1050, 25);
            this.tsIngreso.MinimumSize = new System.Drawing.Size(1050, 25);
            this.tsIngreso.Name = "tsIngreso";
            this.tsIngreso.Size = new System.Drawing.Size(1050, 25);
            this.tsIngreso.TabIndex = 53;
            this.tsIngreso.Text = "toolStrip2";
            // 
            // tsbModificar
            // 
            this.tsbModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(78, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsbCancelar.Text = "Cancelar";
            // 
            // IngresoClinicoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 376);
            this.Controls.Add(this.tsIngreso);
            this.Controls.Add(this.tcIngresoClinico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresoClinicoUI";
            this.RightToLeftLayout = true;
            this.Text = "IngresoClinico";
            this.Load += new System.EventHandler(this.IngresoClinicoUI_Load);
            this.tcIngresoClinico.ResumeLayout(false);
            this.tsIngreso.ResumeLayout(false);
            this.tsIngreso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tpAnalisis;
        private System.Windows.Forms.TabPage tpExamenFisico;
        private System.Windows.Forms.TabPage tpAntecedentes;
        private System.Windows.Forms.TabPage tpValoracion;
        private Util.Controles.TabControlGalactus tcIngresoClinico;
        private System.Windows.Forms.ToolStrip tsIngreso;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
    }
}