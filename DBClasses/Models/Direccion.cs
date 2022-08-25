using System;
using System.Collections.Generic;

namespace DBTallerM.Models
{
    public partial class Direccion
    {
        public Direccion()
        {
            Personas = new HashSet<Persona>();
        }

        public int DireccionId { get; set; }
        public string? Zona { get; set; }
        public string? TipoCalle { get; set; }
        public string? Num1 { get; set; }
        public string? Num2 { get; set; }
        public string? Num3 { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
