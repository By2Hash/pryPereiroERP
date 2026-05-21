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
                String.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                intentos--;
                MessageBox.Show("Debe completar usuario y contraseña. " +
                                "Intentos restantes: " + intentos,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clsConexion conexion = new clsConexion();
                clsUsuario usuario = conexion.ValidarUsuario(txtNombre.Text, txtContraseña.Text);

                if (usuario != null)
                {
                    frmMain principal = new frmMain(usuario);  // le pasamos el usuario
                    principal.Show();
                    
                    return;
                }
                else
                {
                    intentos--;
                    MessageBox.Show("Datos incorrectos. Intentos restantes: " + intentos,
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (intentos == 0)
            {
                MessageBox.Show("Intentos agotados. La aplicación se cerrará.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
