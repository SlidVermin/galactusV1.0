namespace Galactus.VistaControlador.HistoriaClinica.OrdenMedica
{
    partial class IndiceacionesUI
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
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIndicaciones
            // 
            this.txtIndicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIndicaciones.Location = new System.Drawing.Point(6, 21);
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIndicaciones.Size = new System.Drawing.Size(871, 268);
            this.txtIndicaciones.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.GroupBox17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 308);
            this.panel1.TabIndex = 2;
            // 
            // GroupBox17
            // 
            this.GroupBox17.BackColor = System.Drawing.Color.White;
            this.GroupBox17.Controls.Add(this.txtIndicaciones);
            this.GroupBox17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.GroupBox17.ForeColor = System.Drawing.Color.Black;
            this.GroupBox17.Location = new System.Drawing.Point(12, 3);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(883, 295);
            this.GroupBox17.TabIndex = 10092;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "Indicaciones";
            // 
            // IndiceacionesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 308);
            this.Controls.Add(this.panel1);
            this.Name = "IndiceacionesUI";
            this.Text = "IndiceacionesUI";
            this.panel1.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.GroupBox GroupBox17;
    }
}