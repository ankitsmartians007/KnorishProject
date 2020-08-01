using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class KnorishDbContext : DbContext
    {
        public KnorishDbContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Boat> Boats { get; set; }

    }
}
