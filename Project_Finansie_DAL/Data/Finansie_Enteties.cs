using Project_Finansie_DAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Finansie_DAL.Data
{
    public class Finansie_Enteties : DbContext
    {
        public Finansie_Enteties()
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Betalingen> Betalingen { get; set; }
        public DbSet<Ontvangste> Ontvangsten { get; set; }
    }
}
