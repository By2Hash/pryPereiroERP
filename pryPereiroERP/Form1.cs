using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPereiroERP
{
    public partial class frmERP : Form
    {
        public frmERP()
        {
            InitializeComponent();
            VerificarConexion();
        }

        private void VerificarConexion()
        {
            clsConexion conexion = new clsConexion();

            if (conexion.ProbarConexion())
            {
                
                // Opcional: agregar texto al strip
                ToolStripStatusLabel lbl = new ToolStripStatusLabel("Conectado");
                lbl.ForeColor = Color.Green;
                statusStrip1.Items.Clear();
                statusStrip1.Items.Add(lbl);
            }
            else
            {
                
                ToolStripStatusLabel lbl = new ToolStripStatusLabel(" Sin conexión: " + conexion.GetError());
                lbl.ForeColor = Color.Red;
                statusStrip1.Items.Clear();
                statusStrip1.Items.Add(lbl);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
