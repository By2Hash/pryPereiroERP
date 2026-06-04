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
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabGrilla = new System.Windows.Forms.TabPage();
            this.tabRRHH = new System.Windows.Forms.TabPage();
            this.tabCuenta = new System.Windows.Forms.TabPage();
            this.lblAuditoria = new System.Windows.Forms.Label();
            this.optAsc = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.tabAyuda = new System.Windows.Forms.TabPage();
            this.lblRRHH = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.tabGrilla.SuspendLayout();
            this.tabRRHH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(774, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // statusStripTop
            // 
            this.statusStripTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusStripTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStripTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripTop.Location = new System.Drawing.Point(0, 0);
            this.statusStripTop.Name = "statusStripTop";
            this.statusStripTop.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStripTop.Size = new System.Drawing.Size(774, 22);
            this.statusStripTop.TabIndex = 1;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 77);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 62;
            this.dgvConsulta.RowTemplate.Height = 28;
            this.dgvConsulta.Size = new System.Drawing.Size(672, 296);
            this.dgvConsulta.TabIndex = 2;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabGrilla);
            this.tabMenu.Controls.Add(this.tabRRHH);
            this.tabMenu.Controls.Add(this.tabCuenta);
            this.tabMenu.Controls.Add(this.tabAyuda);
            this.tabMenu.Location = new System.Drawing.Point(0, 25);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(773, 450);
            this.tabMenu.TabIndex = 3;
            // 
            // tabGrilla
            // 
            this.tabGrilla.Controls.Add(this.radioButton2);
            this.tabGrilla.Controls.Add(this.optAsc);
            this.tabGrilla.Controls.Add(this.lblAuditoria);
            this.tabGrilla.Controls.Add(this.dgvConsulta);
            this.tabGrilla.Location = new System.Drawing.Point(4, 22);
            this.tabGrilla.Name = "tabGrilla";
            this.tabGrilla.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrilla.Size = new System.Drawing.Size(765, 424);
            this.tabGrilla.TabIndex = 0;
            this.tabGrilla.Text = "AUDITORIA";
            this.tabGrilla.UseVisualStyleBackColor = true;
            // 
            // tabRRHH
            // 
            this.tabRRHH.Controls.Add(this.btnRegistrar);
            this.tabRRHH.Controls.Add(this.lblRRHH);
            this.tabRRHH.Controls.Add(this.dvgUsuarios);
            this.tabRRHH.Location = new System.Drawing.Point(4, 22);
            this.tabRRHH.Name = "tabRRHH";
            this.tabRRHH.Padding = new System.Windows.Forms.Padding(3);
            this.tabRRHH.Size = new System.Drawing.Size(765, 424);
            this.tabRRHH.TabIndex = 1;
            this.tabRRHH.Text = "RRHH";
            this.tabRRHH.UseVisualStyleBackColor = true;
            // 
            // tabCuenta
            // 
            this.tabCuenta.Location = new System.Drawing.Point(4, 22);
            this.tabCuenta.Name = "tabCuenta";
            this.tabCuenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuenta.Size = new System.Drawing.Size(765, 424);
            this.tabCuenta.TabIndex = 2;
            this.tabCuenta.Text = "CUENTA";
            this.tabCuenta.UseVisualStyleBackColor = true;
            // 
            // lblAuditoria
            // 
            this.lblAuditoria.AutoSize = true;
            this.lblAuditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoria.Location = new System.Drawing.Point(8, 14);
            this.lblAuditoria.Name = "lblAuditoria";
            this.lblAuditoria.Size = new System.Drawing.Size(115, 20);
            this.lblAuditoria.TabIndex = 3;
            this.lblAuditoria.Text = "Listar Auditoria";
            // 
            // optAsc
            // 
            this.optAsc.AutoSize = true;
            this.optAsc.Location = new System.Drawing.Point(12, 46);
            this.optAsc.Name = "optAsc";
            this.optAsc.Size = new System.Drawing.Size(38, 17);
            this.optAsc.TabIndex = 4;
            this.optAsc.TabStop = true;
            this.optAsc.Text = "Ac";
            this.optAsc.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(124, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Location = new System.Drawing.Point(7, 90);
            this.dvgUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.RowHeadersWidth = 62;
            this.dvgUsuarios.RowTemplate.Height = 28;
            this.dvgUsuarios.Size = new System.Drawing.Size(751, 329);
            this.dvgUsuarios.TabIndex = 3;
            // 
            // tabAyuda
            // 
            this.tabAyuda.Location = new System.Drawing.Point(4, 22);
            this.tabAyuda.Name = "tabAyuda";
            this.tabAyuda.Padding = new System.Windows.Forms.Padding(3);
            this.tabAyuda.Size = new System.Drawing.Size(765, 424);
            this.tabAyuda.TabIndex = 3;
            this.tabAyuda.Text = "AYUDA";
            this.tabAyuda.UseVisualStyleBackColor = true;
            // 
            // lblRRHH
            // 
            this.lblRRHH.AutoSize = true;
            this.lblRRHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRRHH.Location = new System.Drawing.Point(6, 12);
            this.lblRRHH.Name = "lblRRHH";
            this.lblRRHH.Size = new System.Drawing.Size(132, 20);
            this.lblRRHH.TabIndex = 4;
            this.lblRRHH.Text = "Lista de Usuarios";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(7, 52);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 500);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.statusStripTop);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema ERP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.tabGrilla.ResumeLayout(false);
            this.tabGrilla.PerformLayout();
            this.tabRRHH.ResumeLayout(false);
            this.tabRRHH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStripTop;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabGrilla;
        private System.Windows.Forms.TabPage tabRRHH;
        private System.Windows.Forms.TabPage tabCuenta;
        private System.Windows.Forms.Label lblAuditoria;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton optAsc;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.TabPage tabAyuda;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblRRHH;
    }

}

