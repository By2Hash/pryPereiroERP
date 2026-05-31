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

        public frmRRHH()
        {
            InitializeComponent();
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

        private void frmRRHH_Load(object sender, EventArgs e)
        {
            CargarProvincias();
            CargarLocalidades();

            // Guarda el historial de navegación para este formulario
            clsConexion conexion = new clsConexion();
            conexion.RegistrarAuditoria(nombreUsuarioActual, "Navegacion", this.Name);
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

            string contraseñaGenerada = txtNombre.Text.ToLower() + txtDNI.Text;

            clsConexion conexion = new clsConexion();
            bool resultado = conexion.InsertarUsuario(
                nombre: txtNombre.Text.Trim(),
                apellido: txtApellido.Text.Trim(),
                mail: txtMail.Text.Trim(),
                contraseña: txtContraseña.Text.Trim(),
                activo: chkActivar.Checked,
                dni: txtDNI.Text.Trim(),
                direccion: txtDireccion.Text.Trim(),
                gps: txtGPS.Text.Trim(),
                provincia: provincia,
                localidad: localidad,
                telefono: mskTelefono.Text.Trim(),
                redesSociales: redes
            );

            if (resultado)
            {
                MessageBox.Show("Usuario ingresado correctamente.\nContraseña generada: " + contraseñaGenerada,
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Registra en auditoría que este administrador creó un usuario exitosamente desde este form
                conexion.RegistrarAuditoria(nombreUsuarioActual, "Registro Usuario: " + txtNombre.Text.Trim(), this.Name);

                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Error al guardar: " + conexion.GetError(),
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
    }
}