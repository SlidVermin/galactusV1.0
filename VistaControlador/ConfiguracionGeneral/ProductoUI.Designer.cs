namespace Galactus.VistaControlador.Inventario
{
    partial class ProductoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoUI));
            this.ndIva = new System.Windows.Forms.NumericUpDown();
            this.btnBuscarEquivalencia = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBEquivalencia = new System.Windows.Forms.TextBox();
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCUM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegSanitario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBPresentacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btBuscarPresentacion = new System.Windows.Forms.Button();
            this.tstMenuPatron = new System.Windows.Forms.ToolStrip();
            this.tBtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tBtEditar = new System.Windows.Forms.ToolStripButton();
            this.tBtCancelar = new System.Windows.Forms.ToolStripButton();
            this.tBtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tBtBuscar = new System.Windows.Forms.ToolStripButton();
            this.tBtAnular = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ndIva)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tstMenuPatron.SuspendLayout();
            this.SuspendLayout();
            // 
            // ndIva
            // 
            this.ndIva.DecimalPlaces = 2;
            this.ndIva.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ndIva.Location = new System.Drawing.Point(81, 201);
            this.ndIva.Name = "ndIva";
            this.ndIva.Size = new System.Drawing.Size(55, 20);
            this.ndIva.TabIndex = 45;
            // 
            // btnBuscarEquivalencia
            // 
            this.btnBuscarEquivalencia.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEquivalencia.Image")));
            this.btnBuscarEquivalencia.Location = new System.Drawing.Point(451, 95);
            this.btnBuscarEquivalencia.Name = "btnBuscarEquivalencia";
            this.btnBuscarEquivalencia.Size = new System.Drawing.Size(34, 23);
            this.btnBuscarEquivalencia.TabIndex = 44;
            this.btnBuscarEquivalencia.UseVisualStyleBackColor = true;
            this.btnBuscarEquivalencia.Click += new System.EventHandler(this.btnBuscarEquivalencia_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Equivalencia:";
            // 
            // txtBEquivalencia
            // 
            this.txtBEquivalencia.Location = new System.Drawing.Point(81, 97);
            this.txtBEquivalencia.Name = "txtBEquivalencia";
            this.txtBEquivalencia.Size = new System.Drawing.Size(364, 20);
            this.txtBEquivalencia.TabIndex = 42;
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarMarca.Image")));
            this.btnBuscarMarca.Location = new System.Drawing.Point(451, 69);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(34, 23);
            this.btnBuscarMarca.TabIndex = 41;
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "IVA: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Código CUM:";
            // 
            // txtCUM
            // 
            this.txtCUM.Location = new System.Drawing.Point(81, 175);
            this.txtCUM.Name = "txtCUM";
            this.txtCUM.Size = new System.Drawing.Size(216, 20);
            this.txtCUM.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Reg. Sanitario:";
            // 
            // txtRegSanitario
            // 
            this.txtRegSanitario.Location = new System.Drawing.Point(81, 149);
            this.txtRegSanitario.Name = "txtRegSanitario";
            this.txtRegSanitario.Size = new System.Drawing.Size(216, 20);
            this.txtRegSanitario.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Presentación: ";
            // 
            // txtBPresentacion
            // 
            this.txtBPresentacion.Location = new System.Drawing.Point(81, 123);
            this.txtBPresentacion.Name = "txtBPresentacion";
            this.txtBPresentacion.Size = new System.Drawing.Size(364, 20);
            this.txtBPresentacion.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Marca: ";
            // 
            // txtBMarca
            // 
            this.txtBMarca.Location = new System.Drawing.Point(81, 71);
            this.txtBMarca.Name = "txtBMarca";
            this.txtBMarca.Size = new System.Drawing.Size(364, 20);
            this.txtBMarca.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descripción: ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(81, 45);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(404, 20);
            this.txtDescripcion.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código: ";
            // 
            // txtBCodigo
            // 
            this.txtBCodigo.Location = new System.Drawing.Point(81, 19);
            this.txtBCodigo.Name = "txtBCodigo";
            this.txtBCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBCodigo.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btBuscarPresentacion);
            this.groupBox1.Controls.Add(this.txtBCodigo);
            this.groupBox1.Controls.Add(this.ndIva);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscarEquivalencia);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBEquivalencia);
            this.groupBox1.Controls.Add(this.txtBMarca);
            this.groupBox1.Controls.Add(this.btnBuscarMarca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBPresentacion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCUM);
            this.groupBox1.Controls.Add(this.txtRegSanitario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 360);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Principal";
            // 
            // btBuscarPresentacion
            // 
            this.btBuscarPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarPresentacion.Image")));
            this.btBuscarPresentacion.Location = new System.Drawing.Point(451, 121);
            this.btBuscarPresentacion.Name = "btBuscarPresentacion";
            this.btBuscarPresentacion.Size = new System.Drawing.Size(34, 23);
            this.btBuscarPresentacion.TabIndex = 46;
            this.btBuscarPresentacion.UseVisualStyleBackColor = true;
            this.btBuscarPresentacion.Click += new System.EventHandler(this.btPresentacion_Click);
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
            this.tstMenuPatron.Location = new System.Drawing.Point(0, 380);
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
            // ProductoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 405);
            this.Controls.Add(this.tstMenuPatron);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ProductoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ndIva)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tstMenuPatron.ResumeLayout(false);
            this.tstMenuPatron.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown ndIva;
        private System.Windows.Forms.Button btnBuscarEquivalencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBEquivalencia;
        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCUM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegSanitario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBPresentacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btBuscarPresentacion;
        private System.Windows.Forms.ToolStrip tstMenuPatron;
        private System.Windows.Forms.ToolStripButton tBtNuevo;
        private System.Windows.Forms.ToolStripButton tBtEditar;
        private System.Windows.Forms.ToolStripButton tBtCancelar;
        private System.Windows.Forms.ToolStripButton tBtGuardar;
        private System.Windows.Forms.ToolStripButton tBtBuscar;
        private System.Windows.Forms.ToolStripButton tBtAnular;
    }
}