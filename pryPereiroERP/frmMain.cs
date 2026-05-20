using System;
using System.Drawing;
using System.Windows.Forms;

namespace pryPereiroERP
{
    public partial class frmMain : Form
    {
        private clsUsuario _usuario;

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
            statusStripTop.Items.Clear();

            var lblNombre = new ToolStripStatusLabel("👤 " + _usuario.Nombre + " " + _usuario.Apellido);
            lblNombre.ForeColor = Color.White;

            var lblHora = new ToolStripStatusLabel(" | Conectado: " + _usuario.HoraConexion);
            lblHora.ForeColor = Color.White;

            statusStripTop.Items.Add(lblNombre);
            statusStripTop.Items.Add(lblHora);
        }

        private void VerificarConexion()
        {
            statusStrip1.Items.Clear(); // limpiar también este

            clsConexion conexion = new clsConexion();
            ToolStripStatusLabel lbl;

            if (conexion.ProbarConexion())
                lbl = new ToolStripStatusLabel("🟢 DB Conectada") { ForeColor = Color.Green };
            else
                lbl = new ToolStripStatusLabel("🔴 Sin conexión") { ForeColor = Color.Red };

            statusStrip1.Items.Add(lbl);
        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}