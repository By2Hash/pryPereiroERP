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
            this.tabRRHH = new System.Windows.Forms.TabPage();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblRRHH = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tabGrilla = new System.Windows.Forms.TabPage();
            this.lblAuditoria = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.gbOrden = new System.Windows.Forms.GroupBox();
            this.radioDesc = new System.Windows.Forms.RadioButton();
            this.radioAsc = new System.Windows.Forms.RadioButton();
            this.lblResultados = new System.Windows.Forms.Label();
            this.txtFiltroUsuario = new System.Windows.Forms.TextBox();
            this.dtpFiltroFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFiltroDesde = new System.Windows.Forms.Label();
            this.lblFiltroHasta = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.lblUsuarioTitulo = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.gbPersonal = new System.Windows.Forms.GroupBox();
            this.lblFNombre = new System.Windows.Forms.Label();
            this.lblFApellido = new System.Windows.Forms.Label();
            this.lblFEmail = new System.Windows.Forms.Label();
            this.lblFRol = new System.Windows.Forms.Label();
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblApellidoValor = new System.Windows.Forms.Label();
            this.lblEmailValor = new System.Windows.Forms.Label();
            this.lblRolValor = new System.Windows.Forms.Label();
            this.gbContacto = new System.Windows.Forms.GroupBox();
            this.lblFDireccion = new System.Windows.Forms.Label();
            this.lblFProvincia = new System.Windows.Forms.Label();
            this.lblFLocalidad = new System.Windows.Forms.Label();
            this.lblFTelefono = new System.Windows.Forms.Label();
            this.lblFRedes = new System.Windows.Forms.Label();
            this.lblDireccionValor = new System.Windows.Forms.Label();
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
            this.gbPersonal.SuspendLayout();
            this.gbContacto.SuspendLayout();
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
            // tabRRHH
            // 
            this.tabRRHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabRRHH.Controls.Add(this.txtBuscarUsuario);
            this.tabRRHH.Controls.Add(this.btnRegistrar);
            this.tabRRHH.Controls.Add(this.lblRRHH);
            this.tabRRHH.Controls.Add(this.dgvUsuarios);
            this.tabRRHH.Location = new System.Drawing.Point(4, 37);
            this.tabRRHH.Name = "tabRRHH";
            this.tabRRHH.Padding = new System.Windows.Forms.Padding(3);
            this.tabRRHH.Size = new System.Drawing.Size(1092, 509);
            this.tabRRHH.TabIndex = 1;
            this.tabRRHH.Text = "RRHH";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarUsuario.Location = new System.Drawing.Point(753, 15);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(180, 34);
            this.txtBuscarUsuario.TabIndex = 6;
            this.txtBuscarUsuario.Text = "Buscar usuario...";
            this.txtBuscarUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            this.txtBuscarUsuario.Enter += new System.EventHandler(this.txtBuscarUsuario_Enter);
            this.txtBuscarUsuario.Leave += new System.EventHandler(this.txtBuscarUsuario_Leave);
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
            this.lblRRHH.Location = new System.Drawing.Point(8, 15);
            this.lblRRHH.Name = "lblRRHH";
            this.lblRRHH.Size = new System.Drawing.Size(237, 38);
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
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 77);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.RowTemplate.Height = 30;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1061, 427);
            this.dgvUsuarios.TabIndex = 3;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // tabGrilla
            // 
            this.tabGrilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabGrilla.Controls.Add(this.lblAuditoria);
            this.tabGrilla.Controls.Add(this.dgvConsulta);
            this.tabGrilla.Controls.Add(this.gbOrden);
            this.tabGrilla.Controls.Add(this.lblResultados);
            this.tabGrilla.Controls.Add(this.txtFiltroUsuario);
            this.tabGrilla.Controls.Add(this.dtpFiltroFechaDesde);
            this.tabGrilla.Controls.Add(this.dtpFiltroFechaHasta);
            this.tabGrilla.Controls.Add(this.lblFiltroDesde);
            this.tabGrilla.Controls.Add(this.lblFiltroHasta);
            this.tabGrilla.Controls.Add(this.btnFiltrar);
            this.tabGrilla.Controls.Add(this.btnLimpiarFiltros);
            this.tabGrilla.Location = new System.Drawing.Point(4, 37);
            this.tabGrilla.Name = "tabGrilla";
            this.tabGrilla.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrilla.Size = new System.Drawing.Size(1092, 509);
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
            this.lblAuditoria.Size = new System.Drawing.Size(355, 38);
            this.lblAuditoria.TabIndex = 3;
            this.lblAuditoria.Text = "REGISTRO DE AUDITORÍA";
            this.lblAuditoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 125);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConsulta.RowTemplate.Height = 30;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(1066, 380);
            this.dgvConsulta.TabIndex = 6;
            // 
            // gbOrden
            // 
            this.gbOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.gbOrden.Controls.Add(this.radioDesc);
            this.gbOrden.Controls.Add(this.radioAsc);
            this.gbOrden.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.gbOrden.Location = new System.Drawing.Point(766, 58);
            this.gbOrden.Name = "gbOrden";
            this.gbOrden.Size = new System.Drawing.Size(200, 50);
            this.gbOrden.TabIndex = 4;
            this.gbOrden.TabStop = false;
            this.gbOrden.Text = "Orden";
            // 
            // radioDesc
            // 
            this.radioDesc.AutoSize = true;
            this.radioDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.radioDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.radioDesc.Location = new System.Drawing.Point(105, 22);
            this.radioDesc.Name = "radioDesc";
            this.radioDesc.Size = new System.Drawing.Size(139, 29);
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
            this.radioAsc.Size = new System.Drawing.Size(129, 29);
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
            this.lblResultados.Location = new System.Drawing.Point(16, 105);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 25);
            this.lblResultados.TabIndex = 11;
            // 
            // txtFiltroUsuario
            // 
            this.txtFiltroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtFiltroUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtFiltroUsuario.Location = new System.Drawing.Point(12, 72);
            this.txtFiltroUsuario.Name = "txtFiltroUsuario";
            this.txtFiltroUsuario.Size = new System.Drawing.Size(230, 34);
            this.txtFiltroUsuario.TabIndex = 0;
            this.txtFiltroUsuario.Text = "Buscar usuario...";
            this.txtFiltroUsuario.Enter += new System.EventHandler(this.txtFiltro_Enter);
            this.txtFiltroUsuario.Leave += new System.EventHandler(this.txtFiltro_Leave);
            // 
            // dtpFiltroFechaDesde
            // 
            this.dtpFiltroFechaDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dtpFiltroFechaDesde.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dtpFiltroFechaDesde.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dtpFiltroFechaDesde.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dtpFiltroFechaDesde.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.dtpFiltroFechaDesde.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.dtpFiltroFechaDesde.Checked = false;
            this.dtpFiltroFechaDesde.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltroFechaDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dtpFiltroFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaDesde.Location = new System.Drawing.Point(262, 70);
            this.dtpFiltroFechaDesde.Name = "dtpFiltroFechaDesde";
            this.dtpFiltroFechaDesde.ShowCheckBox = true;
            this.dtpFiltroFechaDesde.Size = new System.Drawing.Size(180, 34);
            this.dtpFiltroFechaDesde.TabIndex = 1;
            // 
            // dtpFiltroFechaHasta
            // 
            this.dtpFiltroFechaHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dtpFiltroFechaHasta.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dtpFiltroFechaHasta.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dtpFiltroFechaHasta.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dtpFiltroFechaHasta.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.dtpFiltroFechaHasta.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.dtpFiltroFechaHasta.Checked = false;
            this.dtpFiltroFechaHasta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltroFechaHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dtpFiltroFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaHasta.Location = new System.Drawing.Point(460, 70);
            this.dtpFiltroFechaHasta.Name = "dtpFiltroFechaHasta";
            this.dtpFiltroFechaHasta.ShowCheckBox = true;
            this.dtpFiltroFechaHasta.Size = new System.Drawing.Size(180, 34);
            this.dtpFiltroFechaHasta.TabIndex = 2;
            // 
            // lblFiltroDesde
            // 
            this.lblFiltroDesde.AutoSize = true;
            this.lblFiltroDesde.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblFiltroDesde.Location = new System.Drawing.Point(262, 45);
            this.lblFiltroDesde.Name = "lblFiltroDesde";
            this.lblFiltroDesde.Size = new System.Drawing.Size(70, 28);
            this.lblFiltroDesde.TabIndex = 13;
            this.lblFiltroDesde.Text = "Desde";
            // 
            // lblFiltroHasta
            // 
            this.lblFiltroHasta.AutoSize = true;
            this.lblFiltroHasta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblFiltroHasta.Location = new System.Drawing.Point(460, 45);
            this.lblFiltroHasta.Name = "lblFiltroHasta";
            this.lblFiltroHasta.Size = new System.Drawing.Size(66, 28);
            this.lblFiltroHasta.TabIndex = 14;
            this.lblFiltroHasta.Text = "Hasta";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnFiltrar.Location = new System.Drawing.Point(658, 70);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(90, 28);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnLimpiarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(984, 70);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(90, 28);
            this.btnLimpiarFiltros.TabIndex = 5;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // tabUsuario
            // 
            this.tabUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabUsuario.Controls.Add(this.lblUsuarioTitulo);
            this.tabUsuario.Controls.Add(this.lblSeparador);
            this.tabUsuario.Controls.Add(this.gbPersonal);
            this.tabUsuario.Controls.Add(this.gbContacto);
            this.tabUsuario.Location = new System.Drawing.Point(4, 37);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(1092, 509);
            this.tabUsuario.TabIndex = 4;
            this.tabUsuario.Text = "USUARIO";
            // 
            // lblUsuarioTitulo
            // 
            this.lblUsuarioTitulo.AutoSize = true;
            this.lblUsuarioTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblUsuarioTitulo.Location = new System.Drawing.Point(26, 14);
            this.lblUsuarioTitulo.Name = "lblUsuarioTitulo";
            this.lblUsuarioTitulo.Size = new System.Drawing.Size(318, 48);
            this.lblUsuarioTitulo.TabIndex = 0;
            this.lblUsuarioTitulo.Text = "Datos del Usuario";
            // 
            // lblSeparador
            // 
            this.lblSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblSeparador.Location = new System.Drawing.Point(26, 50);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(1040, 2);
            this.lblSeparador.TabIndex = 16;
            // 
            // gbPersonal
            // 
            this.gbPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.gbPersonal.Controls.Add(this.lblFNombre);
            this.gbPersonal.Controls.Add(this.lblFApellido);
            this.gbPersonal.Controls.Add(this.lblFEmail);
            this.gbPersonal.Controls.Add(this.lblFRol);
            this.gbPersonal.Controls.Add(this.lblNombreValor);
            this.gbPersonal.Controls.Add(this.lblApellidoValor);
            this.gbPersonal.Controls.Add(this.lblEmailValor);
            this.gbPersonal.Controls.Add(this.lblRolValor);
            this.gbPersonal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.gbPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.gbPersonal.Location = new System.Drawing.Point(26, 60);
            this.gbPersonal.Name = "gbPersonal";
            this.gbPersonal.Size = new System.Drawing.Size(516, 445);
            this.gbPersonal.TabIndex = 12;
            this.gbPersonal.TabStop = false;
            this.gbPersonal.Text = "Información Personal";
            // 
            // lblFNombre
            // 
            this.lblFNombre.AutoSize = true;
            this.lblFNombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblFNombre.Location = new System.Drawing.Point(30, 48);
            this.lblFNombre.Name = "lblFNombre";
            this.lblFNombre.Size = new System.Drawing.Size(133, 38);
            this.lblFNombre.TabIndex = 12;
            this.lblFNombre.Text = "Nombre:";
            // 
            // lblFApellido
            // 
            this.lblFApellido.AutoSize = true;
            this.lblFApellido.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblFApellido.Location = new System.Drawing.Point(30, 143);
            this.lblFApellido.Name = "lblFApellido";
            this.lblFApellido.Size = new System.Drawing.Size(135, 38);
            this.lblFApellido.TabIndex = 13;
            this.lblFApellido.Text = "Apellido:";
            // 
            // lblFEmail
            // 
            this.lblFEmail.AutoSize = true;
            this.lblFEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblFEmail.Location = new System.Drawing.Point(30, 238);
            this.lblFEmail.Name = "lblFEmail";
            this.lblFEmail.Size = new System.Drawing.Size(97, 38);
            this.lblFEmail.TabIndex = 14;
            this.lblFEmail.Text = "Email:";
            // 
            // lblFRol
            // 
            this.lblFRol.AutoSize = true;
            this.lblFRol.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblFRol.Location = new System.Drawing.Point(30, 333);
            this.lblFRol.Name = "lblFRol";
            this.lblFRol.Size = new System.Drawing.Size(67, 38);
            this.lblFRol.TabIndex = 15;
            this.lblFRol.Text = "Rol:";
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblNombreValor.Location = new System.Drawing.Point(200, 48);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(0, 45);
            this.lblNombreValor.TabIndex = 1;
            // 
            // lblApellidoValor
            // 
            this.lblApellidoValor.AutoSize = true;
            this.lblApellidoValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblApellidoValor.Location = new System.Drawing.Point(200, 143);
            this.lblApellidoValor.Name = "lblApellidoValor";
            this.lblApellidoValor.Size = new System.Drawing.Size(0, 45);
            this.lblApellidoValor.TabIndex = 2;
            // 
            // lblEmailValor
            // 
            this.lblEmailValor.AutoSize = true;
            this.lblEmailValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblEmailValor.Location = new System.Drawing.Point(200, 238);
            this.lblEmailValor.Name = "lblEmailValor";
            this.lblEmailValor.Size = new System.Drawing.Size(0, 45);
            this.lblEmailValor.TabIndex = 3;
            // 
            // lblRolValor
            // 
            this.lblRolValor.AutoSize = true;
            this.lblRolValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblRolValor.Location = new System.Drawing.Point(200, 333);
            this.lblRolValor.Name = "lblRolValor";
            this.lblRolValor.Size = new System.Drawing.Size(0, 45);
            this.lblRolValor.TabIndex = 4;
            // 
            // gbContacto
            // 
            this.gbContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.gbContacto.Controls.Add(this.lblFDireccion);
            this.gbContacto.Controls.Add(this.lblFProvincia);
            this.gbContacto.Controls.Add(this.lblFLocalidad);
            this.gbContacto.Controls.Add(this.lblFTelefono);
            this.gbContacto.Controls.Add(this.lblFRedes);
            this.gbContacto.Controls.Add(this.lblDireccionValor);
            this.gbContacto.Controls.Add(this.lblProvinciaValor);
            this.gbContacto.Controls.Add(this.lblLocalidadValor);
            this.gbContacto.Controls.Add(this.lblTelefonoValor);
            this.gbContacto.Controls.Add(this.lblRedesValor);
            this.gbContacto.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.gbContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.gbContacto.Location = new System.Drawing.Point(550, 60);
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.Size = new System.Drawing.Size(516, 445);
            this.gbContacto.TabIndex = 14;
            this.gbContacto.TabStop = false;
            this.gbContacto.Text = "Contacto y Ubicación";
            // 
            // lblFDireccion
            // 
            this.lblFDireccion.AutoSize = true;
            this.lblFDireccion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblFDireccion.Location = new System.Drawing.Point(30, 40);
            this.lblFDireccion.Name = "lblFDireccion";
            this.lblFDireccion.Size = new System.Drawing.Size(148, 38);
            this.lblFDireccion.TabIndex = 16;
            this.lblFDireccion.Text = "Dirección:";
            // 
            // lblFProvincia
            // 
            this.lblFProvincia.AutoSize = true;
            this.lblFProvincia.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblFProvincia.Location = new System.Drawing.Point(30, 100);
            this.lblFProvincia.Name = "lblFProvincia";
            this.lblFProvincia.Size = new System.Drawing.Size(146, 38);
            this.lblFProvincia.TabIndex = 18;
            this.lblFProvincia.Text = "Provincia:";
            // 
            // lblFLocalidad
            // 
            this.lblFLocalidad.AutoSize = true;
            this.lblFLocalidad.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblFLocalidad.Location = new System.Drawing.Point(30, 160);
            this.lblFLocalidad.Name = "lblFLocalidad";
            this.lblFLocalidad.Size = new System.Drawing.Size(149, 38);
            this.lblFLocalidad.TabIndex = 19;
            this.lblFLocalidad.Text = "Localidad:";
            // 
            // lblFTelefono
            // 
            this.lblFTelefono.AutoSize = true;
            this.lblFTelefono.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblFTelefono.Location = new System.Drawing.Point(30, 220);
            this.lblFTelefono.Name = "lblFTelefono";
            this.lblFTelefono.Size = new System.Drawing.Size(138, 38);
            this.lblFTelefono.TabIndex = 20;
            this.lblFTelefono.Text = "Teléfono:";
            // 
            // lblFRedes
            // 
            this.lblFRedes.AutoSize = true;
            this.lblFRedes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFRedes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.lblFRedes.Location = new System.Drawing.Point(30, 280);
            this.lblFRedes.Name = "lblFRedes";
            this.lblFRedes.Size = new System.Drawing.Size(213, 38);
            this.lblFRedes.TabIndex = 21;
            this.lblFRedes.Text = "Redes Sociales:";
            // 
            // lblDireccionValor
            // 
            this.lblDireccionValor.AutoSize = true;
            this.lblDireccionValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblDireccionValor.Location = new System.Drawing.Point(200, 40);
            this.lblDireccionValor.Name = "lblDireccionValor";
            this.lblDireccionValor.Size = new System.Drawing.Size(0, 45);
            this.lblDireccionValor.TabIndex = 6;
            // 
            // lblProvinciaValor
            // 
            this.lblProvinciaValor.AutoSize = true;
            this.lblProvinciaValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinciaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblProvinciaValor.Location = new System.Drawing.Point(200, 100);
            this.lblProvinciaValor.Name = "lblProvinciaValor";
            this.lblProvinciaValor.Size = new System.Drawing.Size(0, 45);
            this.lblProvinciaValor.TabIndex = 8;
            // 
            // lblLocalidadValor
            // 
            this.lblLocalidadValor.AutoSize = true;
            this.lblLocalidadValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidadValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblLocalidadValor.Location = new System.Drawing.Point(200, 160);
            this.lblLocalidadValor.Name = "lblLocalidadValor";
            this.lblLocalidadValor.Size = new System.Drawing.Size(0, 45);
            this.lblLocalidadValor.TabIndex = 9;
            // 
            // lblTelefonoValor
            // 
            this.lblTelefonoValor.AutoSize = true;
            this.lblTelefonoValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblTelefonoValor.Location = new System.Drawing.Point(200, 220);
            this.lblTelefonoValor.Name = "lblTelefonoValor";
            this.lblTelefonoValor.Size = new System.Drawing.Size(0, 45);
            this.lblTelefonoValor.TabIndex = 10;
            // 
            // lblRedesValor
            // 
            this.lblRedesValor.AutoSize = true;
            this.lblRedesValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedesValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblRedesValor.Location = new System.Drawing.Point(200, 280);
            this.lblRedesValor.Name = "lblRedesValor";
            this.lblRedesValor.Size = new System.Drawing.Size(0, 45);
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
            this.tabMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1100, 550);
            this.tabMenu.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
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
            this.Text = "Panel Principal";
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
            this.gbPersonal.ResumeLayout(false);
            this.gbPersonal.PerformLayout();
            this.gbContacto.ResumeLayout(false);
            this.gbContacto.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
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
        private System.Windows.Forms.Label lblDireccionValor;
        private System.Windows.Forms.Label lblProvinciaValor;
        private System.Windows.Forms.Label lblLocalidadValor;
        private System.Windows.Forms.Label lblTelefonoValor;
        private System.Windows.Forms.Label lblRedesValor;
        private System.Windows.Forms.Label lblFNombre;
        private System.Windows.Forms.Label lblFApellido;
        private System.Windows.Forms.Label lblFEmail;
        private System.Windows.Forms.Label lblFRol;
        private System.Windows.Forms.Label lblFDireccion;
        private System.Windows.Forms.Label lblFProvincia;
        private System.Windows.Forms.Label lblFLocalidad;
        private System.Windows.Forms.Label lblFTelefono;
        private System.Windows.Forms.Label lblFRedes;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.GroupBox gbContacto;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.GroupBox gbOrden;
        private System.Windows.Forms.RadioButton radioAsc;
        private System.Windows.Forms.RadioButton radioDesc;
        private System.Windows.Forms.TextBox txtFiltroUsuario;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaHasta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label lblFiltroDesde;
        private System.Windows.Forms.Label lblFiltroHasta;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
    }
}
