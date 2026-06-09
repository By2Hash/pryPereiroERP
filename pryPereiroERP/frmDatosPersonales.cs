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
        // Se declara la variable para identificar quién está usando este formulario de carga
        private string nombreUsuarioActual = "Admin_RRHH";

        private int _idUsuario = -1;

        public frmRRHH()
        {
            InitializeComponent();
        }
        public frmRRHH(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;

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

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // 1. Datos Principales (Tabla Usuarios)
                    txtNombre.Text = row["Nombre"] != DBNull.Value ? row["Nombre"].ToString().Trim() : "";
                    txtApellido.Text = row["Apellido"] != DBNull.Value ? row["Apellido"].ToString().Trim() : "";
                    txtMail.Text = row["Mail"] != DBNull.Value ? row["Mail"].ToString().Trim() : "";
                    txtContraseña.Text = row["Contraseña"] != DBNull.Value ? row["Contraseña"].ToString().Trim() : "";
                    txtDNI.Text = row["DNI"] != DBNull.Value ? row["DNI"].ToString().Trim() : "";
                    chkActivar.Checked = row["Activo"] != DBNull.Value && Convert.ToBoolean(row["Activo"]);

                    // 2. Datos de Domicilio (Validando nulos de Access)
                    txtDireccion.Text = row["Dirección"] != DBNull.Value ? row["Dirección"].ToString().Trim() : "";
                    txtGPS.Text = row["GPS"] != DBNull.Value ? row["GPS"].ToString().Trim() : "";

                    // 3. Datos de Contacto (Validando nulos de Access)
                    mskTelefono.Text = row["Telefono"] != DBNull.Value ? row["Telefono"].ToString().Trim() : "";

                    // 4. Posicionar ComboBox de Provincia inteligentemente
                    if (row["Provincia"] != DBNull.Value)
                    {
                        string provinciaBuscada = row["Provincia"].ToString().Trim();
                        for (int i = 0; i < cmbProvincia.Items.Count; i++)
                        {
                            // Como tus combos se llenan de BD, leemos el DataRowView interno
                            if (cmbProvincia.Items[i] is DataRowView drv)
                            {
                                // Buscamos en la columna "Nombres" o la columna de texto de tu consulta de Provincias
                                if (drv["Nombres"].ToString().Trim().Equals(provinciaBuscada, StringComparison.OrdinalIgnoreCase))
                                {
                                    cmbProvincia.SelectedIndex = i;
                                    break;
                                }
                            }
                        }
                    }

                    // 5. Posicionar ComboBox de Localidad inteligentemente
                    if (row["Localidad"] != DBNull.Value)
                    {
                        string localidadBuscada = row["Localidad"].ToString().Trim();
                        for (int i = 0; i < cmbLocalidad.Items.Count; i++)
                        {
                            if (cmbLocalidad.Items[i] is DataRowView drv)
                            {
                                if (drv["Nombres"].ToString().Trim().Equals(localidadBuscada, StringComparison.OrdinalIgnoreCase))
                                {
                                    cmbLocalidad.SelectedIndex = i;
                                    break;
                                }
                            }
                        }
                    }

                    // 6. Posicionar ComboBox de Redes Sociales (comboBox4)
                    if (row["Redes_Sociales"] != DBNull.Value)
                    {
                        string redBuscada = row["Redes_Sociales"].ToString().Trim();
                        for (int i = 0; i < comboBox4.Items.Count; i++)
                        {
                            if (comboBox4.Items[i].ToString().Trim().Equals(redBuscada, StringComparison.OrdinalIgnoreCase))
                            {
                                comboBox4.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }
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

        private void chkActivar_CheckedChanged(object sender, EventArgs e)
        {
        }

       

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            string redes = comboBox4.SelectedIndex >= 0 ? comboBox4.Text : "";

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
                    mskTelefono.Text.Trim(), redes);

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
                    mskTelefono.Text.Trim(), redes);

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
            comboBox4.SelectedIndex = -1;
            chkActivar.Checked = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRRHH_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}