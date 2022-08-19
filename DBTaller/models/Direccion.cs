using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTaller.models
{
    public class Direccion
    {
        // Primary Key
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DireccionID { get; set; }
        [MaxLength(50)]
        public string Zona { get; set; }
        [MaxLength(50)]
        public string TipoCalle { get; set; }
        [MaxLength(50)]
        public string Num1 { get; set; }
        [MaxLength(50)]
        public string Num2 { get; set; }
        [MaxLength(50)]
        public string Num3 { get; set; }

       

    }
}
