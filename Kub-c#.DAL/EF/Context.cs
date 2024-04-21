using Kub_c_.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kub_c_.DAL
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=kubsu-lessons;UserId=postgres;password=1957");
        }
        
        public DbSet<Client> Clients { get; set; }
        public DbSet<Futura> Futuras { get; set; }
        public DbSet<FuturaInfo> FuturasInfo { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
