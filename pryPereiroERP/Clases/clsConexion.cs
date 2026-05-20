using System;
using System.Data;
using System.Data.OleDb;
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

        public string GetError()
        {
            return ERROR;
        }

        public clsUsuario ValidarUsuario(string nombre, string contraseña)
        {
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                // PASO 1: Validar usuario y obtener su Id_Usuario
                string query1 = "SELECT Id_Usuario, Nombre, Apellido FROM Usuarios " +
                                "WHERE Nombre = ? AND Contraseña = ?";

                OleDbCommand cmd1 = new OleDbCommand(query1, CNN);

                // En OleDb con Access, el nombre del parámetro NO importa ("p1", "p2"), 
                // pero SIEMPRE deben agregarse en el mismo orden exacto en el que aparecen los "?" en el query.
                cmd1.Parameters.AddWithValue("?", nombre);
                cmd1.Parameters.AddWithValue("?", contraseña);

                OleDbDataReader reader1 = cmd1.ExecuteReader();

                if (!reader1.Read())
                {
                    reader1.Close();
                    CNN.Close();
                    ERROR = "Usuario o contraseña incorrectos.";
                    return null;
                }

                // Guardamos los datos del usuario si las credenciales son correctas
                clsUsuario usuario = new clsUsuario();
                usuario.Nombre = reader1["Nombre"].ToString();
                usuario.Apellido = reader1["Apellido"].ToString();
                usuario.HoraConexion = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
                int idUsuario = Convert.ToInt32(reader1["Id_Usuario"]);
                reader1.Close();

                // PASO 2: Buscar el perfil usando el Id_Usuario obtenido
                string query2 = "SELECT p.Nombre FROM Perfil AS p " +
                                "INNER JOIN [Relacion-Usuario-Perfil] AS r ON p.Id_Perfil = r.Id_Perfil " +
                                "WHERE r.Id_Usuario = ?";

                OleDbCommand cmd2 = new OleDbCommand(query2, CNN);

                // Usamos el "?" para mapear correctamente el parámetro posicional de OleDb
                cmd2.Parameters.AddWithValue("?", idUsuario);

                OleDbDataReader reader2 = cmd2.ExecuteReader();

                if (reader2.Read())
                {
                    usuario.Rol = reader2["Nombre"].ToString();
                }
                else
                {
                    usuario.Rol = "Sin perfil";
                }

                // Cerramos todos los recursos abiertos antes de retornar
                reader2.Close();
                CNN.Close();
                return usuario;
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
                if (CNN.State == System.Data.ConnectionState.Open)
                {
                    CNN.Close();
                }
                return null;
            }
        }
    }
}