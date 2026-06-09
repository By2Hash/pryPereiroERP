using System;
using System.Windows.Forms;

namespace pryPereiroERP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        int intentos = 3;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text) ||
                String.IsNullOrWhiteSpace(txtContraseña.Text)
               )
            {
                intentos--;
                MessageBox.Show("Debe completar todos los campos \n(Nombre/Mail y Contraseña )\n" +
                                "Intentos restantes: " + intentos,
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                clsConexion conexion = new clsConexion();
                clsUsuario usuario = conexion.ValidarUsuario(txtNombre.Text, txtContraseña.Text);

                if (usuario != null)
                {
                    MessageBox.Show("¡Bienvenido, " + usuario.Nombre + "!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // --- AQUÍ HACEMOS LA REDIRECCIÓN SEGÚN EL ROL ---
                    frmMain formularioPrincipal = new frmMain(usuario);

                    formularioPrincipal.Show();
                    this.Hide();
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

        private void chkMostrarOcultar_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !chkMostrarOcultar.Checked;
        }
    }
}
