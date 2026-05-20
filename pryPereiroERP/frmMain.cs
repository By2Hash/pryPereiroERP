using System;
using System.Drawing;
using System.Windows.Forms;

namespace pryPereiroERP
{
    public partial class frmMain : Form
    {
        private clsUsuario _usuario;

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

            if (_usuario == null) return;
            MostrarDatosUsuario();
            VerificarConexion();
        }

        private void MostrarDatosUsuario()
        {
            statusStripTop.Items.Clear();

            // 1. Etiqueta de Usuario
            var lblNombre = new ToolStripStatusLabel("👤 " + _usuario.Nombre + " " + _usuario.Apellido + " ");
            lblNombre.ForeColor = Color.White;

            // 2. Etiqueta de Hora y Fecha
            var lblHora = new ToolStripStatusLabel("|  📅 Conectado: " + _usuario.HoraConexion + "  ");
            lblHora.ForeColor = Color.White;

            // 3. Etiqueta de Rol (Cambiamos el diseño para que no sea tan chocante el fondo rojo si no querés)
            var lblRol = new ToolStripStatusLabel("|  🔑 Perfil: " + _usuario.Rol);
            lblRol.ForeColor = Color.White;
            // Si querés mantener el fondo rojo que tenías, descomentá las siguientes dos líneas:
            // lblRol.BackColor = Color.Red;
            // lblRol.DisplayStyle = ToolStripItemDisplayStyle.Text;

            // Los agregamos uno al lado del otro de forma consecutiva
            statusStripTop.Items.Add(lblNombre);
            statusStripTop.Items.Add(lblHora);
            statusStripTop.Items.Add(lblRol);
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