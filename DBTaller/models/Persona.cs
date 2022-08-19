using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTaller.models
{
    public class Persona
    {
        // Primary key auto increment
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonaID { get; set; }

        [MaxLength(250)]
        public string Nombre { get; set; }
        [MaxLength(250)]
        public string Apellido { get; set; }
        [MaxLength(25)]
        public int Telefono { get; set; }

      
        // ForeignKey 
        public int DireccionID { get; set; }

        [ForeignKey("DireccionID")]
        public  Direccion Direccion { get; set; }
      
    }
}
