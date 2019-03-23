namespace Galactus.VistaControlador.HistoriaClinica.FormIngreso
{
    partial class AnalisisUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.Label59 = new System.Windows.Forms.Label();
            this.txtAnalisis = new System.Windows.Forms.TextBox();
            this.txtPronostico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 10061;
            this.label1.Text = "Analisis";
            // 
            // Label59
            // 
            this.Label59.AutoSize = true;
            this.Label59.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label59.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label59.Location = new System.Drawing.Point(16, 147);
            this.Label59.Name = "Label59";
            this.Label59.Size = new System.Drawing.Size(70, 17);
            this.Label59.TabIndex = 10060;
            this.Label59.Text = "Pronostico";
            // 
            // txtAnalisis
            // 
            this.txtAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAnalisis.Location = new System.Drawing.Point(19, 39);
            this.txtAnalisis.Multiline = true;
            this.txtAnalisis.Name = "txtAnalisis";
            this.txtAnalisis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnalisis.Size = new System.Drawing.Size(896, 84);
            this.txtAnalisis.TabIndex = 10062;
            // 
            // txtPronostico
            // 
            this.txtPronostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPronostico.Location = new System.Drawing.Point(19, 167);
            this.txtPronostico.Multiline = true;
            this.txtPronostico.Name = "txtPronostico";
            this.txtPronostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPronostico.Size = new System.Drawing.Size(896, 88);
            this.txtPronostico.TabIndex = 10063;
            // 
            // AnalisisUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 279);
            this.Controls.Add(this.txtAnalisis);
            this.Controls.Add(this.txtPronostico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label59);
            this.Name = "AnalisisUI";
            this.Text = "PronosticoUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label59;
        internal System.Windows.Forms.TextBox txtAnalisis;
        internal System.Windows.Forms.TextBox txtPronostico;
    }
}