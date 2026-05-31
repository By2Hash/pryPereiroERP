using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryPereiroERP
{
    internal class clsConexion
    {
        private OleDbConnection CNN;
        private string ERROR = "";
        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Pereiro.db1.accdb";

        public clsConexion()
        {
            CNN = new OleDbConnection();
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

        public clsUsuario ValidarUsuario(string nombre, string contraseña, string perfilSeleccionado)
        {
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                string query1 = "SELECT Id_Usuario, Nombre, Apellido, Mail, Activo FROM Usuarios " +
                                "WHERE (Nombre = ? OR Mail = ?) AND Contraseña = ? ";

                OleDbCommand cmd1 = new OleDbCommand(query1, CNN);
                cmd1.Parameters.AddWithValue("?", nombre);
                cmd1.Parameters.AddWithValue("?", nombre);
                cmd1.Parameters.AddWithValue("?", contraseña);

                OleDbDataReader reader1 = cmd1.ExecuteReader();

                if (!reader1.Read())
                {
                    reader1.Close();
                    CNN.Close();
                    RegistrarAuditoria(nombre, "Fallido", "frmLogin");
                    ERROR = "Usuario o contraseña incorrectos.";
                    return null;
                }

                bool estaActivo = Convert.ToBoolean(reader1["Activo"]);

                if (estaActivo == false)
                {
                    reader1.Close();
                    CNN.Close();
                    RegistrarAuditoria(nombre, "Fallido", "frmLogin");
                    ERROR = "El usuario está inactivo. Contacte al administrador.";
                    return null;
                }

                clsUsuario usuario = new clsUsuario();
                usuario.Nombre = reader1["Nombre"].ToString();
                usuario.Apellido = reader1["Apellido"].ToString();
                usuario.HoraConexion = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
                int idUsuario = Convert.ToInt32(reader1["Id_Usuario"]);
                reader1.Close();

                string query2 = "SELECT p.Nombre FROM Perfil AS p " +
                                "INNER JOIN [Relacion-Usuario-Perfil] AS r ON p.Id_Perfil = r.Id_Perfil " +
                                "WHERE r.Id_Usuario = ?";

                OleDbCommand cmd2 = new OleDbCommand(query2, CNN);
                cmd2.Parameters.AddWithValue("?", idUsuario);

                OleDbDataReader reader2 = cmd2.ExecuteReader();

                if (reader2.Read())
                {
                    string perfilReal = reader2["Nombre"].ToString();
                    reader2.Close();

                    if (perfilReal != perfilSeleccionado)
                    {
                        CNN.Close();
                        RegistrarAuditoria(nombre, "Fallido", "frmLogin");
                        ERROR = "El perfil seleccionado no corresponde a este usuario.";
                        return null;
                    }

                    usuario.Rol = perfilReal;
                }
                else
                {
                    reader2.Close();
                    usuario.Rol = "Sin perfil";
                }

                CNN.Close();
                RegistrarAuditoria(nombre, "Exitoso", "frmLogin");
                return usuario;
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
                if (CNN.State == ConnectionState.Open)
                    CNN.Close();
                return null;
            }
        }

        public void RegistrarAuditoria(string usuario, string estado, string historial)
        {
            try
            {
                if (CNN.State == System.Data.ConnectionState.Closed)
                {
                    CNN.ConnectionString = cadenaConexion;
                    CNN.Open();
                }

                string query = "INSERT INTO [Auditoria-Sesion] (Usuario, FechaHora, Estado, Historial) VALUES (?, ?, ?, ?)";

                using (OleDbCommand cmd = new OleDbCommand(query, CNN))
                {
                    cmd.Parameters.AddWithValue("p1", usuario);
                    cmd.Parameters.AddWithValue("p2", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    cmd.Parameters.AddWithValue("p3", estado);
                    cmd.Parameters.AddWithValue("p4", historial);

                    cmd.ExecuteNonQuery();
                }
                CNN.Close();
            }
            catch (Exception ex)
            {
                if (CNN.State == ConnectionState.Open)
                    CNN.Close();
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
                CNN.Close();
            }
            catch (Exception ex)
            {
                if (CNN.State == ConnectionState.Open) CNN.Close();
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
                if (CNN.State == ConnectionState.Open) CNN.Close();
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
                if (CNN.State == ConnectionState.Open) CNN.Close();
                ERROR = ex.Message;
            }
            return dt;
        }

        public DataTable ObtenerPerfil()
        {
            DataTable dt = new DataTable();
            try
            {
                if (CNN.State == System.Data.ConnectionState.Open) CNN.Close();

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
                if (CNN.State == System.Data.ConnectionState.Open) CNN.Close();
            }
            return dt;
        }

        public bool InsertarUsuario(string nombre, string apellido, string mail, string contraseña,
                                    bool activo, string dni, string direccion, string gps,
                                    string provincia, string localidad, string telefono, string redesSociales)
        {
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                // 1. Insertar en Usuarios
                string queryUsuario = @"INSERT INTO Usuarios (Nombre, Apellido, Mail, Contraseña, Activo, DNI)
                                        VALUES (?, ?, ?, ?, ?, ?)";

                OleDbCommand cmdUsuario = new OleDbCommand(queryUsuario, CNN);
                cmdUsuario.Parameters.AddWithValue("?", nombre);
                cmdUsuario.Parameters.AddWithValue("?", apellido);
                cmdUsuario.Parameters.AddWithValue("?", mail);
                cmdUsuario.Parameters.AddWithValue("?", contraseña);
                cmdUsuario.Parameters.AddWithValue("?", activo);
                cmdUsuario.Parameters.AddWithValue("?", dni);
                // Se removió el parámetro duplicado de DNI que tenías acá
                cmdUsuario.ExecuteNonQuery();

                // 2. Obtener el Id del usuario recién insertado
                OleDbCommand cmdId = new OleDbCommand("SELECT @@IDENTITY", CNN);
                int nuevoId = Convert.ToInt32(cmdId.ExecuteScalar());

                // 3. Insertar en Domicilio_Usuario
                string queryDomicilio = @"INSERT INTO Domicilio_Usuario (Id_Usuario, GPS, Provincia, Localidad, Dirección)
                                          VALUES (?, ?, ?, ?, ?)";

                OleDbCommand cmdDomicilio = new OleDbCommand(queryDomicilio, CNN);
                cmdDomicilio.Parameters.AddWithValue("?", nuevoId);
                cmdDomicilio.Parameters.AddWithValue("?", gps);
                cmdDomicilio.Parameters.AddWithValue("?", provincia);
                cmdDomicilio.Parameters.AddWithValue("?", localidad);
                cmdDomicilio.Parameters.AddWithValue("?", direccion);
                cmdDomicilio.ExecuteNonQuery();

                // 4. Insertar en Contacto_Usuario
                string queryContacto = @"INSERT INTO Contacto_Usuario (Id_Usuario, Telefono, Redes_Sociales)
                                         VALUES (?, ?, ?)";

                OleDbCommand cmdContacto = new OleDbCommand(queryContacto, CNN);
                cmdContacto.Parameters.AddWithValue("?", nuevoId);
                cmdContacto.Parameters.AddWithValue("?", telefono);
                cmdContacto.Parameters.AddWithValue("?", redesSociales);
                cmdContacto.ExecuteNonQuery();

                CNN.Close();
                ERROR = "";
                return true;
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
                if (CNN.State == ConnectionState.Open)
                    CNN.Close();
                return false;
            }
        }

        public DataTable ObtenerAuditoria()
        {
            DataTable dt = new DataTable();
            try
            {
                if (CNN.State == ConnectionState.Open) CNN.Close();

                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                // Traemos todo ordenado por el ID de forma descendente (el último movimiento primero)
                string query = "SELECT Id_Auditoria, Usuario, FechaHora, Estado, Historial FROM [Auditoria-Sesion] ORDER BY Id_Auditoria DESC";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, CNN);
                adapter.Fill(dt);
                CNN.Close();
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
                if (CNN.State == ConnectionState.Open) CNN.Close();
            }
            return dt;
        }
    }
}