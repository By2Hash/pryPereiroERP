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

            // Bloquear RRHH si el perfil no es Admin ni RRHH
            if (!_usuario.Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase) &&
                !_usuario.Rol.Equals("RRHH", StringComparison.OrdinalIgnoreCase))
            {
                tabMenu.TabPages.Remove(tabRRHH);
            }

            CargarAyuda();

            clsConexion conexion = new clsConexion();
            conexion.RegistrarAuditoria(_usuario.Nombre, "Navegacion", this.Name);
            CargarGrillaAuditoria();
            CargarGrillaUsuarios();
        }

        private void CargarAyuda()
        {
            var lbl = new Label
            {
                Text = "GUÍA RÁPIDA DEL SISTEMA ERP\n\n" +
                       "• Cerrar sesión: Cierre la ventana principal y confirme \"Sí\" " +
                       "cuando se le pregunte si desea salir. La ventana de inicio " +
                       "de sesión se abrirá automáticamente.\n\n" +
                       "• Editar datos de un usuario: Solo los usuarios con perfil " +
                       "Admin o RRHH pueden modificar datos. Haga doble clic sobre " +
                       "la fila del usuario en la grilla de la pestaña RRHH.\n\n" +
                       "• Registrar un usuario nuevo: Vaya a la pestaña RRHH y " +
                       "presione el botón \"Registrar\". Complete los campos " +
                       "obligatorios (DNI, Apellido, Nombre, Mail, Contraseña).\n\n" +
                       "• Activar/Desactivar usuario: Al editar un usuario, marque " +
                       "o desmarque la casilla \"Activar/Desactivar\" y presione " +
                       "\"Actualizar\".\n\n" +
                       "• Auditoría: La pestaña AUDITORIA muestra un historial " +
                       "de inicios de sesión y movimientos. Puede ordenarlo " +
                       "de forma ascendente o descendente.",
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(tabAyuda.Width - 40, tabAyuda.Height - 40),
                Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Regular),
                ForeColor = System.Drawing.Color.FromArgb(50, 50, 50),
                AutoSize = false,
                TextAlign = System.Drawing.ContentAlignment.TopLeft
            };
            tabAyuda.Controls.Add(lbl);
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

                if (dgvConsulta.Columns["Id_Auditoria"] != null) dgvConsulta.Columns["Id_Auditoria"].HeaderText = "ID";
                if (dgvConsulta.Columns["Usuario"] != null) dgvConsulta.Columns["Usuario"].HeaderText = "Usuario";
                if (dgvConsulta.Columns["FechaHora"] != null) dgvConsulta.Columns["FechaHora"].HeaderText = "Fecha y Hora";
                if (dgvConsulta.Columns["Estado"] != null) dgvConsulta.Columns["Estado"].HeaderText = "Estado";
                if (dgvConsulta.Columns["Historial"] != null) dgvConsulta.Columns["Historial"].HeaderText = "Último Formulario";

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

                if (dgvUsuarios.Columns["Id_Usuario"] != null) dgvUsuarios.Columns["Id_Usuario"].HeaderText = "Id";
                if (dgvUsuarios.Columns["DNI"] != null) dgvUsuarios.Columns["DNI"].HeaderText = "DNI";
                if (dgvUsuarios.Columns["Nombre"] != null) dgvUsuarios.Columns["Nombre"].HeaderText = "Nombre";
                if (dgvUsuarios.Columns["Apellido"] != null) dgvUsuarios.Columns["Apellido"].HeaderText = "Apellido";
                if (dgvUsuarios.Columns["Mail"] != null) dgvUsuarios.Columns["Mail"].HeaderText = "Mail";
                if (dgvUsuarios.Columns["Contraseña"] != null) dgvUsuarios.Columns["Contraseña"].HeaderText = "Contraseña";
                if (dgvUsuarios.Columns["Activo"] != null) dgvUsuarios.Columns["Activo"].HeaderText = "Activo";
               

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
            rrhh.UsuarioActual = _usuario?.Nombre;
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

            object val = dgvUsuarios.Rows[e.RowIndex].Cells["Id_Usuario"].Value;
            if (val == null || val == DBNull.Value) return;

            int idUsuario = Convert.ToInt32(val);

            frmRRHH rrhh = new frmRRHH(idUsuario);
            rrhh.UsuarioActual = _usuario?.Nombre;
            rrhh.ShowDialog();

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