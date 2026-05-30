namespace pryPereiroERP
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlIniciarSesion = new System.Windows.Forms.Panel();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pnlIniciarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIniciarSesion
            // 
            this.pnlIniciarSesion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlIniciarSesion.Controls.Add(this.lblPerfil);
            this.pnlIniciarSesion.Controls.Add(this.cmbPerfil);
            this.pnlIniciarSesion.Controls.Add(this.btnIngresar);
            this.pnlIniciarSesion.Controls.Add(this.txtContraseña);
            this.pnlIniciarSesion.Controls.Add(this.txtNombre);
            this.pnlIniciarSesion.Controls.Add(this.lblContraseña);
            this.pnlIniciarSesion.Controls.Add(this.lblNombre);
            this.pnlIniciarSesion.Location = new System.Drawing.Point(14, 114);
            this.pnlIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlIniciarSesion.Name = "pnlIniciarSesion";
            this.pnlIniciarSesion.Size = new System.Drawing.Size(802, 336);
            this.pnlIniciarSesion.TabIndex = 2;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.SystemColors.Control;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(96, 206);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(69, 29);
            this.lblPerfil.TabIndex = 6;
            this.lblPerfil.Text = "Perfil";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(298, 212);
            this.cmbPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(206, 28);
            this.cmbPerfil.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(567, 78);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(147, 46);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(298, 139);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseña.MaxLength = 12;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(206, 35);
            this.txtContraseña.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(298, 78);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 35);
            this.txtNombre.TabIndex = 2;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.SystemColors.Control;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(96, 149);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(136, 29);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(96, 78);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(153, 29);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre/Mail";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(234, 18);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(336, 71);
            this.lblBienvenida.TabIndex = 3;
            this.lblBienvenida.Text = "Bienvenido";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 466);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.pnlIniciarSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlIniciarSesion.ResumeLayout(false);
            this.pnlIniciarSesion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIniciarSesion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cmbPerfil;
    }
}