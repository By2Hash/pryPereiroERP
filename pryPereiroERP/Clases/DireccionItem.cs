using System;

namespace pryPereiroERP
{
    public class DireccionItem
    {
        public string Direccion { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public override string ToString() => $"{Direccion}  |  {Provincia} › {Localidad}";
    }
}
