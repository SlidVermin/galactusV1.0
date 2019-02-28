namespace Galactus.VistaControlador.Inventario
{
    partial class BodegaUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tBtEditar = new System.Windows.Forms.ToolStripButton();
            this.tBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tBtAnular = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.tstMenuPatron.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Descripción: ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(101, 50);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(334, 20);
            this.txtDescripcion.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Código: ";
            // 
            // txtBCodigo
            // 
            this.txtBCodigo.Location = new System.Drawing.Point(101, 24);
            this.txtBCodigo.Name = "txtBCodigo";
            this.txtBCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBCodigo.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtBCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 82);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Principal";
            // 
            // tstMenuPatron
            // 
            this.tstMenuPatron.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstMenuPatron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tBtNuevo,
            this.tBtEditar,
            this.tBtCancelar,
            this.tBtGuardar,
            this.tBtBuscar,
            this.tBtAnular});
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 281);
            this.tstMenuPatron.MaximumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.MinimumSize = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.Name = "tstMenuPatron";
            this.tstMenuPatron.Size = new System.Drawing.Size(1040, 25);
            this.tstMenuPatron.TabIndex = 48;
            this.tstMenuPatron.Text = "toolStrip1";
            // 
            // tBtNuevo
            // 
            this.tBtNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBtNuevo.Image = global::Galactus.Properties.Resources.btn_nuevo;
            this.tBtNuevo.ImageTransparentColor = System.Drawing.Color.White;
            this.tBtNuevo.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tBtNuevo.Name = "tBtNuevo";
            this.tBtNuevo.Size = new System.Drawing.Size(62, 22);
            this.tBtNuevo.Text = "Nuevo";
            // 
            // tBtEditar
            // 
            this.tBtEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBtEditar.Image = global::Galactus.Properties.Resources.bt_editar;
            this.tBtEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtEditar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tBtEditar.Name = "tBtEditar";
            this.tBtEditar.Size = new System.Drawing.Size(57, 22);
            this.tBtEditar.Text = "Editar";
            // 
            // tBtCancelar
            // 
            this.tBtCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBtCancelar.Image = global::Galactus.Properties.Resources.btn_cancelar;
            this.tBtCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtCancelar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tBtCancelar.Name = "tBtCancelar";
            this.tBtCancelar.Size = new System.Drawing.Size(73, 22);
            this.tBtCancelar.Text = "Cancelar";
            // 
            // tBtGuardar
            // 
            this.tBtGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBtGuardar.Image = global::Galactus.Properties.Resources.btn_guardar;
            this.tBtGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtGuardar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tBtGuardar.Name = "tBtGuardar";
            this.tBtGuardar.Size = new System.Drawing.Size(69, 22);
            this.tBtGuardar.Text = "Guardar";
            // 
            // tBtBuscar
            // 
            this.tBtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBtBuscar.Image = global::Galactus.Properties.Resources.btn_buscar;
            this.tBtBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtBuscar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tBtBuscar.Name = "tBtBuscar";
            this.tBtBuscar.Size = new System.Drawing.Size(62, 22);
            this.tBtBuscar.Text = "Buscar";
            // 
            // tBtAnular
            // 
            this.tBtAnular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBtAnular.Image = global::Galactus.Properties.Resources.btn_anular;
            this.tBtAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtAnular.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tBtAnular.Name = "tBtAnular";
            this.tBtAnular.Size = new System.Drawing.Size(62, 22);
            this.tBtAnular.Text = "Anular";
            // 
            // BodegaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 306);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.groupBox1);
            this.Name = "BodegaUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bodega";
            this.Load += new System.EventHandler(this.BodegaUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tBtNuevo;
        private System.Windows.Forms.ToolStripButton tBtEditar;
        private System.Windows.Forms.ToolStripButton tBtCancelar;
        private System.Windows.Forms.ToolStripButton tBtGuardar;
        private System.Windows.Forms.ToolStripButton tBtBuscar;
        private System.Windows.Forms.ToolStripButton tBtAnular;
    }
}