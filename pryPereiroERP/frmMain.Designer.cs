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
            this.lblAuditoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(969, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // statusStripTop
            // 
            this.statusStripTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusStripTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStripTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripTop.Location = new System.Drawing.Point(0, 0);
            this.statusStripTop.Name = "statusStripTop";
            this.statusStripTop.Size = new System.Drawing.Size(969, 22);
            this.statusStripTop.TabIndex = 1;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 94);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 62;
            this.dgvConsulta.RowTemplate.Height = 28;
            this.dgvConsulta.Size = new System.Drawing.Size(945, 477);
            this.dgvConsulta.TabIndex = 2;
            // 
            // lblAuditoria
            // 
            this.lblAuditoria.AutoSize = true;
            this.lblAuditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoria.Location = new System.Drawing.Point(12, 42);
            this.lblAuditoria.Name = "lblAuditoria";
            this.lblAuditoria.Size = new System.Drawing.Size(231, 30);
            this.lblAuditoria.TabIndex = 3;
            this.lblAuditoria.Text = "Consultar Auditoria";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 611);
            this.Controls.Add(this.lblAuditoria);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.statusStripTop);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStripTop;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblAuditoria;
    }

}

