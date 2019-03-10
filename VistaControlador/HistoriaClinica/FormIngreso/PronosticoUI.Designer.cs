namespace Galactus.VistaControlador.HistoriaClinica.FormIngreso
{
    partial class PronosticoUI
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
            this.txtPronosticoN = new System.Windows.Forms.TextBox();
            this.txtAnalisisN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 10061;
            this.label1.Text = "Antecedentes Familiares:";
            // 
            // Label59
            // 
            this.Label59.AutoSize = true;
            this.Label59.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Label59.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label59.Location = new System.Drawing.Point(16, 180);
            this.Label59.Name = "Label59";
            this.Label59.Size = new System.Drawing.Size(134, 16);
            this.Label59.TabIndex = 10060;
            this.Label59.Text = "Revisión por Sistema:";
            // 
            // txtPronosticoN
            // 
            this.txtPronosticoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPronosticoN.Location = new System.Drawing.Point(189, 12);
            this.txtPronosticoN.Multiline = true;
            this.txtPronosticoN.Name = "txtPronosticoN";
            this.txtPronosticoN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPronosticoN.Size = new System.Drawing.Size(726, 157);
            this.txtPronosticoN.TabIndex = 10062;
            // 
            // txtAnalisisN
            // 
            this.txtAnalisisN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAnalisisN.Location = new System.Drawing.Point(189, 175);
            this.txtAnalisisN.Multiline = true;
            this.txtAnalisisN.Name = "txtAnalisisN";
            this.txtAnalisisN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnalisisN.Size = new System.Drawing.Size(726, 175);
            this.txtAnalisisN.TabIndex = 10063;
            // 
            // PronosticoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 355);
            this.Controls.Add(this.txtPronosticoN);
            this.Controls.Add(this.txtAnalisisN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label59);
            this.Name = "PronosticoUI";
            this.Text = "PronosticoUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label59;
        internal System.Windows.Forms.TextBox txtPronosticoN;
        internal System.Windows.Forms.TextBox txtAnalisisN;
    }
}