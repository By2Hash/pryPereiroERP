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
                    cmbProvincia.SelectedIndex = -1; // Arranca vacío sin selección
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
                DataTable dt = conexion.ObtenerLocalidades(); // Llama al nuevo método sin filtros

                if (dt != null && dt.Rows.Count > 0)
                {
                    cmbLocalidad.DataSource = dt;
                    cmbLocalidad.DisplayMember = "Nombres";
                    cmbLocalidad.ValueMember = "Id_Localidad";
                    cmbLocalidad.SelectedIndex = -1; // Arranca vacío sin selección
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
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
