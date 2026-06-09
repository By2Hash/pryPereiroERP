using System;
using System.Data;
using System.Drawing;
using System.Linq;
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
               dgvUsuarios.DataSource = dt;

                // Opcional: Mejorar visualmente los encabezados de las columnas
                dgvUsuarios.Columns["Id_Usuario"].HeaderText = "ID";
                dgvUsuarios.Columns["DNI"].HeaderText = "DNI";
                dgvUsuarios.Columns["Nombre"].HeaderText = "Nombre";
                dgvUsuarios.Columns["Apellido"].HeaderText = "Apellido";
                dgvUsuarios.Columns["Mail"].HeaderText = "Mail";
                dgvUsuarios.Columns["Contraseña"].HeaderText = "Contraseña";
                dgvUsuarios.Columns["Activo"].HeaderText = "Activo";
               

                // Ajustar automáticamente el ancho de las columnas para que se vea ordenado
                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Capturamos el ID de la celda seleccionada
            int idUsuario = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["Id_Usuario"].Value);

            // Abrimos el formulario pasándole el ID
            frmRRHH rrhh = new frmRRHH(idUsuario);
            rrhh.ShowDialog();

            // Al regresar, refrescamos la grilla para ver los cambios
            CargarGrillaUsuarios();
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
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de que desea cerrar sesión y salir del sistema ERP?",
                    "Confirmar Salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true; // Detiene el cierre y mantiene el programa abierto
                }
                else
                {
                    // SI RESPONDE QUE SÍ:
                    // Desasociamos el evento antes de salir para evitar ejecuciones fantasma
                    this.FormClosing -= frmMain_FormClosing;

                    // Instanciamos el login para que el programa no muera por completo
                    frmLogin login = new frmLogin();
                    login.Show();
                }
            }
        }

       

        
    }
}