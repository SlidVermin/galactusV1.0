namespace Galactus
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btIngresar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbSede = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 43);
            this.panel1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.foto);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btIngresar);
            this.groupBox1.Controls.Add(this.txtContrasena);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.lbSede);
            this.groupBox1.Controls.Add(this.lblContrasena);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 222);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Galactus";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 150;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 26);
            this.comboBox1.TabIndex = 27;
            // 
            // btIngresar
            // 
            this.btIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.btIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btIngresar.FlatAppearance.BorderSize = 0;
            this.btIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIngresar.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btIngresar.ForeColor = System.Drawing.Color.White;
            this.btIngresar.Location = new System.Drawing.Point(107, 139);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(262, 34);
            this.btIngresar.TabIndex = 26;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = false;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click_2);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(107, 44);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(260, 25);
            this.txtUsuario.TabIndex = 24;
            // 
            // lbSede
            // 
            this.lbSede.AutoSize = true;
            this.lbSede.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbSede.ForeColor = System.Drawing.Color.White;
            this.lbSede.Location = new System.Drawing.Point(14, 108);
            this.lbSede.Name = "lbSede";
            this.lbSede.Size = new System.Drawing.Size(42, 18);
            this.lbSede.TabIndex = 23;
            this.lbSede.Text = "Sede";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.White;
            this.lblContrasena.Location = new System.Drawing.Point(14, 78);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(84, 18);
            this.lblContrasena.TabIndex = 22;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(14, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 18);
            this.lblUsuario.TabIndex = 21;
            this.lblUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Galactus Copiright 2019";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(484, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(24, 23);
            this.btnSalir.TabIndex = 46;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(377, 46);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(106, 120);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 29;
            this.foto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(375, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 125);
            this.panel2.TabIndex = 30;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(107, 74);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '°';
            this.txtContrasena.Size = new System.Drawing.Size(260, 25);
            this.txtContrasena.TabIndex = 25;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(514, 276);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbSede;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.PictureBox foto;
        internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtContrasena;
    }
}

