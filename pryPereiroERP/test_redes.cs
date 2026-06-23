using System;
using System.Collections.Generic;
using System.Linq;

class TestRedes
{
    static void Main()
    {
        // 1. Simulate serialization
        var redes = new List<RedSocialItem> {
            new RedSocialItem { Tipo = "Facebook", Url = "fb.com/test" },
            new RedSocialItem { Tipo = "Instagram", Url = "ig.com/user" }
        };
        string serialized = string.Join("||", redes.Select(r => $"{r.Tipo}|{r.Url}"));
        Console.WriteLine("Serialized: '" + serialized + "'");

        // 2. Simulate deserialization
        var result = serialized.Split(new[] { "||" }, StringSplitOptions.None)
            .Select(part => part.Split('|'))
            .Where(arr => arr.Length == 2)
            .Select(arr => new RedSocialItem { Tipo = arr[0], Url = arr[1] })
            .ToList();
        Console.WriteLine("Deserialized count: " + result.Count);
        foreach (var r in result) Console.WriteLine("  " + r.ToString());

        // 3. Real DB test - insert and read back
        clsConexion con = new clsConexion();
        bool ok = con.InsertarUsuario(
            "TestRedes", "Test", "test_redes@test.com", "password123",
            true, "11111111",
            "TestAddr|TestProv|TestLoc",   // direccion serialized
            "",                             // gps
            "TestProv", "TestLoc",          // provincia, localidad
            "1234567890",                   // telefono
            serialized,                     // redesSociales
            1                               // idPerfil
        );
        Console.WriteLine("\nInsert result: " + ok);
        if (!ok) { Console.WriteLine("ERROR: " + con.GetError()); return; }

        // Get the last inserted user
        var dt = con.ObtenerDatosTabla("Usuarios");
        int lastId = 0;
        foreach (DataRow row in dt.Rows)
            if ((int)row["Id_Usuario"] > lastId) lastId = (int)row["Id_Usuario"];
        Console.WriteLine("Last user ID: " + lastId);

        // 4. Read back via ObtenerUsuarioPorId
        var dt2 = con.ObtenerUsuarioPorId(lastId);
        if (dt2 == null || dt2.Rows.Count == 0) { Console.WriteLine("No rows returned!"); return; }
        Console.WriteLine("Row returned. Columns: " + string.Join(", ", dt2.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));
        var row = dt2.Rows[0];
        Console.WriteLine("Id_Redes_Sociales = '" + row["Id_Redes_Sociales"] + "'");
        Console.WriteLine("Dirección = '" + row["Dirección"] + "'");
        Console.WriteLine("Telefono = '" + row["Telefono"] + "'");

        // 5. Cleanup
        con.EliminarUsuario(lastId);
        Console.WriteLine("Cleanup OK");
    }
}
