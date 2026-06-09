namespace pryPereiroERP
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripTop = new System.Windows.Forms.StatusStrip();
            this.tabAyuda = new System.Windows.Forms.TabPage();
            this.tabRRHH = new System.Windows.Forms.TabPage();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblRRHH = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tabGrilla = new System.Windows.Forms.TabPage();
            this.optDesc = new System.Windows.Forms.RadioButton();
            this.optAsc = new System.Windows.Forms.RadioButton();
            this.lblAuditoria = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabRRHH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 742);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1161, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // statusStripTop
            // 
            this.statusStripTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusStripTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStripTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripTop.Location = new System.Drawing.Point(0, 0);
            this.statusStripTop.Name = "statusStripTop";
            this.statusStripTop.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStripTop.Size = new System.Drawing.Size(1161, 22);
            this.statusStripTop.TabIndex = 1;
            this.statusStripTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStripTop_ItemClicked);
            // 
            // tabAyuda
            // 
            this.tabAyuda.Location = new System.Drawing.Point(4, 29);
            this.tabAyuda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAyuda.Name = "tabAyuda";
            this.tabAyuda.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAyuda.Size = new System.Drawing.Size(1152, 659);
            this.tabAyuda.TabIndex = 3;
            this.tabAyuda.Text = "AYUDA";
            this.tabAyuda.UseVisualStyleBackColor = true;
            // 
            // tabRRHH
            // 
            this.tabRRHH.Controls.Add(this.btnRegistrar);
            this.tabRRHH.Controls.Add(this.lblRRHH);
            this.tabRRHH.Controls.Add(this.dgvUsuarios);
            this.tabRRHH.Location = new System.Drawing.Point(4, 29);
            this.tabRRHH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabRRHH.Name = "tabRRHH";
            this.tabRRHH.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabRRHH.Size = new System.Drawing.Size(1152, 659);
            this.tabRRHH.TabIndex = 1;
            this.tabRRHH.Text = "RRHH";
            this.tabRRHH.UseVisualStyleBackColor = true;
            this.tabRRHH.Click += new System.EventHandler(this.tabRRHH_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(10, 80);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 35);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblRRHH
            // 
            this.lblRRHH.AutoSize = true;
            this.lblRRHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRRHH.Location = new System.Drawing.Point(9, 18);
            this.lblRRHH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRRHH.Name = "lblRRHH";
            this.lblRRHH.Size = new System.Drawing.Size(198, 29);
            this.lblRRHH.TabIndex = 4;
            this.lblRRHH.Text = "Lista de Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(10, 138);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(1126, 506);
            this.dgvUsuarios.TabIndex = 3;
        
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
           
            // 
            // tabGrilla
            // 
            this.tabGrilla.Controls.Add(this.optDesc);
            this.tabGrilla.Controls.Add(this.optAsc);
            this.tabGrilla.Controls.Add(this.lblAuditoria);
            this.tabGrilla.Controls.Add(this.dgvConsulta);
            this.tabGrilla.Location = new System.Drawing.Point(4, 29);
            this.tabGrilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGrilla.Name = "tabGrilla";
            this.tabGrilla.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGrilla.Size = new System.Drawing.Size(1152, 659);
            this.tabGrilla.TabIndex = 0;
            this.tabGrilla.Text = "AUDITORIA";
            this.tabGrilla.UseVisualStyleBackColor = true;
            this.tabGrilla.Click += new System.EventHandler(this.tabGrilla_Click);
            // 
            // optDesc
            // 
            this.optDesc.AutoSize = true;
            this.optDesc.Location = new System.Drawing.Point(214, 71);
            this.optDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optDesc.Name = "optDesc";
            this.optDesc.Size = new System.Drawing.Size(178, 24);
            this.optDesc.TabIndex = 5;
            this.optDesc.TabStop = true;
            this.optDesc.Text = "Orden Descendente";
            this.optDesc.UseVisualStyleBackColor = true;
            this.optDesc.CheckedChanged += new System.EventHandler(this.optDesc_CheckedChanged);
            // 
            // optAsc
            // 
            this.optAsc.AutoSize = true;
            this.optAsc.Location = new System.Drawing.Point(14, 71);
            this.optAsc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optAsc.Name = "optAsc";
            this.optAsc.Size = new System.Drawing.Size(168, 24);
            this.optAsc.TabIndex = 4;
            this.optAsc.TabStop = true;
            this.optAsc.Text = "Orden Ascendente";
            this.optAsc.UseVisualStyleBackColor = true;
            this.optAsc.CheckedChanged += new System.EventHandler(this.optAsc_CheckedChanged);
            // 
            // lblAuditoria
            // 
            this.lblAuditoria.AutoSize = true;
            this.lblAuditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoria.Location = new System.Drawing.Point(12, 22);
            this.lblAuditoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuditoria.Name = "lblAuditoria";
            this.lblAuditoria.Size = new System.Drawing.Size(172, 29);
            this.lblAuditoria.TabIndex = 3;
            this.lblAuditoria.Text = "Listar Auditoria";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(10, 118);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 62;
            this.dgvConsulta.RowTemplate.Height = 28;
            this.dgvConsulta.Size = new System.Drawing.Size(1128, 526);
            this.dgvConsulta.TabIndex = 2;

            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabGrilla);
            this.tabMenu.Controls.Add(this.tabRRHH);
            this.tabMenu.Controls.Add(this.tabAyuda);
            this.tabMenu.Location = new System.Drawing.Point(0, 38);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1160, 692);
            this.tabMenu.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 764);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.statusStripTop);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ERP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);

            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabRRHH.ResumeLayout(false);
            this.tabRRHH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabGrilla.ResumeLayout(false);
            this.tabGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStripTop;
        private System.Windows.Forms.TabPage tabAyuda;
        private System.Windows.Forms.TabPage tabRRHH;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblRRHH;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TabPage tabGrilla;
        private System.Windows.Forms.RadioButton optDesc;
        private System.Windows.Forms.RadioButton optAsc;
        private System.Windows.Forms.Label lblAuditoria;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.TabControl tabMenu;
    }

}

