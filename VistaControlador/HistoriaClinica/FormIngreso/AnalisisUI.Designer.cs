﻿namespace Galactus.VistaControlador.HistoriaClinica.FormIngreso
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
            this.txtAnalisis = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPronostico = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAnalisis);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 146);
            this.groupBox1.TabIndex = 10064;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analisis";
            // 
            // txtAnalisis
            // 
            this.txtAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAnalisis.Location = new System.Drawing.Point(5, 15);
            this.txtAnalisis.Multiline = true;
            this.txtAnalisis.Name = "txtAnalisis";
            this.txtAnalisis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnalisis.Size = new System.Drawing.Size(961, 125);
            this.txtAnalisis.TabIndex = 10063;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPronostico);
            this.groupBox2.Location = new System.Drawing.Point(6, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 141);
            this.groupBox2.TabIndex = 10065;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pronostico";
            // 
            // txtPronostico
            // 
            this.txtPronostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPronostico.Location = new System.Drawing.Point(5, 15);
            this.txtPronostico.Multiline = true;
            this.txtPronostico.Name = "txtPronostico";
            this.txtPronostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPronostico.Size = new System.Drawing.Size(961, 120);
            this.txtPronostico.TabIndex = 10064;
            // 
            // AnalisisUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 307);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnalisisUI";
            this.Text = "PronosticoUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtAnalisis;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtPronostico;
    }
}