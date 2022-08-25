using System;
using System.Collections.Generic;

namespace DBTallerM.Models
{
    public partial class Administrativo
    {
        public int AdmId { get; set; }
        public string? NivelEstudio { get; set; }
        public int PersonaId { get; set; }
    }
}
