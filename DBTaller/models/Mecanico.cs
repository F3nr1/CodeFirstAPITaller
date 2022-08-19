using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTaller.models
{
    public class Mecanico
    {
        // Primary key auto increment
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MecanicoID { get; set; }

        [MaxLength(150)]
        public string NivelEstudio { get; set; }

        // ForeignKey 
        public int PersonaID { get; set; }
        [ForeignKey("PersonaID")]
        public  Persona Persona { get; set; }


    }
}
