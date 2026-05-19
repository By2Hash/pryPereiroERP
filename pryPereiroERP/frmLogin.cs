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
                    MessageBox.Show("Debe ingresar un nombre de usuario y una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos--;
                }
            
            if (intentos == 0)
            {
                MessageBox.Show("Número de intentos agotados. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
