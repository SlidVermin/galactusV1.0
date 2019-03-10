namespace Galactus.VistaControlador.HistoriaClinica.FormIngreso
{
    partial class AntecedentesFamiliaresUI
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
            this.txtRevision = new System.Windows.Forms.TextBox();
            this.txtAnteF = new System.Windows.Forms.TextBox();
            this.Label59 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRevision
            // 
            this.txtRevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtRevision.Location = new System.Drawing.Point(176, 175);
            this.txtRevision.Multiline = true;
            this.txtRevision.Name = "txtRevision";
            this.txtRevision.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRevision.Size = new System.Drawing.Size(739, 181);
            this.txtRevision.TabIndex = 10057;
            // 
            // txtAnteF
            // 
            this.txtAnteF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAnteF.Location = new System.Drawing.Point(176, 7);
            this.txtAnteF.Multiline = true;
            this.txtAnteF.Name = "txtAnteF";
            this.txtAnteF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnteF.Size = new System.Drawing.Size(739, 162);
            this.txtAnteF.TabIndex = 10057;
            // 
            // Label59
            // 
            this.Label59.AutoSize = true;
            this.Label59.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Label59.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label59.Location = new System.Drawing.Point(14, 178);
            this.Label59.Name = "Label59";
            this.Label59.Size = new System.Drawing.Size(134, 16);
            this.Label59.TabIndex = 10058;
            this.Label59.Text = "Revisión por Sistema:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 10059;
            this.label1.Text = "Antecedentes Familiares:";
            // 
            // AntecedentesFamiliaresUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label59);
            this.Controls.Add(this.txtRevision);
            this.Controls.Add(this.txtAnteF);
            this.Name = "AntecedentesFamiliaresUI";
            this.Text = "AntecedentesFamiliaresUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtRevision;
        internal System.Windows.Forms.TextBox txtAnteF;
        internal System.Windows.Forms.Label Label59;
        internal System.Windows.Forms.Label label1;
    }
}