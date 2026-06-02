using System;
using System.Data;
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

            // Guarda el movimiento de navegación en la base de datos
            clsConexion conexion = new clsConexion();
            conexion.RegistrarAuditoria(_usuario.Nombre, "Navegacion", this.Name);
            CargarGrillaAuditoria();
        }

        private void MostrarDatosUsuario()
        {
            statusStripTop.Items.Clear();

            var lblNombre = new ToolStripStatusLabel("👤 " + _usuario.Nombre + " " + _usuario.Apellido + " ");
            lblNombre.ForeColor = Color.White;

            var lblHora = new ToolStripStatusLabel("|  📅 Conectado: " + _usuario.HoraConexion + "  ");
            lblHora.ForeColor = Color.White;

            var lblRol = new ToolStripStatusLabel("|  🔑 Perfil: " + _usuario.Rol);
            lblRol.ForeColor = Color.White;

            statusStripTop.Items.Add(lblNombre);
            statusStripTop.Items.Add(lblHora);
            statusStripTop.Items.Add(lblRol);
        }

        private void VerificarConexion()
        {
            statusStrip1.Items.Clear();
            clsConexion conexion = new clsConexion();
            ToolStripStatusLabel lbl;

            if (conexion.ProbarConexion())
                lbl = new ToolStripStatusLabel("🟢 DB Conectada") { ForeColor = Color.Green };
            else
                lbl = new ToolStripStatusLabel("🔴 Sin conexión") { ForeColor = Color.Red };

            statusStrip1.Items.Add(lbl);
        }

        private void CargarGrillaAuditoria()
        {
            clsConexion conexion = new clsConexion();
            DataTable dt = conexion.ObtenerAuditoria();

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvConsulta.DataSource = dt;

                // Opcional: Mejorar visualmente los encabezados de las columnas
                dgvConsulta.Columns["Id_Auditoria"].HeaderText = "ID";
                dgvConsulta.Columns["Usuario"].HeaderText = "Usuario";
                dgvConsulta.Columns["FechaHora"].HeaderText = "Fecha y Hora";
                dgvConsulta.Columns["Estado"].HeaderText = "Estado";
                dgvConsulta.Columns["Historial"].HeaderText = "Último Formulario";

                // Ajustar automáticamente el ancho de las columnas para que se vea ordenado
                dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (!string.IsNullOrEmpty(conexion.GetError()))
            {
                MessageBox.Show("Error al cargar la grilla de auditoría: " + conexion.GetError(), "Error");
            }
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}