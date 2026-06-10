using System;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace pryPereiroERP
{
    internal class clsConexion
    {
        private OleDbConnection CNN;
        private string ERROR = "";
        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            System.IO.Path.GetFullPath(System.Windows.Forms.Application.StartupPath + "\\..\\..\\Pereiro.db1.accdb");

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

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private bool VerificarPassword(string input, string storedHash)
        {
            if (string.IsNullOrEmpty(storedHash)) return false;
            if (storedHash.Length == 64) return HashPassword(input) == storedHash;
            return input == storedHash;
        }

        public clsUsuario ValidarUsuario(string nombre, string contraseña )
        {
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                string query1 = "SELECT Id_Usuario, Nombre, Apellido, Mail, Activo, Contraseña FROM Usuarios " +
                                "WHERE (Nombre = ? OR Mail = ?)";

                OleDbCommand cmd1 = new OleDbCommand(query1, CNN);
                cmd1.Parameters.AddWithValue("?", nombre);
                cmd1.Parameters.AddWithValue("?", nombre);

                OleDbDataReader reader1 = cmd1.ExecuteReader();

                if (!reader1.Read())
                {
                    reader1.Close();
                    CNN.Close();
                    RegistrarAuditoria(nombre, "Fallido", "frmLogin");
                    ERROR = "Usuario o contraseña incorrectos.";
                    return null;
                }

                bool estaActivo = reader1["Activo"] != DBNull.Value && Convert.ToBoolean(reader1["Activo"]);

                if (estaActivo == false)
                {
                    reader1.Close();
                    CNN.Close();
                    RegistrarAuditoria(nombre, "Fallido", "frmLogin");
                    ERROR = "El usuario está inactivo. Contacte al administrador.";
                    return null;
                }

                string storedHash = reader1["Contraseña"].ToString();
                if (!VerificarPassword(contraseña, storedHash))
                {
                    reader1.Close();
                    CNN.Close();
                    RegistrarAuditoria(nombre, "Fallido", "frmLogin");
                    ERROR = "Usuario o contraseña incorrectos.";
                    return null;
                }

                clsUsuario usuario = new clsUsuario();
                usuario.Id = Convert.ToInt32(reader1["Id_Usuario"]);
                usuario.Nombre = reader1["Nombre"].ToString();
                usuario.Apellido = reader1["Apellido"].ToString();
                usuario.HoraConexion = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
                int idUsuario = usuario.Id;
                reader1.Close();

                string query2 = "SELECT p.Nombre FROM Perfil AS p " +
                                "INNER JOIN [Relacion-Usuario-Perfil] AS r ON p.Id_Perfil = r.Id_Perfil " +
                                "WHERE r.Id_Usuario = ?";

                OleDbCommand cmd2 = new OleDbCommand(query2, CNN);
                cmd2.Parameters.AddWithValue("?", idUsuario);

                OleDbDataReader reader2 = cmd2.ExecuteReader();

                if (reader2.Read())
                {
                    usuario.Rol = reader2["Nombre"].ToString();
                    reader2.Close();
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
                                    string provincia, string localidad, string telefono, string redesSociales,
                                    int idPerfil)
        {
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                contraseña = HashPassword(contraseña);

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

                // 5. Insertar en Relacion-Usuario-Perfil
                string queryRelacion = @"INSERT INTO [Relacion-Usuario-Perfil] (Id_Usuario, Id_Perfil) VALUES (?, ?)";
                OleDbCommand cmdRelacion = new OleDbCommand(queryRelacion, CNN);
                cmdRelacion.Parameters.AddWithValue("?", nuevoId);
                cmdRelacion.Parameters.AddWithValue("?", idPerfil);
                cmdRelacion.ExecuteNonQuery();

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

        public DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                if (CNN.State == ConnectionState.Open) CNN.Close();

                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                string query = @"SELECT U.Id_Usuario, U.Nombre, U.Apellido, U.Mail, U.Activo, U.DNI, P.Nombre AS Perfil
                                 FROM ((Usuarios U
                                 LEFT JOIN [Relacion-Usuario-Perfil] RUP ON U.Id_Usuario = RUP.Id_Usuario)
                                 LEFT JOIN Perfil P ON RUP.Id_Perfil = P.Id_Perfil)";

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

        public DataTable ObtenerAuditoriaASC()
        {
            DataTable dt = new DataTable();
            try
            {
                if (CNN.State == ConnectionState.Open) CNN.Close();

                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                // Traemos todo ordenado por el ID de forma descendente (el último movimiento primero)
                string query = "SELECT Id_Auditoria, Usuario, FechaHora, Estado, Historial FROM [Auditoria-Sesion] ORDER BY Id_Auditoria ASC";

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

        //Metodos para poder modificar los datos de los usuarios

        public DataTable ObtenerUsuarioPorId(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                // Access requiere doble paréntesis envolviendo múltiples LEFT JOIN
                string query = "SELECT u.Id_Usuario, u.Nombre, u.Apellido, u.Mail, u.Contraseña, u.DNI, u.Activo, " +
                               "d.Dirección, d.GPS, d.Provincia, d.Localidad, " +
                               "c.Telefono, c.Redes_Sociales " +
                               "FROM ((Usuarios AS u " +
                               "LEFT JOIN Domicilio_Usuario AS d ON u.Id_Usuario = d.Id_Usuario) " +
                               "LEFT JOIN Contacto_Usuario AS c ON u.Id_Usuario = c.Id_Usuario) " +
                               "WHERE u.Id_Usuario = ?";

                OleDbCommand cmd = new OleDbCommand(query, CNN);

                // OleDb ignora el nombre del parámetro -> debe coincidir por posición con el ?
                cmd.Parameters.AddWithValue("?", id);

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

                CNN.Close();
                ERROR = "";
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
                if (CNN.State == ConnectionState.Open) CNN.Close();
            }
            return dt;
        }

        public bool ActualizarUsuario(int id, string nombre, string apellido, string mail,
                                       string contraseña, bool activo, string dni,
                                       string direccion, string gps, string provincia,
                                       string localidad, string telefono, string redesSociales,
                                       int idPerfil)
        {
            try
            {
                if (CNN.State == ConnectionState.Open) CNN.Close();
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                if (contraseña.Length != 64)
                    contraseña = HashPassword(contraseña);

                string queryUsuario = @"UPDATE Usuarios 
                                SET Nombre=?, Apellido=?, Mail=?, Contraseña=?, Activo=?, DNI=?
                                WHERE Id_Usuario=?";

                OleDbCommand cmdUsuario = new OleDbCommand(queryUsuario, CNN);
                cmdUsuario.Parameters.AddWithValue("?", nombre);
                cmdUsuario.Parameters.AddWithValue("?", apellido);
                cmdUsuario.Parameters.AddWithValue("?", mail);
                cmdUsuario.Parameters.AddWithValue("?", contraseña);
                cmdUsuario.Parameters.AddWithValue("?", activo);
                cmdUsuario.Parameters.AddWithValue("?", dni);
                cmdUsuario.Parameters.AddWithValue("?", id);
                cmdUsuario.ExecuteNonQuery();

                string queryDomicilio = @"UPDATE Domicilio_Usuario 
                                  SET Dirección=?, GPS=?, Provincia=?, Localidad=?
                                  WHERE Id_Usuario=?";

                OleDbCommand cmdDomicilio = new OleDbCommand(queryDomicilio, CNN);
                cmdDomicilio.Parameters.AddWithValue("?", direccion);
                cmdDomicilio.Parameters.AddWithValue("?", gps);
                cmdDomicilio.Parameters.AddWithValue("?", provincia);
                cmdDomicilio.Parameters.AddWithValue("?", localidad);
                cmdDomicilio.Parameters.AddWithValue("?", id);
                cmdDomicilio.ExecuteNonQuery();

                string queryContacto = @"UPDATE Contacto_Usuario 
                                 SET Telefono=?, Redes_Sociales=?
                                 WHERE Id_Usuario=?";

                OleDbCommand cmdContacto = new OleDbCommand(queryContacto, CNN);
                cmdContacto.Parameters.AddWithValue("?", telefono);
                cmdContacto.Parameters.AddWithValue("?", redesSociales);
                cmdContacto.Parameters.AddWithValue("?", id);
                cmdContacto.ExecuteNonQuery();

                string queryRelacion = @"UPDATE [Relacion-Usuario-Perfil] SET Id_Perfil=? WHERE Id_Usuario=?";
                OleDbCommand cmdRelacion = new OleDbCommand(queryRelacion, CNN);
                cmdRelacion.Parameters.AddWithValue("?", idPerfil);
                cmdRelacion.Parameters.AddWithValue("?", id);
                if (cmdRelacion.ExecuteNonQuery() == 0)
                {
                    queryRelacion = @"INSERT INTO [Relacion-Usuario-Perfil] (Id_Usuario, Id_Perfil) VALUES (?, ?)";
                    cmdRelacion = new OleDbCommand(queryRelacion, CNN);
                    cmdRelacion.Parameters.AddWithValue("?", id);
                    cmdRelacion.Parameters.AddWithValue("?", idPerfil);
                    cmdRelacion.ExecuteNonQuery();
                }

                CNN.Close();
                ERROR = "";
                return true;
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
                if (CNN.State == ConnectionState.Open) CNN.Close();
                return false;
            }
        }

        public bool EliminarUsuario(int idUsuario)
        {
            try
            {
                if (CNN.State == ConnectionState.Open) CNN.Close();
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                OleDbCommand cmd = new OleDbCommand("DELETE FROM Contacto_Usuario WHERE Id_Usuario=?", CNN);
                cmd.Parameters.AddWithValue("?", idUsuario);
                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("DELETE FROM Domicilio_Usuario WHERE Id_Usuario=?", CNN);
                cmd.Parameters.AddWithValue("?", idUsuario);
                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("DELETE FROM [Relacion-Usuario-Perfil] WHERE Id_Usuario=?", CNN);
                cmd.Parameters.AddWithValue("?", idUsuario);
                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("DELETE FROM Usuarios WHERE Id_Usuario=?", CNN);
                cmd.Parameters.AddWithValue("?", idUsuario);
                cmd.ExecuteNonQuery();

                CNN.Close();
                ERROR = "";
                return true;
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
                if (CNN.State == ConnectionState.Open) CNN.Close();
                return false;
            }
        }

        public DataTable ObtenerDatosTabla(string tabla)
        {
            DataTable dt = new DataTable();
            try
            {
                if (CNN.State == ConnectionState.Open) CNN.Close();
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();
                string query;
                if (tabla.Equals("Usuarios", StringComparison.OrdinalIgnoreCase))
                    query = "SELECT Id_Usuario, Nombre, Apellido, Mail, Activo, DNI FROM Usuarios";
                else
                    query = "SELECT * FROM [" + tabla + "]";
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

        public DataTable FiltrarTabla(string tabla, string campo, string valor)
        {
            DataTable dt = new DataTable();
            try
            {
                if (CNN.State == ConnectionState.Open) CNN.Close();
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();

                string tipo = ObtenerTipoColumna(tabla, campo);
                string query;
                OleDbCommand cmd = new OleDbCommand();

                if (tipo == "string")
                {
                    query = "SELECT * FROM [" + tabla + "] WHERE [" + campo + "] LIKE ?";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("?", "%" + valor + "%");
                }
                else if (tipo == "boolean")
                {
                    bool boolVal = valor.Equals("1") || valor.Equals("true", StringComparison.OrdinalIgnoreCase)
                        || valor.Equals("si", StringComparison.OrdinalIgnoreCase);
                    query = "SELECT * FROM [" + tabla + "] WHERE [" + campo + "] = ?";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("?", boolVal);
                }
                else if (tipo == "numeric")
                {
                    if (!decimal.TryParse(valor.Replace(",", "."), out decimal numVal))
                    {
                        ERROR = "El campo '" + campo + "' es numérico. Ingrese un valor numérico válido.";
                        CNN.Close();
                        return dt;
                    }
                    query = "SELECT * FROM [" + tabla + "] WHERE [" + campo + "] = ?";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("?", numVal);
                }
                else if (tipo == "datetime")
                {
                    if (!DateTime.TryParse(valor, out DateTime dateVal))
                    {
                        ERROR = "El campo '" + campo + "' es una fecha. Ingrese un formato válido (dd/MM/yyyy).";
                        CNN.Close();
                        return dt;
                    }
                    query = "SELECT * FROM [" + tabla + "] WHERE [" + campo + "] = ?";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("?", dateVal.ToString("dd/MM/yyyy"));
                }
                else
                {
                    query = "SELECT * FROM [" + tabla + "] WHERE [" + campo + "] LIKE ?";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("?", "%" + valor + "%");
                }

                cmd.Connection = CNN;
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                CNN.Close();
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
                if (CNN.State == ConnectionState.Open) CNN.Close();
            }
            return dt;
        }

        private string ObtenerTipoColumna(string tabla, string campo)
        {
            try
            {
                DataTable schema = ObtenerEstructuraTabla(tabla);
                foreach (DataColumn col in schema.Columns)
                {
                    if (col.ColumnName.Equals(campo, StringComparison.OrdinalIgnoreCase))
                    {
                        Type t = col.DataType;
                        if (t == typeof(string)) return "string";
                        if (t == typeof(bool)) return "boolean";
                        if (t == typeof(int) || t == typeof(long) || t == typeof(decimal) ||
                            t == typeof(double) || t == typeof(float) || t == typeof(short) ||
                            t == typeof(byte)) return "numeric";
                        if (t == typeof(DateTime)) return "datetime";
                        return "string";
                    }
                }
            }
            catch { }
            return "string";
        }

        public DataTable ObtenerEstructuraTabla(string tabla)
        {
            DataTable dt = new DataTable();
            try
            {
                if (CNN.State == ConnectionState.Open) CNN.Close();
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();
                string query = "SELECT TOP 0 * FROM [" + tabla + "]";
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

        public int ContarUsuarios()
        {
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM Usuarios", CNN);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                CNN.Close();
                return count;
            }
            catch { return 0; }
        }

        public int ContarUsuariosActivos()
        {
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM Usuarios WHERE Activo=True", CNN);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                CNN.Close();
                return count;
            }
            catch { return 0; }
        }

        public int ContarAccesosHoy()
        {
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();
                string hoy = DateTime.Now.ToString("dd/MM/yyyy");
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM [Auditoria-Sesion] WHERE FechaHora LIKE ? AND Estado='Exitoso'", CNN);
                cmd.Parameters.AddWithValue("?", hoy + "%");
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                CNN.Close();
                return count;
            }
            catch { return 0; }
        }

        public DataTable ObtenerUltimosAccesos(int top)
        {
            DataTable dt = new DataTable();
            try
            {
                CNN.ConnectionString = cadenaConexion;
                CNN.Open();
                string query = "SELECT TOP " + top + " Usuario, FechaHora, Estado FROM [Auditoria-Sesion] ORDER BY Id_Auditoria DESC";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, CNN);
                adapter.Fill(dt);
                CNN.Close();
            }
            catch { }
            return dt;
        }

    }
}