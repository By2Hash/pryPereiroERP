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

        public string UsuarioActual
        {
            set { nombreUsuarioActual = value ?? "Admin_RRHH"; }
        }

        public frmRRHH()
        {
            InitializeComponent();
        }
        public frmRRHH(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            CargarPerfiles();
        }

        private void frmRRHH_Load(object sender, EventArgs e)
        {
            CargarProvincias();
            CargarLocalidades();

            if (_idUsuario != -1) // Modo edición
            {
                this.Text = "Modificar Usuario";
                btnCargar.Text = "Actualizar";
                CargarDatosUsuario();
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

                txtDireccion.Text = row["Dirección"] != DBNull.Value ? row["Dirección"].ToString().Trim() : "";
                txtGPS.Text = row["GPS"] != DBNull.Value ? row["GPS"].ToString().Trim() : "";
                mskTelefono.Text = row["Telefono"] != DBNull.Value ? row["Telefono"].ToString().Trim() : "";

                if (row["Provincia"] != DBNull.Value)
                {
                    string val = row["Provincia"].ToString().Trim();
                    for (int i = 0; i < cmbProvincia.Items.Count; i++)
                    {
                        if (cmbProvincia.Items[i] is DataRowView drv &&
                            drv["Nombres"].ToString().Trim().Equals(val, StringComparison.OrdinalIgnoreCase))
                        {
                            cmbProvincia.SelectedIndex = i;
                            break;
                        }
                    }
                }

                if (row["Localidad"] != DBNull.Value)
                {
                    string val = row["Localidad"].ToString().Trim();
                    for (int i = 0; i < cmbLocalidad.Items.Count; i++)
                    {
                        if (cmbLocalidad.Items[i] is DataRowView drv &&
                            drv["Nombres"].ToString().Trim().Equals(val, StringComparison.OrdinalIgnoreCase))
                        {
                            cmbLocalidad.SelectedIndex = i;
                            break;
                        }
                    }
                }

                if (row["Redes_Sociales"] != DBNull.Value)
                {
                    string val = row["Redes_Sociales"].ToString().Trim();
                    for (int i = 0; i < cmbRedesSociales.Items.Count; i++)
                    {
                        if (cmbRedesSociales.Items[i].ToString().Trim().Equals(val, StringComparison.OrdinalIgnoreCase))
                        {
                            cmbRedesSociales.SelectedIndex = i;
                            break;
                        }
                    }
                }

                try
                {
                    clsConexion con = new clsConexion();
                    DataTable dtRel = con.ObtenerDatosTabla("Relacion-Usuario-Perfil");
                    DataRow[] rows = dtRel.Select("Id_Usuario=" + _idUsuario);
                    if (rows.Length > 0)
                    {
                        _idPerfil = Convert.ToInt32(rows[0]["Id_Perfil"]);
                        if (cmbPerfil.Items.Count > 0)
                            cmbPerfil.SelectedValue = _idPerfil;
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

        private void CargarPerfiles()
        {
            clsConexion conexion = new clsConexion();
            DataTable dt = conexion.ObtenerDatosTabla("Perfil");
            cmbPerfil.DataSource = dt;
            cmbPerfil.DisplayMember = "Nombre_Perfil";
            cmbPerfil.ValueMember = "Id_Perfil";
            if (_idPerfil > 0)
                cmbPerfil.SelectedValue = _idPerfil;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("DNI, Apellido, Nombre, Contraseña y Mail son obligatorios.",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string provincia = cmbProvincia.SelectedIndex >= 0 ? cmbProvincia.Text : "";
            string localidad = cmbLocalidad.SelectedIndex >= 0 ? cmbLocalidad.Text : "";
            string redes = cmbRedesSociales.SelectedIndex >= 0 ? cmbRedesSociales.Text : "";

            clsConexion conexion = new clsConexion();
            bool resultado;

            if (_idUsuario == -1) // INSERTAR
            {
                resultado = conexion.InsertarUsuario(
                    txtNombre.Text.Trim(), txtApellido.Text.Trim(),
                    txtMail.Text.Trim(), txtContraseña.Text.Trim(),
                    chkActivar.Checked, txtDNI.Text.Trim(),
                    txtDireccion.Text.Trim(), txtGPS.Text.Trim(),
                    provincia, localidad,
                    mskTelefono.Text.Trim(), redes,
                    (int)cmbPerfil.SelectedValue);

                if (resultado)
                {
                    MessageBox.Show("Usuario ingresado correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.RegistrarAuditoria(nombreUsuarioActual,
                                                "Registro Usuario: " + txtNombre.Text.Trim(), this.Name);
                    LimpiarFormulario();
                }
            }
            else // ACTUALIZAR
            {
                resultado = conexion.ActualizarUsuario(
                    _idUsuario,
                    txtNombre.Text.Trim(), txtApellido.Text.Trim(),
                    txtMail.Text.Trim(), txtContraseña.Text.Trim(),
                    chkActivar.Checked, txtDNI.Text.Trim(),
                    txtDireccion.Text.Trim(), txtGPS.Text.Trim(),
                    provincia, localidad,
                    mskTelefono.Text.Trim(), redes,
                    (int)cmbPerfil.SelectedValue);

                if (resultado)
                {
                    MessageBox.Show("Usuario actualizado correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.RegistrarAuditoria(nombreUsuarioActual,
                                                "Modificó Usuario: " + txtNombre.Text.Trim(), this.Name);
                    this.Close();
                }
            }

            if (!resultado)
            {
                MessageBox.Show("Error: " + conexion.GetError(),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
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
            cmbRedesSociales.SelectedIndex = -1;
            chkActivar.Checked = false;
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
    }
}