using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPereiroERP
{
        internal class clsConexion
        {
            private OleDbConnection CNN;
            private DataSet DS;
            private string ERROR = "";

            private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Pereiro.db1.accdb";

            public clsConexion()
            {
                CNN = new OleDbConnection();
                DS = new DataSet();

            }

        public bool ProbarConexion()
        {
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();
                CNN.Close();
                ERROR = "";
                return true;
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
                return false;
            }
        }

        // Para que el Form pueda leer el mensaje de error
        public string GetError()
        {
            return ERROR;
        }

        public clsUsuario ValidarUsuario(String nombre, String contraseña)
        {
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                string query = "SELECT Nombre, Apellido FROM Usuarios " +
                                "WHERE Nombre = @nombre AND Contraseña = @contra";

                OleDbCommand cmd = new OleDbCommand(query, CNN);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@contra", contraseña);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    clsUsuario usuario = new clsUsuario();
                    usuario.Nombre = reader["Nombre"].ToString();
                    usuario.Apellido = reader["Apellido"].ToString();
                    usuario.HoraConexion = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");

                    CNN.Close();
                    return usuario;
                }

                CNN.Close();
                ERROR = "Usuario o contraseña incorrectos.";
                return null;


            }
            catch(Exception ex)
            {
                ERROR = ex.Message;
                return null;
            }
        }




    }

     

    }