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
        public frmRRHH()
        {
            InitializeComponent();
            CargarProvincias();
        }

        private void CargarProvincias()
        {
            clsConexion conexion = new clsConexion();
            DataTable dt = conexion.ObtenerProvincias();

            cmbProvincia.DataSource = dt;
            cmbProvincia.DisplayMember = "Nombre";      // lo que ve el usuario
            cmbProvincia.ValueMember = "Id"; // valor interno
            cmbProvincia.SelectedIndex = -1;             // sin selección inicial
        }

        private void chkActivar_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void frmRRHH_Load(object sender, EventArgs e)
        {

        }
    }
}
