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
            CargarPerfiles();
            

        }

        int intentos = 3;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Si falta cualquier campo, descontamos intento
            if (String.IsNullOrWhiteSpace(txtNombre.Text) ||
                String.IsNullOrWhiteSpace(txtContraseña.Text) ||
                cmbPerfil.SelectedIndex == -1)
            {
                intentos--;
                MessageBox.Show("Debe completar todos los campos (Nombre, Contraseña y Perfil).\n" +
                                "Intentos restantes: " + intentos,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string perfilSeleccionado = cmbPerfil.Text;

                clsConexion conexion = new clsConexion();
                clsUsuario usuario = conexion.ValidarUsuario(txtNombre.Text, txtContraseña.Text, perfilSeleccionado);

                if (usuario != null)
                {

                    txtNombre.Clear();
                    txtContraseña.Clear();
                    cmbPerfil.SelectedIndex = -1;

                    if (usuario.Rol == "RRHH")
                    {
                        frmRRHH rrhh = new frmRRHH();
                        rrhh.Show();
                        
                    }
                    else
                    {
                        frmMain principal = new frmMain(usuario);
                        principal.Show();
                        
                    }
                    return;
                }
                else
                {
                    intentos--;
                    MessageBox.Show(conexion.GetError() + "\nIntentos restantes: " + intentos,
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

                // 🔴 AGREGÁ ESTO TEMPORALMENTE: Si el método falló, te va a decir por qué
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
