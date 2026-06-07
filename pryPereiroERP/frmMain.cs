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
            CargarGrillaUsuarios();
           
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

        private void CargarGrillaUsuarios()
        {
            clsConexion conexion = new clsConexion();
            DataTable dt = conexion.ObtenerUsuarios();

            if (dt != null && dt.Rows.Count > 0)
            {
               dvgUsuarios.DataSource = dt;

                // Opcional: Mejorar visualmente los encabezados de las columnas
                dvgUsuarios.Columns["Id_Usuario"].HeaderText = "ID";
                dvgUsuarios.Columns["DNI"].HeaderText = "DNI";
                dvgUsuarios.Columns["Nombre"].HeaderText = "Nombre";
                dvgUsuarios.Columns["Apellido"].HeaderText = "Apellido";
                dvgUsuarios.Columns["Mail"].HeaderText = "Mail";
                dvgUsuarios.Columns["Contraseña"].HeaderText = "Contraseña";
                dvgUsuarios.Columns["Activo"].HeaderText = "Activo";
               

                // Ajustar automáticamente el ancho de las columnas para que se vea ordenado
                dvgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (!string.IsNullOrEmpty(conexion.GetError()))
            {
                MessageBox.Show("Error al cargar la grilla de auditoría: " + conexion.GetError(), "Error");
            }
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRRHH rrhh = new frmRRHH();
            rrhh.ShowDialog();
        }

        private void optAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (optAsc.Checked)
            { 
                clsConexion conexion = new clsConexion();
                DataTable dt = conexion.ObtenerAuditoriaASC();

                dgvConsulta.DataSource = dt;
            }
            else
                           {
                CargarGrillaAuditoria();
            }
        }

        private void tabRRHH_Click(object sender, EventArgs e)
        {

        }

        private void tabGrilla_Click(object sender, EventArgs e)
        {

        }

        private void dvgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRRHH rrhh = new frmRRHH();
            rrhh.ShowDialog();
        }

        private void optDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (optDesc.Checked)
            {
                clsConexion conexion = new clsConexion();
                DataTable dt = conexion.ObtenerAuditoria();
                dgvConsulta.DataSource = dt;
            }
            else
            {
                CargarGrillaAuditoria();
            }
        }

        private void statusStripTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Lanzamos el cuadro de diálogo para preguntar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea cerrar sesión y salir del sistema ERP?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario responde que NO, cancelamos el cierre de la ventana
            if (respuesta == DialogResult.No)
            {
                e.Cancel = true; // Esto detiene a Windows y mantiene el programa abierto
            }
            else
            {
                // Si responde que SÍ, dejamos que el formulario se cierre normalmente.
                // Aquí puedes agregar código para reabrir el Login si no quieres que el programa muera:

                // frmLogin login = new frmLogin();
                // login.Show();
                Application.Exit();
            }
        }
    }
}