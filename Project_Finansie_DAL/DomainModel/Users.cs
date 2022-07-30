using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Finansie_DAL.DomainModel
{
    [Table("Users")]
    public class Users
    {
        [Required]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Naam { get; set; }
        [Required]
        public double Kapitaal { get; set; }
        public ICollection<Ontvangste> Ontvangste { get; set; }
        public ICollection<Betalingen> Betalingen { get; set; }
    }
}
