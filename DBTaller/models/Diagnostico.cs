using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTaller.models
{
    public class Diagnostico
    {

        // Primary key auto increment
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiagID { get; set; }
        [MaxLength(50)]
        public string TipoRevision { get; set; }
        [MaxLength(50)]
        public string RevisionNiveles { get; set; }
        [MaxLength(50)]
        public string TipoRepuestos { get; set; }
        [MaxLength(250)]
        public string Repuesto { get; set; }

        // ForeignKey 
        public int VehiculoID { get; set; }
        [ForeignKey("VehiculoID")]
        public Vehiculo Vehiculo { get; set; }
    }
}
