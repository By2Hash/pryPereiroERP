namespace pryPereiroERP
{
    partial class frmRRHH
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRRHH));
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpbDomicilio = new System.Windows.Forms.GroupBox();
            this.txtGPS = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.lblGPS = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lstDirecciones = new System.Windows.Forms.ListBox();
            this.btnAgregarDireccion = new System.Windows.Forms.Button();
            this.btnQuitarDireccion = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpbContacto = new System.Windows.Forms.GroupBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cmbTipoRed = new System.Windows.Forms.ComboBox();
            this.txtUrlRed = new System.Windows.Forms.TextBox();
            this.btnAgregarRed = new System.Windows.Forms.Button();
            this.btnQuitarRed = new System.Windows.Forms.Button();
            this.lstRedesSociales = new System.Windows.Forms.ListBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblActivar = new System.Windows.Forms.Label();
            this.chkActivar = new System.Windows.Forms.CheckBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.cmbTipoPerfil = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTipoPerfil = new System.Windows.Forms.Label();
            this.gpbDomicilio.SuspendLayout();
            this.gpbContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblDni.Location = new System.Drawing.Point(45, 105);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(50, 30);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblApellido.Location = new System.Drawing.Point(500, 52);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(93, 30);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblNombre.Location = new System.Drawing.Point(40, 52);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 30);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // gpbDomicilio
            // 
            this.gpbDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.gpbDomicilio.Controls.Add(this.txtGPS);
            this.gpbDomicilio.Controls.Add(this.txtDireccion);
            this.gpbDomicilio.Controls.Add(this.lblProvincia);
            this.gpbDomicilio.Controls.Add(this.lblLocalidad);
            this.gpbDomicilio.Controls.Add(this.cmbProvincia);
            this.gpbDomicilio.Controls.Add(this.cmbLocalidad);
            this.gpbDomicilio.Controls.Add(this.lblGPS);
            this.gpbDomicilio.Controls.Add(this.lblDireccion);
            this.gpbDomicilio.Controls.Add(this.lstDirecciones);
            this.gpbDomicilio.Controls.Add(this.btnAgregarDireccion);
            this.gpbDomicilio.Controls.Add(this.btnQuitarDireccion);
            this.gpbDomicilio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.gpbDomicilio.Location = new System.Drawing.Point(29, 223);
            this.gpbDomicilio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbDomicilio.Name = "gpbDomicilio";
            this.gpbDomicilio.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbDomicilio.Size = new System.Drawing.Size(428, 340);
            this.gpbDomicilio.TabIndex = 3;
            this.gpbDomicilio.TabStop = false;
            this.gpbDomicilio.Text = "Domicilio";
            // 
            // txtGPS
            // 
            this.txtGPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtGPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGPS.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPS.ForeColor = System.Drawing.Color.White;
            this.txtGPS.Location = new System.Drawing.Point(160, 73);
            this.txtGPS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGPS.MaxLength = 120;
            this.txtGPS.Name = "txtGPS";
            this.txtGPS.Size = new System.Drawing.Size(193, 37);
            this.txtGPS.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(160, 38);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(193, 37);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblProvincia.Location = new System.Drawing.Point(16, 111);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(100, 30);
            this.lblProvincia.TabIndex = 5;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblLocalidad.Location = new System.Drawing.Point(16, 146);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(104, 30);
            this.lblLocalidad.TabIndex = 4;
            this.lblLocalidad.Text = "Localidad";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProvincia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(160, 108);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(193, 38);
            this.cmbProvincia.TabIndex = 3;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLocalidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(160, 143);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(193, 38);
            this.cmbLocalidad.TabIndex = 2;
            // 
            // lblGPS
            // 
            this.lblGPS.AutoSize = true;
            this.lblGPS.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblGPS.Location = new System.Drawing.Point(16, 76);
            this.lblGPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPS.Name = "lblGPS";
            this.lblGPS.Size = new System.Drawing.Size(52, 30);
            this.lblGPS.TabIndex = 1;
            this.lblGPS.Text = "GPS";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblDireccion.Location = new System.Drawing.Point(16, 41);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(103, 30);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección";
            // 
            // lstDirecciones
            // 
            this.lstDirecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lstDirecciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDirecciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDirecciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lstDirecciones.FormattingEnabled = true;
            this.lstDirecciones.ItemHeight = 28;
            this.lstDirecciones.Location = new System.Drawing.Point(16, 182);
            this.lstDirecciones.Name = "lstDirecciones";
            this.lstDirecciones.Size = new System.Drawing.Size(392, 86);
            this.lstDirecciones.TabIndex = 10;
            this.lstDirecciones.SelectedIndexChanged += new System.EventHandler(this.lstDirecciones_SelectedIndexChanged);
            // 
            // btnAgregarDireccion
            // 
            this.btnAgregarDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAgregarDireccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDireccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAgregarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(238)))), ((int)(((byte)(144)))));
            this.btnAgregarDireccion.Location = new System.Drawing.Point(16, 300);
            this.btnAgregarDireccion.Name = "btnAgregarDireccion";
            this.btnAgregarDireccion.Size = new System.Drawing.Size(90, 28);
            this.btnAgregarDireccion.TabIndex = 11;
            this.btnAgregarDireccion.Text = "+ Agregar";
            this.btnAgregarDireccion.UseVisualStyleBackColor = false;
            this.btnAgregarDireccion.Click += new System.EventHandler(this.btnAgregarDireccion_Click);
            // 
            // btnQuitarDireccion
            // 
            this.btnQuitarDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnQuitarDireccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarDireccion.Enabled = false;
            this.btnQuitarDireccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnQuitarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnQuitarDireccion.Location = new System.Drawing.Point(112, 300);
            this.btnQuitarDireccion.Name = "btnQuitarDireccion";
            this.btnQuitarDireccion.Size = new System.Drawing.Size(82, 28);
            this.btnQuitarDireccion.TabIndex = 12;
            this.btnQuitarDireccion.Text = "✕ Quitar";
            this.btnQuitarDireccion.UseVisualStyleBackColor = false;
            this.btnQuitarDireccion.Click += new System.EventHandler(this.btnQuitarDireccion_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.Color.White;
            this.txtDNI.Location = new System.Drawing.Point(184, 105);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(148, 37);
            this.txtDNI.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(706, 46);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(148, 37);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(184, 46);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 37);
            this.txtNombre.TabIndex = 6;
            // 
            // gpbContacto
            // 
            this.gpbContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.gpbContacto.Controls.Add(this.mskTelefono);
            this.gpbContacto.Controls.Add(this.txtMail);
            this.gpbContacto.Controls.Add(this.cmbTipoRed);
            this.gpbContacto.Controls.Add(this.txtUrlRed);
            this.gpbContacto.Controls.Add(this.btnAgregarRed);
            this.gpbContacto.Controls.Add(this.btnQuitarRed);
            this.gpbContacto.Controls.Add(this.lstRedesSociales);
            this.gpbContacto.Controls.Add(this.lblTelefono);
            this.gpbContacto.Controls.Add(this.lblMail);
            this.gpbContacto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.gpbContacto.Location = new System.Drawing.Point(492, 223);
            this.gpbContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbContacto.Name = "gpbContacto";
            this.gpbContacto.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbContacto.Size = new System.Drawing.Size(428, 340);
            this.gpbContacto.TabIndex = 7;
            this.gpbContacto.TabStop = false;
            this.gpbContacto.Text = "Contacto";
            // 
            // mskTelefono
            // 
            this.mskTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.mskTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefono.ForeColor = System.Drawing.Color.White;
            this.mskTelefono.Location = new System.Drawing.Point(313, 80);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskTelefono.Mask = "000-000-0000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(91, 37);
            this.mskTelefono.TabIndex = 10;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(224, 38);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMail.MaxLength = 100;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(180, 37);
            this.txtMail.TabIndex = 9;
            // 
            // cmbTipoRed
            // 
            this.cmbTipoRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbTipoRed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoRed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbTipoRed.FormattingEnabled = true;
            this.cmbTipoRed.Items.AddRange(new object[] {
            "Facebook",
            "Instagram",
            "X (Twitter)",
            "LinkedIn",
            "TikTok",
            "YouTube",
            "WhatsApp",
            "Otro"});
            this.cmbTipoRed.Location = new System.Drawing.Point(16, 140);
            this.cmbTipoRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoRed.Name = "cmbTipoRed";
            this.cmbTipoRed.Size = new System.Drawing.Size(140, 36);
            this.cmbTipoRed.TabIndex = 13;
            // 
            // txtUrlRed
            // 
            this.txtUrlRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtUrlRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrlRed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlRed.ForeColor = System.Drawing.Color.White;
            this.txtUrlRed.Location = new System.Drawing.Point(170, 140);
            this.txtUrlRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrlRed.MaxLength = 120;
            this.txtUrlRed.Name = "txtUrlRed";
            this.txtUrlRed.Size = new System.Drawing.Size(234, 34);
            this.txtUrlRed.TabIndex = 14;
            this.txtUrlRed.Enter += new System.EventHandler(this.txtUrlRed_Enter);
            this.txtUrlRed.Leave += new System.EventHandler(this.txtUrlRed_Leave);
            // 
            // btnAgregarRed
            // 
            this.btnAgregarRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAgregarRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarRed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAgregarRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(238)))), ((int)(((byte)(144)))));
            this.btnAgregarRed.Location = new System.Drawing.Point(16, 172);
            this.btnAgregarRed.Name = "btnAgregarRed";
            this.btnAgregarRed.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarRed.TabIndex = 15;
            this.btnAgregarRed.Text = "+";
            this.btnAgregarRed.UseVisualStyleBackColor = false;
            this.btnAgregarRed.Click += new System.EventHandler(this.btnAgregarRed_Click);
            // 
            // btnQuitarRed
            // 
            this.btnQuitarRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnQuitarRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarRed.Enabled = false;
            this.btnQuitarRed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnQuitarRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarRed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnQuitarRed.Location = new System.Drawing.Point(50, 172);
            this.btnQuitarRed.Name = "btnQuitarRed";
            this.btnQuitarRed.Size = new System.Drawing.Size(28, 28);
            this.btnQuitarRed.TabIndex = 16;
            this.btnQuitarRed.Text = "✕";
            this.btnQuitarRed.UseVisualStyleBackColor = false;
            this.btnQuitarRed.Click += new System.EventHandler(this.btnQuitarRed_Click);
            // 
            // lstRedesSociales
            // 
            this.lstRedesSociales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lstRedesSociales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRedesSociales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRedesSociales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lstRedesSociales.FormattingEnabled = true;
            this.lstRedesSociales.ItemHeight = 28;
            this.lstRedesSociales.Location = new System.Drawing.Point(16, 208);
            this.lstRedesSociales.Name = "lstRedesSociales";
            this.lstRedesSociales.Size = new System.Drawing.Size(388, 86);
            this.lstRedesSociales.TabIndex = 17;
            this.lstRedesSociales.SelectedIndexChanged += new System.EventHandler(this.lstRedesSociales_SelectedIndexChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblTelefono.Location = new System.Drawing.Point(16, 87);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(97, 30);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblMail.Location = new System.Drawing.Point(16, 41);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(54, 30);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail";
            // 
            // lblActivar
            // 
            this.lblActivar.AutoSize = true;
            this.lblActivar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblActivar.Location = new System.Drawing.Point(40, 580);
            this.lblActivar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivar.Name = "lblActivar";
            this.lblActivar.Size = new System.Drawing.Size(275, 30);
            this.lblActivar.TabIndex = 8;
            this.lblActivar.Text = "Activar / Desactivar usuario";
            // 
            // chkActivar
            // 
            this.chkActivar.AutoSize = true;
            this.chkActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkActivar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.chkActivar.Location = new System.Drawing.Point(256, 585);
            this.chkActivar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkActivar.Name = "chkActivar";
            this.chkActivar.Size = new System.Drawing.Size(17, 16);
            this.chkActivar.TabIndex = 9;
            this.chkActivar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnCargar.Location = new System.Drawing.Point(756, 575);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(164, 35);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Guardar Usuario";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(706, 118);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseña.MaxLength = 64;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(148, 37);
            this.txtContraseña.TabIndex = 12;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblContraseña.Location = new System.Drawing.Point(500, 107);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(122, 30);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "Contraseña";
            // 
            // cmbTipoPerfil
            // 
            this.cmbTipoPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbTipoPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoPerfil.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbTipoPerfil.FormattingEnabled = true;
            this.cmbTipoPerfil.Items.AddRange(new object[] {
            "Admin",
            "RRHH",
            "Usuario"});
            this.cmbTipoPerfil.Location = new System.Drawing.Point(184, 162);
            this.cmbTipoPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoPerfil.Name = "cmbTipoPerfil";
            this.cmbTipoPerfil.Size = new System.Drawing.Size(148, 38);
            this.cmbTipoPerfil.TabIndex = 16;
            this.cmbTipoPerfil.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPerfil_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnEliminar.Location = new System.Drawing.Point(619, 575);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 35);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTipoPerfil
            // 
            this.lblTipoPerfil.AutoSize = true;
            this.lblTipoPerfil.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblTipoPerfil.Location = new System.Drawing.Point(45, 165);
            this.lblTipoPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPerfil.Name = "lblTipoPerfil";
            this.lblTipoPerfil.Size = new System.Drawing.Size(110, 30);
            this.lblTipoPerfil.TabIndex = 15;
            this.lblTipoPerfil.Text = "Tipo Perfil";
            // 
            // frmRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(984, 664);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.chkActivar);
            this.Controls.Add(this.lblActivar);
            this.Controls.Add(this.gpbContacto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.gpbDomicilio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblTipoPerfil);
            this.Controls.Add(this.cmbTipoPerfil);
            this.Controls.Add(this.btnEliminar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 720);
            this.Name = "frmRRHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRRHH_FormClosing);
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
        private System.Windows.Forms.TextBox txtGPS;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label lblGPS;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gpbContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblActivar;
        private System.Windows.Forms.CheckBox chkActivar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblTipoPerfil;
        private System.Windows.Forms.ComboBox cmbTipoPerfil;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lstDirecciones;
        private System.Windows.Forms.Button btnAgregarDireccion;
        private System.Windows.Forms.Button btnQuitarDireccion;
        private System.Windows.Forms.ComboBox cmbTipoRed;
        private System.Windows.Forms.TextBox txtUrlRed;
        private System.Windows.Forms.Button btnAgregarRed;
        private System.Windows.Forms.Button btnQuitarRed;
        private System.Windows.Forms.ListBox lstRedesSociales;
    }
}
