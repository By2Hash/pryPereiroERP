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
    public partial class frmRRHH : Form
    {
        private string nombreUsuarioActual = "Admin_RRHH";
        private int _idUsuario = -1;
        private int _idPerfil = -1;
        private ErrorProvider errorProvider;
        private const string PLACEHOLDER_RED = "Ingresá el usuario o URL de esta red";

        public string UsuarioActual
        {
            set { nombreUsuarioActual = value ?? "Admin_RRHH"; }
        }

        public frmRRHH()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            InicializarPlaceholderRed();
        }
        public frmRRHH(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            errorProvider = new ErrorProvider();
            InicializarPlaceholderRed();
        }

        private void InicializarPlaceholderRed()
        {
            txtUrlRed.Text = PLACEHOLDER_RED;
            txtUrlRed.ForeColor = Color.FromArgb(120, 120, 120);
        }

        private void frmRRHH_Load(object sender, EventArgs e)
        {
            CargarProvincias();
            CargarLocalidades();

            if (_idUsuario != -1) // Modo edición
            {
                this.Text = "Modificar Usuario";
                btnCargar.Text = "Actualizar";
                btnEliminar.Visible = true;
                CargarDatosUsuario();
            }
            else
            {
                btnEliminar.Visible = false;
            }
            clsConexion conexion = new clsConexion();
            conexion.RegistrarAuditoria(nombreUsuarioActual, "Navegacion", this.Name);
        }

        private void CargarDatosUsuario()
        {
            try
            {
                clsConexion conexion = new clsConexion();
                DataTable dt = conexion.ObtenerUsuarioPorId(_idUsuario);

                if (dt == null || dt.Rows.Count == 0) return;

                DataRow row = dt.Rows[0];

                txtNombre.Text = row["Nombre"] != DBNull.Value ? row["Nombre"].ToString().Trim() : "";
                txtApellido.Text = row["Apellido"] != DBNull.Value ? row["Apellido"].ToString().Trim() : "";
                txtMail.Text = row["Mail"] != DBNull.Value ? row["Mail"].ToString().Trim() : "";
                txtContraseña.Text = row["Contraseña"] != DBNull.Value ? row["Contraseña"].ToString().Trim() : "";
                txtDNI.Text = row["DNI"] != DBNull.Value ? row["DNI"].ToString().Trim() : "";
                chkActivar.Checked = row["Activo"] != DBNull.Value && Convert.ToBoolean(row["Activo"]);

                txtGPS.Text = row["GPS"] != DBNull.Value ? row["GPS"].ToString().Trim() : "";
                mskTelefono.Text = row["Telefono"] != DBNull.Value ? row["Telefono"].ToString().Trim() : "";

                UsuarioController controller = new UsuarioController();
                var datos = controller.CargarDireccionesYRedes(_idUsuario);

                lstDirecciones.Items.Clear();
                foreach (var d in datos.Direcciones)
                    lstDirecciones.Items.Add(d);

                lstRedesSociales.Items.Clear();
                foreach (var r in datos.Redes)
                    lstRedesSociales.Items.Add(r);

                try
                {
                    clsConexion con = new clsConexion();
                    DataTable dtRel = con.ObtenerDatosTabla("Relacion-Usuario-Perfil");
                    DataRow[] rows = dtRel.Select("Id_Usuario=" + _idUsuario);
                    if (rows.Length > 0)
                    {
                        _idPerfil = Convert.ToInt32(rows[0]["Id_Perfil"]);
                        string nombrePerfil = ObtenerNombrePerfil(_idPerfil);
                        for (int i = 0; i < cmbTipoPerfil.Items.Count; i++)
                        {
                            if (cmbTipoPerfil.Items[i].ToString().Equals(nombrePerfil, StringComparison.OrdinalIgnoreCase))
                            {
                                cmbTipoPerfil.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }
                catch { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las cajas de texto de edición: " + ex.Message,
                                "Error de Mapeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProvincias()
        {
            try
            {
                clsConexion conexion = new clsConexion();
                DataTable dt = conexion.ObtenerProvincias();

                if (dt != null && dt.Rows.Count > 0)
                {
                    cmbProvincia.DataSource = dt;
                    cmbProvincia.DisplayMember = "Nombres";
                    cmbProvincia.ValueMember = "Id_Provincia";
                    cmbProvincia.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar provincias: " + ex.Message);
            }
        }

        private void CargarLocalidades()
        {
            try
            {
                clsConexion conexion = new clsConexion();
                DataTable dt = conexion.ObtenerLocalidades();

                if (dt != null && dt.Rows.Count > 0)
                {
                    cmbLocalidad.DataSource = dt;
                    cmbLocalidad.DisplayMember = "Nombres";
                    cmbLocalidad.ValueMember = "Id_Localidad";
                    cmbLocalidad.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar localidades: " + ex.Message);
            }
        }

        private string ObtenerNombrePerfil(int idPerfil)
        {
            clsConexion con = new clsConexion();
            DataTable dt = con.ObtenerDatosTabla("Perfil");
            DataRow[] rows = dt.Select("Id_Perfil=" + idPerfil);
            return rows.Length > 0 ? rows[0]["Nombre"].ToString() : "";
        }

        private int ObtenerIdPerfilPorNombre(string nombre)
        {
            clsConexion con = new clsConexion();
            DataTable dt = con.ObtenerDatosTabla("Perfil");
            foreach (DataRow row in dt.Rows)
            {
                if (row["Nombre"].ToString().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    return Convert.ToInt32(row["Id_Perfil"]);
            }
            return -1;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            { errorProvider.SetError(txtDNI, "DNI requerido"); valido = false; }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            { errorProvider.SetError(txtApellido, "Apellido requerido"); valido = false; }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { errorProvider.SetError(txtNombre, "Nombre requerido"); valido = false; }
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            { errorProvider.SetError(txtMail, "Mail requerido"); valido = false; }
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            { errorProvider.SetError(txtContraseña, "Contraseña requerida"); valido = false; }

            if (lstDirecciones.Items.Count == 0)
            {
                errorProvider.SetError(lstDirecciones, "Debe agregar al menos una dirección");
                valido = false;
            }

            int idPerfil = ObtenerIdPerfilPorNombre(cmbTipoPerfil.Text);
            if (idPerfil < 0)
            { errorProvider.SetError(cmbTipoPerfil, "Seleccione un Perfil válido"); valido = false; }

            if (!valido) return;

            var direcciones = lstDirecciones.Items.Cast<DireccionItem>().ToList();
            var redes = lstRedesSociales.Items.Cast<RedSocialItem>().ToList();

            UsuarioController controller = new UsuarioController();
            bool resultado = controller.GuardarUsuario(
                _idUsuario == -1 ? null : (int?)_idUsuario,
                txtNombre.Text.Trim(), txtApellido.Text.Trim(),
                txtMail.Text.Trim(), txtContraseña.Text.Trim(),
                chkActivar.Checked, txtDNI.Text.Trim(),
                direcciones,
                txtGPS.Text.Trim(),
                mskTelefono.Text.Trim(),
                redes,
                idPerfil);

            if (resultado)
            {
                string accion = _idUsuario == -1 ? "Registro" : "Modificó";
                MessageBox.Show("Usuario " + (_idUsuario == -1 ? "ingresado" : "actualizado") + " correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controller.RegistrarAuditoria(nombreUsuarioActual,
                    accion + " Usuario: " + txtNombre.Text.Trim(), this.Name);

                if (_idUsuario == -1)
                    LimpiarFormulario();
                else
                    this.Close();
            }
            else
            {
                MessageBox.Show("Error: " + controller.GetError(),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idUsuario < 0) return;

            DialogResult confirm = MessageBox.Show(
                "¿Está seguro de que desea eliminar al usuario " + txtNombre.Text.Trim() + " " + txtApellido.Text.Trim() + "?\n\nEsta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            clsConexion conexion = new clsConexion();
            if (conexion.EliminarUsuario(_idUsuario))
            {
                conexion.RegistrarAuditoria(nombreUsuarioActual,
                                            "Eliminó Usuario: " + txtNombre.Text.Trim(), this.Name);
                MessageBox.Show("Usuario eliminado correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar: " + conexion.GetError(),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            errorProvider.Clear();
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtMail.Clear();
            txtContraseña.Clear();
            txtDireccion.Clear();
            txtGPS.Clear();
            mskTelefono.Clear();
            cmbProvincia.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            cmbTipoPerfil.SelectedIndex = -1;
            chkActivar.Checked = false;
            lstDirecciones.Items.Clear();
            lstRedesSociales.Items.Clear();
            cmbTipoRed.SelectedIndex = -1;
            txtUrlRed.Clear();
        }

        private void frmRRHH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f is frmLogin)
                    {
                        f.Show();
                        break;
                    }
                }
            }
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            string dir = txtDireccion.Text.Trim();
            string prov = cmbProvincia.SelectedIndex >= 0 ? cmbProvincia.Text.Trim() : "";
            string loc = cmbLocalidad.SelectedIndex >= 0 ? cmbLocalidad.Text.Trim() : "";

            if (string.IsNullOrWhiteSpace(dir))
            { errorProvider.SetError(txtDireccion, "Ingrese la dirección"); return; }
            if (string.IsNullOrWhiteSpace(prov))
            { errorProvider.SetError(cmbProvincia, "Seleccione una provincia"); return; }
            if (string.IsNullOrWhiteSpace(loc))
            { errorProvider.SetError(cmbLocalidad, "Seleccione una localidad"); return; }

            lstDirecciones.Items.Add(new DireccionItem
            {
                Direccion = dir,
                Provincia = prov,
                Localidad = loc
            });

            txtDireccion.Clear();
            txtGPS.Clear();
            cmbProvincia.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            txtDireccion.Focus();
        }

        private void btnQuitarDireccion_Click(object sender, EventArgs e)
        {
            if (lstDirecciones.SelectedItem != null)
            {
                lstDirecciones.Items.Remove(lstDirecciones.SelectedItem);
                errorProvider.SetError(lstDirecciones, null);
            }
        }

        private void lstDirecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnQuitarDireccion.Enabled = lstDirecciones.SelectedItem != null;
        }

        private void btnAgregarRed_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            string tipo = cmbTipoRed.SelectedIndex >= 0 ? cmbTipoRed.Text.Trim() : "";
            string url = txtUrlRed.Text.Trim();
            if (url == PLACEHOLDER_RED) url = "";

            if (string.IsNullOrWhiteSpace(tipo))
            { errorProvider.SetError(cmbTipoRed, "Seleccione el tipo de red"); return; }
            if (string.IsNullOrWhiteSpace(url))
            { errorProvider.SetError(txtUrlRed, "Ingrese la URL o usuario"); return; }

            lstRedesSociales.Items.Add(new RedSocialItem
            {
                Tipo = tipo,
                Url = url
            });

            cmbTipoRed.SelectedIndex = -1;
            txtUrlRed.Clear();
            cmbTipoRed.Focus();
        }

        private void btnQuitarRed_Click(object sender, EventArgs e)
        {
            if (lstRedesSociales.SelectedItem != null)
                lstRedesSociales.Items.Remove(lstRedesSociales.SelectedItem);
        }

        private void lstRedesSociales_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnQuitarRed.Enabled = lstRedesSociales.SelectedItem != null;
        }

        private void cmbTipoPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtUrlRed_Enter(object sender, EventArgs e)
        {
            if (txtUrlRed.Text == PLACEHOLDER_RED)
            {
                txtUrlRed.Text = "";
                txtUrlRed.ForeColor = Color.FromArgb(210, 210, 210);
            }
        }

        private void txtUrlRed_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrlRed.Text))
            {
                txtUrlRed.Text = PLACEHOLDER_RED;
                txtUrlRed.ForeColor = Color.FromArgb(120, 120, 120);
            }
        }
    }
}
