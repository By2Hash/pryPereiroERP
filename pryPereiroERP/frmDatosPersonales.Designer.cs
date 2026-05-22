namespace pryPereiroERP
{
    partial class frmRRHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRRHH));
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpbDomicilio = new System.Windows.Forms.GroupBox();
            this.txtGEO = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.lblGPO = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gpbContacto = new System.Windows.Forms.GroupBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblRedes = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblActivar = new System.Windows.Forms.Label();
            this.chkActivar = new System.Windows.Forms.CheckBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.gpbDomicilio.SuspendLayout();
            this.gpbContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(20, 74);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(54, 29);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(300, 74);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(102, 29);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(598, 74);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 29);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // gpbDomicilio
            // 
            this.gpbDomicilio.Controls.Add(this.txtGEO);
            this.gpbDomicilio.Controls.Add(this.txtDireccion);
            this.gpbDomicilio.Controls.Add(this.lblProvincia);
            this.gpbDomicilio.Controls.Add(this.lblLocalidad);
            this.gpbDomicilio.Controls.Add(this.cmbProvincia);
            this.gpbDomicilio.Controls.Add(this.cmbLocalidad);
            this.gpbDomicilio.Controls.Add(this.lblGPO);
            this.gpbDomicilio.Controls.Add(this.lblDireccion);
            this.gpbDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDomicilio.Location = new System.Drawing.Point(24, 152);
            this.gpbDomicilio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbDomicilio.Name = "gpbDomicilio";
            this.gpbDomicilio.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbDomicilio.Size = new System.Drawing.Size(428, 280);
            this.gpbDomicilio.TabIndex = 3;
            this.gpbDomicilio.TabStop = false;
            this.gpbDomicilio.Text = "Domicilio";
            // 
            // txtGEO
            // 
            this.txtGEO.Location = new System.Drawing.Point(160, 95);
            this.txtGEO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGEO.Name = "txtGEO";
            this.txtGEO.Size = new System.Drawing.Size(193, 35);
            this.txtGEO.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(160, 46);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(193, 35);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(16, 149);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(112, 29);
            this.lblProvincia.TabIndex = 5;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(16, 195);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(118, 29);
            this.lblLocalidad.TabIndex = 4;
            this.lblLocalidad.Text = "Localidad";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(160, 149);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(180, 37);
            this.cmbProvincia.TabIndex = 3;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(160, 202);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(180, 37);
            this.cmbLocalidad.TabIndex = 2;
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // lblGPO
            // 
            this.lblGPO.AutoSize = true;
            this.lblGPO.Location = new System.Drawing.Point(16, 100);
            this.lblGPO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPO.Name = "lblGPO";
            this.lblGPO.Size = new System.Drawing.Size(66, 29);
            this.lblGPO.TabIndex = 1;
            this.lblGPO.Text = "GPO";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(16, 46);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(115, 29);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(84, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 35);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(406, 69);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 35);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(705, 74);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 35);
            this.textBox3.TabIndex = 6;
            // 
            // gpbContacto
            // 
            this.gpbContacto.Controls.Add(this.mskTelefono);
            this.gpbContacto.Controls.Add(this.txtMail);
            this.gpbContacto.Controls.Add(this.lblRedes);
            this.gpbContacto.Controls.Add(this.comboBox4);
            this.gpbContacto.Controls.Add(this.lblTelefono);
            this.gpbContacto.Controls.Add(this.lblMail);
            this.gpbContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbContacto.Location = new System.Drawing.Point(482, 152);
            this.gpbContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbContacto.Name = "gpbContacto";
            this.gpbContacto.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbContacto.Size = new System.Drawing.Size(428, 254);
            this.gpbContacto.TabIndex = 7;
            this.gpbContacto.TabStop = false;
            this.gpbContacto.Text = "Contacto";
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(224, 120);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskTelefono.Mask = "000-000-0000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(180, 35);
            this.mskTelefono.TabIndex = 10;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(224, 46);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(180, 35);
            this.txtMail.TabIndex = 9;
            // 
            // lblRedes
            // 
            this.lblRedes.AutoSize = true;
            this.lblRedes.Location = new System.Drawing.Point(16, 195);
            this.lblRedes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRedes.Name = "lblRedes";
            this.lblRedes.Size = new System.Drawing.Size(183, 29);
            this.lblRedes.TabIndex = 4;
            this.lblRedes.Text = "Redes Sociales";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(224, 183);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(180, 37);
            this.comboBox4.TabIndex = 2;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(16, 125);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(110, 29);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(16, 55);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(58, 29);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail";
            // 
            // lblActivar
            // 
            this.lblActivar.AutoSize = true;
            this.lblActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivar.Location = new System.Drawing.Point(40, 448);
            this.lblActivar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivar.Name = "lblActivar";
            this.lblActivar.Size = new System.Drawing.Size(292, 29);
            this.lblActivar.TabIndex = 8;
            this.lblActivar.Text = "Activar/Desactivar Usuario";
            // 
            // chkActivar
            // 
            this.chkActivar.AutoSize = true;
            this.chkActivar.FlatAppearance.BorderSize = 5;
            this.chkActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivar.Location = new System.Drawing.Point(357, 454);
            this.chkActivar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkActivar.Name = "chkActivar";
            this.chkActivar.Size = new System.Drawing.Size(22, 21);
            this.chkActivar.TabIndex = 9;
            this.chkActivar.UseVisualStyleBackColor = true;
            this.chkActivar.CheckedChanged += new System.EventHandler(this.chkActivar_CheckedChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(746, 442);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(164, 45);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar Usuario";
            this.btnCargar.UseVisualStyleBackColor = false;
            // 
            // frmRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 551);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.chkActivar);
            this.Controls.Add(this.lblActivar);
            this.Controls.Add(this.gpbContacto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gpbDomicilio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRRHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.Load += new System.EventHandler(this.frmRRHH_Load);
            this.gpbDomicilio.ResumeLayout(false);
            this.gpbDomicilio.PerformLayout();
            this.gpbContacto.ResumeLayout(false);
            this.gpbContacto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gpbDomicilio;
        private System.Windows.Forms.TextBox txtGEO;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label lblGPO;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox gpbContacto;
        private System.Windows.Forms.Label lblRedes;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblActivar;
        private System.Windows.Forms.CheckBox chkActivar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
    }
}