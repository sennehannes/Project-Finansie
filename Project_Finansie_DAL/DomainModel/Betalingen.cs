using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Finansie_DAL.DomainModel
{
    [Table("Betalingen")]
    public class Betalingen
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public double Hoeveelheid { get; set; }

        public Users User { get; set; }
    }
}
