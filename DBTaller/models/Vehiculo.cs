using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTaller.models
{
    public class Vehiculo
    {
        //Primary Key
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehiculoID { get; set; }
        [MaxLength(50)]
        public string Placa { get; set; }
        [MaxLength(50)]
        public string TipoVehiculo { get; set; }
        [MaxLength(50)]
        public string Marca { get; set; }
        [MaxLength(50)]
        public string CapacidadPasajeros { get; set; }
        [MaxLength(50)]
        public string Cilindrada { get; set; }

        // ForeignKey
        [Required]
        public int ClienteID { get; set; }
        [ForeignKey("ClienteID")]
        public Cliente Cliente { get; set; }

        // ForeignKey 
        public int MecanicoID { get; set; }
        [ForeignKey("MecanicoID")]
        public Mecanico Mecanico { get; set; }


    }
}
