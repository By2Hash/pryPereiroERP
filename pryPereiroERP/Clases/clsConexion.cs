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
                cmd1.Parameters.AddWithValue("?", nombre);
                cmd1.Parameters.AddWithValue("?", contraseña);

                OleDbDataReader reader1 = cmd1.ExecuteReader();

                if (!reader1.Read())
                {
                    reader1.Close();

                    // 🔴 LLAMADO EXTRA: Registramos que hubo un intento con contraseña incorrecta
                    RegistrarAuditoria(nombre, "Fallido");

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
                reader2.Close();

                // 🟢 LLAMADO EXTRA: El usuario ingresó bien, registramos el éxito
                RegistrarAuditoria(nombre, "Exitoso");

                CNN.Close();
                return usuario;
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
                if (CNN.State == System.Data.ConnectionState.Open)
                    CNN.Close();
                return null;
            }
        }

        //Metodo Registrar Auditoria
        public void RegistrarAuditoria(string usuario, string estado)
        {
            try
            {
                // Si por alguna razón la conexión se cerró, la volvemos a abrir
                if (CNN.State == System.Data.ConnectionState.Closed)
                {
                    CNN.ConnectionString = cadenaConexion;
                    CNN.Open();
                }

                // Usamos corchetes porque el nombre de la tabla tiene un guion medio
                string query = "INSERT INTO [Auditoria-Sesion] (Usuario, FechaHora, Estado) VALUES (?, ?, ?)";

                using (OleDbCommand cmd = new OleDbCommand(query, CNN))
                {
                    cmd.Parameters.AddWithValue("p1", usuario);
                    cmd.Parameters.AddWithValue("p2", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    cmd.Parameters.AddWithValue("p3", estado);

                    cmd.ExecuteNonQuery(); // Ejecuta el guardado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Fallo en Auditoría");
                ERROR = "Error en auditoría: " + ex.Message;
                }
            }

        public int ContadorDeInicioSesion(string usuario)
        {
            int cantidad = 0;
            try
            {
                if (CNN.State == System.Data.ConnectionState.Closed)
                {
                    CNN.ConnectionString = cadenaConexion;
                    CNN.Open();
                }

                string query = "SELECT COUNT(*) FROM [Auditoria-Sesion] WHERE Usuario = ? AND Estado = 'Exitoso'";

                using (OleDbCommand cmd = new OleDbCommand(query, CNN))
                {
                    cmd.Parameters.AddWithValue("?", usuario);
                    cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
            }
            return cantidad;
        }

        public DataTable ObtenerProvincias()
        {
            DataTable dt = new DataTable();
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                string query = "SELECT Id_Provincia, Nombres FROM Provincias ORDER BY Nombres";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, CNN);
                adapter.Fill(dt);

                CNN.Close();
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
            }
            return dt;
        }


        public DataTable ObtenerLocalidades()
        {
            DataTable dt = new DataTable();
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                string query = "SELECT Id_Localidad, Nombres FROM Localidades ORDER BY Nombres";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, CNN);
                adapter.Fill(dt);

                CNN.Close();
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
            }
            return dt;
        }


        public DataTable ObtenerPerfil()
        {
            DataTable dt = new DataTable();
            try
            {
                // Seguridad: Si la conexión quedó abierta por otro proceso, la cerramos antes de reusarla
                if (CNN.State == System.Data.ConnectionState.Open)
                {
                    CNN.Close();
                }

                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                string query = "SELECT [Id_Perfil], [Nombre] FROM [Perfil] ORDER BY [Nombre]";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, CNN);
                adapter.Fill(dt);

                CNN.Close();
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
                // Si falló a mitad de camino, nos aseguramos de no dejar la base de datos colgada
                if (CNN.State == System.Data.ConnectionState.Open)
                {
                    CNN.Close();
                }
            }

            return dt; // ◄ Siempre al final de todo
        }

    }
}