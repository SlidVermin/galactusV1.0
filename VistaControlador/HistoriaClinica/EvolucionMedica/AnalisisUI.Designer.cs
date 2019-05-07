namespace Galactus.VistaControlador.HistoriaClinica.EvolucionMedica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAnalisis = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPlan = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAnalisis);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 131);
            this.groupBox1.TabIndex = 10095;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analisis";
            // 
            // txtAnalisis
            // 
            this.txtAnalisis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAnalisis.Location = new System.Drawing.Point(3, 17);
            this.txtAnalisis.Name = "txtAnalisis";
            this.txtAnalisis.Size = new System.Drawing.Size(966, 111);
            this.txtAnalisis.TabIndex = 0;
            this.txtAnalisis.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPlan);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox2.Location = new System.Drawing.Point(5, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 139);
            this.groupBox2.TabIndex = 10096;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plan";
            // 
            // txtPlan
            // 
            this.txtPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlan.Location = new System.Drawing.Point(3, 17);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(966, 119);
            this.txtPlan.TabIndex = 0;
            this.txtPlan.Text = "";
            // 
            // AnalisisUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 285);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnalisisUI";
            this.Text = "AnalisisUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.RichTextBox txtAnalisis;
        internal System.Windows.Forms.RichTextBox txtPlan;
    }
}