using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace pryPereiroERP
{
    public class UsuarioController
    {
        private clsConexion _conexion;

        public UsuarioController()
        {
            _conexion = new clsConexion();
        }

        public string GetError() => _conexion.GetError();

        public string SerializarDirecciones(List<DireccionItem> direcciones)
        {
            if (direcciones == null || direcciones.Count == 0) return "";
            return string.Join("||", direcciones.Select(d => $"{d.Direccion}|{d.Provincia}|{d.Localidad}"));
        }

        public List<DireccionItem> DeserializarDirecciones(string data)
        {
            if (string.IsNullOrEmpty(data)) return new List<DireccionItem>();
            return data.Split(new[] { "||" }, StringSplitOptions.None)
                       .Select(part => part.Split('|'))
                       .Where(arr => arr.Length == 3)
                       .Select(arr => new DireccionItem
                       {
                           Direccion = arr[0],
                           Provincia = arr[1],
                           Localidad = arr[2]
                       })
                       .ToList();
        }

        public string SerializarRedes(List<RedSocialItem> redes)
        {
            if (redes == null || redes.Count == 0) return "";
            return string.Join("||", redes.Select(r => $"{r.Tipo}|{r.Url}"));
        }

        public List<RedSocialItem> DeserializarRedes(string data)
        {
            if (string.IsNullOrEmpty(data)) return new List<RedSocialItem>();
            return data.Split(new[] { "||" }, StringSplitOptions.None)
                       .Select(part => part.Split('|'))
                       .Where(arr => arr.Length == 2)
                       .Select(arr => new RedSocialItem
                       {
                           Tipo = arr[0],
                           Url = arr[1]
                       })
                       .ToList();
        }

        public bool GuardarUsuario(
            int? idUsuario,
            string nombre, string apellido, string mail, string contraseña,
            bool activo, string dni,
            List<DireccionItem> direcciones,
            string gps,
            string telefono,
            List<RedSocialItem> redes,
            int idPerfil)
        {
            string direccionesSerialized = SerializarDirecciones(direcciones);
            string redesSerialized = SerializarRedes(redes);

            string primeraDireccion = direcciones.FirstOrDefault()?.Direccion ?? "";
            string primeraProvincia = direcciones.FirstOrDefault()?.Provincia ?? "";
            string primeraLocalidad = direcciones.FirstOrDefault()?.Localidad ?? "";

            if (idUsuario == null || idUsuario == -1)
            {
                return _conexion.InsertarUsuario(
                    nombre, apellido, mail, contraseña, activo, dni,
                    direccionesSerialized, gps, primeraProvincia, primeraLocalidad,
                    telefono, redesSerialized, idPerfil);
            }
            else
            {
                return _conexion.ActualizarUsuario(
                    idUsuario.Value,
                    nombre, apellido, mail, contraseña, activo, dni,
                    direccionesSerialized, gps, primeraProvincia, primeraLocalidad,
                    telefono, redesSerialized, idPerfil);
            }
        }

        public bool EliminarUsuario(int idUsuario, string nombreOperador, string nombreForm)
        {
            bool ok = _conexion.EliminarUsuario(idUsuario);
            if (ok)
            {
                _conexion.RegistrarAuditoria(nombreOperador,
                    "Eliminó Usuario ID: " + idUsuario, nombreForm);
            }
            return ok;
        }

        public void RegistrarAuditoria(string usuario, string estado, string formulario)
        {
            _conexion.RegistrarAuditoria(usuario, estado, formulario);
        }

        public (List<DireccionItem> Direcciones, List<RedSocialItem> Redes, string Gps, string Telefono)
            CargarDireccionesYRedes(int idUsuario)
        {
            DataTable dt = _conexion.ObtenerUsuarioPorId(idUsuario);
            if (dt == null || dt.Rows.Count == 0)
                return (new List<DireccionItem>(), new List<RedSocialItem>(), "", "");

            DataRow row = dt.Rows[0];

            string direcData = row["Dirección"] != DBNull.Value ? row["Dirección"].ToString() : "";
            string redesData = row["Id_Redes_Sociales"] != DBNull.Value ? row["Id_Redes_Sociales"].ToString() : "";
            string gps = row["GPS"] != DBNull.Value ? row["GPS"].ToString().Trim() : "";
            string telefono = row["Telefono"] != DBNull.Value ? row["Telefono"].ToString().Trim() : "";

            var direcciones = DeserializarDirecciones(direcData);
            var redes = DeserializarRedes(redesData);

            return (direcciones, redes, gps, telefono);
        }
    }
}
