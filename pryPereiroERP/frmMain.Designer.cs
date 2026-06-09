namespace pryPereiroERP
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabAyuda = new System.Windows.Forms.TabPage();
            this.tabRRHH = new System.Windows.Forms.TabPage();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblRRHH = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tabGrilla = new System.Windows.Forms.TabPage();
            this.lblAuditoria = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.cboTablas = new System.Windows.Forms.ComboBox();
            this.gbOrden = new System.Windows.Forms.GroupBox();
            this.radioDesc = new System.Windows.Forms.RadioButton();
            this.radioAsc = new System.Windows.Forms.RadioButton();
            this.lblResultados = new System.Windows.Forms.Label();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.lblUsuarioTitulo = new System.Windows.Forms.Label();
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblApellidoValor = new System.Windows.Forms.Label();
            this.lblEmailValor = new System.Windows.Forms.Label();
            this.lblRolValor = new System.Windows.Forms.Label();
            this.lblConexionValor = new System.Windows.Forms.Label();
            this.lblDireccionValor = new System.Windows.Forms.Label();
            this.lblGPSValor = new System.Windows.Forms.Label();
            this.lblProvinciaValor = new System.Windows.Forms.Label();
            this.lblLocalidadValor = new System.Windows.Forms.Label();
            this.lblTelefonoValor = new System.Windows.Forms.Label();
            this.lblRedesValor = new System.Windows.Forms.Label();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabRRHH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.gbOrden.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1100, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            // 
            // tabAyuda
            // 
            this.tabAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabAyuda.Location = new System.Drawing.Point(4, 26);
            this.tabAyuda.Name = "tabAyuda";
            this.tabAyuda.Padding = new System.Windows.Forms.Padding(3);
            this.tabAyuda.Size = new System.Drawing.Size(1092, 520);
            this.tabAyuda.TabIndex = 3;
            this.tabAyuda.Text = "AYUDA";
            // 
            // tabRRHH
            // 
            this.tabRRHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabRRHH.Controls.Add(this.btnRegistrar);
            this.tabRRHH.Controls.Add(this.lblRRHH);
            this.tabRRHH.Controls.Add(this.dgvUsuarios);
            this.tabRRHH.Location = new System.Drawing.Point(4, 26);
            this.tabRRHH.Name = "tabRRHH";
            this.tabRRHH.Padding = new System.Windows.Forms.Padding(3);
            this.tabRRHH.Size = new System.Drawing.Size(1092, 520);
            this.tabRRHH.TabIndex = 1;
            this.tabRRHH.Text = "RRHH";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnRegistrar.Location = new System.Drawing.Point(953, 15);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 35);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "+ Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblRRHH
            // 
            this.lblRRHH.AutoSize = true;
            this.lblRRHH.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRRHH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblRRHH.Location = new System.Drawing.Point(12, 15);
            this.lblRRHH.Name = "lblRRHH";
            this.lblRRHH.Size = new System.Drawing.Size(161, 25);
            this.lblRRHH.TabIndex = 4;
            this.lblRRHH.Text = "Lista de Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 58);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.RowTemplate.Height = 30;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1061, 446);
            this.dgvUsuarios.TabIndex = 3;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // tabGrilla
            // 
            this.tabGrilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabGrilla.Controls.Add(this.lblAuditoria);
            this.tabGrilla.Controls.Add(this.dgvConsulta);
            this.tabGrilla.Controls.Add(this.cboTablas);
            this.tabGrilla.Controls.Add(this.gbOrden);
            this.tabGrilla.Controls.Add(this.lblResultados);
            this.tabGrilla.Location = new System.Drawing.Point(4, 26);
            this.tabGrilla.Name = "tabGrilla";
            this.tabGrilla.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrilla.Size = new System.Drawing.Size(1092, 520);
            this.tabGrilla.TabIndex = 0;
            this.tabGrilla.Text = "AUDITORIA";
            // 
            // lblAuditoria
            // 
            this.lblAuditoria.AutoSize = true;
            this.lblAuditoria.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblAuditoria.Location = new System.Drawing.Point(16, 14);
            this.lblAuditoria.Name = "lblAuditoria";
            this.lblAuditoria.Size = new System.Drawing.Size(313, 25);
            this.lblAuditoria.TabIndex = 3;
            this.lblAuditoria.Text = "CONSULTAS A LA BASE DE DATOS";
            this.lblAuditoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 130);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConsulta.RowTemplate.Height = 30;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(1066, 375);
            this.dgvConsulta.TabIndex = 2;
            // 
            // cboTablas
            // 
            this.cboTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTablas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTablas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cboTablas.FormattingEnabled = true;
            this.cboTablas.Items.AddRange(new object[] {
            "Usuarios",
            "Perfil",
            "Relacion-Usuario-Perfil",
            "Auditoria-Sesion",
            "Domicilio_Usuario",
            "Contacto_Usuario",
            "Provincias",
            "Localidades"});
            this.cboTablas.Location = new System.Drawing.Point(16, 50);
            this.cboTablas.Name = "cboTablas";
            this.cboTablas.Size = new System.Drawing.Size(180, 25);
            this.cboTablas.TabIndex = 6;
            this.cboTablas.SelectedIndexChanged += new System.EventHandler(this.cboTablas_SelectedIndexChanged);
            // 
            // gbOrden
            // 
            this.gbOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.gbOrden.Controls.Add(this.radioDesc);
            this.gbOrden.Controls.Add(this.radioAsc);
            this.gbOrden.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.gbOrden.Location = new System.Drawing.Point(210, 35);
            this.gbOrden.Name = "gbOrden";
            this.gbOrden.Size = new System.Drawing.Size(210, 50);
            this.gbOrden.TabIndex = 12;
            this.gbOrden.TabStop = false;
            this.gbOrden.Text = "Orden";
            // 
            // radioDesc
            // 
            this.radioDesc.AutoSize = true;
            this.radioDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.radioDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.radioDesc.Location = new System.Drawing.Point(110, 22);
            this.radioDesc.Name = "radioDesc";
            this.radioDesc.Size = new System.Drawing.Size(93, 19);
            this.radioDesc.TabIndex = 1;
            this.radioDesc.TabStop = true;
            this.radioDesc.Text = "Descendente";
            this.radioDesc.UseVisualStyleBackColor = false;
            this.radioDesc.CheckedChanged += new System.EventHandler(this.radioOrden_CheckedChanged);
            // 
            // radioAsc
            // 
            this.radioAsc.AutoSize = true;
            this.radioAsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.radioAsc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.radioAsc.Location = new System.Drawing.Point(12, 22);
            this.radioAsc.Name = "radioAsc";
            this.radioAsc.Size = new System.Drawing.Size(87, 19);
            this.radioAsc.TabIndex = 0;
            this.radioAsc.TabStop = true;
            this.radioAsc.Text = "Ascendente";
            this.radioAsc.UseVisualStyleBackColor = false;
            this.radioAsc.CheckedChanged += new System.EventHandler(this.radioOrden_CheckedChanged);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblResultados.Location = new System.Drawing.Point(16, 95);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 15);
            this.lblResultados.TabIndex = 11;
            // 
            // tabUsuario
            // 
            this.tabUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabUsuario.Controls.Add(this.lblUsuarioTitulo);
            this.tabUsuario.Controls.Add(this.lblNombreValor);
            this.tabUsuario.Controls.Add(this.lblApellidoValor);
            this.tabUsuario.Controls.Add(this.lblEmailValor);
            this.tabUsuario.Controls.Add(this.lblRolValor);
            this.tabUsuario.Controls.Add(this.lblConexionValor);
            this.tabUsuario.Controls.Add(this.lblDireccionValor);
            this.tabUsuario.Controls.Add(this.lblGPSValor);
            this.tabUsuario.Controls.Add(this.lblProvinciaValor);
            this.tabUsuario.Controls.Add(this.lblLocalidadValor);
            this.tabUsuario.Controls.Add(this.lblTelefonoValor);
            this.tabUsuario.Controls.Add(this.lblRedesValor);
            this.tabUsuario.Location = new System.Drawing.Point(4, 26);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(1092, 520);
            this.tabUsuario.TabIndex = 4;
            this.tabUsuario.Text = "USUARIO";
            // 
            // lblUsuarioTitulo
            // 
            this.lblUsuarioTitulo.AutoSize = true;
            this.lblUsuarioTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblUsuarioTitulo.Location = new System.Drawing.Point(16, 14);
            this.lblUsuarioTitulo.Name = "lblUsuarioTitulo";
            this.lblUsuarioTitulo.Size = new System.Drawing.Size(196, 30);
            this.lblUsuarioTitulo.TabIndex = 0;
            this.lblUsuarioTitulo.Text = "Datos del Usuario";
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblNombreValor.Location = new System.Drawing.Point(18, 62);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(0, 21);
            this.lblNombreValor.TabIndex = 1;
            // 
            // lblApellidoValor
            // 
            this.lblApellidoValor.AutoSize = true;
            this.lblApellidoValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblApellidoValor.Location = new System.Drawing.Point(18, 97);
            this.lblApellidoValor.Name = "lblApellidoValor";
            this.lblApellidoValor.Size = new System.Drawing.Size(0, 21);
            this.lblApellidoValor.TabIndex = 2;
            // 
            // lblEmailValor
            // 
            this.lblEmailValor.AutoSize = true;
            this.lblEmailValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblEmailValor.Location = new System.Drawing.Point(18, 132);
            this.lblEmailValor.Name = "lblEmailValor";
            this.lblEmailValor.Size = new System.Drawing.Size(0, 21);
            this.lblEmailValor.TabIndex = 3;
            // 
            // lblRolValor
            // 
            this.lblRolValor.AutoSize = true;
            this.lblRolValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblRolValor.Location = new System.Drawing.Point(18, 167);
            this.lblRolValor.Name = "lblRolValor";
            this.lblRolValor.Size = new System.Drawing.Size(0, 21);
            this.lblRolValor.TabIndex = 4;
            // 
            // lblConexionValor
            // 
            this.lblConexionValor.AutoSize = true;
            this.lblConexionValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexionValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblConexionValor.Location = new System.Drawing.Point(18, 202);
            this.lblConexionValor.Name = "lblConexionValor";
            this.lblConexionValor.Size = new System.Drawing.Size(0, 21);
            this.lblConexionValor.TabIndex = 5;
            // 
            // lblDireccionValor
            // 
            this.lblDireccionValor.AutoSize = true;
            this.lblDireccionValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblDireccionValor.Location = new System.Drawing.Point(500, 62);
            this.lblDireccionValor.Name = "lblDireccionValor";
            this.lblDireccionValor.Size = new System.Drawing.Size(0, 21);
            this.lblDireccionValor.TabIndex = 6;
            // 
            // lblGPSValor
            // 
            this.lblGPSValor.AutoSize = true;
            this.lblGPSValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblGPSValor.Location = new System.Drawing.Point(500, 97);
            this.lblGPSValor.Name = "lblGPSValor";
            this.lblGPSValor.Size = new System.Drawing.Size(0, 21);
            this.lblGPSValor.TabIndex = 7;
            // 
            // lblProvinciaValor
            // 
            this.lblProvinciaValor.AutoSize = true;
            this.lblProvinciaValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinciaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblProvinciaValor.Location = new System.Drawing.Point(500, 132);
            this.lblProvinciaValor.Name = "lblProvinciaValor";
            this.lblProvinciaValor.Size = new System.Drawing.Size(0, 21);
            this.lblProvinciaValor.TabIndex = 8;
            // 
            // lblLocalidadValor
            // 
            this.lblLocalidadValor.AutoSize = true;
            this.lblLocalidadValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidadValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblLocalidadValor.Location = new System.Drawing.Point(500, 167);
            this.lblLocalidadValor.Name = "lblLocalidadValor";
            this.lblLocalidadValor.Size = new System.Drawing.Size(0, 21);
            this.lblLocalidadValor.TabIndex = 9;
            // 
            // lblTelefonoValor
            // 
            this.lblTelefonoValor.AutoSize = true;
            this.lblTelefonoValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblTelefonoValor.Location = new System.Drawing.Point(500, 202);
            this.lblTelefonoValor.Name = "lblTelefonoValor";
            this.lblTelefonoValor.Size = new System.Drawing.Size(0, 21);
            this.lblTelefonoValor.TabIndex = 10;
            // 
            // lblRedesValor
            // 
            this.lblRedesValor.AutoSize = true;
            this.lblRedesValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedesValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblRedesValor.Location = new System.Drawing.Point(500, 237);
            this.lblRedesValor.Name = "lblRedesValor";
            this.lblRedesValor.Size = new System.Drawing.Size(0, 21);
            this.lblRedesValor.TabIndex = 11;
            // 
            // tabMenu
            // 
            this.tabMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMenu.Controls.Add(this.tabUsuario);
            this.tabMenu.Controls.Add(this.tabGrilla);
            this.tabMenu.Controls.Add(this.tabRRHH);
            this.tabMenu.Controls.Add(this.tabAyuda);
            this.tabMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1100, 550);
            this.tabMenu.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(1100, 576);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pereiro ERP - Panel Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabRRHH.ResumeLayout(false);
            this.tabRRHH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabGrilla.ResumeLayout(false);
            this.tabGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.gbOrden.ResumeLayout(false);
            this.gbOrden.PerformLayout();
            this.tabUsuario.ResumeLayout(false);
            this.tabUsuario.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabAyuda;
        private System.Windows.Forms.TabPage tabRRHH;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblRRHH;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TabPage tabGrilla;
        private System.Windows.Forms.Label lblAuditoria;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.Label lblUsuarioTitulo;
        private System.Windows.Forms.Label lblNombreValor;
        private System.Windows.Forms.Label lblApellidoValor;
        private System.Windows.Forms.Label lblEmailValor;
        private System.Windows.Forms.Label lblRolValor;
        private System.Windows.Forms.Label lblConexionValor;
        private System.Windows.Forms.Label lblDireccionValor;
        private System.Windows.Forms.Label lblGPSValor;
        private System.Windows.Forms.Label lblProvinciaValor;
        private System.Windows.Forms.Label lblLocalidadValor;
        private System.Windows.Forms.Label lblTelefonoValor;
        private System.Windows.Forms.Label lblRedesValor;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.ComboBox cboTablas;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.GroupBox gbOrden;
        private System.Windows.Forms.RadioButton radioAsc;
        private System.Windows.Forms.RadioButton radioDesc;
    }
}
