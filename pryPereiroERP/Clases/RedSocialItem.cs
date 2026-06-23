using System;

namespace pryPereiroERP
{
    public class RedSocialItem
    {
        public string Tipo { get; set; }
        public string Url { get; set; }
        public override string ToString() => $"[{Tipo}]  {Url}";
    }
}
