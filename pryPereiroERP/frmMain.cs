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
    public partial class frmMain : Form
    {
        private clsUsuario _usuario;

        // Constructor que recibe el usuario
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(clsUsuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatosUsuario();
            VerificarConexion();
        }

        private void MostrarDatosUsuario()
        {
            // Usando labels en el StatusStrip (ya lo tenés)
            statusStrip1.Items.Clear();

            ToolStripStatusLabel lblNombre = new ToolStripStatusLabel(
                "👤 " + _usuario.Nombre + " " + _usuario.Apellido);
            lblNombre.ForeColor = Color.White;

            ToolStripStatusLabel lblRol = new ToolStripStatusLabel(
                " | Rol: " + _usuario.Rol);
            lblRol.ForeColor = Color.LightBlue;

            ToolStripStatusLabel lblHora = new ToolStripStatusLabel(
                " | Conectado: " + _usuario.HoraConexion);
            lblHora.ForeColor = Color.LightGreen;

            statusStrip1.Items.Add(lblNombre);
            statusStrip1.Items.Add(lblRol);
            statusStrip1.Items.Add(lblHora);
        }

        private void VerificarConexion()
        {
            clsConexion conexion = new clsConexion();
            ToolStripStatusLabel lbl;

            if (conexion.ProbarConexion())
                lbl = new ToolStripStatusLabel(" | 🟢 DB Conectada") { ForeColor = Color.Green };
            else
                lbl = new ToolStripStatusLabel(" | 🔴 Sin conexión") { ForeColor = Color.Red };

            statusStrip1.Items.Add(lbl);
        }
    }
}
