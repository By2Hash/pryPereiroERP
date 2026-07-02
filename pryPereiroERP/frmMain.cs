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

            clsConexion conexion = new clsConexion();
            conexion.RegistrarAuditoria(_usuario.Nombre, "Navegacion", this.Name);

            radioDesc.Checked = true;

            CargarTablaEnGrilla("Auditoria-Sesion");
            CargarGrillaUsuarios();
        }

        private void CargarDatosUsuarioTab()
        {
            lblNombreValor.Text = _usuario.Nombre;
            lblApellidoValor.Text = _usuario.Apellido;
            lblRolValor.Text = _usuario.Rol;

            lblEmailValor.AutoSize = false;
            lblEmailValor.Width = 290;
            lblDireccionValor.AutoSize = false;
            lblDireccionValor.Width = 290;
            lblProvinciaValor.AutoSize = false;
            lblProvinciaValor.Width = 290;
            lblLocalidadValor.AutoSize = false;
            lblLocalidadValor.Width = 290;
            lblTelefonoValor.AutoSize = false;
            lblTelefonoValor.Width = 290;
            lblRedesValor.AutoSize = false;
            lblRedesValor.Width = 290;

            try
            {
                clsConexion conexion = new clsConexion();
                DataTable dt = conexion.ObtenerUsuarioPorId(_usuario.Id);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    lblEmailValor.Text = row["Mail"] != DBNull.Value ? row["Mail"].ToString().Trim() : "-";
                    lblDireccionValor.Text = row["Dirección"] != DBNull.Value ? row["Dirección"].ToString().Trim() : "-";
                    lblProvinciaValor.Text = row["Provincia"] != DBNull.Value ? row["Provincia"].ToString().Trim() : "-";
                    lblLocalidadValor.Text = row["Localidad"] != DBNull.Value ? row["Localidad"].ToString().Trim() : "-";
                    lblTelefonoValor.Text = row["Telefono"] != DBNull.Value ? row["Telefono"].ToString().Trim() : "-";
                    lblRedesValor.Text = row["Id_Redes_Sociales"] != DBNull.Value ? row["Id_Redes_Sociales"].ToString().Trim() : "-";
                }
                else
                {
                    lblEmailValor.Text = "-";
                    lblDireccionValor.Text = "-";
                    lblProvinciaValor.Text = "-";
                    lblLocalidadValor.Text = "-";
                    lblTelefonoValor.Text = "-";
                    lblRedesValor.Text = "-";
                }
            }
            catch
            {
                lblEmailValor.Text = "Error al cargar";
            }
        }

        private void VerificarConexion()
        {
            statusStrip1.Items.Clear();
            clsConexion conexion = new clsConexion();

            ToolStripStatusLabel lblIcono = new ToolStripStatusLabel(" ●");
            lblIcono.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblIcono.Alignment = ToolStripItemAlignment.Right;

            ToolStripStatusLabel lblTexto = new ToolStripStatusLabel();
            lblTexto.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTexto.ForeColor = Color.FromArgb(255, 219, 137);
            lblTexto.Alignment = ToolStripItemAlignment.Right;

            if (conexion.ProbarConexion())
            {
                lblIcono.ForeColor = Color.Lime;
                lblTexto.Text = " Base de datos conectada";
            }
            else
            {
                lblIcono.ForeColor = Color.Red;
                lblTexto.Text = " Sin conexión";
            }

            statusStrip1.Items.Add(lblIcono);
            statusStrip1.Items.Add(lblTexto);
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
                }
                dgvConsulta.DataSource = dt.DefaultView;

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

        private void radioOrden_CheckedChanged(object sender, EventArgs e)
        {
            CargarTablaEnGrilla("Auditoria-Sesion");
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
                if (dgvUsuarios.Columns["Contraseña"] != null) { dgvUsuarios.Columns["Contraseña"].HeaderText = "Contraseña"; dgvUsuarios.Columns["Contraseña"].Visible = false; }
                if (dgvUsuarios.Columns["Activo"] != null) dgvUsuarios.Columns["Activo"].HeaderText = "Activo";
                if (dgvUsuarios.Columns["Perfil"] != null) dgvUsuarios.Columns["Perfil"].HeaderText = "Perfil";
                if (dgvUsuarios.Columns["Dirección"] != null) dgvUsuarios.Columns["Dirección"].HeaderText = "Dirección";
                if (dgvUsuarios.Columns["Provincia"] != null) dgvUsuarios.Columns["Provincia"].HeaderText = "Provincia";
                if (dgvUsuarios.Columns["Localidad"] != null) dgvUsuarios.Columns["Localidad"].HeaderText = "Localidad";
                if (dgvUsuarios.Columns["Telefono"] != null) dgvUsuarios.Columns["Telefono"].HeaderText = "Teléfono";
                if (dgvUsuarios.Columns["Redes"] != null) dgvUsuarios.Columns["Redes"].HeaderText = "Redes Sociales";
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
            CargarGrillaUsuarios();
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

        private void txtFiltro_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            if (txt.Text == "Buscar usuario...")
            {
                txt.Text = "";
                txt.ForeColor = System.Drawing.Color.White;
            }
        }

        private void txtFiltro_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = "Buscar usuario...";
                txt.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarTablaEnGrilla("Auditoria-Sesion");

            if (dgvConsulta.DataSource is DataView dv)
            {
                string filtros = "";

                string usuario = txtFiltroUsuario.Text;
                if (usuario != "Buscar usuario..." && !string.IsNullOrWhiteSpace(usuario))
                {
                    filtros += string.Format("CONVERT(Usuario, System.String) LIKE '%{0}%'", usuario.Replace("'", "''"));
                }

                if (dtpFiltroFechaDesde.Checked && dtpFiltroFechaHasta.Checked)
                {
                    if (dtpFiltroFechaDesde.Value > dtpFiltroFechaHasta.Value)
                    {
                        MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.", "Fechas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (dtpFiltroFechaDesde.Checked)
                {
                    if (filtros.Length > 0) filtros += " AND ";
                    filtros += string.Format("FechaHora >= #{0}#", dtpFiltroFechaDesde.Value.Date.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture));
                }

                if (dtpFiltroFechaHasta.Checked)
                {
                    if (filtros.Length > 0) filtros += " AND ";
                    filtros += string.Format("FechaHora <= #{0}#", dtpFiltroFechaHasta.Value.Date.AddDays(1).ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture));
                }

                // Filtro por Estado (si se seleccionó alguno)
                if (cmbEstado != null && cmbEstado.SelectedItem != null)
                {
                    string estado = cmbEstado.SelectedItem.ToString();
                    if (!string.IsNullOrWhiteSpace(estado))
                    {
                        if (filtros.Length > 0) filtros += " AND ";
                        // RowFilter usa comillas simples para cadenas
                        filtros += string.Format("Estado = '{0}'", estado.Replace("'", "''"));
                    }
                }

                dv.RowFilter = filtros;

                string orden = radioAsc.Checked ? " ASC" : " DESC";
                string colOrden = ObtenerColumnaOrden("Auditoria-Sesion", dv.Table);
                if (!string.IsNullOrEmpty(colOrden))
                    dv.Sort = colOrden + orden;

                lblResultados.Text = dv.Count + " registros encontrados";
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtFiltroUsuario.Text = "Buscar usuario...";
            txtFiltroUsuario.ForeColor = System.Drawing.Color.Gray;
            dtpFiltroFechaDesde.Checked = false;
            dtpFiltroFechaHasta.Checked = false;

            CargarTablaEnGrilla("Auditoria-Sesion");
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
