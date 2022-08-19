using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTaller.models
{
    public class Soat
    {

        // Primary key auto increment
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SoatID { get; set; }
        public DateTime FechaVencimiento { get; set; }
        [MaxLength(25)]
        public string PuedeTransitar { get; set; }
        // ForeignKey 
        public int VehiculoID { get; set; }
        [ForeignKey("VehiculoID")]
        public Vehiculo Vehiculo { get; set; }


    }
}
