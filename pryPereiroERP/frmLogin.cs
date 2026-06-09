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
                String.IsNullOrWhiteSpace(txtContraseña.Text) 
               )
            {
                intentos--;
                MessageBox.Show("Debe completar todos los campos (Nombre/Mail y Contraseña ).\n" +
                                "Intentos restantes: " + intentos,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              
                clsConexion conexion = new clsConexion();
                clsUsuario usuario = conexion.ValidarUsuario(txtNombre.Text, txtContraseña.Text);

                if (usuario != null)
                {
                    MessageBox.Show("¡Bienvenido, " + usuario.Nombre + "!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // --- AQUÍ HACEMOS LA REDIRECCIÓN SEGÚN EL ROL ---
                    if (usuario.Rol == "RRHH")
                    {
                        frmRRHH formularioRRHH = new frmRRHH();
                        formularioRRHH.UsuarioActual = usuario.Nombre;
                        formularioRRHH.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Si es Administrador o cualquier otro perfil, va al menú principal normal
                        frmMain formularioPrincipal = new frmMain(usuario);
                       
                        formularioPrincipal.Show();
                        this.Hide();

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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los perfiles: " + ex.Message);
            }
        }

        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlIniciarSesion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void optMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void optMostrarContra_Click(object sender, EventArgs e)
        {
           
        }

        private void chkMostrarOcultar_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMostrarOcultar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
    }
}