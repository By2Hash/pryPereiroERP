using System;
using System.Data;
using System.Windows.Forms;

namespace pryPereiroERP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            CargarPerfiles();
        }

        int intentos = 3;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text) ||
                String.IsNullOrWhiteSpace(txtContraseña.Text) ||
                cmbPerfil.SelectedIndex == -1)
            {
                intentos--;
                MessageBox.Show("Debe completar todos los campos (Nombre, Contraseña y Perfil).\n" +
                                "Intentos restantes: " + intentos,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string perfilSeleccionado = cmbPerfil.Text;
                clsConexion conexion = new clsConexion();
                clsUsuario usuario = conexion.ValidarUsuario(txtNombre.Text, txtContraseña.Text, perfilSeleccionado);

                if (usuario != null)
                {
                    MessageBox.Show("¡Bienvenido, " + usuario.Nombre + "!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // --- AQUÍ HACEMOS LA REDIRECCIÓN SEGÚN EL ROL ---
                    if (usuario.Rol == "RRHH")
                    {
                        // Si el perfil validado es RRHH, instanciamos y abrimos su ventana específica
                        frmRRHH formularioRRHH = new frmRRHH();
                        this.Hide();
                        formularioRRHH.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        // Si es Administrador o cualquier otro perfil, va al menú principal normal
                        frmMain formularioPrincipal = new frmMain(usuario);
                        this.Hide();
                        formularioPrincipal.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    intentos--;
                    MessageBox.Show(conexion.GetError() + "\nIntentos restantes: " + intentos, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (intentos == 0)
            {
                MessageBox.Show("Intentos agotados. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
        }

        public void CargarPerfiles()
        {
            try
            {
                clsConexion conexion = new clsConexion();
                DataTable dt = conexion.ObtenerPerfil();

                if (!string.IsNullOrEmpty(conexion.GetError()))
                {
                    MessageBox.Show("Error interno de la base de datos: " + conexion.GetError());
                    return;
                }

                if (dt != null && dt.Rows.Count > 0)
                {
                    cmbPerfil.DataSource = dt;
                    cmbPerfil.DisplayMember = "Nombre";
                    cmbPerfil.ValueMember = "Id_Perfil";
                    cmbPerfil.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los perfiles: " + ex.Message);
            }
        }
    }
}