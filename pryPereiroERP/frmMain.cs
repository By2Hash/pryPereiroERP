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

            VerificarConexion();
            CargarDatosUsuarioTab();

            // Bloquear RRHH si el perfil no es Admin ni RRHH
            if (!_usuario.Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase) &&
                !_usuario.Rol.Equals("RRHH", StringComparison.OrdinalIgnoreCase))
            {
                tabMenu.TabPages.Remove(tabRRHH);
            }

            CargarAyuda();

            clsConexion conexion = new clsConexion();
            conexion.RegistrarAuditoria(_usuario.Nombre, "Navegacion", this.Name);

            radioDesc.Checked = true;
            cboTablas.SelectedItem = "Auditoria-Sesion";

            CargarGrillaUsuarios();
            CargarDashboard();
        }

        private void CargarDatosUsuarioTab()
        {
            lblNombreValor.Text = "  Nombre: " + _usuario.Nombre;
            lblApellidoValor.Text = "  Apellido: " + _usuario.Apellido;
            lblRolValor.Text = "  Perfil: " + _usuario.Rol;
            lblConexionValor.Text = "  Conectado desde: " + _usuario.HoraConexion;

            try
            {
                clsConexion conexion = new clsConexion();
                DataTable dt = conexion.ObtenerUsuarioPorId(_usuario.Id);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    lblEmailValor.Text = "  Email: " + (row["Mail"] != DBNull.Value ? row["Mail"].ToString().Trim() : "-");
                    lblDireccionValor.Text = "  Dirección: " + (row["Dirección"] != DBNull.Value ? row["Dirección"].ToString().Trim() : "-");
                    lblGPSValor.Text = "  GPS: " + (row["GPS"] != DBNull.Value ? row["GPS"].ToString().Trim() : "-");
                    lblProvinciaValor.Text = "  Provincia: " + (row["Provincia"] != DBNull.Value ? row["Provincia"].ToString().Trim() : "-");
                    lblLocalidadValor.Text = "  Localidad: " + (row["Localidad"] != DBNull.Value ? row["Localidad"].ToString().Trim() : "-");
                    lblTelefonoValor.Text = "  Teléfono: " + (row["Telefono"] != DBNull.Value ? row["Telefono"].ToString().Trim() : "-");
                    lblRedesValor.Text = "  Redes Sociales: " + (row["Redes_Sociales"] != DBNull.Value ? row["Redes_Sociales"].ToString().Trim() : "-");
                }
                else
                {
                    lblEmailValor.Text = "  Email: -";
                    lblDireccionValor.Text = "  Dirección: -";
                    lblGPSValor.Text = "  GPS: -";
                    lblProvinciaValor.Text = "  Provincia: -";
                    lblLocalidadValor.Text = "  Localidad: -";
                    lblTelefonoValor.Text = "  Teléfono: -";
                    lblRedesValor.Text = "  Redes Sociales: -";
                }
            }
            catch
            {
                lblEmailValor.Text = "  Email: Error al cargar";
            }
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
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(tabAyuda.Width - 40, tabAyuda.Height - 40),
                Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Regular),
                ForeColor = System.Drawing.Color.FromArgb(204, 204, 204),
                AutoSize = false,
                TextAlign = System.Drawing.ContentAlignment.TopLeft
            };
            tabAyuda.Controls.Add(lbl);
        }

        private void VerificarConexion()
        {
            statusStrip1.Items.Clear();
            clsConexion conexion = new clsConexion();
            ToolStripStatusLabel lbl;

            if (conexion.ProbarConexion())
                lbl = new ToolStripStatusLabel("  🟢 Base de datos conectada") { ForeColor = Color.Lime };
            else
                lbl = new ToolStripStatusLabel("  🔴 Sin conexión") { ForeColor = Color.Red };

            lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            statusStrip1.Items.Add(lbl);
        }

        private void CargarTablaEnGrilla(string tabla)
        {
            clsConexion conexion = new clsConexion();
            DataTable dt = conexion.ObtenerDatosTabla(tabla);

            if (dt != null)
            {
                bool ascendente = radioAsc.Checked;
                string colOrden = ObtenerColumnaOrden(tabla, dt);
                if (!string.IsNullOrEmpty(colOrden))
                {
                    dt.DefaultView.Sort = colOrden + (ascendente ? " ASC" : " DESC");
                    dgvConsulta.DataSource = dt.DefaultView;
                }
                else
                {
                    dgvConsulta.DataSource = dt;
                }

                dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                lblResultados.Text = dt.Rows.Count + " registros encontrados";
            }
            else if (!string.IsNullOrEmpty(conexion.GetError()))
            {
                MessageBox.Show("Error al cargar la tabla " + tabla + ": " + conexion.GetError(), "Error");
            }
        }

        private string ObtenerColumnaOrden(string tabla, DataTable dt)
        {
            if (dt == null || dt.Columns.Count == 0) return null;

            foreach (string colName in new[] { "Id_Auditoria", "Id_Usuario", "Id_Perfil", "Id_Provincia", "Id_Localidad" })
            {
                if (dt.Columns[colName] != null) return colName;
            }

            foreach (DataColumn col in dt.Columns)
            {
                Type t = col.DataType;
                if (t == typeof(int) || t == typeof(long) || t == typeof(short) || t == typeof(byte))
                    return col.ColumnName;
            }

            return dt.Columns[0].ColumnName;
        }

        private void cboTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTablas.SelectedItem == null) return;
            CargarTablaEnGrilla(cboTablas.SelectedItem.ToString());
        }

        private void radioOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (cboTablas.SelectedItem != null)
            {
                CargarTablaEnGrilla(cboTablas.SelectedItem.ToString());
            }
        }

        private void CargarGrillaUsuarios()
        {
            clsConexion conexion = new clsConexion();
            DataTable dt = conexion.ObtenerUsuarios();

            if (dt != null && dt.Rows.Count > 0)
            {
               dgvUsuarios.DataSource = new DataView(dt);

                if (dgvUsuarios.Columns["Id_Usuario"] != null) dgvUsuarios.Columns["Id_Usuario"].HeaderText = "Id";
                if (dgvUsuarios.Columns["DNI"] != null) dgvUsuarios.Columns["DNI"].HeaderText = "DNI";
                if (dgvUsuarios.Columns["Nombre"] != null) dgvUsuarios.Columns["Nombre"].HeaderText = "Nombre";
                if (dgvUsuarios.Columns["Apellido"] != null) dgvUsuarios.Columns["Apellido"].HeaderText = "Apellido";
                if (dgvUsuarios.Columns["Mail"] != null) dgvUsuarios.Columns["Mail"].HeaderText = "Mail";
                if (dgvUsuarios.Columns["Contraseña"] != null) dgvUsuarios.Columns["Contraseña"].HeaderText = "Contraseña";
                if (dgvUsuarios.Columns["Activo"] != null) dgvUsuarios.Columns["Activo"].HeaderText = "Activo";

                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (!string.IsNullOrEmpty(conexion.GetError()))
            {
                MessageBox.Show("Error al cargar la grilla de auditoría: " + conexion.GetError(), "Error");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRRHH rrhh = new frmRRHH();
            rrhh.UsuarioActual = _usuario?.Nombre;
            rrhh.ShowDialog();
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
                    e.Cancel = true;
                }
                else
                {
                    this.FormClosing -= frmMain_FormClosing;

                    frmLogin login = new frmLogin();
                    login.Show();
                }
            }
        }

        private void txtBuscarUsuario_Enter(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Text == "Buscar usuario...")
            {
                txtBuscarUsuario.Text = "";
                txtBuscarUsuario.ForeColor = System.Drawing.Color.White;
            }
        }

        private void txtBuscarUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarUsuario.Text))
            {
                txtBuscarUsuario.Text = "Buscar usuario...";
                txtBuscarUsuario.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.DataSource is DataView dv)
            {
                if (txtBuscarUsuario.Text == "Buscar usuario..." || string.IsNullOrWhiteSpace(txtBuscarUsuario.Text))
                    dv.RowFilter = "";
                else
                    dv.RowFilter = string.Format("CONVERT(Nombre, System.String) LIKE '%{0}%' OR CONVERT(Apellido, System.String) LIKE '%{0}%' OR CONVERT(Mail, System.String) LIKE '%{0}%'", txtBuscarUsuario.Text.Replace("'", "''"));
            }
        }

        private void CargarDashboard()
        {
            clsConexion conexion = new clsConexion();
            lblDashboardTotalValor.Text = conexion.ContarUsuarios().ToString();
            lblDashboardActivosValor.Text = conexion.ContarUsuariosActivos().ToString();
            lblDashboardAccesosValor.Text = conexion.ContarAccesosHoy().ToString();
        }
    }
}
